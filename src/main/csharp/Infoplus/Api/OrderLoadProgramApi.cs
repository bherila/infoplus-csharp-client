using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Infoplus.Client;
using Infoplus.Model;

namespace Infoplus.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrderLoadProgramApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Search orderLoadPrograms
        /// </summary>
        /// <remarks>
        /// Returns the list of orderLoadPrograms that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>List&lt;OrderLoadProgram&gt;</returns>
        List<OrderLoadProgram> GetOrderLoadProgramBySearchText (string searchText = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Search orderLoadPrograms
        /// </summary>
        /// <remarks>
        /// Returns the list of orderLoadPrograms that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>ApiResponse of List&lt;OrderLoadProgram&gt;</returns>
        ApiResponse<List<OrderLoadProgram>> GetOrderLoadProgramBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Get an orderLoadProgram by id
        /// </summary>
        /// <remarks>
        /// Returns the orderLoadProgram identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLoadProgramId">Id of orderLoadProgram to be returned.</param>
        /// <returns>OrderLoadProgram</returns>
        OrderLoadProgram GetReqLoadProgramById (string orderLoadProgramId);
  
        /// <summary>
        /// Get an orderLoadProgram by id
        /// </summary>
        /// <remarks>
        /// Returns the orderLoadProgram identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLoadProgramId">Id of orderLoadProgram to be returned.</param>
        /// <returns>ApiResponse of OrderLoadProgram</returns>
        ApiResponse<OrderLoadProgram> GetReqLoadProgramByIdWithHttpInfo (string orderLoadProgramId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Search orderLoadPrograms
        /// </summary>
        /// <remarks>
        /// Returns the list of orderLoadPrograms that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;OrderLoadProgram&gt;</returns>
        System.Threading.Tasks.Task<List<OrderLoadProgram>> GetOrderLoadProgramBySearchTextAsync (string searchText = null, int? page = null, int? limit = null);

        /// <summary>
        /// Search orderLoadPrograms
        /// </summary>
        /// <remarks>
        /// Returns the list of orderLoadPrograms that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OrderLoadProgram&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OrderLoadProgram>>> GetOrderLoadProgramBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Get an orderLoadProgram by id
        /// </summary>
        /// <remarks>
        /// Returns the orderLoadProgram identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLoadProgramId">Id of orderLoadProgram to be returned.</param>
        /// <returns>Task of OrderLoadProgram</returns>
        System.Threading.Tasks.Task<OrderLoadProgram> GetReqLoadProgramByIdAsync (string orderLoadProgramId);

        /// <summary>
        /// Get an orderLoadProgram by id
        /// </summary>
        /// <remarks>
        /// Returns the orderLoadProgram identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLoadProgramId">Id of orderLoadProgram to be returned.</param>
        /// <returns>Task of ApiResponse (OrderLoadProgram)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderLoadProgram>> GetReqLoadProgramByIdAsyncWithHttpInfo (string orderLoadProgramId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderLoadProgramApi : IOrderLoadProgramApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLoadProgramApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderLoadProgramApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLoadProgramApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrderLoadProgramApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Search orderLoadPrograms Returns the list of orderLoadPrograms that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>List&lt;OrderLoadProgram&gt;</returns>
        public List<OrderLoadProgram> GetOrderLoadProgramBySearchText (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<OrderLoadProgram>> localVarResponse = GetOrderLoadProgramBySearchTextWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search orderLoadPrograms Returns the list of orderLoadPrograms that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>ApiResponse of List&lt;OrderLoadProgram&gt;</returns>
        public ApiResponse< List<OrderLoadProgram> > GetOrderLoadProgramBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/beta/orderLoadProgram/search";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (searchText != null) localVarQueryParams.Add("searchText", Configuration.ApiClient.ParameterToString(searchText)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLoadProgramBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLoadProgramBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<OrderLoadProgram>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrderLoadProgram>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OrderLoadProgram>)));
            
        }

        
        /// <summary>
        /// Search orderLoadPrograms Returns the list of orderLoadPrograms that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;OrderLoadProgram&gt;</returns>
        public async System.Threading.Tasks.Task<List<OrderLoadProgram>> GetOrderLoadProgramBySearchTextAsync (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<OrderLoadProgram>> localVarResponse = await GetOrderLoadProgramBySearchTextAsyncWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search orderLoadPrograms Returns the list of orderLoadPrograms that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OrderLoadProgram&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OrderLoadProgram>>> GetOrderLoadProgramBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/beta/orderLoadProgram/search";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (searchText != null) localVarQueryParams.Add("searchText", Configuration.ApiClient.ParameterToString(searchText)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLoadProgramBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLoadProgramBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<OrderLoadProgram>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrderLoadProgram>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OrderLoadProgram>)));
            
        }
        
        /// <summary>
        /// Get an orderLoadProgram by id Returns the orderLoadProgram identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLoadProgramId">Id of orderLoadProgram to be returned.</param> 
        /// <returns>OrderLoadProgram</returns>
        public OrderLoadProgram GetReqLoadProgramById (string orderLoadProgramId)
        {
             ApiResponse<OrderLoadProgram> localVarResponse = GetReqLoadProgramByIdWithHttpInfo(orderLoadProgramId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an orderLoadProgram by id Returns the orderLoadProgram identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLoadProgramId">Id of orderLoadProgram to be returned.</param> 
        /// <returns>ApiResponse of OrderLoadProgram</returns>
        public ApiResponse< OrderLoadProgram > GetReqLoadProgramByIdWithHttpInfo (string orderLoadProgramId)
        {
            
            // verify the required parameter 'orderLoadProgramId' is set
            if (orderLoadProgramId == null)
                throw new ApiException(400, "Missing required parameter 'orderLoadProgramId' when calling OrderLoadProgramApi->GetReqLoadProgramById");
            
    
            var localVarPath = "/beta/orderLoadProgram/{orderLoadProgramId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (orderLoadProgramId != null) localVarPathParams.Add("orderLoadProgramId", Configuration.ApiClient.ParameterToString(orderLoadProgramId)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetReqLoadProgramById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReqLoadProgramById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderLoadProgram>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderLoadProgram) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderLoadProgram)));
            
        }

        
        /// <summary>
        /// Get an orderLoadProgram by id Returns the orderLoadProgram identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLoadProgramId">Id of orderLoadProgram to be returned.</param>
        /// <returns>Task of OrderLoadProgram</returns>
        public async System.Threading.Tasks.Task<OrderLoadProgram> GetReqLoadProgramByIdAsync (string orderLoadProgramId)
        {
             ApiResponse<OrderLoadProgram> localVarResponse = await GetReqLoadProgramByIdAsyncWithHttpInfo(orderLoadProgramId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an orderLoadProgram by id Returns the orderLoadProgram identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLoadProgramId">Id of orderLoadProgram to be returned.</param>
        /// <returns>Task of ApiResponse (OrderLoadProgram)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderLoadProgram>> GetReqLoadProgramByIdAsyncWithHttpInfo (string orderLoadProgramId)
        {
            // verify the required parameter 'orderLoadProgramId' is set
            if (orderLoadProgramId == null) throw new ApiException(400, "Missing required parameter 'orderLoadProgramId' when calling GetReqLoadProgramById");
            
    
            var localVarPath = "/beta/orderLoadProgram/{orderLoadProgramId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (orderLoadProgramId != null) localVarPathParams.Add("orderLoadProgramId", Configuration.ApiClient.ParameterToString(orderLoadProgramId)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetReqLoadProgramById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReqLoadProgramById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderLoadProgram>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderLoadProgram) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderLoadProgram)));
            
        }
        
    }
    
}
