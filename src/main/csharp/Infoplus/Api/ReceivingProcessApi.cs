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
    public interface IReceivingProcessApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a receivingProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing receivingProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add an audit to</param>
        /// <param name="receivingProcessAudit">The audit to add</param>
        /// <returns></returns>
        void AddReceivingProcessAudit (int? receivingProcessId, string receivingProcessAudit);
  
        /// <summary>
        /// Add new audit for a receivingProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing receivingProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add an audit to</param>
        /// <param name="receivingProcessAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddReceivingProcessAuditWithHttpInfo (int? receivingProcessId, string receivingProcessAudit);
        
        /// <summary>
        /// Add new tags for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing receivingProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add a tag to</param>
        /// <param name="receivingProcessTag">The tag to add</param>
        /// <returns></returns>
        void AddReceivingProcessTag (int? receivingProcessId, string receivingProcessTag);
  
        /// <summary>
        /// Add new tags for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing receivingProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add a tag to</param>
        /// <param name="receivingProcessTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddReceivingProcessTagWithHttpInfo (int? receivingProcessId, string receivingProcessTag);
        
        /// <summary>
        /// Delete a receivingProcess
        /// </summary>
        /// <remarks>
        /// Deletes the receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be deleted.</param>
        /// <returns></returns>
        void DeleteReceivingProcess (int? receivingProcessId);
  
        /// <summary>
        /// Delete a receivingProcess
        /// </summary>
        /// <remarks>
        /// Deletes the receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteReceivingProcessWithHttpInfo (int? receivingProcessId);
        
        /// <summary>
        /// Delete a tag for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing receivingProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to remove tag from</param>
        /// <param name="receivingProcessTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteReceivingProcessTag (int? receivingProcessId, string receivingProcessTag);
  
        /// <summary>
        /// Delete a tag for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing receivingProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to remove tag from</param>
        /// <param name="receivingProcessTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteReceivingProcessTagWithHttpInfo (int? receivingProcessId, string receivingProcessTag);
        
        /// <summary>
        /// Get a duplicated a receivingProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be duplicated.</param>
        /// <returns>ReceivingProcess</returns>
        ReceivingProcess GetDuplicateReceivingProcessById (int? receivingProcessId);
  
        /// <summary>
        /// Get a duplicated a receivingProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be duplicated.</param>
        /// <returns>ApiResponse of ReceivingProcess</returns>
        ApiResponse<ReceivingProcess> GetDuplicateReceivingProcessByIdWithHttpInfo (int? receivingProcessId);
        
        /// <summary>
        /// Search receivingProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of receivingProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ReceivingProcess&gt;</returns>
        List<ReceivingProcess> GetReceivingProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search receivingProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of receivingProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ReceivingProcess&gt;</returns>
        ApiResponse<List<ReceivingProcess>> GetReceivingProcessByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a receivingProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be returned.</param>
        /// <returns>ReceivingProcess</returns>
        ReceivingProcess GetReceivingProcessById (int? receivingProcessId);
  
        /// <summary>
        /// Get a receivingProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be returned.</param>
        /// <returns>ApiResponse of ReceivingProcess</returns>
        ApiResponse<ReceivingProcess> GetReceivingProcessByIdWithHttpInfo (int? receivingProcessId);
        
        /// <summary>
        /// Get the tags for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing receivingProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to get tags for</param>
        /// <returns></returns>
        void GetReceivingProcessTags (int? receivingProcessId);
  
        /// <summary>
        /// Get the tags for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing receivingProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetReceivingProcessTagsWithHttpInfo (int? receivingProcessId);
        
        /// <summary>
        /// Update a receivingProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingProcess to be updated.</param>
        /// <returns></returns>
        void UpdateReceivingProcessCustomFields (ReceivingProcess body);
  
        /// <summary>
        /// Update a receivingProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingProcess to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateReceivingProcessCustomFieldsWithHttpInfo (ReceivingProcess body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a receivingProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing receivingProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add an audit to</param>
        /// <param name="receivingProcessAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddReceivingProcessAuditAsync (int? receivingProcessId, string receivingProcessAudit);

        /// <summary>
        /// Add new audit for a receivingProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing receivingProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add an audit to</param>
        /// <param name="receivingProcessAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddReceivingProcessAuditAsyncWithHttpInfo (int? receivingProcessId, string receivingProcessAudit);
        
        /// <summary>
        /// Add new tags for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing receivingProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add a tag to</param>
        /// <param name="receivingProcessTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddReceivingProcessTagAsync (int? receivingProcessId, string receivingProcessTag);

        /// <summary>
        /// Add new tags for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing receivingProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add a tag to</param>
        /// <param name="receivingProcessTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddReceivingProcessTagAsyncWithHttpInfo (int? receivingProcessId, string receivingProcessTag);
        
        /// <summary>
        /// Delete a receivingProcess
        /// </summary>
        /// <remarks>
        /// Deletes the receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteReceivingProcessAsync (int? receivingProcessId);

        /// <summary>
        /// Delete a receivingProcess
        /// </summary>
        /// <remarks>
        /// Deletes the receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReceivingProcessAsyncWithHttpInfo (int? receivingProcessId);
        
        /// <summary>
        /// Delete a tag for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing receivingProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to remove tag from</param>
        /// <param name="receivingProcessTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteReceivingProcessTagAsync (int? receivingProcessId, string receivingProcessTag);

        /// <summary>
        /// Delete a tag for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing receivingProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to remove tag from</param>
        /// <param name="receivingProcessTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReceivingProcessTagAsyncWithHttpInfo (int? receivingProcessId, string receivingProcessTag);
        
        /// <summary>
        /// Get a duplicated a receivingProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be duplicated.</param>
        /// <returns>Task of ReceivingProcess</returns>
        System.Threading.Tasks.Task<ReceivingProcess> GetDuplicateReceivingProcessByIdAsync (int? receivingProcessId);

        /// <summary>
        /// Get a duplicated a receivingProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be duplicated.</param>
        /// <returns>Task of ApiResponse (ReceivingProcess)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReceivingProcess>> GetDuplicateReceivingProcessByIdAsyncWithHttpInfo (int? receivingProcessId);
        
        /// <summary>
        /// Search receivingProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of receivingProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ReceivingProcess&gt;</returns>
        System.Threading.Tasks.Task<List<ReceivingProcess>> GetReceivingProcessByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search receivingProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of receivingProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ReceivingProcess&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ReceivingProcess>>> GetReceivingProcessByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a receivingProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be returned.</param>
        /// <returns>Task of ReceivingProcess</returns>
        System.Threading.Tasks.Task<ReceivingProcess> GetReceivingProcessByIdAsync (int? receivingProcessId);

        /// <summary>
        /// Get a receivingProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the receivingProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be returned.</param>
        /// <returns>Task of ApiResponse (ReceivingProcess)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReceivingProcess>> GetReceivingProcessByIdAsyncWithHttpInfo (int? receivingProcessId);
        
        /// <summary>
        /// Get the tags for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing receivingProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetReceivingProcessTagsAsync (int? receivingProcessId);

        /// <summary>
        /// Get the tags for a receivingProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing receivingProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetReceivingProcessTagsAsyncWithHttpInfo (int? receivingProcessId);
        
        /// <summary>
        /// Update a receivingProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingProcess to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateReceivingProcessCustomFieldsAsync (ReceivingProcess body);

        /// <summary>
        /// Update a receivingProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingProcess to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReceivingProcessCustomFieldsAsyncWithHttpInfo (ReceivingProcess body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReceivingProcessApi : IReceivingProcessApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivingProcessApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReceivingProcessApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivingProcessApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReceivingProcessApi(Configuration configuration = null)
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
        /// Add new audit for a receivingProcess Adds an audit to an existing receivingProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add an audit to</param> 
        /// <param name="receivingProcessAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddReceivingProcessAudit (int? receivingProcessId, string receivingProcessAudit)
        {
             AddReceivingProcessAuditWithHttpInfo(receivingProcessId, receivingProcessAudit);
        }

        /// <summary>
        /// Add new audit for a receivingProcess Adds an audit to an existing receivingProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add an audit to</param> 
        /// <param name="receivingProcessAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddReceivingProcessAuditWithHttpInfo (int? receivingProcessId, string receivingProcessAudit)
        {
            
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null)
                throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling ReceivingProcessApi->AddReceivingProcessAudit");
            
            // verify the required parameter 'receivingProcessAudit' is set
            if (receivingProcessAudit == null)
                throw new ApiException(400, "Missing required parameter 'receivingProcessAudit' when calling ReceivingProcessApi->AddReceivingProcessAudit");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}/audit/{receivingProcessAudit}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            if (receivingProcessAudit != null) localVarPathParams.Add("receivingProcessAudit", Configuration.ApiClient.ParameterToString(receivingProcessAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingProcessAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingProcessAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a receivingProcess Adds an audit to an existing receivingProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add an audit to</param>
        /// <param name="receivingProcessAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddReceivingProcessAuditAsync (int? receivingProcessId, string receivingProcessAudit)
        {
             await AddReceivingProcessAuditAsyncWithHttpInfo(receivingProcessId, receivingProcessAudit);

        }

        /// <summary>
        /// Add new audit for a receivingProcess Adds an audit to an existing receivingProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add an audit to</param>
        /// <param name="receivingProcessAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddReceivingProcessAuditAsyncWithHttpInfo (int? receivingProcessId, string receivingProcessAudit)
        {
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null) throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling AddReceivingProcessAudit");
            // verify the required parameter 'receivingProcessAudit' is set
            if (receivingProcessAudit == null) throw new ApiException(400, "Missing required parameter 'receivingProcessAudit' when calling AddReceivingProcessAudit");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}/audit/{receivingProcessAudit}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            if (receivingProcessAudit != null) localVarPathParams.Add("receivingProcessAudit", Configuration.ApiClient.ParameterToString(receivingProcessAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingProcessAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingProcessAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a receivingProcess. Adds a tag to an existing receivingProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add a tag to</param> 
        /// <param name="receivingProcessTag">The tag to add</param> 
        /// <returns></returns>
        public void AddReceivingProcessTag (int? receivingProcessId, string receivingProcessTag)
        {
             AddReceivingProcessTagWithHttpInfo(receivingProcessId, receivingProcessTag);
        }

        /// <summary>
        /// Add new tags for a receivingProcess. Adds a tag to an existing receivingProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add a tag to</param> 
        /// <param name="receivingProcessTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddReceivingProcessTagWithHttpInfo (int? receivingProcessId, string receivingProcessTag)
        {
            
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null)
                throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling ReceivingProcessApi->AddReceivingProcessTag");
            
            // verify the required parameter 'receivingProcessTag' is set
            if (receivingProcessTag == null)
                throw new ApiException(400, "Missing required parameter 'receivingProcessTag' when calling ReceivingProcessApi->AddReceivingProcessTag");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}/tag/{receivingProcessTag}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            if (receivingProcessTag != null) localVarPathParams.Add("receivingProcessTag", Configuration.ApiClient.ParameterToString(receivingProcessTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a receivingProcess. Adds a tag to an existing receivingProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add a tag to</param>
        /// <param name="receivingProcessTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddReceivingProcessTagAsync (int? receivingProcessId, string receivingProcessTag)
        {
             await AddReceivingProcessTagAsyncWithHttpInfo(receivingProcessId, receivingProcessTag);

        }

        /// <summary>
        /// Add new tags for a receivingProcess. Adds a tag to an existing receivingProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to add a tag to</param>
        /// <param name="receivingProcessTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddReceivingProcessTagAsyncWithHttpInfo (int? receivingProcessId, string receivingProcessTag)
        {
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null) throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling AddReceivingProcessTag");
            // verify the required parameter 'receivingProcessTag' is set
            if (receivingProcessTag == null) throw new ApiException(400, "Missing required parameter 'receivingProcessTag' when calling AddReceivingProcessTag");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}/tag/{receivingProcessTag}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            if (receivingProcessTag != null) localVarPathParams.Add("receivingProcessTag", Configuration.ApiClient.ParameterToString(receivingProcessTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a receivingProcess Deletes the receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be deleted.</param> 
        /// <returns></returns>
        public void DeleteReceivingProcess (int? receivingProcessId)
        {
             DeleteReceivingProcessWithHttpInfo(receivingProcessId);
        }

        /// <summary>
        /// Delete a receivingProcess Deletes the receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteReceivingProcessWithHttpInfo (int? receivingProcessId)
        {
            
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null)
                throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling ReceivingProcessApi->DeleteReceivingProcess");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingProcess: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingProcess: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a receivingProcess Deletes the receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteReceivingProcessAsync (int? receivingProcessId)
        {
             await DeleteReceivingProcessAsyncWithHttpInfo(receivingProcessId);

        }

        /// <summary>
        /// Delete a receivingProcess Deletes the receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReceivingProcessAsyncWithHttpInfo (int? receivingProcessId)
        {
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null) throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling DeleteReceivingProcess");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingProcess: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingProcess: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a receivingProcess. Deletes an existing receivingProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to remove tag from</param> 
        /// <param name="receivingProcessTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteReceivingProcessTag (int? receivingProcessId, string receivingProcessTag)
        {
             DeleteReceivingProcessTagWithHttpInfo(receivingProcessId, receivingProcessTag);
        }

        /// <summary>
        /// Delete a tag for a receivingProcess. Deletes an existing receivingProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to remove tag from</param> 
        /// <param name="receivingProcessTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteReceivingProcessTagWithHttpInfo (int? receivingProcessId, string receivingProcessTag)
        {
            
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null)
                throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling ReceivingProcessApi->DeleteReceivingProcessTag");
            
            // verify the required parameter 'receivingProcessTag' is set
            if (receivingProcessTag == null)
                throw new ApiException(400, "Missing required parameter 'receivingProcessTag' when calling ReceivingProcessApi->DeleteReceivingProcessTag");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}/tag/{receivingProcessTag}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            if (receivingProcessTag != null) localVarPathParams.Add("receivingProcessTag", Configuration.ApiClient.ParameterToString(receivingProcessTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a receivingProcess. Deletes an existing receivingProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to remove tag from</param>
        /// <param name="receivingProcessTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteReceivingProcessTagAsync (int? receivingProcessId, string receivingProcessTag)
        {
             await DeleteReceivingProcessTagAsyncWithHttpInfo(receivingProcessId, receivingProcessTag);

        }

        /// <summary>
        /// Delete a tag for a receivingProcess. Deletes an existing receivingProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to remove tag from</param>
        /// <param name="receivingProcessTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReceivingProcessTagAsyncWithHttpInfo (int? receivingProcessId, string receivingProcessTag)
        {
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null) throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling DeleteReceivingProcessTag");
            // verify the required parameter 'receivingProcessTag' is set
            if (receivingProcessTag == null) throw new ApiException(400, "Missing required parameter 'receivingProcessTag' when calling DeleteReceivingProcessTag");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}/tag/{receivingProcessTag}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            if (receivingProcessTag != null) localVarPathParams.Add("receivingProcessTag", Configuration.ApiClient.ParameterToString(receivingProcessTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a receivingProcess by id Returns a duplicated receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be duplicated.</param> 
        /// <returns>ReceivingProcess</returns>
        public ReceivingProcess GetDuplicateReceivingProcessById (int? receivingProcessId)
        {
             ApiResponse<ReceivingProcess> localVarResponse = GetDuplicateReceivingProcessByIdWithHttpInfo(receivingProcessId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a receivingProcess by id Returns a duplicated receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be duplicated.</param> 
        /// <returns>ApiResponse of ReceivingProcess</returns>
        public ApiResponse< ReceivingProcess > GetDuplicateReceivingProcessByIdWithHttpInfo (int? receivingProcessId)
        {
            
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null)
                throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling ReceivingProcessApi->GetDuplicateReceivingProcessById");
            
    
            var localVarPath = "/beta/receivingProcess/duplicate/{receivingProcessId}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReceivingProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReceivingProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ReceivingProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivingProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivingProcess)));
            
        }

        
        /// <summary>
        /// Get a duplicated a receivingProcess by id Returns a duplicated receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be duplicated.</param>
        /// <returns>Task of ReceivingProcess</returns>
        public async System.Threading.Tasks.Task<ReceivingProcess> GetDuplicateReceivingProcessByIdAsync (int? receivingProcessId)
        {
             ApiResponse<ReceivingProcess> localVarResponse = await GetDuplicateReceivingProcessByIdAsyncWithHttpInfo(receivingProcessId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a receivingProcess by id Returns a duplicated receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be duplicated.</param>
        /// <returns>Task of ApiResponse (ReceivingProcess)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReceivingProcess>> GetDuplicateReceivingProcessByIdAsyncWithHttpInfo (int? receivingProcessId)
        {
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null) throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling GetDuplicateReceivingProcessById");
            
    
            var localVarPath = "/beta/receivingProcess/duplicate/{receivingProcessId}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReceivingProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReceivingProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReceivingProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivingProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivingProcess)));
            
        }
        
        /// <summary>
        /// Search receivingProcesses by filter Returns the list of receivingProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ReceivingProcess&gt;</returns>
        public List<ReceivingProcess> GetReceivingProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ReceivingProcess>> localVarResponse = GetReceivingProcessByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search receivingProcesses by filter Returns the list of receivingProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ReceivingProcess&gt;</returns>
        public ApiResponse< List<ReceivingProcess> > GetReceivingProcessByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/receivingProcess/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ReceivingProcess>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ReceivingProcess>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ReceivingProcess>)));
            
        }

        
        /// <summary>
        /// Search receivingProcesses by filter Returns the list of receivingProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ReceivingProcess&gt;</returns>
        public async System.Threading.Tasks.Task<List<ReceivingProcess>> GetReceivingProcessByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ReceivingProcess>> localVarResponse = await GetReceivingProcessByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search receivingProcesses by filter Returns the list of receivingProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ReceivingProcess&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ReceivingProcess>>> GetReceivingProcessByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/receivingProcess/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ReceivingProcess>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ReceivingProcess>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ReceivingProcess>)));
            
        }
        
        /// <summary>
        /// Get a receivingProcess by id Returns the receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be returned.</param> 
        /// <returns>ReceivingProcess</returns>
        public ReceivingProcess GetReceivingProcessById (int? receivingProcessId)
        {
             ApiResponse<ReceivingProcess> localVarResponse = GetReceivingProcessByIdWithHttpInfo(receivingProcessId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a receivingProcess by id Returns the receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be returned.</param> 
        /// <returns>ApiResponse of ReceivingProcess</returns>
        public ApiResponse< ReceivingProcess > GetReceivingProcessByIdWithHttpInfo (int? receivingProcessId)
        {
            
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null)
                throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling ReceivingProcessApi->GetReceivingProcessById");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ReceivingProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivingProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivingProcess)));
            
        }

        
        /// <summary>
        /// Get a receivingProcess by id Returns the receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be returned.</param>
        /// <returns>Task of ReceivingProcess</returns>
        public async System.Threading.Tasks.Task<ReceivingProcess> GetReceivingProcessByIdAsync (int? receivingProcessId)
        {
             ApiResponse<ReceivingProcess> localVarResponse = await GetReceivingProcessByIdAsyncWithHttpInfo(receivingProcessId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a receivingProcess by id Returns the receivingProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to be returned.</param>
        /// <returns>Task of ApiResponse (ReceivingProcess)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReceivingProcess>> GetReceivingProcessByIdAsyncWithHttpInfo (int? receivingProcessId)
        {
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null) throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling GetReceivingProcessById");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReceivingProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivingProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivingProcess)));
            
        }
        
        /// <summary>
        /// Get the tags for a receivingProcess. Get all existing receivingProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to get tags for</param> 
        /// <returns></returns>
        public void GetReceivingProcessTags (int? receivingProcessId)
        {
             GetReceivingProcessTagsWithHttpInfo(receivingProcessId);
        }

        /// <summary>
        /// Get the tags for a receivingProcess. Get all existing receivingProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetReceivingProcessTagsWithHttpInfo (int? receivingProcessId)
        {
            
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null)
                throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling ReceivingProcessApi->GetReceivingProcessTags");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}/tag";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a receivingProcess. Get all existing receivingProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetReceivingProcessTagsAsync (int? receivingProcessId)
        {
             await GetReceivingProcessTagsAsyncWithHttpInfo(receivingProcessId);

        }

        /// <summary>
        /// Get the tags for a receivingProcess. Get all existing receivingProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingProcessId">Id of the receivingProcess to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetReceivingProcessTagsAsyncWithHttpInfo (int? receivingProcessId)
        {
            // verify the required parameter 'receivingProcessId' is set
            if (receivingProcessId == null) throw new ApiException(400, "Missing required parameter 'receivingProcessId' when calling GetReceivingProcessTags");
            
    
            var localVarPath = "/beta/receivingProcess/{receivingProcessId}/tag";
    
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
            if (receivingProcessId != null) localVarPathParams.Add("receivingProcessId", Configuration.ApiClient.ParameterToString(receivingProcessId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingProcessTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a receivingProcess custom fields Updates an existing receivingProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingProcess to be updated.</param> 
        /// <returns></returns>
        public void UpdateReceivingProcessCustomFields (ReceivingProcess body)
        {
             UpdateReceivingProcessCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a receivingProcess custom fields Updates an existing receivingProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingProcess to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateReceivingProcessCustomFieldsWithHttpInfo (ReceivingProcess body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ReceivingProcessApi->UpdateReceivingProcessCustomFields");
            
    
            var localVarPath = "/beta/receivingProcess/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingProcessCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingProcessCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a receivingProcess custom fields Updates an existing receivingProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingProcess to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateReceivingProcessCustomFieldsAsync (ReceivingProcess body)
        {
             await UpdateReceivingProcessCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a receivingProcess custom fields Updates an existing receivingProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingProcess to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReceivingProcessCustomFieldsAsyncWithHttpInfo (ReceivingProcess body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateReceivingProcessCustomFields");
            
    
            var localVarPath = "/beta/receivingProcess/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingProcessCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingProcessCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
