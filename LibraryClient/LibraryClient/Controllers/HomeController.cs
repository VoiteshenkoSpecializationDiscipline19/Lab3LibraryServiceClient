using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryClient.Models;
using AzureLibraryService;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text;

namespace LibraryClient.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        private static readonly String defaultToken = "default";
        private static String getAllBooksToken = null;
        private static String orderBookToken = null;

        public async Task<IActionResult> AllBooks()
        {
            var result = await GetAllBooks();
            if (result is ErrorViewModel)
            {
                return View("~/Views/Shared/Error.cshtml", result);
            }
            GetAllBooksResponse list = result as GetAllBooksResponse;
            if (list.Body.GetAllBooksResult == null || list.Body.GetAllBooksResult.Length == 0)
            {
                return View("Error");
            }
            return View(list.Body.GetAllBooksResult.ToList());
        }

        private async Task<Object> GetAllBooks()
        {
            String token = getAllBooksToken;
            if (token == null)
            {
                var payment = await getToken(
               new DateRange(DateTime.Today, DateTime.Today.AddDays(2.0)), "GetAllBooks");

                if (payment is ErrorViewModel)
                    return payment;
                token = payment as String;
            }
            

            LibraryServiceSoapClient.EndpointConfiguration endpointConfiguration = LibraryServiceSoapClient.EndpointConfiguration.LibraryServiceSoap;
            var client = new LibraryServiceSoapClient(endpointConfiguration);
            var request = new GetAllBooksRequest();
            request.Body = new GetAllBooksRequestBody(defaultToken);

            var result = await client.GetAllBooksAsync(token);
            return result;
        }


        public async Task<IActionResult> AllAvailableBooks()
        {
            String token = getAllBooksToken;
            if (token == null)
            {
                var payment = await getToken(
               new DateRange(DateTime.Today, DateTime.Today.AddDays(2.0)), "GetAllBooks");

                if (payment is ErrorViewModel)
                    return View("~/Views/Shared/Error.cshtml", payment);
                token = payment as String;
            }

            LibraryServiceSoapClient.EndpointConfiguration endpointConfiguration = LibraryServiceSoapClient.EndpointConfiguration.LibraryServiceSoap;
            var client = new LibraryServiceSoapClient(endpointConfiguration);
            var request = new GetAllAvailableBooksRequest();
            request.Body = new GetAllAvailableBooksRequestBody(token);

            var result = await client.GetAllAvailableBooksAsync(token);
            if (result.Body.GetAllAvailableBooksResult == null || result.Body.GetAllAvailableBooksResult.Length == 0)
            {
                return View("Error");
            }
            return View(result.Body.GetAllAvailableBooksResult.ToList());
        }


        public async Task<IActionResult> Order(int bookId)
        {
            String token = orderBookToken;
            if (token == null)
            {
                var payment = await getToken(
               new DateRange(DateTime.Today, DateTime.Today.AddDays(2.0)), "OrderBook");

                if (payment is ErrorViewModel)
                    return View("~/Views/Shared/Error.cshtml", payment);
                token = payment as String;
            }

            LibraryServiceSoapClient.EndpointConfiguration endpointConfiguration = LibraryServiceSoapClient.EndpointConfiguration.LibraryServiceSoap;
            var client = new LibraryServiceSoapClient(endpointConfiguration);
            var request = new OrderBookRequest();
            request.Body = new OrderBookRequestBody(defaultToken, bookId);
            var result = await client.OrderBookAsync(defaultToken, bookId);

            if (result.Body.OrderBookResult == false)
            {
                return View("Error");
            }


            return Redirect("AllBooks");
        }


        public async Task<IActionResult> Return(int bookId)
        {
            LibraryServiceSoapClient.EndpointConfiguration endpointConfiguration = LibraryServiceSoapClient.EndpointConfiguration.LibraryServiceSoap;
            var client = new LibraryServiceSoapClient(endpointConfiguration);
            var request = new ReturnBookRequest();
            request.Body = new ReturnBookRequestBody(defaultToken, bookId);
            var result = await client.ReturnBookAsync(defaultToken, bookId);

            if (result.Body.ReturnBookResult == false)
            {
                return View("Error");
            }

            return Redirect("AllBooks");
        }

        private async Task<Object> getToken(DateRange dates, string methodName)
        {
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {
                var uri = new Uri("http://cryptic-beach-05943.herokuapp.com/token/LibraryService/"
                    + methodName);

                var jsonRequest = JsonConvert.SerializeObject(dates,
                    new JsonSerializerSettings
                    {
                        ContractResolver = new DefaultContractResolver
                        {
                            NamingStrategy = new SnakeCaseNamingStrategy()
                        }
                    });
                response = await client.PostAsync(uri,
                    new StringContent(jsonRequest, Encoding.UTF8, "application/json"));
            }
            var jsonResponse = await response.Content.ReadAsStringAsync();
            PaymentResponse paymentResponse = JsonConvert.DeserializeObject<PaymentResponse>(jsonResponse);

            if (paymentResponse.StatusCode == 404)
            {
                return new ErrorViewModel { RequestId = paymentResponse.StatusMessage };
            }
            return paymentResponse.Token;
        } 

        public IActionResult Error()
        {
            return View();
        }

    }
}
