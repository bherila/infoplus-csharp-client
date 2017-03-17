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
    public interface IInventoryDetailApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for an inventoryDetail
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryDetail.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add an audit to</param>
        /// <param name="inventoryDetailAudit">The audit to add</param>
        /// <returns></returns>
        void AddInventoryDetailAudit (int? inventoryDetailId, string inventoryDetailAudit);
  
        /// <summary>
        /// Add new audit for an inventoryDetail
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryDetail.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add an audit to</param>
        /// <param name="inventoryDetailAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInventoryDetailAuditWithHttpInfo (int? inventoryDetailId, string inventoryDetailAudit);
        
        /// <summary>
        /// Add new tags for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryDetail.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add a tag to</param>
        /// <param name="inventoryDetailTag">The tag to add</param>
        /// <returns></returns>
        void AddInventoryDetailTag (int? inventoryDetailId, string inventoryDetailTag);
  
        /// <summary>
        /// Add new tags for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryDetail.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add a tag to</param>
        /// <param name="inventoryDetailTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInventoryDetailTagWithHttpInfo (int? inventoryDetailId, string inventoryDetailTag);
        
        /// <summary>
        /// Delete a tag for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryDetail tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to remove tag from</param>
        /// <param name="inventoryDetailTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteInventoryDetailTag (int? inventoryDetailId, string inventoryDetailTag);
  
        /// <summary>
        /// Delete a tag for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryDetail tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to remove tag from</param>
        /// <param name="inventoryDetailTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInventoryDetailTagWithHttpInfo (int? inventoryDetailId, string inventoryDetailTag);
        
        /// <summary>
        /// Get a duplicated an inventoryDetail by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryDetail identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be duplicated.</param>
        /// <returns>InventoryDetail</returns>
        InventoryDetail GetDuplicateInventoryDetailById (int? inventoryDetailId);
  
        /// <summary>
        /// Get a duplicated an inventoryDetail by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryDetail identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be duplicated.</param>
        /// <returns>ApiResponse of InventoryDetail</returns>
        ApiResponse<InventoryDetail> GetDuplicateInventoryDetailByIdWithHttpInfo (int? inventoryDetailId);
        
        /// <summary>
        /// Search inventoryDetails by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryDetails that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;InventoryDetail&gt;</returns>
        List<InventoryDetail> GetInventoryDetailByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search inventoryDetails by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryDetails that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;InventoryDetail&gt;</returns>
        ApiResponse<List<InventoryDetail>> GetInventoryDetailByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an inventoryDetail by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryDetail identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be returned.</param>
        /// <returns>InventoryDetail</returns>
        InventoryDetail GetInventoryDetailById (int? inventoryDetailId);
  
        /// <summary>
        /// Get an inventoryDetail by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryDetail identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be returned.</param>
        /// <returns>ApiResponse of InventoryDetail</returns>
        ApiResponse<InventoryDetail> GetInventoryDetailByIdWithHttpInfo (int? inventoryDetailId);
        
        /// <summary>
        /// Get the tags for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryDetail tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to get tags for</param>
        /// <returns></returns>
        void GetInventoryDetailTags (int? inventoryDetailId);
  
        /// <summary>
        /// Get the tags for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryDetail tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetInventoryDetailTagsWithHttpInfo (int? inventoryDetailId);
        
        /// <summary>
        /// Update an inventoryDetail custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryDetail custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryDetail to be updated.</param>
        /// <returns></returns>
        void UpdateInventoryDetailCustomFields (InventoryDetail body);
  
        /// <summary>
        /// Update an inventoryDetail custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryDetail custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryDetail to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateInventoryDetailCustomFieldsWithHttpInfo (InventoryDetail body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for an inventoryDetail
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryDetail.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add an audit to</param>
        /// <param name="inventoryDetailAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInventoryDetailAuditAsync (int? inventoryDetailId, string inventoryDetailAudit);

        /// <summary>
        /// Add new audit for an inventoryDetail
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryDetail.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add an audit to</param>
        /// <param name="inventoryDetailAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryDetailAuditAsyncWithHttpInfo (int? inventoryDetailId, string inventoryDetailAudit);
        
        /// <summary>
        /// Add new tags for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryDetail.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add a tag to</param>
        /// <param name="inventoryDetailTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInventoryDetailTagAsync (int? inventoryDetailId, string inventoryDetailTag);

        /// <summary>
        /// Add new tags for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryDetail.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add a tag to</param>
        /// <param name="inventoryDetailTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryDetailTagAsyncWithHttpInfo (int? inventoryDetailId, string inventoryDetailTag);
        
        /// <summary>
        /// Delete a tag for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryDetail tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to remove tag from</param>
        /// <param name="inventoryDetailTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInventoryDetailTagAsync (int? inventoryDetailId, string inventoryDetailTag);

        /// <summary>
        /// Delete a tag for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryDetail tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to remove tag from</param>
        /// <param name="inventoryDetailTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInventoryDetailTagAsyncWithHttpInfo (int? inventoryDetailId, string inventoryDetailTag);
        
        /// <summary>
        /// Get a duplicated an inventoryDetail by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryDetail identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be duplicated.</param>
        /// <returns>Task of InventoryDetail</returns>
        System.Threading.Tasks.Task<InventoryDetail> GetDuplicateInventoryDetailByIdAsync (int? inventoryDetailId);

        /// <summary>
        /// Get a duplicated an inventoryDetail by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryDetail identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be duplicated.</param>
        /// <returns>Task of ApiResponse (InventoryDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<InventoryDetail>> GetDuplicateInventoryDetailByIdAsyncWithHttpInfo (int? inventoryDetailId);
        
        /// <summary>
        /// Search inventoryDetails by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryDetails that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InventoryDetail&gt;</returns>
        System.Threading.Tasks.Task<List<InventoryDetail>> GetInventoryDetailByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search inventoryDetails by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryDetails that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InventoryDetail&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InventoryDetail>>> GetInventoryDetailByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an inventoryDetail by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryDetail identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be returned.</param>
        /// <returns>Task of InventoryDetail</returns>
        System.Threading.Tasks.Task<InventoryDetail> GetInventoryDetailByIdAsync (int? inventoryDetailId);

        /// <summary>
        /// Get an inventoryDetail by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryDetail identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be returned.</param>
        /// <returns>Task of ApiResponse (InventoryDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<InventoryDetail>> GetInventoryDetailByIdAsyncWithHttpInfo (int? inventoryDetailId);
        
        /// <summary>
        /// Get the tags for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryDetail tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetInventoryDetailTagsAsync (int? inventoryDetailId);

        /// <summary>
        /// Get the tags for an inventoryDetail.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryDetail tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetInventoryDetailTagsAsyncWithHttpInfo (int? inventoryDetailId);
        
        /// <summary>
        /// Update an inventoryDetail custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryDetail custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryDetail to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateInventoryDetailCustomFieldsAsync (InventoryDetail body);

        /// <summary>
        /// Update an inventoryDetail custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryDetail custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryDetail to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateInventoryDetailCustomFieldsAsyncWithHttpInfo (InventoryDetail body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InventoryDetailApi : IInventoryDetailApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryDetailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InventoryDetailApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryDetailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InventoryDetailApi(Configuration configuration = null)
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
        /// Add new audit for an inventoryDetail Adds an audit to an existing inventoryDetail.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add an audit to</param> 
        /// <param name="inventoryDetailAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddInventoryDetailAudit (int? inventoryDetailId, string inventoryDetailAudit)
        {
             AddInventoryDetailAuditWithHttpInfo(inventoryDetailId, inventoryDetailAudit);
        }

        /// <summary>
        /// Add new audit for an inventoryDetail Adds an audit to an existing inventoryDetail.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add an audit to</param> 
        /// <param name="inventoryDetailAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInventoryDetailAuditWithHttpInfo (int? inventoryDetailId, string inventoryDetailAudit)
        {
            
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling InventoryDetailApi->AddInventoryDetailAudit");
            
            // verify the required parameter 'inventoryDetailAudit' is set
            if (inventoryDetailAudit == null)
                throw new ApiException(400, "Missing required parameter 'inventoryDetailAudit' when calling InventoryDetailApi->AddInventoryDetailAudit");
            
    
            var localVarPath = "/beta/inventoryDetail/{inventoryDetailId}/audit/{inventoryDetailAudit}";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            if (inventoryDetailAudit != null) localVarPathParams.Add("inventoryDetailAudit", Configuration.ApiClient.ParameterToString(inventoryDetailAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryDetailAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryDetailAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an inventoryDetail Adds an audit to an existing inventoryDetail.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add an audit to</param>
        /// <param name="inventoryDetailAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInventoryDetailAuditAsync (int? inventoryDetailId, string inventoryDetailAudit)
        {
             await AddInventoryDetailAuditAsyncWithHttpInfo(inventoryDetailId, inventoryDetailAudit);

        }

        /// <summary>
        /// Add new audit for an inventoryDetail Adds an audit to an existing inventoryDetail.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add an audit to</param>
        /// <param name="inventoryDetailAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryDetailAuditAsyncWithHttpInfo (int? inventoryDetailId, string inventoryDetailAudit)
        {
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null) throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling AddInventoryDetailAudit");
            // verify the required parameter 'inventoryDetailAudit' is set
            if (inventoryDetailAudit == null) throw new ApiException(400, "Missing required parameter 'inventoryDetailAudit' when calling AddInventoryDetailAudit");
            
    
            var localVarPath = "/beta/inventoryDetail/{inventoryDetailId}/audit/{inventoryDetailAudit}";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            if (inventoryDetailAudit != null) localVarPathParams.Add("inventoryDetailAudit", Configuration.ApiClient.ParameterToString(inventoryDetailAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryDetailAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryDetailAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an inventoryDetail. Adds a tag to an existing inventoryDetail.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add a tag to</param> 
        /// <param name="inventoryDetailTag">The tag to add</param> 
        /// <returns></returns>
        public void AddInventoryDetailTag (int? inventoryDetailId, string inventoryDetailTag)
        {
             AddInventoryDetailTagWithHttpInfo(inventoryDetailId, inventoryDetailTag);
        }

        /// <summary>
        /// Add new tags for an inventoryDetail. Adds a tag to an existing inventoryDetail.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add a tag to</param> 
        /// <param name="inventoryDetailTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInventoryDetailTagWithHttpInfo (int? inventoryDetailId, string inventoryDetailTag)
        {
            
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling InventoryDetailApi->AddInventoryDetailTag");
            
            // verify the required parameter 'inventoryDetailTag' is set
            if (inventoryDetailTag == null)
                throw new ApiException(400, "Missing required parameter 'inventoryDetailTag' when calling InventoryDetailApi->AddInventoryDetailTag");
            
    
            var localVarPath = "/beta/inventoryDetail/{inventoryDetailId}/tag/{inventoryDetailTag}";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            if (inventoryDetailTag != null) localVarPathParams.Add("inventoryDetailTag", Configuration.ApiClient.ParameterToString(inventoryDetailTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryDetailTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryDetailTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an inventoryDetail. Adds a tag to an existing inventoryDetail.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add a tag to</param>
        /// <param name="inventoryDetailTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInventoryDetailTagAsync (int? inventoryDetailId, string inventoryDetailTag)
        {
             await AddInventoryDetailTagAsyncWithHttpInfo(inventoryDetailId, inventoryDetailTag);

        }

        /// <summary>
        /// Add new tags for an inventoryDetail. Adds a tag to an existing inventoryDetail.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to add a tag to</param>
        /// <param name="inventoryDetailTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryDetailTagAsyncWithHttpInfo (int? inventoryDetailId, string inventoryDetailTag)
        {
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null) throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling AddInventoryDetailTag");
            // verify the required parameter 'inventoryDetailTag' is set
            if (inventoryDetailTag == null) throw new ApiException(400, "Missing required parameter 'inventoryDetailTag' when calling AddInventoryDetailTag");
            
    
            var localVarPath = "/beta/inventoryDetail/{inventoryDetailId}/tag/{inventoryDetailTag}";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            if (inventoryDetailTag != null) localVarPathParams.Add("inventoryDetailTag", Configuration.ApiClient.ParameterToString(inventoryDetailTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryDetailTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryDetailTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an inventoryDetail. Deletes an existing inventoryDetail tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to remove tag from</param> 
        /// <param name="inventoryDetailTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteInventoryDetailTag (int? inventoryDetailId, string inventoryDetailTag)
        {
             DeleteInventoryDetailTagWithHttpInfo(inventoryDetailId, inventoryDetailTag);
        }

        /// <summary>
        /// Delete a tag for an inventoryDetail. Deletes an existing inventoryDetail tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to remove tag from</param> 
        /// <param name="inventoryDetailTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInventoryDetailTagWithHttpInfo (int? inventoryDetailId, string inventoryDetailTag)
        {
            
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling InventoryDetailApi->DeleteInventoryDetailTag");
            
            // verify the required parameter 'inventoryDetailTag' is set
            if (inventoryDetailTag == null)
                throw new ApiException(400, "Missing required parameter 'inventoryDetailTag' when calling InventoryDetailApi->DeleteInventoryDetailTag");
            
    
            var localVarPath = "/beta/inventoryDetail/{inventoryDetailId}/tag/{inventoryDetailTag}";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            if (inventoryDetailTag != null) localVarPathParams.Add("inventoryDetailTag", Configuration.ApiClient.ParameterToString(inventoryDetailTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryDetailTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryDetailTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an inventoryDetail. Deletes an existing inventoryDetail tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to remove tag from</param>
        /// <param name="inventoryDetailTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInventoryDetailTagAsync (int? inventoryDetailId, string inventoryDetailTag)
        {
             await DeleteInventoryDetailTagAsyncWithHttpInfo(inventoryDetailId, inventoryDetailTag);

        }

        /// <summary>
        /// Delete a tag for an inventoryDetail. Deletes an existing inventoryDetail tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to remove tag from</param>
        /// <param name="inventoryDetailTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInventoryDetailTagAsyncWithHttpInfo (int? inventoryDetailId, string inventoryDetailTag)
        {
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null) throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling DeleteInventoryDetailTag");
            // verify the required parameter 'inventoryDetailTag' is set
            if (inventoryDetailTag == null) throw new ApiException(400, "Missing required parameter 'inventoryDetailTag' when calling DeleteInventoryDetailTag");
            
    
            var localVarPath = "/beta/inventoryDetail/{inventoryDetailId}/tag/{inventoryDetailTag}";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            if (inventoryDetailTag != null) localVarPathParams.Add("inventoryDetailTag", Configuration.ApiClient.ParameterToString(inventoryDetailTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryDetailTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryDetailTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an inventoryDetail by id Returns a duplicated inventoryDetail identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be duplicated.</param> 
        /// <returns>InventoryDetail</returns>
        public InventoryDetail GetDuplicateInventoryDetailById (int? inventoryDetailId)
        {
             ApiResponse<InventoryDetail> localVarResponse = GetDuplicateInventoryDetailByIdWithHttpInfo(inventoryDetailId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an inventoryDetail by id Returns a duplicated inventoryDetail identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be duplicated.</param> 
        /// <returns>ApiResponse of InventoryDetail</returns>
        public ApiResponse< InventoryDetail > GetDuplicateInventoryDetailByIdWithHttpInfo (int? inventoryDetailId)
        {
            
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling InventoryDetailApi->GetDuplicateInventoryDetailById");
            
    
            var localVarPath = "/beta/inventoryDetail/duplicate/{inventoryDetailId}";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryDetailById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryDetailById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InventoryDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryDetail)));
            
        }

        
        /// <summary>
        /// Get a duplicated an inventoryDetail by id Returns a duplicated inventoryDetail identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be duplicated.</param>
        /// <returns>Task of InventoryDetail</returns>
        public async System.Threading.Tasks.Task<InventoryDetail> GetDuplicateInventoryDetailByIdAsync (int? inventoryDetailId)
        {
             ApiResponse<InventoryDetail> localVarResponse = await GetDuplicateInventoryDetailByIdAsyncWithHttpInfo(inventoryDetailId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an inventoryDetail by id Returns a duplicated inventoryDetail identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be duplicated.</param>
        /// <returns>Task of ApiResponse (InventoryDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InventoryDetail>> GetDuplicateInventoryDetailByIdAsyncWithHttpInfo (int? inventoryDetailId)
        {
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null) throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling GetDuplicateInventoryDetailById");
            
    
            var localVarPath = "/beta/inventoryDetail/duplicate/{inventoryDetailId}";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryDetailById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryDetailById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InventoryDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryDetail)));
            
        }
        
        /// <summary>
        /// Search inventoryDetails by filter Returns the list of inventoryDetails that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;InventoryDetail&gt;</returns>
        public List<InventoryDetail> GetInventoryDetailByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InventoryDetail>> localVarResponse = GetInventoryDetailByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search inventoryDetails by filter Returns the list of inventoryDetails that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;InventoryDetail&gt;</returns>
        public ApiResponse< List<InventoryDetail> > GetInventoryDetailByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/inventoryDetail/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<InventoryDetail>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventoryDetail>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InventoryDetail>)));
            
        }

        
        /// <summary>
        /// Search inventoryDetails by filter Returns the list of inventoryDetails that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InventoryDetail&gt;</returns>
        public async System.Threading.Tasks.Task<List<InventoryDetail>> GetInventoryDetailByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InventoryDetail>> localVarResponse = await GetInventoryDetailByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search inventoryDetails by filter Returns the list of inventoryDetails that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InventoryDetail&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InventoryDetail>>> GetInventoryDetailByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/inventoryDetail/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InventoryDetail>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventoryDetail>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InventoryDetail>)));
            
        }
        
        /// <summary>
        /// Get an inventoryDetail by id Returns the inventoryDetail identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be returned.</param> 
        /// <returns>InventoryDetail</returns>
        public InventoryDetail GetInventoryDetailById (int? inventoryDetailId)
        {
             ApiResponse<InventoryDetail> localVarResponse = GetInventoryDetailByIdWithHttpInfo(inventoryDetailId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an inventoryDetail by id Returns the inventoryDetail identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be returned.</param> 
        /// <returns>ApiResponse of InventoryDetail</returns>
        public ApiResponse< InventoryDetail > GetInventoryDetailByIdWithHttpInfo (int? inventoryDetailId)
        {
            
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling InventoryDetailApi->GetInventoryDetailById");
            
    
            var localVarPath = "/beta/inventoryDetail/{inventoryDetailId}";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InventoryDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryDetail)));
            
        }

        
        /// <summary>
        /// Get an inventoryDetail by id Returns the inventoryDetail identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be returned.</param>
        /// <returns>Task of InventoryDetail</returns>
        public async System.Threading.Tasks.Task<InventoryDetail> GetInventoryDetailByIdAsync (int? inventoryDetailId)
        {
             ApiResponse<InventoryDetail> localVarResponse = await GetInventoryDetailByIdAsyncWithHttpInfo(inventoryDetailId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an inventoryDetail by id Returns the inventoryDetail identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to be returned.</param>
        /// <returns>Task of ApiResponse (InventoryDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InventoryDetail>> GetInventoryDetailByIdAsyncWithHttpInfo (int? inventoryDetailId)
        {
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null) throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling GetInventoryDetailById");
            
    
            var localVarPath = "/beta/inventoryDetail/{inventoryDetailId}";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InventoryDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryDetail)));
            
        }
        
        /// <summary>
        /// Get the tags for an inventoryDetail. Get all existing inventoryDetail tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to get tags for</param> 
        /// <returns></returns>
        public void GetInventoryDetailTags (int? inventoryDetailId)
        {
             GetInventoryDetailTagsWithHttpInfo(inventoryDetailId);
        }

        /// <summary>
        /// Get the tags for an inventoryDetail. Get all existing inventoryDetail tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetInventoryDetailTagsWithHttpInfo (int? inventoryDetailId)
        {
            
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling InventoryDetailApi->GetInventoryDetailTags");
            
    
            var localVarPath = "/beta/inventoryDetail/{inventoryDetailId}/tag";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an inventoryDetail. Get all existing inventoryDetail tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetInventoryDetailTagsAsync (int? inventoryDetailId)
        {
             await GetInventoryDetailTagsAsyncWithHttpInfo(inventoryDetailId);

        }

        /// <summary>
        /// Get the tags for an inventoryDetail. Get all existing inventoryDetail tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryDetailId">Id of the inventoryDetail to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetInventoryDetailTagsAsyncWithHttpInfo (int? inventoryDetailId)
        {
            // verify the required parameter 'inventoryDetailId' is set
            if (inventoryDetailId == null) throw new ApiException(400, "Missing required parameter 'inventoryDetailId' when calling GetInventoryDetailTags");
            
    
            var localVarPath = "/beta/inventoryDetail/{inventoryDetailId}/tag";
    
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
            if (inventoryDetailId != null) localVarPathParams.Add("inventoryDetailId", Configuration.ApiClient.ParameterToString(inventoryDetailId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryDetailTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an inventoryDetail custom fields Updates an existing inventoryDetail custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryDetail to be updated.</param> 
        /// <returns></returns>
        public void UpdateInventoryDetailCustomFields (InventoryDetail body)
        {
             UpdateInventoryDetailCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update an inventoryDetail custom fields Updates an existing inventoryDetail custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryDetail to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateInventoryDetailCustomFieldsWithHttpInfo (InventoryDetail body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling InventoryDetailApi->UpdateInventoryDetailCustomFields");
            
    
            var localVarPath = "/beta/inventoryDetail/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryDetailCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryDetailCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an inventoryDetail custom fields Updates an existing inventoryDetail custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryDetail to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateInventoryDetailCustomFieldsAsync (InventoryDetail body)
        {
             await UpdateInventoryDetailCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an inventoryDetail custom fields Updates an existing inventoryDetail custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryDetail to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateInventoryDetailCustomFieldsAsyncWithHttpInfo (InventoryDetail body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateInventoryDetailCustomFields");
            
    
            var localVarPath = "/beta/inventoryDetail/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryDetailCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryDetailCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}