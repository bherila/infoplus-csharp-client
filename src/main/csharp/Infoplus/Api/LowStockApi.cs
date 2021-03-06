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
    public interface ILowStockApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a lowStock
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing lowStock.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add an audit to</param>
        /// <param name="lowStockAudit">The audit to add</param>
        /// <returns></returns>
        void AddLowStockAudit (int? lowStockId, string lowStockAudit);
  
        /// <summary>
        /// Add new audit for a lowStock
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing lowStock.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add an audit to</param>
        /// <param name="lowStockAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddLowStockAuditWithHttpInfo (int? lowStockId, string lowStockAudit);
        
        /// <summary>
        /// Add new tags for a lowStock.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing lowStock.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add a tag to</param>
        /// <param name="lowStockTag">The tag to add</param>
        /// <returns></returns>
        void AddLowStockTag (int? lowStockId, string lowStockTag);
  
        /// <summary>
        /// Add new tags for a lowStock.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing lowStock.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add a tag to</param>
        /// <param name="lowStockTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddLowStockTagWithHttpInfo (int? lowStockId, string lowStockTag);
        
        /// <summary>
        /// Delete a tag for a lowStock.
        /// </summary>
        /// <remarks>
        /// Deletes an existing lowStock tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to remove tag from</param>
        /// <param name="lowStockTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteLowStockTag (int? lowStockId, string lowStockTag);
  
        /// <summary>
        /// Delete a tag for a lowStock.
        /// </summary>
        /// <remarks>
        /// Deletes an existing lowStock tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to remove tag from</param>
        /// <param name="lowStockTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLowStockTagWithHttpInfo (int? lowStockId, string lowStockTag);
        
        /// <summary>
        /// Get a duplicated a lowStock by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated lowStock identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be duplicated.</param>
        /// <returns>LowStock</returns>
        LowStock GetDuplicateLowStockById (int? lowStockId);
  
        /// <summary>
        /// Get a duplicated a lowStock by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated lowStock identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be duplicated.</param>
        /// <returns>ApiResponse of LowStock</returns>
        ApiResponse<LowStock> GetDuplicateLowStockByIdWithHttpInfo (int? lowStockId);
        
        /// <summary>
        /// Search lowStocks by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of lowStocks that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;LowStock&gt;</returns>
        List<LowStock> GetLowStockByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search lowStocks by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of lowStocks that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;LowStock&gt;</returns>
        ApiResponse<List<LowStock>> GetLowStockByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a lowStock by id
        /// </summary>
        /// <remarks>
        /// Returns the lowStock identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be returned.</param>
        /// <returns>LowStock</returns>
        LowStock GetLowStockById (int? lowStockId);
  
        /// <summary>
        /// Get a lowStock by id
        /// </summary>
        /// <remarks>
        /// Returns the lowStock identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be returned.</param>
        /// <returns>ApiResponse of LowStock</returns>
        ApiResponse<LowStock> GetLowStockByIdWithHttpInfo (int? lowStockId);
        
        /// <summary>
        /// Get the tags for a lowStock.
        /// </summary>
        /// <remarks>
        /// Get all existing lowStock tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to get tags for</param>
        /// <returns></returns>
        void GetLowStockTags (int? lowStockId);
  
        /// <summary>
        /// Get the tags for a lowStock.
        /// </summary>
        /// <remarks>
        /// Get all existing lowStock tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetLowStockTagsWithHttpInfo (int? lowStockId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a lowStock
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing lowStock.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add an audit to</param>
        /// <param name="lowStockAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddLowStockAuditAsync (int? lowStockId, string lowStockAudit);

        /// <summary>
        /// Add new audit for a lowStock
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing lowStock.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add an audit to</param>
        /// <param name="lowStockAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddLowStockAuditAsyncWithHttpInfo (int? lowStockId, string lowStockAudit);
        
        /// <summary>
        /// Add new tags for a lowStock.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing lowStock.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add a tag to</param>
        /// <param name="lowStockTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddLowStockTagAsync (int? lowStockId, string lowStockTag);

        /// <summary>
        /// Add new tags for a lowStock.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing lowStock.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add a tag to</param>
        /// <param name="lowStockTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddLowStockTagAsyncWithHttpInfo (int? lowStockId, string lowStockTag);
        
        /// <summary>
        /// Delete a tag for a lowStock.
        /// </summary>
        /// <remarks>
        /// Deletes an existing lowStock tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to remove tag from</param>
        /// <param name="lowStockTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLowStockTagAsync (int? lowStockId, string lowStockTag);

        /// <summary>
        /// Delete a tag for a lowStock.
        /// </summary>
        /// <remarks>
        /// Deletes an existing lowStock tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to remove tag from</param>
        /// <param name="lowStockTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLowStockTagAsyncWithHttpInfo (int? lowStockId, string lowStockTag);
        
        /// <summary>
        /// Get a duplicated a lowStock by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated lowStock identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be duplicated.</param>
        /// <returns>Task of LowStock</returns>
        System.Threading.Tasks.Task<LowStock> GetDuplicateLowStockByIdAsync (int? lowStockId);

        /// <summary>
        /// Get a duplicated a lowStock by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated lowStock identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be duplicated.</param>
        /// <returns>Task of ApiResponse (LowStock)</returns>
        System.Threading.Tasks.Task<ApiResponse<LowStock>> GetDuplicateLowStockByIdAsyncWithHttpInfo (int? lowStockId);
        
        /// <summary>
        /// Search lowStocks by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of lowStocks that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LowStock&gt;</returns>
        System.Threading.Tasks.Task<List<LowStock>> GetLowStockByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search lowStocks by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of lowStocks that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LowStock&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LowStock>>> GetLowStockByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a lowStock by id
        /// </summary>
        /// <remarks>
        /// Returns the lowStock identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be returned.</param>
        /// <returns>Task of LowStock</returns>
        System.Threading.Tasks.Task<LowStock> GetLowStockByIdAsync (int? lowStockId);

        /// <summary>
        /// Get a lowStock by id
        /// </summary>
        /// <remarks>
        /// Returns the lowStock identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be returned.</param>
        /// <returns>Task of ApiResponse (LowStock)</returns>
        System.Threading.Tasks.Task<ApiResponse<LowStock>> GetLowStockByIdAsyncWithHttpInfo (int? lowStockId);
        
        /// <summary>
        /// Get the tags for a lowStock.
        /// </summary>
        /// <remarks>
        /// Get all existing lowStock tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetLowStockTagsAsync (int? lowStockId);

        /// <summary>
        /// Get the tags for a lowStock.
        /// </summary>
        /// <remarks>
        /// Get all existing lowStock tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetLowStockTagsAsyncWithHttpInfo (int? lowStockId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LowStockApi : ILowStockApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LowStockApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LowStockApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LowStockApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LowStockApi(Configuration configuration = null)
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
        /// Add new audit for a lowStock Adds an audit to an existing lowStock.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add an audit to</param> 
        /// <param name="lowStockAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddLowStockAudit (int? lowStockId, string lowStockAudit)
        {
             AddLowStockAuditWithHttpInfo(lowStockId, lowStockAudit);
        }

        /// <summary>
        /// Add new audit for a lowStock Adds an audit to an existing lowStock.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add an audit to</param> 
        /// <param name="lowStockAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddLowStockAuditWithHttpInfo (int? lowStockId, string lowStockAudit)
        {
            
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null)
                throw new ApiException(400, "Missing required parameter 'lowStockId' when calling LowStockApi->AddLowStockAudit");
            
            // verify the required parameter 'lowStockAudit' is set
            if (lowStockAudit == null)
                throw new ApiException(400, "Missing required parameter 'lowStockAudit' when calling LowStockApi->AddLowStockAudit");
            
    
            var localVarPath = "/beta/lowStock/{lowStockId}/audit/{lowStockAudit}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            if (lowStockAudit != null) localVarPathParams.Add("lowStockAudit", Configuration.ApiClient.ParameterToString(lowStockAudit)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddLowStockAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLowStockAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a lowStock Adds an audit to an existing lowStock.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add an audit to</param>
        /// <param name="lowStockAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddLowStockAuditAsync (int? lowStockId, string lowStockAudit)
        {
             await AddLowStockAuditAsyncWithHttpInfo(lowStockId, lowStockAudit);

        }

        /// <summary>
        /// Add new audit for a lowStock Adds an audit to an existing lowStock.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add an audit to</param>
        /// <param name="lowStockAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddLowStockAuditAsyncWithHttpInfo (int? lowStockId, string lowStockAudit)
        {
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null) throw new ApiException(400, "Missing required parameter 'lowStockId' when calling AddLowStockAudit");
            // verify the required parameter 'lowStockAudit' is set
            if (lowStockAudit == null) throw new ApiException(400, "Missing required parameter 'lowStockAudit' when calling AddLowStockAudit");
            
    
            var localVarPath = "/beta/lowStock/{lowStockId}/audit/{lowStockAudit}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            if (lowStockAudit != null) localVarPathParams.Add("lowStockAudit", Configuration.ApiClient.ParameterToString(lowStockAudit)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddLowStockAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLowStockAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a lowStock. Adds a tag to an existing lowStock.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add a tag to</param> 
        /// <param name="lowStockTag">The tag to add</param> 
        /// <returns></returns>
        public void AddLowStockTag (int? lowStockId, string lowStockTag)
        {
             AddLowStockTagWithHttpInfo(lowStockId, lowStockTag);
        }

        /// <summary>
        /// Add new tags for a lowStock. Adds a tag to an existing lowStock.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add a tag to</param> 
        /// <param name="lowStockTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddLowStockTagWithHttpInfo (int? lowStockId, string lowStockTag)
        {
            
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null)
                throw new ApiException(400, "Missing required parameter 'lowStockId' when calling LowStockApi->AddLowStockTag");
            
            // verify the required parameter 'lowStockTag' is set
            if (lowStockTag == null)
                throw new ApiException(400, "Missing required parameter 'lowStockTag' when calling LowStockApi->AddLowStockTag");
            
    
            var localVarPath = "/beta/lowStock/{lowStockId}/tag/{lowStockTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            if (lowStockTag != null) localVarPathParams.Add("lowStockTag", Configuration.ApiClient.ParameterToString(lowStockTag)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddLowStockTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLowStockTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a lowStock. Adds a tag to an existing lowStock.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add a tag to</param>
        /// <param name="lowStockTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddLowStockTagAsync (int? lowStockId, string lowStockTag)
        {
             await AddLowStockTagAsyncWithHttpInfo(lowStockId, lowStockTag);

        }

        /// <summary>
        /// Add new tags for a lowStock. Adds a tag to an existing lowStock.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to add a tag to</param>
        /// <param name="lowStockTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddLowStockTagAsyncWithHttpInfo (int? lowStockId, string lowStockTag)
        {
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null) throw new ApiException(400, "Missing required parameter 'lowStockId' when calling AddLowStockTag");
            // verify the required parameter 'lowStockTag' is set
            if (lowStockTag == null) throw new ApiException(400, "Missing required parameter 'lowStockTag' when calling AddLowStockTag");
            
    
            var localVarPath = "/beta/lowStock/{lowStockId}/tag/{lowStockTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            if (lowStockTag != null) localVarPathParams.Add("lowStockTag", Configuration.ApiClient.ParameterToString(lowStockTag)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddLowStockTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLowStockTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a lowStock. Deletes an existing lowStock tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to remove tag from</param> 
        /// <param name="lowStockTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteLowStockTag (int? lowStockId, string lowStockTag)
        {
             DeleteLowStockTagWithHttpInfo(lowStockId, lowStockTag);
        }

        /// <summary>
        /// Delete a tag for a lowStock. Deletes an existing lowStock tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to remove tag from</param> 
        /// <param name="lowStockTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLowStockTagWithHttpInfo (int? lowStockId, string lowStockTag)
        {
            
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null)
                throw new ApiException(400, "Missing required parameter 'lowStockId' when calling LowStockApi->DeleteLowStockTag");
            
            // verify the required parameter 'lowStockTag' is set
            if (lowStockTag == null)
                throw new ApiException(400, "Missing required parameter 'lowStockTag' when calling LowStockApi->DeleteLowStockTag");
            
    
            var localVarPath = "/beta/lowStock/{lowStockId}/tag/{lowStockTag}";
    
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            if (lowStockTag != null) localVarPathParams.Add("lowStockTag", Configuration.ApiClient.ParameterToString(lowStockTag)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLowStockTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLowStockTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a lowStock. Deletes an existing lowStock tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to remove tag from</param>
        /// <param name="lowStockTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLowStockTagAsync (int? lowStockId, string lowStockTag)
        {
             await DeleteLowStockTagAsyncWithHttpInfo(lowStockId, lowStockTag);

        }

        /// <summary>
        /// Delete a tag for a lowStock. Deletes an existing lowStock tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to remove tag from</param>
        /// <param name="lowStockTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLowStockTagAsyncWithHttpInfo (int? lowStockId, string lowStockTag)
        {
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null) throw new ApiException(400, "Missing required parameter 'lowStockId' when calling DeleteLowStockTag");
            // verify the required parameter 'lowStockTag' is set
            if (lowStockTag == null) throw new ApiException(400, "Missing required parameter 'lowStockTag' when calling DeleteLowStockTag");
            
    
            var localVarPath = "/beta/lowStock/{lowStockId}/tag/{lowStockTag}";
    
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            if (lowStockTag != null) localVarPathParams.Add("lowStockTag", Configuration.ApiClient.ParameterToString(lowStockTag)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLowStockTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLowStockTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a lowStock by id Returns a duplicated lowStock identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be duplicated.</param> 
        /// <returns>LowStock</returns>
        public LowStock GetDuplicateLowStockById (int? lowStockId)
        {
             ApiResponse<LowStock> localVarResponse = GetDuplicateLowStockByIdWithHttpInfo(lowStockId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a lowStock by id Returns a duplicated lowStock identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be duplicated.</param> 
        /// <returns>ApiResponse of LowStock</returns>
        public ApiResponse< LowStock > GetDuplicateLowStockByIdWithHttpInfo (int? lowStockId)
        {
            
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null)
                throw new ApiException(400, "Missing required parameter 'lowStockId' when calling LowStockApi->GetDuplicateLowStockById");
            
    
            var localVarPath = "/beta/lowStock/duplicate/{lowStockId}";
    
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLowStockById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLowStockById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LowStock>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LowStock) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LowStock)));
            
        }

        
        /// <summary>
        /// Get a duplicated a lowStock by id Returns a duplicated lowStock identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be duplicated.</param>
        /// <returns>Task of LowStock</returns>
        public async System.Threading.Tasks.Task<LowStock> GetDuplicateLowStockByIdAsync (int? lowStockId)
        {
             ApiResponse<LowStock> localVarResponse = await GetDuplicateLowStockByIdAsyncWithHttpInfo(lowStockId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a lowStock by id Returns a duplicated lowStock identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be duplicated.</param>
        /// <returns>Task of ApiResponse (LowStock)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LowStock>> GetDuplicateLowStockByIdAsyncWithHttpInfo (int? lowStockId)
        {
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null) throw new ApiException(400, "Missing required parameter 'lowStockId' when calling GetDuplicateLowStockById");
            
    
            var localVarPath = "/beta/lowStock/duplicate/{lowStockId}";
    
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLowStockById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLowStockById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LowStock>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LowStock) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LowStock)));
            
        }
        
        /// <summary>
        /// Search lowStocks by filter Returns the list of lowStocks that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;LowStock&gt;</returns>
        public List<LowStock> GetLowStockByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LowStock>> localVarResponse = GetLowStockByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search lowStocks by filter Returns the list of lowStocks that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;LowStock&gt;</returns>
        public ApiResponse< List<LowStock> > GetLowStockByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/lowStock/search";
    
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
            
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<LowStock>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LowStock>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LowStock>)));
            
        }

        
        /// <summary>
        /// Search lowStocks by filter Returns the list of lowStocks that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LowStock&gt;</returns>
        public async System.Threading.Tasks.Task<List<LowStock>> GetLowStockByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LowStock>> localVarResponse = await GetLowStockByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search lowStocks by filter Returns the list of lowStocks that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LowStock&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LowStock>>> GetLowStockByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/lowStock/search";
    
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
            
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<LowStock>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LowStock>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LowStock>)));
            
        }
        
        /// <summary>
        /// Get a lowStock by id Returns the lowStock identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be returned.</param> 
        /// <returns>LowStock</returns>
        public LowStock GetLowStockById (int? lowStockId)
        {
             ApiResponse<LowStock> localVarResponse = GetLowStockByIdWithHttpInfo(lowStockId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a lowStock by id Returns the lowStock identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be returned.</param> 
        /// <returns>ApiResponse of LowStock</returns>
        public ApiResponse< LowStock > GetLowStockByIdWithHttpInfo (int? lowStockId)
        {
            
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null)
                throw new ApiException(400, "Missing required parameter 'lowStockId' when calling LowStockApi->GetLowStockById");
            
    
            var localVarPath = "/beta/lowStock/{lowStockId}";
    
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LowStock>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LowStock) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LowStock)));
            
        }

        
        /// <summary>
        /// Get a lowStock by id Returns the lowStock identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be returned.</param>
        /// <returns>Task of LowStock</returns>
        public async System.Threading.Tasks.Task<LowStock> GetLowStockByIdAsync (int? lowStockId)
        {
             ApiResponse<LowStock> localVarResponse = await GetLowStockByIdAsyncWithHttpInfo(lowStockId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a lowStock by id Returns the lowStock identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to be returned.</param>
        /// <returns>Task of ApiResponse (LowStock)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LowStock>> GetLowStockByIdAsyncWithHttpInfo (int? lowStockId)
        {
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null) throw new ApiException(400, "Missing required parameter 'lowStockId' when calling GetLowStockById");
            
    
            var localVarPath = "/beta/lowStock/{lowStockId}";
    
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LowStock>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LowStock) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LowStock)));
            
        }
        
        /// <summary>
        /// Get the tags for a lowStock. Get all existing lowStock tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to get tags for</param> 
        /// <returns></returns>
        public void GetLowStockTags (int? lowStockId)
        {
             GetLowStockTagsWithHttpInfo(lowStockId);
        }

        /// <summary>
        /// Get the tags for a lowStock. Get all existing lowStock tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetLowStockTagsWithHttpInfo (int? lowStockId)
        {
            
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null)
                throw new ApiException(400, "Missing required parameter 'lowStockId' when calling LowStockApi->GetLowStockTags");
            
    
            var localVarPath = "/beta/lowStock/{lowStockId}/tag";
    
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a lowStock. Get all existing lowStock tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetLowStockTagsAsync (int? lowStockId)
        {
             await GetLowStockTagsAsyncWithHttpInfo(lowStockId);

        }

        /// <summary>
        /// Get the tags for a lowStock. Get all existing lowStock tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lowStockId">Id of the lowStock to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetLowStockTagsAsyncWithHttpInfo (int? lowStockId)
        {
            // verify the required parameter 'lowStockId' is set
            if (lowStockId == null) throw new ApiException(400, "Missing required parameter 'lowStockId' when calling GetLowStockTags");
            
    
            var localVarPath = "/beta/lowStock/{lowStockId}/tag";
    
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
            if (lowStockId != null) localVarPathParams.Add("lowStockId", Configuration.ApiClient.ParameterToString(lowStockId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLowStockTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
