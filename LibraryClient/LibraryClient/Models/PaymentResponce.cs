using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

public class PaymentResponse
{
    [JsonProperty("token")]
    public string Token { get; set; }

    [JsonProperty("status_code")]
    public int StatusCode { get; set; }

    [JsonProperty("status_message")]
    public string StatusMessage { get; set; }
}
