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
    public interface IFulfillmentProcessApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a fulfillmentProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing fulfillmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add an audit to</param>
        /// <param name="fulfillmentProcessAudit">The audit to add</param>
        /// <returns></returns>
        void AddFulfillmentProcessAudit (int? fulfillmentProcessId, string fulfillmentProcessAudit);
  
        /// <summary>
        /// Add new audit for a fulfillmentProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing fulfillmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add an audit to</param>
        /// <param name="fulfillmentProcessAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddFulfillmentProcessAuditWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessAudit);
        
        /// <summary>
        /// Add new tags for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing fulfillmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add a tag to</param>
        /// <param name="fulfillmentProcessTag">The tag to add</param>
        /// <returns></returns>
        void AddFulfillmentProcessTag (int? fulfillmentProcessId, string fulfillmentProcessTag);
  
        /// <summary>
        /// Add new tags for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing fulfillmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add a tag to</param>
        /// <param name="fulfillmentProcessTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddFulfillmentProcessTagWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessTag);
        
        /// <summary>
        /// Delete a tag for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing fulfillmentProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to remove tag from</param>
        /// <param name="fulfillmentProcessTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteFulfillmentProcessTag (int? fulfillmentProcessId, string fulfillmentProcessTag);
  
        /// <summary>
        /// Delete a tag for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing fulfillmentProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to remove tag from</param>
        /// <param name="fulfillmentProcessTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFulfillmentProcessTagWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessTag);
        
        /// <summary>
        /// Get a duplicated a fulfillmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated fulfillmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be duplicated.</param>
        /// <returns>FulfillmentProcess</returns>
        FulfillmentProcess GetDuplicateFulfillmentProcessById (int? fulfillmentProcessId);
  
        /// <summary>
        /// Get a duplicated a fulfillmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated fulfillmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be duplicated.</param>
        /// <returns>ApiResponse of FulfillmentProcess</returns>
        ApiResponse<FulfillmentProcess> GetDuplicateFulfillmentProcessByIdWithHttpInfo (int? fulfillmentProcessId);
        
        /// <summary>
        /// Search fulfillmentProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;FulfillmentProcess&gt;</returns>
        List<FulfillmentProcess> GetFulfillmentProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search fulfillmentProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;FulfillmentProcess&gt;</returns>
        ApiResponse<List<FulfillmentProcess>> GetFulfillmentProcessByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a fulfillmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be returned.</param>
        /// <returns>FulfillmentProcess</returns>
        FulfillmentProcess GetFulfillmentProcessById (int? fulfillmentProcessId);
  
        /// <summary>
        /// Get a fulfillmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be returned.</param>
        /// <returns>ApiResponse of FulfillmentProcess</returns>
        ApiResponse<FulfillmentProcess> GetFulfillmentProcessByIdWithHttpInfo (int? fulfillmentProcessId);
        
        /// <summary>
        /// Get the tags for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing fulfillmentProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to get tags for</param>
        /// <returns></returns>
        void GetFulfillmentProcessTags (int? fulfillmentProcessId);
  
        /// <summary>
        /// Get the tags for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing fulfillmentProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetFulfillmentProcessTagsWithHttpInfo (int? fulfillmentProcessId);
        
        /// <summary>
        /// Update a fulfillmentProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentProcess to be updated.</param>
        /// <returns></returns>
        void UpdateFulfillmentProcessCustomFields (FulfillmentProcess body);
  
        /// <summary>
        /// Update a fulfillmentProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentProcess to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateFulfillmentProcessCustomFieldsWithHttpInfo (FulfillmentProcess body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a fulfillmentProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing fulfillmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add an audit to</param>
        /// <param name="fulfillmentProcessAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddFulfillmentProcessAuditAsync (int? fulfillmentProcessId, string fulfillmentProcessAudit);

        /// <summary>
        /// Add new audit for a fulfillmentProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing fulfillmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add an audit to</param>
        /// <param name="fulfillmentProcessAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddFulfillmentProcessAuditAsyncWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessAudit);
        
        /// <summary>
        /// Add new tags for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing fulfillmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add a tag to</param>
        /// <param name="fulfillmentProcessTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddFulfillmentProcessTagAsync (int? fulfillmentProcessId, string fulfillmentProcessTag);

        /// <summary>
        /// Add new tags for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing fulfillmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add a tag to</param>
        /// <param name="fulfillmentProcessTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddFulfillmentProcessTagAsyncWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessTag);
        
        /// <summary>
        /// Delete a tag for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing fulfillmentProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to remove tag from</param>
        /// <param name="fulfillmentProcessTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFulfillmentProcessTagAsync (int? fulfillmentProcessId, string fulfillmentProcessTag);

        /// <summary>
        /// Delete a tag for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing fulfillmentProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to remove tag from</param>
        /// <param name="fulfillmentProcessTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFulfillmentProcessTagAsyncWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessTag);
        
        /// <summary>
        /// Get a duplicated a fulfillmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated fulfillmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be duplicated.</param>
        /// <returns>Task of FulfillmentProcess</returns>
        System.Threading.Tasks.Task<FulfillmentProcess> GetDuplicateFulfillmentProcessByIdAsync (int? fulfillmentProcessId);

        /// <summary>
        /// Get a duplicated a fulfillmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated fulfillmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be duplicated.</param>
        /// <returns>Task of ApiResponse (FulfillmentProcess)</returns>
        System.Threading.Tasks.Task<ApiResponse<FulfillmentProcess>> GetDuplicateFulfillmentProcessByIdAsyncWithHttpInfo (int? fulfillmentProcessId);
        
        /// <summary>
        /// Search fulfillmentProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;FulfillmentProcess&gt;</returns>
        System.Threading.Tasks.Task<List<FulfillmentProcess>> GetFulfillmentProcessByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search fulfillmentProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;FulfillmentProcess&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<FulfillmentProcess>>> GetFulfillmentProcessByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a fulfillmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be returned.</param>
        /// <returns>Task of FulfillmentProcess</returns>
        System.Threading.Tasks.Task<FulfillmentProcess> GetFulfillmentProcessByIdAsync (int? fulfillmentProcessId);

        /// <summary>
        /// Get a fulfillmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be returned.</param>
        /// <returns>Task of ApiResponse (FulfillmentProcess)</returns>
        System.Threading.Tasks.Task<ApiResponse<FulfillmentProcess>> GetFulfillmentProcessByIdAsyncWithHttpInfo (int? fulfillmentProcessId);
        
        /// <summary>
        /// Get the tags for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing fulfillmentProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetFulfillmentProcessTagsAsync (int? fulfillmentProcessId);

        /// <summary>
        /// Get the tags for a fulfillmentProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing fulfillmentProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetFulfillmentProcessTagsAsyncWithHttpInfo (int? fulfillmentProcessId);
        
        /// <summary>
        /// Update a fulfillmentProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentProcess to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateFulfillmentProcessCustomFieldsAsync (FulfillmentProcess body);

        /// <summary>
        /// Update a fulfillmentProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentProcess to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateFulfillmentProcessCustomFieldsAsyncWithHttpInfo (FulfillmentProcess body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FulfillmentProcessApi : IFulfillmentProcessApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentProcessApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FulfillmentProcessApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentProcessApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FulfillmentProcessApi(Configuration configuration = null)
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
        /// Add new audit for a fulfillmentProcess Adds an audit to an existing fulfillmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add an audit to</param> 
        /// <param name="fulfillmentProcessAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddFulfillmentProcessAudit (int? fulfillmentProcessId, string fulfillmentProcessAudit)
        {
             AddFulfillmentProcessAuditWithHttpInfo(fulfillmentProcessId, fulfillmentProcessAudit);
        }

        /// <summary>
        /// Add new audit for a fulfillmentProcess Adds an audit to an existing fulfillmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add an audit to</param> 
        /// <param name="fulfillmentProcessAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddFulfillmentProcessAuditWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessAudit)
        {
            
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling FulfillmentProcessApi->AddFulfillmentProcessAudit");
            
            // verify the required parameter 'fulfillmentProcessAudit' is set
            if (fulfillmentProcessAudit == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentProcessAudit' when calling FulfillmentProcessApi->AddFulfillmentProcessAudit");
            
    
            var localVarPath = "/beta/fulfillmentProcess/{fulfillmentProcessId}/audit/{fulfillmentProcessAudit}";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            if (fulfillmentProcessAudit != null) localVarPathParams.Add("fulfillmentProcessAudit", Configuration.ApiClient.ParameterToString(fulfillmentProcessAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentProcessAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentProcessAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a fulfillmentProcess Adds an audit to an existing fulfillmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add an audit to</param>
        /// <param name="fulfillmentProcessAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddFulfillmentProcessAuditAsync (int? fulfillmentProcessId, string fulfillmentProcessAudit)
        {
             await AddFulfillmentProcessAuditAsyncWithHttpInfo(fulfillmentProcessId, fulfillmentProcessAudit);

        }

        /// <summary>
        /// Add new audit for a fulfillmentProcess Adds an audit to an existing fulfillmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add an audit to</param>
        /// <param name="fulfillmentProcessAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddFulfillmentProcessAuditAsyncWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessAudit)
        {
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null) throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling AddFulfillmentProcessAudit");
            // verify the required parameter 'fulfillmentProcessAudit' is set
            if (fulfillmentProcessAudit == null) throw new ApiException(400, "Missing required parameter 'fulfillmentProcessAudit' when calling AddFulfillmentProcessAudit");
            
    
            var localVarPath = "/beta/fulfillmentProcess/{fulfillmentProcessId}/audit/{fulfillmentProcessAudit}";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            if (fulfillmentProcessAudit != null) localVarPathParams.Add("fulfillmentProcessAudit", Configuration.ApiClient.ParameterToString(fulfillmentProcessAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentProcessAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentProcessAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a fulfillmentProcess. Adds a tag to an existing fulfillmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add a tag to</param> 
        /// <param name="fulfillmentProcessTag">The tag to add</param> 
        /// <returns></returns>
        public void AddFulfillmentProcessTag (int? fulfillmentProcessId, string fulfillmentProcessTag)
        {
             AddFulfillmentProcessTagWithHttpInfo(fulfillmentProcessId, fulfillmentProcessTag);
        }

        /// <summary>
        /// Add new tags for a fulfillmentProcess. Adds a tag to an existing fulfillmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add a tag to</param> 
        /// <param name="fulfillmentProcessTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddFulfillmentProcessTagWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessTag)
        {
            
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling FulfillmentProcessApi->AddFulfillmentProcessTag");
            
            // verify the required parameter 'fulfillmentProcessTag' is set
            if (fulfillmentProcessTag == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentProcessTag' when calling FulfillmentProcessApi->AddFulfillmentProcessTag");
            
    
            var localVarPath = "/beta/fulfillmentProcess/{fulfillmentProcessId}/tag/{fulfillmentProcessTag}";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            if (fulfillmentProcessTag != null) localVarPathParams.Add("fulfillmentProcessTag", Configuration.ApiClient.ParameterToString(fulfillmentProcessTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a fulfillmentProcess. Adds a tag to an existing fulfillmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add a tag to</param>
        /// <param name="fulfillmentProcessTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddFulfillmentProcessTagAsync (int? fulfillmentProcessId, string fulfillmentProcessTag)
        {
             await AddFulfillmentProcessTagAsyncWithHttpInfo(fulfillmentProcessId, fulfillmentProcessTag);

        }

        /// <summary>
        /// Add new tags for a fulfillmentProcess. Adds a tag to an existing fulfillmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to add a tag to</param>
        /// <param name="fulfillmentProcessTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddFulfillmentProcessTagAsyncWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessTag)
        {
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null) throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling AddFulfillmentProcessTag");
            // verify the required parameter 'fulfillmentProcessTag' is set
            if (fulfillmentProcessTag == null) throw new ApiException(400, "Missing required parameter 'fulfillmentProcessTag' when calling AddFulfillmentProcessTag");
            
    
            var localVarPath = "/beta/fulfillmentProcess/{fulfillmentProcessId}/tag/{fulfillmentProcessTag}";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            if (fulfillmentProcessTag != null) localVarPathParams.Add("fulfillmentProcessTag", Configuration.ApiClient.ParameterToString(fulfillmentProcessTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a fulfillmentProcess. Deletes an existing fulfillmentProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to remove tag from</param> 
        /// <param name="fulfillmentProcessTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteFulfillmentProcessTag (int? fulfillmentProcessId, string fulfillmentProcessTag)
        {
             DeleteFulfillmentProcessTagWithHttpInfo(fulfillmentProcessId, fulfillmentProcessTag);
        }

        /// <summary>
        /// Delete a tag for a fulfillmentProcess. Deletes an existing fulfillmentProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to remove tag from</param> 
        /// <param name="fulfillmentProcessTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFulfillmentProcessTagWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessTag)
        {
            
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling FulfillmentProcessApi->DeleteFulfillmentProcessTag");
            
            // verify the required parameter 'fulfillmentProcessTag' is set
            if (fulfillmentProcessTag == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentProcessTag' when calling FulfillmentProcessApi->DeleteFulfillmentProcessTag");
            
    
            var localVarPath = "/beta/fulfillmentProcess/{fulfillmentProcessId}/tag/{fulfillmentProcessTag}";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            if (fulfillmentProcessTag != null) localVarPathParams.Add("fulfillmentProcessTag", Configuration.ApiClient.ParameterToString(fulfillmentProcessTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteFulfillmentProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFulfillmentProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a fulfillmentProcess. Deletes an existing fulfillmentProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to remove tag from</param>
        /// <param name="fulfillmentProcessTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteFulfillmentProcessTagAsync (int? fulfillmentProcessId, string fulfillmentProcessTag)
        {
             await DeleteFulfillmentProcessTagAsyncWithHttpInfo(fulfillmentProcessId, fulfillmentProcessTag);

        }

        /// <summary>
        /// Delete a tag for a fulfillmentProcess. Deletes an existing fulfillmentProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to remove tag from</param>
        /// <param name="fulfillmentProcessTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFulfillmentProcessTagAsyncWithHttpInfo (int? fulfillmentProcessId, string fulfillmentProcessTag)
        {
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null) throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling DeleteFulfillmentProcessTag");
            // verify the required parameter 'fulfillmentProcessTag' is set
            if (fulfillmentProcessTag == null) throw new ApiException(400, "Missing required parameter 'fulfillmentProcessTag' when calling DeleteFulfillmentProcessTag");
            
    
            var localVarPath = "/beta/fulfillmentProcess/{fulfillmentProcessId}/tag/{fulfillmentProcessTag}";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            if (fulfillmentProcessTag != null) localVarPathParams.Add("fulfillmentProcessTag", Configuration.ApiClient.ParameterToString(fulfillmentProcessTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteFulfillmentProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFulfillmentProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a fulfillmentProcess by id Returns a duplicated fulfillmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be duplicated.</param> 
        /// <returns>FulfillmentProcess</returns>
        public FulfillmentProcess GetDuplicateFulfillmentProcessById (int? fulfillmentProcessId)
        {
             ApiResponse<FulfillmentProcess> localVarResponse = GetDuplicateFulfillmentProcessByIdWithHttpInfo(fulfillmentProcessId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a fulfillmentProcess by id Returns a duplicated fulfillmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be duplicated.</param> 
        /// <returns>ApiResponse of FulfillmentProcess</returns>
        public ApiResponse< FulfillmentProcess > GetDuplicateFulfillmentProcessByIdWithHttpInfo (int? fulfillmentProcessId)
        {
            
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling FulfillmentProcessApi->GetDuplicateFulfillmentProcessById");
            
    
            var localVarPath = "/beta/fulfillmentProcess/duplicate/{fulfillmentProcessId}";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateFulfillmentProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateFulfillmentProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FulfillmentProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FulfillmentProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FulfillmentProcess)));
            
        }

        
        /// <summary>
        /// Get a duplicated a fulfillmentProcess by id Returns a duplicated fulfillmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be duplicated.</param>
        /// <returns>Task of FulfillmentProcess</returns>
        public async System.Threading.Tasks.Task<FulfillmentProcess> GetDuplicateFulfillmentProcessByIdAsync (int? fulfillmentProcessId)
        {
             ApiResponse<FulfillmentProcess> localVarResponse = await GetDuplicateFulfillmentProcessByIdAsyncWithHttpInfo(fulfillmentProcessId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a fulfillmentProcess by id Returns a duplicated fulfillmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be duplicated.</param>
        /// <returns>Task of ApiResponse (FulfillmentProcess)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FulfillmentProcess>> GetDuplicateFulfillmentProcessByIdAsyncWithHttpInfo (int? fulfillmentProcessId)
        {
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null) throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling GetDuplicateFulfillmentProcessById");
            
    
            var localVarPath = "/beta/fulfillmentProcess/duplicate/{fulfillmentProcessId}";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateFulfillmentProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateFulfillmentProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FulfillmentProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FulfillmentProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FulfillmentProcess)));
            
        }
        
        /// <summary>
        /// Search fulfillmentProcesses by filter Returns the list of fulfillmentProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;FulfillmentProcess&gt;</returns>
        public List<FulfillmentProcess> GetFulfillmentProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<FulfillmentProcess>> localVarResponse = GetFulfillmentProcessByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search fulfillmentProcesses by filter Returns the list of fulfillmentProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;FulfillmentProcess&gt;</returns>
        public ApiResponse< List<FulfillmentProcess> > GetFulfillmentProcessByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/fulfillmentProcess/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<FulfillmentProcess>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FulfillmentProcess>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FulfillmentProcess>)));
            
        }

        
        /// <summary>
        /// Search fulfillmentProcesses by filter Returns the list of fulfillmentProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;FulfillmentProcess&gt;</returns>
        public async System.Threading.Tasks.Task<List<FulfillmentProcess>> GetFulfillmentProcessByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<FulfillmentProcess>> localVarResponse = await GetFulfillmentProcessByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search fulfillmentProcesses by filter Returns the list of fulfillmentProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;FulfillmentProcess&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<FulfillmentProcess>>> GetFulfillmentProcessByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/fulfillmentProcess/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<FulfillmentProcess>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FulfillmentProcess>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FulfillmentProcess>)));
            
        }
        
        /// <summary>
        /// Get a fulfillmentProcess by id Returns the fulfillmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be returned.</param> 
        /// <returns>FulfillmentProcess</returns>
        public FulfillmentProcess GetFulfillmentProcessById (int? fulfillmentProcessId)
        {
             ApiResponse<FulfillmentProcess> localVarResponse = GetFulfillmentProcessByIdWithHttpInfo(fulfillmentProcessId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a fulfillmentProcess by id Returns the fulfillmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be returned.</param> 
        /// <returns>ApiResponse of FulfillmentProcess</returns>
        public ApiResponse< FulfillmentProcess > GetFulfillmentProcessByIdWithHttpInfo (int? fulfillmentProcessId)
        {
            
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling FulfillmentProcessApi->GetFulfillmentProcessById");
            
    
            var localVarPath = "/beta/fulfillmentProcess/{fulfillmentProcessId}";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FulfillmentProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FulfillmentProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FulfillmentProcess)));
            
        }

        
        /// <summary>
        /// Get a fulfillmentProcess by id Returns the fulfillmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be returned.</param>
        /// <returns>Task of FulfillmentProcess</returns>
        public async System.Threading.Tasks.Task<FulfillmentProcess> GetFulfillmentProcessByIdAsync (int? fulfillmentProcessId)
        {
             ApiResponse<FulfillmentProcess> localVarResponse = await GetFulfillmentProcessByIdAsyncWithHttpInfo(fulfillmentProcessId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a fulfillmentProcess by id Returns the fulfillmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to be returned.</param>
        /// <returns>Task of ApiResponse (FulfillmentProcess)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FulfillmentProcess>> GetFulfillmentProcessByIdAsyncWithHttpInfo (int? fulfillmentProcessId)
        {
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null) throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling GetFulfillmentProcessById");
            
    
            var localVarPath = "/beta/fulfillmentProcess/{fulfillmentProcessId}";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FulfillmentProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FulfillmentProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FulfillmentProcess)));
            
        }
        
        /// <summary>
        /// Get the tags for a fulfillmentProcess. Get all existing fulfillmentProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to get tags for</param> 
        /// <returns></returns>
        public void GetFulfillmentProcessTags (int? fulfillmentProcessId)
        {
             GetFulfillmentProcessTagsWithHttpInfo(fulfillmentProcessId);
        }

        /// <summary>
        /// Get the tags for a fulfillmentProcess. Get all existing fulfillmentProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetFulfillmentProcessTagsWithHttpInfo (int? fulfillmentProcessId)
        {
            
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling FulfillmentProcessApi->GetFulfillmentProcessTags");
            
    
            var localVarPath = "/beta/fulfillmentProcess/{fulfillmentProcessId}/tag";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a fulfillmentProcess. Get all existing fulfillmentProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetFulfillmentProcessTagsAsync (int? fulfillmentProcessId)
        {
             await GetFulfillmentProcessTagsAsyncWithHttpInfo(fulfillmentProcessId);

        }

        /// <summary>
        /// Get the tags for a fulfillmentProcess. Get all existing fulfillmentProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessId">Id of the fulfillmentProcess to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetFulfillmentProcessTagsAsyncWithHttpInfo (int? fulfillmentProcessId)
        {
            // verify the required parameter 'fulfillmentProcessId' is set
            if (fulfillmentProcessId == null) throw new ApiException(400, "Missing required parameter 'fulfillmentProcessId' when calling GetFulfillmentProcessTags");
            
    
            var localVarPath = "/beta/fulfillmentProcess/{fulfillmentProcessId}/tag";
    
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
            if (fulfillmentProcessId != null) localVarPathParams.Add("fulfillmentProcessId", Configuration.ApiClient.ParameterToString(fulfillmentProcessId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentProcessTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a fulfillmentProcess custom fields Updates an existing fulfillmentProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentProcess to be updated.</param> 
        /// <returns></returns>
        public void UpdateFulfillmentProcessCustomFields (FulfillmentProcess body)
        {
             UpdateFulfillmentProcessCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a fulfillmentProcess custom fields Updates an existing fulfillmentProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentProcess to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateFulfillmentProcessCustomFieldsWithHttpInfo (FulfillmentProcess body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling FulfillmentProcessApi->UpdateFulfillmentProcessCustomFields");
            
    
            var localVarPath = "/beta/fulfillmentProcess/customFields";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

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
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentProcessCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentProcessCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a fulfillmentProcess custom fields Updates an existing fulfillmentProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentProcess to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateFulfillmentProcessCustomFieldsAsync (FulfillmentProcess body)
        {
             await UpdateFulfillmentProcessCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a fulfillmentProcess custom fields Updates an existing fulfillmentProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentProcess to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateFulfillmentProcessCustomFieldsAsyncWithHttpInfo (FulfillmentProcess body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateFulfillmentProcessCustomFields");
            
    
            var localVarPath = "/beta/fulfillmentProcess/customFields";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentProcessCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentProcessCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
