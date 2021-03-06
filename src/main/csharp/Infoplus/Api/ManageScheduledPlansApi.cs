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
    public interface IManageScheduledPlansApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Inserts a new manageScheduledPlans using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be inserted.</param>
        /// <returns>ManageScheduledPlans</returns>
        ManageScheduledPlans AddManageScheduledPlans (ManageScheduledPlans body);
  
        /// <summary>
        /// Create a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Inserts a new manageScheduledPlans using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be inserted.</param>
        /// <returns>ApiResponse of ManageScheduledPlans</returns>
        ApiResponse<ManageScheduledPlans> AddManageScheduledPlansWithHttpInfo (ManageScheduledPlans body);
        
        /// <summary>
        /// Add new audit for a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing manageScheduledPlans.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add an audit to</param>
        /// <param name="manageScheduledPlansAudit">The audit to add</param>
        /// <returns></returns>
        void AddManageScheduledPlansAudit (int? manageScheduledPlansId, string manageScheduledPlansAudit);
  
        /// <summary>
        /// Add new audit for a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing manageScheduledPlans.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add an audit to</param>
        /// <param name="manageScheduledPlansAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddManageScheduledPlansAuditWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansAudit);
        
        /// <summary>
        /// Add new tags for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing manageScheduledPlans.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add a tag to</param>
        /// <param name="manageScheduledPlansTag">The tag to add</param>
        /// <returns></returns>
        void AddManageScheduledPlansTag (int? manageScheduledPlansId, string manageScheduledPlansTag);
  
        /// <summary>
        /// Add new tags for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing manageScheduledPlans.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add a tag to</param>
        /// <param name="manageScheduledPlansTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddManageScheduledPlansTagWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansTag);
        
        /// <summary>
        /// Delete a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Deletes the manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be deleted.</param>
        /// <returns></returns>
        void DeleteManageScheduledPlans (int? manageScheduledPlansId);
  
        /// <summary>
        /// Delete a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Deletes the manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteManageScheduledPlansWithHttpInfo (int? manageScheduledPlansId);
        
        /// <summary>
        /// Delete a tag for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Deletes an existing manageScheduledPlans tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to remove tag from</param>
        /// <param name="manageScheduledPlansTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteManageScheduledPlansTag (int? manageScheduledPlansId, string manageScheduledPlansTag);
  
        /// <summary>
        /// Delete a tag for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Deletes an existing manageScheduledPlans tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to remove tag from</param>
        /// <param name="manageScheduledPlansTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteManageScheduledPlansTagWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansTag);
        
        /// <summary>
        /// Get a duplicated a manageScheduledPlans by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be duplicated.</param>
        /// <returns>ManageScheduledPlans</returns>
        ManageScheduledPlans GetDuplicateManageScheduledPlansById (int? manageScheduledPlansId);
  
        /// <summary>
        /// Get a duplicated a manageScheduledPlans by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be duplicated.</param>
        /// <returns>ApiResponse of ManageScheduledPlans</returns>
        ApiResponse<ManageScheduledPlans> GetDuplicateManageScheduledPlansByIdWithHttpInfo (int? manageScheduledPlansId);
        
        /// <summary>
        /// Search manageScheduledPlanses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of manageScheduledPlanses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ManageScheduledPlans&gt;</returns>
        List<ManageScheduledPlans> GetManageScheduledPlansByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search manageScheduledPlanses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of manageScheduledPlanses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ManageScheduledPlans&gt;</returns>
        ApiResponse<List<ManageScheduledPlans>> GetManageScheduledPlansByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a manageScheduledPlans by id
        /// </summary>
        /// <remarks>
        /// Returns the manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be returned.</param>
        /// <returns>ManageScheduledPlans</returns>
        ManageScheduledPlans GetManageScheduledPlansById (int? manageScheduledPlansId);
  
        /// <summary>
        /// Get a manageScheduledPlans by id
        /// </summary>
        /// <remarks>
        /// Returns the manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be returned.</param>
        /// <returns>ApiResponse of ManageScheduledPlans</returns>
        ApiResponse<ManageScheduledPlans> GetManageScheduledPlansByIdWithHttpInfo (int? manageScheduledPlansId);
        
        /// <summary>
        /// Get the tags for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Get all existing manageScheduledPlans tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to get tags for</param>
        /// <returns></returns>
        void GetManageScheduledPlansTags (int? manageScheduledPlansId);
  
        /// <summary>
        /// Get the tags for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Get all existing manageScheduledPlans tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetManageScheduledPlansTagsWithHttpInfo (int? manageScheduledPlansId);
        
        /// <summary>
        /// Update a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Updates an existing manageScheduledPlans using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be updated.</param>
        /// <returns></returns>
        void UpdateManageScheduledPlans (ManageScheduledPlans body);
  
        /// <summary>
        /// Update a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Updates an existing manageScheduledPlans using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateManageScheduledPlansWithHttpInfo (ManageScheduledPlans body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Inserts a new manageScheduledPlans using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be inserted.</param>
        /// <returns>Task of ManageScheduledPlans</returns>
        System.Threading.Tasks.Task<ManageScheduledPlans> AddManageScheduledPlansAsync (ManageScheduledPlans body);

        /// <summary>
        /// Create a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Inserts a new manageScheduledPlans using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be inserted.</param>
        /// <returns>Task of ApiResponse (ManageScheduledPlans)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManageScheduledPlans>> AddManageScheduledPlansAsyncWithHttpInfo (ManageScheduledPlans body);
        
        /// <summary>
        /// Add new audit for a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing manageScheduledPlans.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add an audit to</param>
        /// <param name="manageScheduledPlansAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddManageScheduledPlansAuditAsync (int? manageScheduledPlansId, string manageScheduledPlansAudit);

        /// <summary>
        /// Add new audit for a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing manageScheduledPlans.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add an audit to</param>
        /// <param name="manageScheduledPlansAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddManageScheduledPlansAuditAsyncWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansAudit);
        
        /// <summary>
        /// Add new tags for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing manageScheduledPlans.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add a tag to</param>
        /// <param name="manageScheduledPlansTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddManageScheduledPlansTagAsync (int? manageScheduledPlansId, string manageScheduledPlansTag);

        /// <summary>
        /// Add new tags for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing manageScheduledPlans.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add a tag to</param>
        /// <param name="manageScheduledPlansTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddManageScheduledPlansTagAsyncWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansTag);
        
        /// <summary>
        /// Delete a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Deletes the manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteManageScheduledPlansAsync (int? manageScheduledPlansId);

        /// <summary>
        /// Delete a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Deletes the manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteManageScheduledPlansAsyncWithHttpInfo (int? manageScheduledPlansId);
        
        /// <summary>
        /// Delete a tag for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Deletes an existing manageScheduledPlans tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to remove tag from</param>
        /// <param name="manageScheduledPlansTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteManageScheduledPlansTagAsync (int? manageScheduledPlansId, string manageScheduledPlansTag);

        /// <summary>
        /// Delete a tag for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Deletes an existing manageScheduledPlans tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to remove tag from</param>
        /// <param name="manageScheduledPlansTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteManageScheduledPlansTagAsyncWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansTag);
        
        /// <summary>
        /// Get a duplicated a manageScheduledPlans by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be duplicated.</param>
        /// <returns>Task of ManageScheduledPlans</returns>
        System.Threading.Tasks.Task<ManageScheduledPlans> GetDuplicateManageScheduledPlansByIdAsync (int? manageScheduledPlansId);

        /// <summary>
        /// Get a duplicated a manageScheduledPlans by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be duplicated.</param>
        /// <returns>Task of ApiResponse (ManageScheduledPlans)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManageScheduledPlans>> GetDuplicateManageScheduledPlansByIdAsyncWithHttpInfo (int? manageScheduledPlansId);
        
        /// <summary>
        /// Search manageScheduledPlanses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of manageScheduledPlanses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ManageScheduledPlans&gt;</returns>
        System.Threading.Tasks.Task<List<ManageScheduledPlans>> GetManageScheduledPlansByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search manageScheduledPlanses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of manageScheduledPlanses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ManageScheduledPlans&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ManageScheduledPlans>>> GetManageScheduledPlansByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a manageScheduledPlans by id
        /// </summary>
        /// <remarks>
        /// Returns the manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be returned.</param>
        /// <returns>Task of ManageScheduledPlans</returns>
        System.Threading.Tasks.Task<ManageScheduledPlans> GetManageScheduledPlansByIdAsync (int? manageScheduledPlansId);

        /// <summary>
        /// Get a manageScheduledPlans by id
        /// </summary>
        /// <remarks>
        /// Returns the manageScheduledPlans identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be returned.</param>
        /// <returns>Task of ApiResponse (ManageScheduledPlans)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManageScheduledPlans>> GetManageScheduledPlansByIdAsyncWithHttpInfo (int? manageScheduledPlansId);
        
        /// <summary>
        /// Get the tags for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Get all existing manageScheduledPlans tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetManageScheduledPlansTagsAsync (int? manageScheduledPlansId);

        /// <summary>
        /// Get the tags for a manageScheduledPlans.
        /// </summary>
        /// <remarks>
        /// Get all existing manageScheduledPlans tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetManageScheduledPlansTagsAsyncWithHttpInfo (int? manageScheduledPlansId);
        
        /// <summary>
        /// Update a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Updates an existing manageScheduledPlans using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateManageScheduledPlansAsync (ManageScheduledPlans body);

        /// <summary>
        /// Update a manageScheduledPlans
        /// </summary>
        /// <remarks>
        /// Updates an existing manageScheduledPlans using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateManageScheduledPlansAsyncWithHttpInfo (ManageScheduledPlans body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ManageScheduledPlansApi : IManageScheduledPlansApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageScheduledPlansApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ManageScheduledPlansApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageScheduledPlansApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ManageScheduledPlansApi(Configuration configuration = null)
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
        /// Create a manageScheduledPlans Inserts a new manageScheduledPlans using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be inserted.</param> 
        /// <returns>ManageScheduledPlans</returns>
        public ManageScheduledPlans AddManageScheduledPlans (ManageScheduledPlans body)
        {
             ApiResponse<ManageScheduledPlans> localVarResponse = AddManageScheduledPlansWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a manageScheduledPlans Inserts a new manageScheduledPlans using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be inserted.</param> 
        /// <returns>ApiResponse of ManageScheduledPlans</returns>
        public ApiResponse< ManageScheduledPlans > AddManageScheduledPlansWithHttpInfo (ManageScheduledPlans body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ManageScheduledPlansApi->AddManageScheduledPlans");
            
    
            var localVarPath = "/beta/manageScheduledPlans";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ManageScheduledPlans>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManageScheduledPlans) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManageScheduledPlans)));
            
        }

        
        /// <summary>
        /// Create a manageScheduledPlans Inserts a new manageScheduledPlans using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be inserted.</param>
        /// <returns>Task of ManageScheduledPlans</returns>
        public async System.Threading.Tasks.Task<ManageScheduledPlans> AddManageScheduledPlansAsync (ManageScheduledPlans body)
        {
             ApiResponse<ManageScheduledPlans> localVarResponse = await AddManageScheduledPlansAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a manageScheduledPlans Inserts a new manageScheduledPlans using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be inserted.</param>
        /// <returns>Task of ApiResponse (ManageScheduledPlans)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManageScheduledPlans>> AddManageScheduledPlansAsyncWithHttpInfo (ManageScheduledPlans body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddManageScheduledPlans");
            
    
            var localVarPath = "/beta/manageScheduledPlans";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManageScheduledPlans>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManageScheduledPlans) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManageScheduledPlans)));
            
        }
        
        /// <summary>
        /// Add new audit for a manageScheduledPlans Adds an audit to an existing manageScheduledPlans.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add an audit to</param> 
        /// <param name="manageScheduledPlansAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddManageScheduledPlansAudit (int? manageScheduledPlansId, string manageScheduledPlansAudit)
        {
             AddManageScheduledPlansAuditWithHttpInfo(manageScheduledPlansId, manageScheduledPlansAudit);
        }

        /// <summary>
        /// Add new audit for a manageScheduledPlans Adds an audit to an existing manageScheduledPlans.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add an audit to</param> 
        /// <param name="manageScheduledPlansAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddManageScheduledPlansAuditWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansAudit)
        {
            
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null)
                throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling ManageScheduledPlansApi->AddManageScheduledPlansAudit");
            
            // verify the required parameter 'manageScheduledPlansAudit' is set
            if (manageScheduledPlansAudit == null)
                throw new ApiException(400, "Missing required parameter 'manageScheduledPlansAudit' when calling ManageScheduledPlansApi->AddManageScheduledPlansAudit");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}/audit/{manageScheduledPlansAudit}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            if (manageScheduledPlansAudit != null) localVarPathParams.Add("manageScheduledPlansAudit", Configuration.ApiClient.ParameterToString(manageScheduledPlansAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlansAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlansAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a manageScheduledPlans Adds an audit to an existing manageScheduledPlans.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add an audit to</param>
        /// <param name="manageScheduledPlansAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddManageScheduledPlansAuditAsync (int? manageScheduledPlansId, string manageScheduledPlansAudit)
        {
             await AddManageScheduledPlansAuditAsyncWithHttpInfo(manageScheduledPlansId, manageScheduledPlansAudit);

        }

        /// <summary>
        /// Add new audit for a manageScheduledPlans Adds an audit to an existing manageScheduledPlans.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add an audit to</param>
        /// <param name="manageScheduledPlansAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddManageScheduledPlansAuditAsyncWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansAudit)
        {
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null) throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling AddManageScheduledPlansAudit");
            // verify the required parameter 'manageScheduledPlansAudit' is set
            if (manageScheduledPlansAudit == null) throw new ApiException(400, "Missing required parameter 'manageScheduledPlansAudit' when calling AddManageScheduledPlansAudit");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}/audit/{manageScheduledPlansAudit}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            if (manageScheduledPlansAudit != null) localVarPathParams.Add("manageScheduledPlansAudit", Configuration.ApiClient.ParameterToString(manageScheduledPlansAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlansAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlansAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a manageScheduledPlans. Adds a tag to an existing manageScheduledPlans.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add a tag to</param> 
        /// <param name="manageScheduledPlansTag">The tag to add</param> 
        /// <returns></returns>
        public void AddManageScheduledPlansTag (int? manageScheduledPlansId, string manageScheduledPlansTag)
        {
             AddManageScheduledPlansTagWithHttpInfo(manageScheduledPlansId, manageScheduledPlansTag);
        }

        /// <summary>
        /// Add new tags for a manageScheduledPlans. Adds a tag to an existing manageScheduledPlans.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add a tag to</param> 
        /// <param name="manageScheduledPlansTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddManageScheduledPlansTagWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansTag)
        {
            
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null)
                throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling ManageScheduledPlansApi->AddManageScheduledPlansTag");
            
            // verify the required parameter 'manageScheduledPlansTag' is set
            if (manageScheduledPlansTag == null)
                throw new ApiException(400, "Missing required parameter 'manageScheduledPlansTag' when calling ManageScheduledPlansApi->AddManageScheduledPlansTag");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}/tag/{manageScheduledPlansTag}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            if (manageScheduledPlansTag != null) localVarPathParams.Add("manageScheduledPlansTag", Configuration.ApiClient.ParameterToString(manageScheduledPlansTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlansTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlansTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a manageScheduledPlans. Adds a tag to an existing manageScheduledPlans.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add a tag to</param>
        /// <param name="manageScheduledPlansTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddManageScheduledPlansTagAsync (int? manageScheduledPlansId, string manageScheduledPlansTag)
        {
             await AddManageScheduledPlansTagAsyncWithHttpInfo(manageScheduledPlansId, manageScheduledPlansTag);

        }

        /// <summary>
        /// Add new tags for a manageScheduledPlans. Adds a tag to an existing manageScheduledPlans.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to add a tag to</param>
        /// <param name="manageScheduledPlansTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddManageScheduledPlansTagAsyncWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansTag)
        {
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null) throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling AddManageScheduledPlansTag");
            // verify the required parameter 'manageScheduledPlansTag' is set
            if (manageScheduledPlansTag == null) throw new ApiException(400, "Missing required parameter 'manageScheduledPlansTag' when calling AddManageScheduledPlansTag");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}/tag/{manageScheduledPlansTag}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            if (manageScheduledPlansTag != null) localVarPathParams.Add("manageScheduledPlansTag", Configuration.ApiClient.ParameterToString(manageScheduledPlansTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlansTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddManageScheduledPlansTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a manageScheduledPlans Deletes the manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be deleted.</param> 
        /// <returns></returns>
        public void DeleteManageScheduledPlans (int? manageScheduledPlansId)
        {
             DeleteManageScheduledPlansWithHttpInfo(manageScheduledPlansId);
        }

        /// <summary>
        /// Delete a manageScheduledPlans Deletes the manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteManageScheduledPlansWithHttpInfo (int? manageScheduledPlansId)
        {
            
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null)
                throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling ManageScheduledPlansApi->DeleteManageScheduledPlans");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteManageScheduledPlans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteManageScheduledPlans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a manageScheduledPlans Deletes the manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteManageScheduledPlansAsync (int? manageScheduledPlansId)
        {
             await DeleteManageScheduledPlansAsyncWithHttpInfo(manageScheduledPlansId);

        }

        /// <summary>
        /// Delete a manageScheduledPlans Deletes the manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteManageScheduledPlansAsyncWithHttpInfo (int? manageScheduledPlansId)
        {
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null) throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling DeleteManageScheduledPlans");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteManageScheduledPlans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteManageScheduledPlans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a manageScheduledPlans. Deletes an existing manageScheduledPlans tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to remove tag from</param> 
        /// <param name="manageScheduledPlansTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteManageScheduledPlansTag (int? manageScheduledPlansId, string manageScheduledPlansTag)
        {
             DeleteManageScheduledPlansTagWithHttpInfo(manageScheduledPlansId, manageScheduledPlansTag);
        }

        /// <summary>
        /// Delete a tag for a manageScheduledPlans. Deletes an existing manageScheduledPlans tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to remove tag from</param> 
        /// <param name="manageScheduledPlansTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteManageScheduledPlansTagWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansTag)
        {
            
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null)
                throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling ManageScheduledPlansApi->DeleteManageScheduledPlansTag");
            
            // verify the required parameter 'manageScheduledPlansTag' is set
            if (manageScheduledPlansTag == null)
                throw new ApiException(400, "Missing required parameter 'manageScheduledPlansTag' when calling ManageScheduledPlansApi->DeleteManageScheduledPlansTag");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}/tag/{manageScheduledPlansTag}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            if (manageScheduledPlansTag != null) localVarPathParams.Add("manageScheduledPlansTag", Configuration.ApiClient.ParameterToString(manageScheduledPlansTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteManageScheduledPlansTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteManageScheduledPlansTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a manageScheduledPlans. Deletes an existing manageScheduledPlans tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to remove tag from</param>
        /// <param name="manageScheduledPlansTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteManageScheduledPlansTagAsync (int? manageScheduledPlansId, string manageScheduledPlansTag)
        {
             await DeleteManageScheduledPlansTagAsyncWithHttpInfo(manageScheduledPlansId, manageScheduledPlansTag);

        }

        /// <summary>
        /// Delete a tag for a manageScheduledPlans. Deletes an existing manageScheduledPlans tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to remove tag from</param>
        /// <param name="manageScheduledPlansTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteManageScheduledPlansTagAsyncWithHttpInfo (int? manageScheduledPlansId, string manageScheduledPlansTag)
        {
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null) throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling DeleteManageScheduledPlansTag");
            // verify the required parameter 'manageScheduledPlansTag' is set
            if (manageScheduledPlansTag == null) throw new ApiException(400, "Missing required parameter 'manageScheduledPlansTag' when calling DeleteManageScheduledPlansTag");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}/tag/{manageScheduledPlansTag}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            if (manageScheduledPlansTag != null) localVarPathParams.Add("manageScheduledPlansTag", Configuration.ApiClient.ParameterToString(manageScheduledPlansTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteManageScheduledPlansTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteManageScheduledPlansTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a manageScheduledPlans by id Returns a duplicated manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be duplicated.</param> 
        /// <returns>ManageScheduledPlans</returns>
        public ManageScheduledPlans GetDuplicateManageScheduledPlansById (int? manageScheduledPlansId)
        {
             ApiResponse<ManageScheduledPlans> localVarResponse = GetDuplicateManageScheduledPlansByIdWithHttpInfo(manageScheduledPlansId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a manageScheduledPlans by id Returns a duplicated manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be duplicated.</param> 
        /// <returns>ApiResponse of ManageScheduledPlans</returns>
        public ApiResponse< ManageScheduledPlans > GetDuplicateManageScheduledPlansByIdWithHttpInfo (int? manageScheduledPlansId)
        {
            
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null)
                throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling ManageScheduledPlansApi->GetDuplicateManageScheduledPlansById");
            
    
            var localVarPath = "/beta/manageScheduledPlans/duplicate/{manageScheduledPlansId}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateManageScheduledPlansById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateManageScheduledPlansById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ManageScheduledPlans>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManageScheduledPlans) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManageScheduledPlans)));
            
        }

        
        /// <summary>
        /// Get a duplicated a manageScheduledPlans by id Returns a duplicated manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be duplicated.</param>
        /// <returns>Task of ManageScheduledPlans</returns>
        public async System.Threading.Tasks.Task<ManageScheduledPlans> GetDuplicateManageScheduledPlansByIdAsync (int? manageScheduledPlansId)
        {
             ApiResponse<ManageScheduledPlans> localVarResponse = await GetDuplicateManageScheduledPlansByIdAsyncWithHttpInfo(manageScheduledPlansId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a manageScheduledPlans by id Returns a duplicated manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be duplicated.</param>
        /// <returns>Task of ApiResponse (ManageScheduledPlans)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManageScheduledPlans>> GetDuplicateManageScheduledPlansByIdAsyncWithHttpInfo (int? manageScheduledPlansId)
        {
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null) throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling GetDuplicateManageScheduledPlansById");
            
    
            var localVarPath = "/beta/manageScheduledPlans/duplicate/{manageScheduledPlansId}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateManageScheduledPlansById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateManageScheduledPlansById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManageScheduledPlans>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManageScheduledPlans) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManageScheduledPlans)));
            
        }
        
        /// <summary>
        /// Search manageScheduledPlanses by filter Returns the list of manageScheduledPlanses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ManageScheduledPlans&gt;</returns>
        public List<ManageScheduledPlans> GetManageScheduledPlansByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ManageScheduledPlans>> localVarResponse = GetManageScheduledPlansByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search manageScheduledPlanses by filter Returns the list of manageScheduledPlanses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ManageScheduledPlans&gt;</returns>
        public ApiResponse< List<ManageScheduledPlans> > GetManageScheduledPlansByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/manageScheduledPlans/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ManageScheduledPlans>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ManageScheduledPlans>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ManageScheduledPlans>)));
            
        }

        
        /// <summary>
        /// Search manageScheduledPlanses by filter Returns the list of manageScheduledPlanses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ManageScheduledPlans&gt;</returns>
        public async System.Threading.Tasks.Task<List<ManageScheduledPlans>> GetManageScheduledPlansByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ManageScheduledPlans>> localVarResponse = await GetManageScheduledPlansByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search manageScheduledPlanses by filter Returns the list of manageScheduledPlanses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ManageScheduledPlans&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ManageScheduledPlans>>> GetManageScheduledPlansByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/manageScheduledPlans/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ManageScheduledPlans>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ManageScheduledPlans>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ManageScheduledPlans>)));
            
        }
        
        /// <summary>
        /// Get a manageScheduledPlans by id Returns the manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be returned.</param> 
        /// <returns>ManageScheduledPlans</returns>
        public ManageScheduledPlans GetManageScheduledPlansById (int? manageScheduledPlansId)
        {
             ApiResponse<ManageScheduledPlans> localVarResponse = GetManageScheduledPlansByIdWithHttpInfo(manageScheduledPlansId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a manageScheduledPlans by id Returns the manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be returned.</param> 
        /// <returns>ApiResponse of ManageScheduledPlans</returns>
        public ApiResponse< ManageScheduledPlans > GetManageScheduledPlansByIdWithHttpInfo (int? manageScheduledPlansId)
        {
            
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null)
                throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling ManageScheduledPlansApi->GetManageScheduledPlansById");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ManageScheduledPlans>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManageScheduledPlans) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManageScheduledPlans)));
            
        }

        
        /// <summary>
        /// Get a manageScheduledPlans by id Returns the manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be returned.</param>
        /// <returns>Task of ManageScheduledPlans</returns>
        public async System.Threading.Tasks.Task<ManageScheduledPlans> GetManageScheduledPlansByIdAsync (int? manageScheduledPlansId)
        {
             ApiResponse<ManageScheduledPlans> localVarResponse = await GetManageScheduledPlansByIdAsyncWithHttpInfo(manageScheduledPlansId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a manageScheduledPlans by id Returns the manageScheduledPlans identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to be returned.</param>
        /// <returns>Task of ApiResponse (ManageScheduledPlans)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManageScheduledPlans>> GetManageScheduledPlansByIdAsyncWithHttpInfo (int? manageScheduledPlansId)
        {
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null) throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling GetManageScheduledPlansById");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManageScheduledPlans>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManageScheduledPlans) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManageScheduledPlans)));
            
        }
        
        /// <summary>
        /// Get the tags for a manageScheduledPlans. Get all existing manageScheduledPlans tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to get tags for</param> 
        /// <returns></returns>
        public void GetManageScheduledPlansTags (int? manageScheduledPlansId)
        {
             GetManageScheduledPlansTagsWithHttpInfo(manageScheduledPlansId);
        }

        /// <summary>
        /// Get the tags for a manageScheduledPlans. Get all existing manageScheduledPlans tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetManageScheduledPlansTagsWithHttpInfo (int? manageScheduledPlansId)
        {
            
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null)
                throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling ManageScheduledPlansApi->GetManageScheduledPlansTags");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}/tag";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a manageScheduledPlans. Get all existing manageScheduledPlans tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetManageScheduledPlansTagsAsync (int? manageScheduledPlansId)
        {
             await GetManageScheduledPlansTagsAsyncWithHttpInfo(manageScheduledPlansId);

        }

        /// <summary>
        /// Get the tags for a manageScheduledPlans. Get all existing manageScheduledPlans tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manageScheduledPlansId">Id of the manageScheduledPlans to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetManageScheduledPlansTagsAsyncWithHttpInfo (int? manageScheduledPlansId)
        {
            // verify the required parameter 'manageScheduledPlansId' is set
            if (manageScheduledPlansId == null) throw new ApiException(400, "Missing required parameter 'manageScheduledPlansId' when calling GetManageScheduledPlansTags");
            
    
            var localVarPath = "/beta/manageScheduledPlans/{manageScheduledPlansId}/tag";
    
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
            if (manageScheduledPlansId != null) localVarPathParams.Add("manageScheduledPlansId", Configuration.ApiClient.ParameterToString(manageScheduledPlansId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManageScheduledPlansTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a manageScheduledPlans Updates an existing manageScheduledPlans using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be updated.</param> 
        /// <returns></returns>
        public void UpdateManageScheduledPlans (ManageScheduledPlans body)
        {
             UpdateManageScheduledPlansWithHttpInfo(body);
        }

        /// <summary>
        /// Update a manageScheduledPlans Updates an existing manageScheduledPlans using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateManageScheduledPlansWithHttpInfo (ManageScheduledPlans body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ManageScheduledPlansApi->UpdateManageScheduledPlans");
            
    
            var localVarPath = "/beta/manageScheduledPlans";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateManageScheduledPlans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateManageScheduledPlans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a manageScheduledPlans Updates an existing manageScheduledPlans using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateManageScheduledPlansAsync (ManageScheduledPlans body)
        {
             await UpdateManageScheduledPlansAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a manageScheduledPlans Updates an existing manageScheduledPlans using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ManageScheduledPlans to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateManageScheduledPlansAsyncWithHttpInfo (ManageScheduledPlans body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateManageScheduledPlans");
            
    
            var localVarPath = "/beta/manageScheduledPlans";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateManageScheduledPlans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateManageScheduledPlans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
