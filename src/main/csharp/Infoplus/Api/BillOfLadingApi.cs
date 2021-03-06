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
    public interface IBillOfLadingApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a billOfLading
        /// </summary>
        /// <remarks>
        /// Inserts a new billOfLading using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be inserted.</param>
        /// <returns>BillOfLading</returns>
        BillOfLading AddBillOfLading (BillOfLading body);
  
        /// <summary>
        /// Create a billOfLading
        /// </summary>
        /// <remarks>
        /// Inserts a new billOfLading using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be inserted.</param>
        /// <returns>ApiResponse of BillOfLading</returns>
        ApiResponse<BillOfLading> AddBillOfLadingWithHttpInfo (BillOfLading body);
        
        /// <summary>
        /// Add new audit for a billOfLading
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billOfLading.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add an audit to</param>
        /// <param name="billOfLadingAudit">The audit to add</param>
        /// <returns></returns>
        void AddBillOfLadingAudit (int? billOfLadingId, string billOfLadingAudit);
  
        /// <summary>
        /// Add new audit for a billOfLading
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billOfLading.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add an audit to</param>
        /// <param name="billOfLadingAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddBillOfLadingAuditWithHttpInfo (int? billOfLadingId, string billOfLadingAudit);
        
        /// <summary>
        /// Add new tags for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billOfLading.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add a tag to</param>
        /// <param name="billOfLadingTag">The tag to add</param>
        /// <returns></returns>
        void AddBillOfLadingTag (int? billOfLadingId, string billOfLadingTag);
  
        /// <summary>
        /// Add new tags for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billOfLading.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add a tag to</param>
        /// <param name="billOfLadingTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddBillOfLadingTagWithHttpInfo (int? billOfLadingId, string billOfLadingTag);
        
        /// <summary>
        /// Delete a billOfLading
        /// </summary>
        /// <remarks>
        /// Deletes the billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be deleted.</param>
        /// <returns></returns>
        void DeleteBillOfLading (int? billOfLadingId);
  
        /// <summary>
        /// Delete a billOfLading
        /// </summary>
        /// <remarks>
        /// Deletes the billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBillOfLadingWithHttpInfo (int? billOfLadingId);
        
        /// <summary>
        /// Delete a tag for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billOfLading tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to remove tag from</param>
        /// <param name="billOfLadingTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteBillOfLadingTag (int? billOfLadingId, string billOfLadingTag);
  
        /// <summary>
        /// Delete a tag for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billOfLading tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to remove tag from</param>
        /// <param name="billOfLadingTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBillOfLadingTagWithHttpInfo (int? billOfLadingId, string billOfLadingTag);
        
        /// <summary>
        /// Search billOfLadings by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billOfLadings that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;BillOfLading&gt;</returns>
        List<BillOfLading> GetBillOfLadingByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search billOfLadings by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billOfLadings that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;BillOfLading&gt;</returns>
        ApiResponse<List<BillOfLading>> GetBillOfLadingByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a billOfLading by id
        /// </summary>
        /// <remarks>
        /// Returns the billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be returned.</param>
        /// <returns>BillOfLading</returns>
        BillOfLading GetBillOfLadingById (int? billOfLadingId);
  
        /// <summary>
        /// Get a billOfLading by id
        /// </summary>
        /// <remarks>
        /// Returns the billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be returned.</param>
        /// <returns>ApiResponse of BillOfLading</returns>
        ApiResponse<BillOfLading> GetBillOfLadingByIdWithHttpInfo (int? billOfLadingId);
        
        /// <summary>
        /// Get the tags for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Get all existing billOfLading tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to get tags for</param>
        /// <returns></returns>
        void GetBillOfLadingTags (int? billOfLadingId);
  
        /// <summary>
        /// Get the tags for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Get all existing billOfLading tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetBillOfLadingTagsWithHttpInfo (int? billOfLadingId);
        
        /// <summary>
        /// Get a duplicated a billOfLading by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be duplicated.</param>
        /// <returns>BillOfLading</returns>
        BillOfLading GetDuplicateBillOfLadingById (int? billOfLadingId);
  
        /// <summary>
        /// Get a duplicated a billOfLading by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be duplicated.</param>
        /// <returns>ApiResponse of BillOfLading</returns>
        ApiResponse<BillOfLading> GetDuplicateBillOfLadingByIdWithHttpInfo (int? billOfLadingId);
        
        /// <summary>
        /// Update a billOfLading
        /// </summary>
        /// <remarks>
        /// Updates an existing billOfLading using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns></returns>
        void UpdateBillOfLading (BillOfLading body);
  
        /// <summary>
        /// Update a billOfLading
        /// </summary>
        /// <remarks>
        /// Updates an existing billOfLading using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateBillOfLadingWithHttpInfo (BillOfLading body);
        
        /// <summary>
        /// Update a billOfLading custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing billOfLading custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns></returns>
        void UpdateBillOfLadingCustomFields (BillOfLading body);
  
        /// <summary>
        /// Update a billOfLading custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing billOfLading custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateBillOfLadingCustomFieldsWithHttpInfo (BillOfLading body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a billOfLading
        /// </summary>
        /// <remarks>
        /// Inserts a new billOfLading using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be inserted.</param>
        /// <returns>Task of BillOfLading</returns>
        System.Threading.Tasks.Task<BillOfLading> AddBillOfLadingAsync (BillOfLading body);

        /// <summary>
        /// Create a billOfLading
        /// </summary>
        /// <remarks>
        /// Inserts a new billOfLading using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be inserted.</param>
        /// <returns>Task of ApiResponse (BillOfLading)</returns>
        System.Threading.Tasks.Task<ApiResponse<BillOfLading>> AddBillOfLadingAsyncWithHttpInfo (BillOfLading body);
        
        /// <summary>
        /// Add new audit for a billOfLading
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billOfLading.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add an audit to</param>
        /// <param name="billOfLadingAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddBillOfLadingAuditAsync (int? billOfLadingId, string billOfLadingAudit);

        /// <summary>
        /// Add new audit for a billOfLading
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billOfLading.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add an audit to</param>
        /// <param name="billOfLadingAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddBillOfLadingAuditAsyncWithHttpInfo (int? billOfLadingId, string billOfLadingAudit);
        
        /// <summary>
        /// Add new tags for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billOfLading.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add a tag to</param>
        /// <param name="billOfLadingTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddBillOfLadingTagAsync (int? billOfLadingId, string billOfLadingTag);

        /// <summary>
        /// Add new tags for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billOfLading.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add a tag to</param>
        /// <param name="billOfLadingTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddBillOfLadingTagAsyncWithHttpInfo (int? billOfLadingId, string billOfLadingTag);
        
        /// <summary>
        /// Delete a billOfLading
        /// </summary>
        /// <remarks>
        /// Deletes the billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBillOfLadingAsync (int? billOfLadingId);

        /// <summary>
        /// Delete a billOfLading
        /// </summary>
        /// <remarks>
        /// Deletes the billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillOfLadingAsyncWithHttpInfo (int? billOfLadingId);
        
        /// <summary>
        /// Delete a tag for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billOfLading tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to remove tag from</param>
        /// <param name="billOfLadingTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBillOfLadingTagAsync (int? billOfLadingId, string billOfLadingTag);

        /// <summary>
        /// Delete a tag for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billOfLading tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to remove tag from</param>
        /// <param name="billOfLadingTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillOfLadingTagAsyncWithHttpInfo (int? billOfLadingId, string billOfLadingTag);
        
        /// <summary>
        /// Search billOfLadings by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billOfLadings that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;BillOfLading&gt;</returns>
        System.Threading.Tasks.Task<List<BillOfLading>> GetBillOfLadingByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search billOfLadings by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billOfLadings that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BillOfLading&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BillOfLading>>> GetBillOfLadingByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a billOfLading by id
        /// </summary>
        /// <remarks>
        /// Returns the billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be returned.</param>
        /// <returns>Task of BillOfLading</returns>
        System.Threading.Tasks.Task<BillOfLading> GetBillOfLadingByIdAsync (int? billOfLadingId);

        /// <summary>
        /// Get a billOfLading by id
        /// </summary>
        /// <remarks>
        /// Returns the billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be returned.</param>
        /// <returns>Task of ApiResponse (BillOfLading)</returns>
        System.Threading.Tasks.Task<ApiResponse<BillOfLading>> GetBillOfLadingByIdAsyncWithHttpInfo (int? billOfLadingId);
        
        /// <summary>
        /// Get the tags for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Get all existing billOfLading tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetBillOfLadingTagsAsync (int? billOfLadingId);

        /// <summary>
        /// Get the tags for a billOfLading.
        /// </summary>
        /// <remarks>
        /// Get all existing billOfLading tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetBillOfLadingTagsAsyncWithHttpInfo (int? billOfLadingId);
        
        /// <summary>
        /// Get a duplicated a billOfLading by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be duplicated.</param>
        /// <returns>Task of BillOfLading</returns>
        System.Threading.Tasks.Task<BillOfLading> GetDuplicateBillOfLadingByIdAsync (int? billOfLadingId);

        /// <summary>
        /// Get a duplicated a billOfLading by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billOfLading identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be duplicated.</param>
        /// <returns>Task of ApiResponse (BillOfLading)</returns>
        System.Threading.Tasks.Task<ApiResponse<BillOfLading>> GetDuplicateBillOfLadingByIdAsyncWithHttpInfo (int? billOfLadingId);
        
        /// <summary>
        /// Update a billOfLading
        /// </summary>
        /// <remarks>
        /// Updates an existing billOfLading using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateBillOfLadingAsync (BillOfLading body);

        /// <summary>
        /// Update a billOfLading
        /// </summary>
        /// <remarks>
        /// Updates an existing billOfLading using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBillOfLadingAsyncWithHttpInfo (BillOfLading body);
        
        /// <summary>
        /// Update a billOfLading custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing billOfLading custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateBillOfLadingCustomFieldsAsync (BillOfLading body);

        /// <summary>
        /// Update a billOfLading custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing billOfLading custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBillOfLadingCustomFieldsAsyncWithHttpInfo (BillOfLading body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BillOfLadingApi : IBillOfLadingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillOfLadingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BillOfLadingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillOfLadingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BillOfLadingApi(Configuration configuration = null)
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
        /// Create a billOfLading Inserts a new billOfLading using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be inserted.</param> 
        /// <returns>BillOfLading</returns>
        public BillOfLading AddBillOfLading (BillOfLading body)
        {
             ApiResponse<BillOfLading> localVarResponse = AddBillOfLadingWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a billOfLading Inserts a new billOfLading using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be inserted.</param> 
        /// <returns>ApiResponse of BillOfLading</returns>
        public ApiResponse< BillOfLading > AddBillOfLadingWithHttpInfo (BillOfLading body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BillOfLadingApi->AddBillOfLading");
            
    
            var localVarPath = "/beta/billOfLading";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLading: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLading: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BillOfLading>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillOfLading) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillOfLading)));
            
        }

        
        /// <summary>
        /// Create a billOfLading Inserts a new billOfLading using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be inserted.</param>
        /// <returns>Task of BillOfLading</returns>
        public async System.Threading.Tasks.Task<BillOfLading> AddBillOfLadingAsync (BillOfLading body)
        {
             ApiResponse<BillOfLading> localVarResponse = await AddBillOfLadingAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a billOfLading Inserts a new billOfLading using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be inserted.</param>
        /// <returns>Task of ApiResponse (BillOfLading)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BillOfLading>> AddBillOfLadingAsyncWithHttpInfo (BillOfLading body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddBillOfLading");
            
    
            var localVarPath = "/beta/billOfLading";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLading: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLading: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillOfLading>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillOfLading) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillOfLading)));
            
        }
        
        /// <summary>
        /// Add new audit for a billOfLading Adds an audit to an existing billOfLading.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add an audit to</param> 
        /// <param name="billOfLadingAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddBillOfLadingAudit (int? billOfLadingId, string billOfLadingAudit)
        {
             AddBillOfLadingAuditWithHttpInfo(billOfLadingId, billOfLadingAudit);
        }

        /// <summary>
        /// Add new audit for a billOfLading Adds an audit to an existing billOfLading.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add an audit to</param> 
        /// <param name="billOfLadingAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddBillOfLadingAuditWithHttpInfo (int? billOfLadingId, string billOfLadingAudit)
        {
            
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null)
                throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling BillOfLadingApi->AddBillOfLadingAudit");
            
            // verify the required parameter 'billOfLadingAudit' is set
            if (billOfLadingAudit == null)
                throw new ApiException(400, "Missing required parameter 'billOfLadingAudit' when calling BillOfLadingApi->AddBillOfLadingAudit");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}/audit/{billOfLadingAudit}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            if (billOfLadingAudit != null) localVarPathParams.Add("billOfLadingAudit", Configuration.ApiClient.ParameterToString(billOfLadingAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLadingAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLadingAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a billOfLading Adds an audit to an existing billOfLading.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add an audit to</param>
        /// <param name="billOfLadingAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddBillOfLadingAuditAsync (int? billOfLadingId, string billOfLadingAudit)
        {
             await AddBillOfLadingAuditAsyncWithHttpInfo(billOfLadingId, billOfLadingAudit);

        }

        /// <summary>
        /// Add new audit for a billOfLading Adds an audit to an existing billOfLading.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add an audit to</param>
        /// <param name="billOfLadingAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddBillOfLadingAuditAsyncWithHttpInfo (int? billOfLadingId, string billOfLadingAudit)
        {
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null) throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling AddBillOfLadingAudit");
            // verify the required parameter 'billOfLadingAudit' is set
            if (billOfLadingAudit == null) throw new ApiException(400, "Missing required parameter 'billOfLadingAudit' when calling AddBillOfLadingAudit");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}/audit/{billOfLadingAudit}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            if (billOfLadingAudit != null) localVarPathParams.Add("billOfLadingAudit", Configuration.ApiClient.ParameterToString(billOfLadingAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLadingAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLadingAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a billOfLading. Adds a tag to an existing billOfLading.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add a tag to</param> 
        /// <param name="billOfLadingTag">The tag to add</param> 
        /// <returns></returns>
        public void AddBillOfLadingTag (int? billOfLadingId, string billOfLadingTag)
        {
             AddBillOfLadingTagWithHttpInfo(billOfLadingId, billOfLadingTag);
        }

        /// <summary>
        /// Add new tags for a billOfLading. Adds a tag to an existing billOfLading.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add a tag to</param> 
        /// <param name="billOfLadingTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddBillOfLadingTagWithHttpInfo (int? billOfLadingId, string billOfLadingTag)
        {
            
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null)
                throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling BillOfLadingApi->AddBillOfLadingTag");
            
            // verify the required parameter 'billOfLadingTag' is set
            if (billOfLadingTag == null)
                throw new ApiException(400, "Missing required parameter 'billOfLadingTag' when calling BillOfLadingApi->AddBillOfLadingTag");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}/tag/{billOfLadingTag}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            if (billOfLadingTag != null) localVarPathParams.Add("billOfLadingTag", Configuration.ApiClient.ParameterToString(billOfLadingTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLadingTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLadingTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a billOfLading. Adds a tag to an existing billOfLading.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add a tag to</param>
        /// <param name="billOfLadingTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddBillOfLadingTagAsync (int? billOfLadingId, string billOfLadingTag)
        {
             await AddBillOfLadingTagAsyncWithHttpInfo(billOfLadingId, billOfLadingTag);

        }

        /// <summary>
        /// Add new tags for a billOfLading. Adds a tag to an existing billOfLading.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to add a tag to</param>
        /// <param name="billOfLadingTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddBillOfLadingTagAsyncWithHttpInfo (int? billOfLadingId, string billOfLadingTag)
        {
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null) throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling AddBillOfLadingTag");
            // verify the required parameter 'billOfLadingTag' is set
            if (billOfLadingTag == null) throw new ApiException(400, "Missing required parameter 'billOfLadingTag' when calling AddBillOfLadingTag");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}/tag/{billOfLadingTag}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            if (billOfLadingTag != null) localVarPathParams.Add("billOfLadingTag", Configuration.ApiClient.ParameterToString(billOfLadingTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLadingTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillOfLadingTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a billOfLading Deletes the billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be deleted.</param> 
        /// <returns></returns>
        public void DeleteBillOfLading (int? billOfLadingId)
        {
             DeleteBillOfLadingWithHttpInfo(billOfLadingId);
        }

        /// <summary>
        /// Delete a billOfLading Deletes the billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBillOfLadingWithHttpInfo (int? billOfLadingId)
        {
            
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null)
                throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling BillOfLadingApi->DeleteBillOfLading");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillOfLading: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillOfLading: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a billOfLading Deletes the billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBillOfLadingAsync (int? billOfLadingId)
        {
             await DeleteBillOfLadingAsyncWithHttpInfo(billOfLadingId);

        }

        /// <summary>
        /// Delete a billOfLading Deletes the billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillOfLadingAsyncWithHttpInfo (int? billOfLadingId)
        {
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null) throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling DeleteBillOfLading");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillOfLading: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillOfLading: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a billOfLading. Deletes an existing billOfLading tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to remove tag from</param> 
        /// <param name="billOfLadingTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteBillOfLadingTag (int? billOfLadingId, string billOfLadingTag)
        {
             DeleteBillOfLadingTagWithHttpInfo(billOfLadingId, billOfLadingTag);
        }

        /// <summary>
        /// Delete a tag for a billOfLading. Deletes an existing billOfLading tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to remove tag from</param> 
        /// <param name="billOfLadingTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBillOfLadingTagWithHttpInfo (int? billOfLadingId, string billOfLadingTag)
        {
            
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null)
                throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling BillOfLadingApi->DeleteBillOfLadingTag");
            
            // verify the required parameter 'billOfLadingTag' is set
            if (billOfLadingTag == null)
                throw new ApiException(400, "Missing required parameter 'billOfLadingTag' when calling BillOfLadingApi->DeleteBillOfLadingTag");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}/tag/{billOfLadingTag}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            if (billOfLadingTag != null) localVarPathParams.Add("billOfLadingTag", Configuration.ApiClient.ParameterToString(billOfLadingTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillOfLadingTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillOfLadingTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a billOfLading. Deletes an existing billOfLading tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to remove tag from</param>
        /// <param name="billOfLadingTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBillOfLadingTagAsync (int? billOfLadingId, string billOfLadingTag)
        {
             await DeleteBillOfLadingTagAsyncWithHttpInfo(billOfLadingId, billOfLadingTag);

        }

        /// <summary>
        /// Delete a tag for a billOfLading. Deletes an existing billOfLading tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to remove tag from</param>
        /// <param name="billOfLadingTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillOfLadingTagAsyncWithHttpInfo (int? billOfLadingId, string billOfLadingTag)
        {
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null) throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling DeleteBillOfLadingTag");
            // verify the required parameter 'billOfLadingTag' is set
            if (billOfLadingTag == null) throw new ApiException(400, "Missing required parameter 'billOfLadingTag' when calling DeleteBillOfLadingTag");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}/tag/{billOfLadingTag}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            if (billOfLadingTag != null) localVarPathParams.Add("billOfLadingTag", Configuration.ApiClient.ParameterToString(billOfLadingTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillOfLadingTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillOfLadingTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search billOfLadings by filter Returns the list of billOfLadings that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;BillOfLading&gt;</returns>
        public List<BillOfLading> GetBillOfLadingByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<BillOfLading>> localVarResponse = GetBillOfLadingByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search billOfLadings by filter Returns the list of billOfLadings that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;BillOfLading&gt;</returns>
        public ApiResponse< List<BillOfLading> > GetBillOfLadingByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/billOfLading/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<BillOfLading>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BillOfLading>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BillOfLading>)));
            
        }

        
        /// <summary>
        /// Search billOfLadings by filter Returns the list of billOfLadings that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;BillOfLading&gt;</returns>
        public async System.Threading.Tasks.Task<List<BillOfLading>> GetBillOfLadingByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<BillOfLading>> localVarResponse = await GetBillOfLadingByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search billOfLadings by filter Returns the list of billOfLadings that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BillOfLading&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BillOfLading>>> GetBillOfLadingByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/billOfLading/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<BillOfLading>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BillOfLading>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BillOfLading>)));
            
        }
        
        /// <summary>
        /// Get a billOfLading by id Returns the billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be returned.</param> 
        /// <returns>BillOfLading</returns>
        public BillOfLading GetBillOfLadingById (int? billOfLadingId)
        {
             ApiResponse<BillOfLading> localVarResponse = GetBillOfLadingByIdWithHttpInfo(billOfLadingId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a billOfLading by id Returns the billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be returned.</param> 
        /// <returns>ApiResponse of BillOfLading</returns>
        public ApiResponse< BillOfLading > GetBillOfLadingByIdWithHttpInfo (int? billOfLadingId)
        {
            
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null)
                throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling BillOfLadingApi->GetBillOfLadingById");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BillOfLading>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillOfLading) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillOfLading)));
            
        }

        
        /// <summary>
        /// Get a billOfLading by id Returns the billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be returned.</param>
        /// <returns>Task of BillOfLading</returns>
        public async System.Threading.Tasks.Task<BillOfLading> GetBillOfLadingByIdAsync (int? billOfLadingId)
        {
             ApiResponse<BillOfLading> localVarResponse = await GetBillOfLadingByIdAsyncWithHttpInfo(billOfLadingId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a billOfLading by id Returns the billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be returned.</param>
        /// <returns>Task of ApiResponse (BillOfLading)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BillOfLading>> GetBillOfLadingByIdAsyncWithHttpInfo (int? billOfLadingId)
        {
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null) throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling GetBillOfLadingById");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillOfLading>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillOfLading) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillOfLading)));
            
        }
        
        /// <summary>
        /// Get the tags for a billOfLading. Get all existing billOfLading tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to get tags for</param> 
        /// <returns></returns>
        public void GetBillOfLadingTags (int? billOfLadingId)
        {
             GetBillOfLadingTagsWithHttpInfo(billOfLadingId);
        }

        /// <summary>
        /// Get the tags for a billOfLading. Get all existing billOfLading tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetBillOfLadingTagsWithHttpInfo (int? billOfLadingId)
        {
            
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null)
                throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling BillOfLadingApi->GetBillOfLadingTags");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}/tag";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a billOfLading. Get all existing billOfLading tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetBillOfLadingTagsAsync (int? billOfLadingId)
        {
             await GetBillOfLadingTagsAsyncWithHttpInfo(billOfLadingId);

        }

        /// <summary>
        /// Get the tags for a billOfLading. Get all existing billOfLading tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetBillOfLadingTagsAsyncWithHttpInfo (int? billOfLadingId)
        {
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null) throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling GetBillOfLadingTags");
            
    
            var localVarPath = "/beta/billOfLading/{billOfLadingId}/tag";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillOfLadingTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a billOfLading by id Returns a duplicated billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be duplicated.</param> 
        /// <returns>BillOfLading</returns>
        public BillOfLading GetDuplicateBillOfLadingById (int? billOfLadingId)
        {
             ApiResponse<BillOfLading> localVarResponse = GetDuplicateBillOfLadingByIdWithHttpInfo(billOfLadingId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a billOfLading by id Returns a duplicated billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be duplicated.</param> 
        /// <returns>ApiResponse of BillOfLading</returns>
        public ApiResponse< BillOfLading > GetDuplicateBillOfLadingByIdWithHttpInfo (int? billOfLadingId)
        {
            
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null)
                throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling BillOfLadingApi->GetDuplicateBillOfLadingById");
            
    
            var localVarPath = "/beta/billOfLading/duplicate/{billOfLadingId}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillOfLadingById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillOfLadingById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BillOfLading>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillOfLading) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillOfLading)));
            
        }

        
        /// <summary>
        /// Get a duplicated a billOfLading by id Returns a duplicated billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be duplicated.</param>
        /// <returns>Task of BillOfLading</returns>
        public async System.Threading.Tasks.Task<BillOfLading> GetDuplicateBillOfLadingByIdAsync (int? billOfLadingId)
        {
             ApiResponse<BillOfLading> localVarResponse = await GetDuplicateBillOfLadingByIdAsyncWithHttpInfo(billOfLadingId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a billOfLading by id Returns a duplicated billOfLading identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billOfLadingId">Id of the billOfLading to be duplicated.</param>
        /// <returns>Task of ApiResponse (BillOfLading)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BillOfLading>> GetDuplicateBillOfLadingByIdAsyncWithHttpInfo (int? billOfLadingId)
        {
            // verify the required parameter 'billOfLadingId' is set
            if (billOfLadingId == null) throw new ApiException(400, "Missing required parameter 'billOfLadingId' when calling GetDuplicateBillOfLadingById");
            
    
            var localVarPath = "/beta/billOfLading/duplicate/{billOfLadingId}";
    
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
            if (billOfLadingId != null) localVarPathParams.Add("billOfLadingId", Configuration.ApiClient.ParameterToString(billOfLadingId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillOfLadingById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillOfLadingById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillOfLading>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillOfLading) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillOfLading)));
            
        }
        
        /// <summary>
        /// Update a billOfLading Updates an existing billOfLading using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param> 
        /// <returns></returns>
        public void UpdateBillOfLading (BillOfLading body)
        {
             UpdateBillOfLadingWithHttpInfo(body);
        }

        /// <summary>
        /// Update a billOfLading Updates an existing billOfLading using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateBillOfLadingWithHttpInfo (BillOfLading body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BillOfLadingApi->UpdateBillOfLading");
            
    
            var localVarPath = "/beta/billOfLading";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillOfLading: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillOfLading: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a billOfLading Updates an existing billOfLading using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateBillOfLadingAsync (BillOfLading body)
        {
             await UpdateBillOfLadingAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a billOfLading Updates an existing billOfLading using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBillOfLadingAsyncWithHttpInfo (BillOfLading body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBillOfLading");
            
    
            var localVarPath = "/beta/billOfLading";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillOfLading: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillOfLading: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a billOfLading custom fields Updates an existing billOfLading custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param> 
        /// <returns></returns>
        public void UpdateBillOfLadingCustomFields (BillOfLading body)
        {
             UpdateBillOfLadingCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a billOfLading custom fields Updates an existing billOfLading custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateBillOfLadingCustomFieldsWithHttpInfo (BillOfLading body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BillOfLadingApi->UpdateBillOfLadingCustomFields");
            
    
            var localVarPath = "/beta/billOfLading/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillOfLadingCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillOfLadingCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a billOfLading custom fields Updates an existing billOfLading custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateBillOfLadingCustomFieldsAsync (BillOfLading body)
        {
             await UpdateBillOfLadingCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a billOfLading custom fields Updates an existing billOfLading custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillOfLading to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBillOfLadingCustomFieldsAsyncWithHttpInfo (BillOfLading body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBillOfLadingCustomFields");
            
    
            var localVarPath = "/beta/billOfLading/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillOfLadingCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillOfLadingCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
