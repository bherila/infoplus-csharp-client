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
    public interface IParcelAccountApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a parcelAccount
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add an audit to</param>
        /// <param name="parcelAccountAudit">The audit to add</param>
        /// <returns></returns>
        void AddParcelAccountAudit (int? parcelAccountId, string parcelAccountAudit);
  
        /// <summary>
        /// Add new audit for a parcelAccount
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add an audit to</param>
        /// <param name="parcelAccountAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddParcelAccountAuditWithHttpInfo (int? parcelAccountId, string parcelAccountAudit);
        
        /// <summary>
        /// Add new tags for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add a tag to</param>
        /// <param name="parcelAccountTag">The tag to add</param>
        /// <returns></returns>
        void AddParcelAccountTag (int? parcelAccountId, string parcelAccountTag);
  
        /// <summary>
        /// Add new tags for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add a tag to</param>
        /// <param name="parcelAccountTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddParcelAccountTagWithHttpInfo (int? parcelAccountId, string parcelAccountTag);
        
        /// <summary>
        /// Delete a tag for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelAccount tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to remove tag from</param>
        /// <param name="parcelAccountTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteParcelAccountTag (int? parcelAccountId, string parcelAccountTag);
  
        /// <summary>
        /// Delete a tag for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelAccount tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to remove tag from</param>
        /// <param name="parcelAccountTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteParcelAccountTagWithHttpInfo (int? parcelAccountId, string parcelAccountTag);
        
        /// <summary>
        /// Get a duplicated a parcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be duplicated.</param>
        /// <returns>ParcelAccount</returns>
        ParcelAccount GetDuplicateParcelAccountById (int? parcelAccountId);
  
        /// <summary>
        /// Get a duplicated a parcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be duplicated.</param>
        /// <returns>ApiResponse of ParcelAccount</returns>
        ApiResponse<ParcelAccount> GetDuplicateParcelAccountByIdWithHttpInfo (int? parcelAccountId);
        
        /// <summary>
        /// Search parcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ParcelAccount&gt;</returns>
        List<ParcelAccount> GetParcelAccountByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search parcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ParcelAccount&gt;</returns>
        ApiResponse<List<ParcelAccount>> GetParcelAccountByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a parcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be returned.</param>
        /// <returns>ParcelAccount</returns>
        ParcelAccount GetParcelAccountById (int? parcelAccountId);
  
        /// <summary>
        /// Get a parcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be returned.</param>
        /// <returns>ApiResponse of ParcelAccount</returns>
        ApiResponse<ParcelAccount> GetParcelAccountByIdWithHttpInfo (int? parcelAccountId);
        
        /// <summary>
        /// Get the tags for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelAccount tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to get tags for</param>
        /// <returns></returns>
        void GetParcelAccountTags (int? parcelAccountId);
  
        /// <summary>
        /// Get the tags for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelAccount tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetParcelAccountTagsWithHttpInfo (int? parcelAccountId);
        
        /// <summary>
        /// Update a parcelAccount custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing parcelAccount custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelAccount to be updated.</param>
        /// <returns></returns>
        void UpdateParcelAccountCustomFields (ParcelAccount body);
  
        /// <summary>
        /// Update a parcelAccount custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing parcelAccount custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelAccount to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateParcelAccountCustomFieldsWithHttpInfo (ParcelAccount body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a parcelAccount
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add an audit to</param>
        /// <param name="parcelAccountAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddParcelAccountAuditAsync (int? parcelAccountId, string parcelAccountAudit);

        /// <summary>
        /// Add new audit for a parcelAccount
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add an audit to</param>
        /// <param name="parcelAccountAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelAccountAuditAsyncWithHttpInfo (int? parcelAccountId, string parcelAccountAudit);
        
        /// <summary>
        /// Add new tags for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add a tag to</param>
        /// <param name="parcelAccountTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddParcelAccountTagAsync (int? parcelAccountId, string parcelAccountTag);

        /// <summary>
        /// Add new tags for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add a tag to</param>
        /// <param name="parcelAccountTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelAccountTagAsyncWithHttpInfo (int? parcelAccountId, string parcelAccountTag);
        
        /// <summary>
        /// Delete a tag for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelAccount tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to remove tag from</param>
        /// <param name="parcelAccountTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteParcelAccountTagAsync (int? parcelAccountId, string parcelAccountTag);

        /// <summary>
        /// Delete a tag for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelAccount tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to remove tag from</param>
        /// <param name="parcelAccountTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteParcelAccountTagAsyncWithHttpInfo (int? parcelAccountId, string parcelAccountTag);
        
        /// <summary>
        /// Get a duplicated a parcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be duplicated.</param>
        /// <returns>Task of ParcelAccount</returns>
        System.Threading.Tasks.Task<ParcelAccount> GetDuplicateParcelAccountByIdAsync (int? parcelAccountId);

        /// <summary>
        /// Get a duplicated a parcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be duplicated.</param>
        /// <returns>Task of ApiResponse (ParcelAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParcelAccount>> GetDuplicateParcelAccountByIdAsyncWithHttpInfo (int? parcelAccountId);
        
        /// <summary>
        /// Search parcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ParcelAccount&gt;</returns>
        System.Threading.Tasks.Task<List<ParcelAccount>> GetParcelAccountByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search parcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ParcelAccount&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ParcelAccount>>> GetParcelAccountByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a parcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be returned.</param>
        /// <returns>Task of ParcelAccount</returns>
        System.Threading.Tasks.Task<ParcelAccount> GetParcelAccountByIdAsync (int? parcelAccountId);

        /// <summary>
        /// Get a parcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be returned.</param>
        /// <returns>Task of ApiResponse (ParcelAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParcelAccount>> GetParcelAccountByIdAsyncWithHttpInfo (int? parcelAccountId);
        
        /// <summary>
        /// Get the tags for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelAccount tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetParcelAccountTagsAsync (int? parcelAccountId);

        /// <summary>
        /// Get the tags for a parcelAccount.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelAccount tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetParcelAccountTagsAsyncWithHttpInfo (int? parcelAccountId);
        
        /// <summary>
        /// Update a parcelAccount custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing parcelAccount custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelAccount to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateParcelAccountCustomFieldsAsync (ParcelAccount body);

        /// <summary>
        /// Update a parcelAccount custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing parcelAccount custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelAccount to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateParcelAccountCustomFieldsAsyncWithHttpInfo (ParcelAccount body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ParcelAccountApi : IParcelAccountApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelAccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ParcelAccountApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelAccountApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ParcelAccountApi(Configuration configuration = null)
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
        /// Add new audit for a parcelAccount Adds an audit to an existing parcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add an audit to</param> 
        /// <param name="parcelAccountAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddParcelAccountAudit (int? parcelAccountId, string parcelAccountAudit)
        {
             AddParcelAccountAuditWithHttpInfo(parcelAccountId, parcelAccountAudit);
        }

        /// <summary>
        /// Add new audit for a parcelAccount Adds an audit to an existing parcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add an audit to</param> 
        /// <param name="parcelAccountAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddParcelAccountAuditWithHttpInfo (int? parcelAccountId, string parcelAccountAudit)
        {
            
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling ParcelAccountApi->AddParcelAccountAudit");
            
            // verify the required parameter 'parcelAccountAudit' is set
            if (parcelAccountAudit == null)
                throw new ApiException(400, "Missing required parameter 'parcelAccountAudit' when calling ParcelAccountApi->AddParcelAccountAudit");
            
    
            var localVarPath = "/beta/parcelAccount/{parcelAccountId}/audit/{parcelAccountAudit}";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            if (parcelAccountAudit != null) localVarPathParams.Add("parcelAccountAudit", Configuration.ApiClient.ParameterToString(parcelAccountAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelAccountAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelAccountAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a parcelAccount Adds an audit to an existing parcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add an audit to</param>
        /// <param name="parcelAccountAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddParcelAccountAuditAsync (int? parcelAccountId, string parcelAccountAudit)
        {
             await AddParcelAccountAuditAsyncWithHttpInfo(parcelAccountId, parcelAccountAudit);

        }

        /// <summary>
        /// Add new audit for a parcelAccount Adds an audit to an existing parcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add an audit to</param>
        /// <param name="parcelAccountAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelAccountAuditAsyncWithHttpInfo (int? parcelAccountId, string parcelAccountAudit)
        {
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null) throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling AddParcelAccountAudit");
            // verify the required parameter 'parcelAccountAudit' is set
            if (parcelAccountAudit == null) throw new ApiException(400, "Missing required parameter 'parcelAccountAudit' when calling AddParcelAccountAudit");
            
    
            var localVarPath = "/beta/parcelAccount/{parcelAccountId}/audit/{parcelAccountAudit}";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            if (parcelAccountAudit != null) localVarPathParams.Add("parcelAccountAudit", Configuration.ApiClient.ParameterToString(parcelAccountAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelAccountAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelAccountAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a parcelAccount. Adds a tag to an existing parcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add a tag to</param> 
        /// <param name="parcelAccountTag">The tag to add</param> 
        /// <returns></returns>
        public void AddParcelAccountTag (int? parcelAccountId, string parcelAccountTag)
        {
             AddParcelAccountTagWithHttpInfo(parcelAccountId, parcelAccountTag);
        }

        /// <summary>
        /// Add new tags for a parcelAccount. Adds a tag to an existing parcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add a tag to</param> 
        /// <param name="parcelAccountTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddParcelAccountTagWithHttpInfo (int? parcelAccountId, string parcelAccountTag)
        {
            
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling ParcelAccountApi->AddParcelAccountTag");
            
            // verify the required parameter 'parcelAccountTag' is set
            if (parcelAccountTag == null)
                throw new ApiException(400, "Missing required parameter 'parcelAccountTag' when calling ParcelAccountApi->AddParcelAccountTag");
            
    
            var localVarPath = "/beta/parcelAccount/{parcelAccountId}/tag/{parcelAccountTag}";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            if (parcelAccountTag != null) localVarPathParams.Add("parcelAccountTag", Configuration.ApiClient.ParameterToString(parcelAccountTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelAccountTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelAccountTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a parcelAccount. Adds a tag to an existing parcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add a tag to</param>
        /// <param name="parcelAccountTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddParcelAccountTagAsync (int? parcelAccountId, string parcelAccountTag)
        {
             await AddParcelAccountTagAsyncWithHttpInfo(parcelAccountId, parcelAccountTag);

        }

        /// <summary>
        /// Add new tags for a parcelAccount. Adds a tag to an existing parcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to add a tag to</param>
        /// <param name="parcelAccountTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelAccountTagAsyncWithHttpInfo (int? parcelAccountId, string parcelAccountTag)
        {
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null) throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling AddParcelAccountTag");
            // verify the required parameter 'parcelAccountTag' is set
            if (parcelAccountTag == null) throw new ApiException(400, "Missing required parameter 'parcelAccountTag' when calling AddParcelAccountTag");
            
    
            var localVarPath = "/beta/parcelAccount/{parcelAccountId}/tag/{parcelAccountTag}";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            if (parcelAccountTag != null) localVarPathParams.Add("parcelAccountTag", Configuration.ApiClient.ParameterToString(parcelAccountTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelAccountTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelAccountTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a parcelAccount. Deletes an existing parcelAccount tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to remove tag from</param> 
        /// <param name="parcelAccountTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteParcelAccountTag (int? parcelAccountId, string parcelAccountTag)
        {
             DeleteParcelAccountTagWithHttpInfo(parcelAccountId, parcelAccountTag);
        }

        /// <summary>
        /// Delete a tag for a parcelAccount. Deletes an existing parcelAccount tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to remove tag from</param> 
        /// <param name="parcelAccountTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteParcelAccountTagWithHttpInfo (int? parcelAccountId, string parcelAccountTag)
        {
            
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling ParcelAccountApi->DeleteParcelAccountTag");
            
            // verify the required parameter 'parcelAccountTag' is set
            if (parcelAccountTag == null)
                throw new ApiException(400, "Missing required parameter 'parcelAccountTag' when calling ParcelAccountApi->DeleteParcelAccountTag");
            
    
            var localVarPath = "/beta/parcelAccount/{parcelAccountId}/tag/{parcelAccountTag}";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            if (parcelAccountTag != null) localVarPathParams.Add("parcelAccountTag", Configuration.ApiClient.ParameterToString(parcelAccountTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelAccountTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelAccountTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a parcelAccount. Deletes an existing parcelAccount tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to remove tag from</param>
        /// <param name="parcelAccountTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteParcelAccountTagAsync (int? parcelAccountId, string parcelAccountTag)
        {
             await DeleteParcelAccountTagAsyncWithHttpInfo(parcelAccountId, parcelAccountTag);

        }

        /// <summary>
        /// Delete a tag for a parcelAccount. Deletes an existing parcelAccount tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to remove tag from</param>
        /// <param name="parcelAccountTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteParcelAccountTagAsyncWithHttpInfo (int? parcelAccountId, string parcelAccountTag)
        {
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null) throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling DeleteParcelAccountTag");
            // verify the required parameter 'parcelAccountTag' is set
            if (parcelAccountTag == null) throw new ApiException(400, "Missing required parameter 'parcelAccountTag' when calling DeleteParcelAccountTag");
            
    
            var localVarPath = "/beta/parcelAccount/{parcelAccountId}/tag/{parcelAccountTag}";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            if (parcelAccountTag != null) localVarPathParams.Add("parcelAccountTag", Configuration.ApiClient.ParameterToString(parcelAccountTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelAccountTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelAccountTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a parcelAccount by id Returns a duplicated parcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be duplicated.</param> 
        /// <returns>ParcelAccount</returns>
        public ParcelAccount GetDuplicateParcelAccountById (int? parcelAccountId)
        {
             ApiResponse<ParcelAccount> localVarResponse = GetDuplicateParcelAccountByIdWithHttpInfo(parcelAccountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a parcelAccount by id Returns a duplicated parcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be duplicated.</param> 
        /// <returns>ApiResponse of ParcelAccount</returns>
        public ApiResponse< ParcelAccount > GetDuplicateParcelAccountByIdWithHttpInfo (int? parcelAccountId)
        {
            
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling ParcelAccountApi->GetDuplicateParcelAccountById");
            
    
            var localVarPath = "/beta/parcelAccount/duplicate/{parcelAccountId}";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelAccountById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelAccountById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelAccount)));
            
        }

        
        /// <summary>
        /// Get a duplicated a parcelAccount by id Returns a duplicated parcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be duplicated.</param>
        /// <returns>Task of ParcelAccount</returns>
        public async System.Threading.Tasks.Task<ParcelAccount> GetDuplicateParcelAccountByIdAsync (int? parcelAccountId)
        {
             ApiResponse<ParcelAccount> localVarResponse = await GetDuplicateParcelAccountByIdAsyncWithHttpInfo(parcelAccountId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a parcelAccount by id Returns a duplicated parcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be duplicated.</param>
        /// <returns>Task of ApiResponse (ParcelAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParcelAccount>> GetDuplicateParcelAccountByIdAsyncWithHttpInfo (int? parcelAccountId)
        {
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null) throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling GetDuplicateParcelAccountById");
            
    
            var localVarPath = "/beta/parcelAccount/duplicate/{parcelAccountId}";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelAccountById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelAccountById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelAccount)));
            
        }
        
        /// <summary>
        /// Search parcelAccounts by filter Returns the list of parcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ParcelAccount&gt;</returns>
        public List<ParcelAccount> GetParcelAccountByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ParcelAccount>> localVarResponse = GetParcelAccountByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search parcelAccounts by filter Returns the list of parcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ParcelAccount&gt;</returns>
        public ApiResponse< List<ParcelAccount> > GetParcelAccountByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/parcelAccount/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ParcelAccount>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ParcelAccount>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ParcelAccount>)));
            
        }

        
        /// <summary>
        /// Search parcelAccounts by filter Returns the list of parcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ParcelAccount&gt;</returns>
        public async System.Threading.Tasks.Task<List<ParcelAccount>> GetParcelAccountByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ParcelAccount>> localVarResponse = await GetParcelAccountByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search parcelAccounts by filter Returns the list of parcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ParcelAccount&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ParcelAccount>>> GetParcelAccountByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/parcelAccount/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ParcelAccount>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ParcelAccount>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ParcelAccount>)));
            
        }
        
        /// <summary>
        /// Get a parcelAccount by id Returns the parcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be returned.</param> 
        /// <returns>ParcelAccount</returns>
        public ParcelAccount GetParcelAccountById (int? parcelAccountId)
        {
             ApiResponse<ParcelAccount> localVarResponse = GetParcelAccountByIdWithHttpInfo(parcelAccountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a parcelAccount by id Returns the parcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be returned.</param> 
        /// <returns>ApiResponse of ParcelAccount</returns>
        public ApiResponse< ParcelAccount > GetParcelAccountByIdWithHttpInfo (int? parcelAccountId)
        {
            
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling ParcelAccountApi->GetParcelAccountById");
            
    
            var localVarPath = "/beta/parcelAccount/{parcelAccountId}";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelAccount)));
            
        }

        
        /// <summary>
        /// Get a parcelAccount by id Returns the parcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be returned.</param>
        /// <returns>Task of ParcelAccount</returns>
        public async System.Threading.Tasks.Task<ParcelAccount> GetParcelAccountByIdAsync (int? parcelAccountId)
        {
             ApiResponse<ParcelAccount> localVarResponse = await GetParcelAccountByIdAsyncWithHttpInfo(parcelAccountId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a parcelAccount by id Returns the parcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to be returned.</param>
        /// <returns>Task of ApiResponse (ParcelAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParcelAccount>> GetParcelAccountByIdAsyncWithHttpInfo (int? parcelAccountId)
        {
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null) throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling GetParcelAccountById");
            
    
            var localVarPath = "/beta/parcelAccount/{parcelAccountId}";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelAccount)));
            
        }
        
        /// <summary>
        /// Get the tags for a parcelAccount. Get all existing parcelAccount tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to get tags for</param> 
        /// <returns></returns>
        public void GetParcelAccountTags (int? parcelAccountId)
        {
             GetParcelAccountTagsWithHttpInfo(parcelAccountId);
        }

        /// <summary>
        /// Get the tags for a parcelAccount. Get all existing parcelAccount tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetParcelAccountTagsWithHttpInfo (int? parcelAccountId)
        {
            
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling ParcelAccountApi->GetParcelAccountTags");
            
    
            var localVarPath = "/beta/parcelAccount/{parcelAccountId}/tag";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a parcelAccount. Get all existing parcelAccount tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetParcelAccountTagsAsync (int? parcelAccountId)
        {
             await GetParcelAccountTagsAsyncWithHttpInfo(parcelAccountId);

        }

        /// <summary>
        /// Get the tags for a parcelAccount. Get all existing parcelAccount tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelAccountId">Id of the parcelAccount to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetParcelAccountTagsAsyncWithHttpInfo (int? parcelAccountId)
        {
            // verify the required parameter 'parcelAccountId' is set
            if (parcelAccountId == null) throw new ApiException(400, "Missing required parameter 'parcelAccountId' when calling GetParcelAccountTags");
            
    
            var localVarPath = "/beta/parcelAccount/{parcelAccountId}/tag";
    
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
            if (parcelAccountId != null) localVarPathParams.Add("parcelAccountId", Configuration.ApiClient.ParameterToString(parcelAccountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelAccountTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a parcelAccount custom fields Updates an existing parcelAccount custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelAccount to be updated.</param> 
        /// <returns></returns>
        public void UpdateParcelAccountCustomFields (ParcelAccount body)
        {
             UpdateParcelAccountCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a parcelAccount custom fields Updates an existing parcelAccount custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelAccount to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateParcelAccountCustomFieldsWithHttpInfo (ParcelAccount body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ParcelAccountApi->UpdateParcelAccountCustomFields");
            
    
            var localVarPath = "/beta/parcelAccount/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateParcelAccountCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateParcelAccountCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a parcelAccount custom fields Updates an existing parcelAccount custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelAccount to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateParcelAccountCustomFieldsAsync (ParcelAccount body)
        {
             await UpdateParcelAccountCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a parcelAccount custom fields Updates an existing parcelAccount custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelAccount to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateParcelAccountCustomFieldsAsyncWithHttpInfo (ParcelAccount body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateParcelAccountCustomFields");
            
    
            var localVarPath = "/beta/parcelAccount/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateParcelAccountCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateParcelAccountCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
