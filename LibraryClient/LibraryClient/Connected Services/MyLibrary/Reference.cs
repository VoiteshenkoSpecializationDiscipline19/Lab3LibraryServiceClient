﻿//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace MyLibrary
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://asmx.libraryService.com/")]
    public partial class Book : object
    {
        
        private int IDField;
        
        private string NameField;
        
        private string AuthorNameField;
        
        private bool IsAvailableField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string AuthorName
        {
            get
            {
                return this.AuthorNameField;
            }
            set
            {
                this.AuthorNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public bool IsAvailable
        {
            get
            {
                return this.IsAvailableField;
            }
            set
            {
                this.IsAvailableField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://asmx.libraryService.com/", ConfigurationName="MyLibrary.LibraryServiceSoap")]
    public interface LibraryServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://asmx.libraryService.com/GetAllBooks", ReplyAction="*")]
        System.Threading.Tasks.Task<MyLibrary.GetAllBooksResponse> GetAllBooksAsync(MyLibrary.GetAllBooksRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://asmx.libraryService.com/GetAllBooksByName", ReplyAction="*")]
        System.Threading.Tasks.Task<MyLibrary.GetAllBooksByNameResponse> GetAllBooksByNameAsync(MyLibrary.GetAllBooksByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://asmx.libraryService.com/GetAllAvailableBooks", ReplyAction="*")]
        System.Threading.Tasks.Task<MyLibrary.GetAllAvailableBooksResponse> GetAllAvailableBooksAsync(MyLibrary.GetAllAvailableBooksRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://asmx.libraryService.com/OrderBook", ReplyAction="*")]
        System.Threading.Tasks.Task<MyLibrary.OrderBookResponse> OrderBookAsync(MyLibrary.OrderBookRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://asmx.libraryService.com/ReturnBook", ReplyAction="*")]
        System.Threading.Tasks.Task<MyLibrary.ReturnBookResponse> ReturnBookAsync(MyLibrary.ReturnBookRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://asmx.libraryService.com/AddNewBook", ReplyAction="*")]
        System.Threading.Tasks.Task<MyLibrary.AddNewBookResponse> AddNewBookAsync(MyLibrary.AddNewBookRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://asmx.libraryService.com/RemoveBook", ReplyAction="*")]
        System.Threading.Tasks.Task<MyLibrary.RemoveBookResponse> RemoveBookAsync(MyLibrary.RemoveBookRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllBooksRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllBooks", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.GetAllBooksRequestBody Body;
        
        public GetAllBooksRequest()
        {
        }
        
        public GetAllBooksRequest(MyLibrary.GetAllBooksRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class GetAllBooksRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string token;
        
        public GetAllBooksRequestBody()
        {
        }
        
        public GetAllBooksRequestBody(string token)
        {
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllBooksResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllBooksResponse", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.GetAllBooksResponseBody Body;
        
        public GetAllBooksResponse()
        {
        }
        
        public GetAllBooksResponse(MyLibrary.GetAllBooksResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class GetAllBooksResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MyLibrary.Book[] GetAllBooksResult;
        
        public GetAllBooksResponseBody()
        {
        }
        
        public GetAllBooksResponseBody(MyLibrary.Book[] GetAllBooksResult)
        {
            this.GetAllBooksResult = GetAllBooksResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllBooksByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllBooksByName", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.GetAllBooksByNameRequestBody Body;
        
        public GetAllBooksByNameRequest()
        {
        }
        
        public GetAllBooksByNameRequest(MyLibrary.GetAllBooksByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class GetAllBooksByNameRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string token;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        public GetAllBooksByNameRequestBody()
        {
        }
        
        public GetAllBooksByNameRequestBody(string token, string name)
        {
            this.token = token;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllBooksByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllBooksByNameResponse", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.GetAllBooksByNameResponseBody Body;
        
        public GetAllBooksByNameResponse()
        {
        }
        
        public GetAllBooksByNameResponse(MyLibrary.GetAllBooksByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class GetAllBooksByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MyLibrary.Book[] GetAllBooksByNameResult;
        
        public GetAllBooksByNameResponseBody()
        {
        }
        
        public GetAllBooksByNameResponseBody(MyLibrary.Book[] GetAllBooksByNameResult)
        {
            this.GetAllBooksByNameResult = GetAllBooksByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllAvailableBooksRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllAvailableBooks", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.GetAllAvailableBooksRequestBody Body;
        
        public GetAllAvailableBooksRequest()
        {
        }
        
        public GetAllAvailableBooksRequest(MyLibrary.GetAllAvailableBooksRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class GetAllAvailableBooksRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string token;
        
        public GetAllAvailableBooksRequestBody()
        {
        }
        
        public GetAllAvailableBooksRequestBody(string token)
        {
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllAvailableBooksResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllAvailableBooksResponse", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.GetAllAvailableBooksResponseBody Body;
        
        public GetAllAvailableBooksResponse()
        {
        }
        
        public GetAllAvailableBooksResponse(MyLibrary.GetAllAvailableBooksResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class GetAllAvailableBooksResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MyLibrary.Book[] GetAllAvailableBooksResult;
        
        public GetAllAvailableBooksResponseBody()
        {
        }
        
        public GetAllAvailableBooksResponseBody(MyLibrary.Book[] GetAllAvailableBooksResult)
        {
            this.GetAllAvailableBooksResult = GetAllAvailableBooksResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OrderBookRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OrderBook", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.OrderBookRequestBody Body;
        
        public OrderBookRequest()
        {
        }
        
        public OrderBookRequest(MyLibrary.OrderBookRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class OrderBookRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string token;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int bookId;
        
        public OrderBookRequestBody()
        {
        }
        
        public OrderBookRequestBody(string token, int bookId)
        {
            this.token = token;
            this.bookId = bookId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OrderBookResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OrderBookResponse", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.OrderBookResponseBody Body;
        
        public OrderBookResponse()
        {
        }
        
        public OrderBookResponse(MyLibrary.OrderBookResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class OrderBookResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool OrderBookResult;
        
        public OrderBookResponseBody()
        {
        }
        
        public OrderBookResponseBody(bool OrderBookResult)
        {
            this.OrderBookResult = OrderBookResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReturnBookRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReturnBook", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.ReturnBookRequestBody Body;
        
        public ReturnBookRequest()
        {
        }
        
        public ReturnBookRequest(MyLibrary.ReturnBookRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class ReturnBookRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string token;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int bookId;
        
        public ReturnBookRequestBody()
        {
        }
        
        public ReturnBookRequestBody(string token, int bookId)
        {
            this.token = token;
            this.bookId = bookId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReturnBookResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReturnBookResponse", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.ReturnBookResponseBody Body;
        
        public ReturnBookResponse()
        {
        }
        
        public ReturnBookResponse(MyLibrary.ReturnBookResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class ReturnBookResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ReturnBookResult;
        
        public ReturnBookResponseBody()
        {
        }
        
        public ReturnBookResponseBody(bool ReturnBookResult)
        {
            this.ReturnBookResult = ReturnBookResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddNewBookRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddNewBook", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.AddNewBookRequestBody Body;
        
        public AddNewBookRequest()
        {
        }
        
        public AddNewBookRequest(MyLibrary.AddNewBookRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class AddNewBookRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string token;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public MyLibrary.Book book;
        
        public AddNewBookRequestBody()
        {
        }
        
        public AddNewBookRequestBody(string token, MyLibrary.Book book)
        {
            this.token = token;
            this.book = book;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddNewBookResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddNewBookResponse", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.AddNewBookResponseBody Body;
        
        public AddNewBookResponse()
        {
        }
        
        public AddNewBookResponse(MyLibrary.AddNewBookResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class AddNewBookResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AddNewBookResult;
        
        public AddNewBookResponseBody()
        {
        }
        
        public AddNewBookResponseBody(bool AddNewBookResult)
        {
            this.AddNewBookResult = AddNewBookResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemoveBookRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RemoveBook", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.RemoveBookRequestBody Body;
        
        public RemoveBookRequest()
        {
        }
        
        public RemoveBookRequest(MyLibrary.RemoveBookRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class RemoveBookRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string token;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int bookId;
        
        public RemoveBookRequestBody()
        {
        }
        
        public RemoveBookRequestBody(string token, int bookId)
        {
            this.token = token;
            this.bookId = bookId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemoveBookResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RemoveBookResponse", Namespace="http://asmx.libraryService.com/", Order=0)]
        public MyLibrary.RemoveBookResponseBody Body;
        
        public RemoveBookResponse()
        {
        }
        
        public RemoveBookResponse(MyLibrary.RemoveBookResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://asmx.libraryService.com/")]
    public partial class RemoveBookResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool RemoveBookResult;
        
        public RemoveBookResponseBody()
        {
        }
        
        public RemoveBookResponseBody(bool RemoveBookResult)
        {
            this.RemoveBookResult = RemoveBookResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface LibraryServiceSoapChannel : MyLibrary.LibraryServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class LibraryServiceSoapClient : System.ServiceModel.ClientBase<MyLibrary.LibraryServiceSoap>, MyLibrary.LibraryServiceSoap
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public LibraryServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(LibraryServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), LibraryServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LibraryServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(LibraryServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LibraryServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(LibraryServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LibraryServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyLibrary.GetAllBooksResponse> MyLibrary.LibraryServiceSoap.GetAllBooksAsync(MyLibrary.GetAllBooksRequest request)
        {
            return base.Channel.GetAllBooksAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyLibrary.GetAllBooksResponse> GetAllBooksAsync(string token)
        {
            MyLibrary.GetAllBooksRequest inValue = new MyLibrary.GetAllBooksRequest();
            inValue.Body = new MyLibrary.GetAllBooksRequestBody();
            inValue.Body.token = token;
            return ((MyLibrary.LibraryServiceSoap)(this)).GetAllBooksAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyLibrary.GetAllBooksByNameResponse> MyLibrary.LibraryServiceSoap.GetAllBooksByNameAsync(MyLibrary.GetAllBooksByNameRequest request)
        {
            return base.Channel.GetAllBooksByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyLibrary.GetAllBooksByNameResponse> GetAllBooksByNameAsync(string token, string name)
        {
            MyLibrary.GetAllBooksByNameRequest inValue = new MyLibrary.GetAllBooksByNameRequest();
            inValue.Body = new MyLibrary.GetAllBooksByNameRequestBody();
            inValue.Body.token = token;
            inValue.Body.name = name;
            return ((MyLibrary.LibraryServiceSoap)(this)).GetAllBooksByNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyLibrary.GetAllAvailableBooksResponse> MyLibrary.LibraryServiceSoap.GetAllAvailableBooksAsync(MyLibrary.GetAllAvailableBooksRequest request)
        {
            return base.Channel.GetAllAvailableBooksAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyLibrary.GetAllAvailableBooksResponse> GetAllAvailableBooksAsync(string token)
        {
            MyLibrary.GetAllAvailableBooksRequest inValue = new MyLibrary.GetAllAvailableBooksRequest();
            inValue.Body = new MyLibrary.GetAllAvailableBooksRequestBody();
            inValue.Body.token = token;
            return ((MyLibrary.LibraryServiceSoap)(this)).GetAllAvailableBooksAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyLibrary.OrderBookResponse> MyLibrary.LibraryServiceSoap.OrderBookAsync(MyLibrary.OrderBookRequest request)
        {
            return base.Channel.OrderBookAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyLibrary.OrderBookResponse> OrderBookAsync(string token, int bookId)
        {
            MyLibrary.OrderBookRequest inValue = new MyLibrary.OrderBookRequest();
            inValue.Body = new MyLibrary.OrderBookRequestBody();
            inValue.Body.token = token;
            inValue.Body.bookId = bookId;
            return ((MyLibrary.LibraryServiceSoap)(this)).OrderBookAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyLibrary.ReturnBookResponse> MyLibrary.LibraryServiceSoap.ReturnBookAsync(MyLibrary.ReturnBookRequest request)
        {
            return base.Channel.ReturnBookAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyLibrary.ReturnBookResponse> ReturnBookAsync(string token, int bookId)
        {
            MyLibrary.ReturnBookRequest inValue = new MyLibrary.ReturnBookRequest();
            inValue.Body = new MyLibrary.ReturnBookRequestBody();
            inValue.Body.token = token;
            inValue.Body.bookId = bookId;
            return ((MyLibrary.LibraryServiceSoap)(this)).ReturnBookAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyLibrary.AddNewBookResponse> MyLibrary.LibraryServiceSoap.AddNewBookAsync(MyLibrary.AddNewBookRequest request)
        {
            return base.Channel.AddNewBookAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyLibrary.AddNewBookResponse> AddNewBookAsync(string token, MyLibrary.Book book)
        {
            MyLibrary.AddNewBookRequest inValue = new MyLibrary.AddNewBookRequest();
            inValue.Body = new MyLibrary.AddNewBookRequestBody();
            inValue.Body.token = token;
            inValue.Body.book = book;
            return ((MyLibrary.LibraryServiceSoap)(this)).AddNewBookAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyLibrary.RemoveBookResponse> MyLibrary.LibraryServiceSoap.RemoveBookAsync(MyLibrary.RemoveBookRequest request)
        {
            return base.Channel.RemoveBookAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyLibrary.RemoveBookResponse> RemoveBookAsync(string token, int bookId)
        {
            MyLibrary.RemoveBookRequest inValue = new MyLibrary.RemoveBookRequest();
            inValue.Body = new MyLibrary.RemoveBookRequestBody();
            inValue.Body.token = token;
            inValue.Body.bookId = bookId;
            return ((MyLibrary.LibraryServiceSoap)(this)).RemoveBookAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.LibraryServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.LibraryServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.LibraryServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:64780/LibraryService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.LibraryServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:64780/LibraryService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            LibraryServiceSoap,
            
            LibraryServiceSoap12,
        }
    }
}
