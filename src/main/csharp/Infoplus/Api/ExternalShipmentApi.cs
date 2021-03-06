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
    public interface IExternalShipmentApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an externalShipment
        /// </summary>
        /// <remarks>
        /// Inserts a new externalShipment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be inserted.</param>
        /// <returns>ExternalShipment</returns>
        ExternalShipment AddExternalShipment (ExternalShipment body);
  
        /// <summary>
        /// Create an externalShipment
        /// </summary>
        /// <remarks>
        /// Inserts a new externalShipment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be inserted.</param>
        /// <returns>ApiResponse of ExternalShipment</returns>
        ApiResponse<ExternalShipment> AddExternalShipmentWithHttpInfo (ExternalShipment body);
        
        /// <summary>
        /// Add new audit for an externalShipment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing externalShipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add an audit to</param>
        /// <param name="externalShipmentAudit">The audit to add</param>
        /// <returns></returns>
        void AddExternalShipmentAudit (int? externalShipmentId, string externalShipmentAudit);
  
        /// <summary>
        /// Add new audit for an externalShipment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing externalShipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add an audit to</param>
        /// <param name="externalShipmentAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddExternalShipmentAuditWithHttpInfo (int? externalShipmentId, string externalShipmentAudit);
        
        /// <summary>
        /// Add new tags for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing externalShipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add a tag to</param>
        /// <param name="externalShipmentTag">The tag to add</param>
        /// <returns></returns>
        void AddExternalShipmentTag (int? externalShipmentId, string externalShipmentTag);
  
        /// <summary>
        /// Add new tags for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing externalShipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add a tag to</param>
        /// <param name="externalShipmentTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddExternalShipmentTagWithHttpInfo (int? externalShipmentId, string externalShipmentTag);
        
        /// <summary>
        /// Delete an externalShipment
        /// </summary>
        /// <remarks>
        /// Deletes the externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be deleted.</param>
        /// <returns></returns>
        void DeleteExternalShipment (int? externalShipmentId);
  
        /// <summary>
        /// Delete an externalShipment
        /// </summary>
        /// <remarks>
        /// Deletes the externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteExternalShipmentWithHttpInfo (int? externalShipmentId);
        
        /// <summary>
        /// Delete a tag for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing externalShipment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to remove tag from</param>
        /// <param name="externalShipmentTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteExternalShipmentTag (int? externalShipmentId, string externalShipmentTag);
  
        /// <summary>
        /// Delete a tag for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing externalShipment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to remove tag from</param>
        /// <param name="externalShipmentTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteExternalShipmentTagWithHttpInfo (int? externalShipmentId, string externalShipmentTag);
        
        /// <summary>
        /// Get a duplicated an externalShipment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be duplicated.</param>
        /// <returns>ExternalShipment</returns>
        ExternalShipment GetDuplicateExternalShipmentById (int? externalShipmentId);
  
        /// <summary>
        /// Get a duplicated an externalShipment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be duplicated.</param>
        /// <returns>ApiResponse of ExternalShipment</returns>
        ApiResponse<ExternalShipment> GetDuplicateExternalShipmentByIdWithHttpInfo (int? externalShipmentId);
        
        /// <summary>
        /// Search externalShipments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of externalShipments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ExternalShipment&gt;</returns>
        List<ExternalShipment> GetExternalShipmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search externalShipments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of externalShipments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ExternalShipment&gt;</returns>
        ApiResponse<List<ExternalShipment>> GetExternalShipmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an externalShipment by id
        /// </summary>
        /// <remarks>
        /// Returns the externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be returned.</param>
        /// <returns>ExternalShipment</returns>
        ExternalShipment GetExternalShipmentById (int? externalShipmentId);
  
        /// <summary>
        /// Get an externalShipment by id
        /// </summary>
        /// <remarks>
        /// Returns the externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be returned.</param>
        /// <returns>ApiResponse of ExternalShipment</returns>
        ApiResponse<ExternalShipment> GetExternalShipmentByIdWithHttpInfo (int? externalShipmentId);
        
        /// <summary>
        /// Get the tags for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Get all existing externalShipment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to get tags for</param>
        /// <returns></returns>
        void GetExternalShipmentTags (int? externalShipmentId);
  
        /// <summary>
        /// Get the tags for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Get all existing externalShipment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetExternalShipmentTagsWithHttpInfo (int? externalShipmentId);
        
        /// <summary>
        /// Update an externalShipment
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShipment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns></returns>
        void UpdateExternalShipment (ExternalShipment body);
  
        /// <summary>
        /// Update an externalShipment
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShipment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateExternalShipmentWithHttpInfo (ExternalShipment body);
        
        /// <summary>
        /// Update an externalShipment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShipment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns></returns>
        void UpdateExternalShipmentCustomFields (ExternalShipment body);
  
        /// <summary>
        /// Update an externalShipment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShipment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateExternalShipmentCustomFieldsWithHttpInfo (ExternalShipment body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an externalShipment
        /// </summary>
        /// <remarks>
        /// Inserts a new externalShipment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be inserted.</param>
        /// <returns>Task of ExternalShipment</returns>
        System.Threading.Tasks.Task<ExternalShipment> AddExternalShipmentAsync (ExternalShipment body);

        /// <summary>
        /// Create an externalShipment
        /// </summary>
        /// <remarks>
        /// Inserts a new externalShipment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be inserted.</param>
        /// <returns>Task of ApiResponse (ExternalShipment)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalShipment>> AddExternalShipmentAsyncWithHttpInfo (ExternalShipment body);
        
        /// <summary>
        /// Add new audit for an externalShipment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing externalShipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add an audit to</param>
        /// <param name="externalShipmentAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddExternalShipmentAuditAsync (int? externalShipmentId, string externalShipmentAudit);

        /// <summary>
        /// Add new audit for an externalShipment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing externalShipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add an audit to</param>
        /// <param name="externalShipmentAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddExternalShipmentAuditAsyncWithHttpInfo (int? externalShipmentId, string externalShipmentAudit);
        
        /// <summary>
        /// Add new tags for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing externalShipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add a tag to</param>
        /// <param name="externalShipmentTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddExternalShipmentTagAsync (int? externalShipmentId, string externalShipmentTag);

        /// <summary>
        /// Add new tags for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing externalShipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add a tag to</param>
        /// <param name="externalShipmentTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddExternalShipmentTagAsyncWithHttpInfo (int? externalShipmentId, string externalShipmentTag);
        
        /// <summary>
        /// Delete an externalShipment
        /// </summary>
        /// <remarks>
        /// Deletes the externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalShipmentAsync (int? externalShipmentId);

        /// <summary>
        /// Delete an externalShipment
        /// </summary>
        /// <remarks>
        /// Deletes the externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalShipmentAsyncWithHttpInfo (int? externalShipmentId);
        
        /// <summary>
        /// Delete a tag for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing externalShipment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to remove tag from</param>
        /// <param name="externalShipmentTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalShipmentTagAsync (int? externalShipmentId, string externalShipmentTag);

        /// <summary>
        /// Delete a tag for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing externalShipment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to remove tag from</param>
        /// <param name="externalShipmentTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalShipmentTagAsyncWithHttpInfo (int? externalShipmentId, string externalShipmentTag);
        
        /// <summary>
        /// Get a duplicated an externalShipment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be duplicated.</param>
        /// <returns>Task of ExternalShipment</returns>
        System.Threading.Tasks.Task<ExternalShipment> GetDuplicateExternalShipmentByIdAsync (int? externalShipmentId);

        /// <summary>
        /// Get a duplicated an externalShipment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be duplicated.</param>
        /// <returns>Task of ApiResponse (ExternalShipment)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalShipment>> GetDuplicateExternalShipmentByIdAsyncWithHttpInfo (int? externalShipmentId);
        
        /// <summary>
        /// Search externalShipments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of externalShipments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ExternalShipment&gt;</returns>
        System.Threading.Tasks.Task<List<ExternalShipment>> GetExternalShipmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search externalShipments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of externalShipments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ExternalShipment&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ExternalShipment>>> GetExternalShipmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an externalShipment by id
        /// </summary>
        /// <remarks>
        /// Returns the externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be returned.</param>
        /// <returns>Task of ExternalShipment</returns>
        System.Threading.Tasks.Task<ExternalShipment> GetExternalShipmentByIdAsync (int? externalShipmentId);

        /// <summary>
        /// Get an externalShipment by id
        /// </summary>
        /// <remarks>
        /// Returns the externalShipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be returned.</param>
        /// <returns>Task of ApiResponse (ExternalShipment)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalShipment>> GetExternalShipmentByIdAsyncWithHttpInfo (int? externalShipmentId);
        
        /// <summary>
        /// Get the tags for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Get all existing externalShipment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetExternalShipmentTagsAsync (int? externalShipmentId);

        /// <summary>
        /// Get the tags for an externalShipment.
        /// </summary>
        /// <remarks>
        /// Get all existing externalShipment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetExternalShipmentTagsAsyncWithHttpInfo (int? externalShipmentId);
        
        /// <summary>
        /// Update an externalShipment
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShipment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateExternalShipmentAsync (ExternalShipment body);

        /// <summary>
        /// Update an externalShipment
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShipment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateExternalShipmentAsyncWithHttpInfo (ExternalShipment body);
        
        /// <summary>
        /// Update an externalShipment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShipment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateExternalShipmentCustomFieldsAsync (ExternalShipment body);

        /// <summary>
        /// Update an externalShipment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShipment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateExternalShipmentCustomFieldsAsyncWithHttpInfo (ExternalShipment body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ExternalShipmentApi : IExternalShipmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalShipmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExternalShipmentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalShipmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExternalShipmentApi(Configuration configuration = null)
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
        /// Create an externalShipment Inserts a new externalShipment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be inserted.</param> 
        /// <returns>ExternalShipment</returns>
        public ExternalShipment AddExternalShipment (ExternalShipment body)
        {
             ApiResponse<ExternalShipment> localVarResponse = AddExternalShipmentWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an externalShipment Inserts a new externalShipment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be inserted.</param> 
        /// <returns>ApiResponse of ExternalShipment</returns>
        public ApiResponse< ExternalShipment > AddExternalShipmentWithHttpInfo (ExternalShipment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalShipmentApi->AddExternalShipment");
            
    
            var localVarPath = "/beta/externalShipment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExternalShipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShipment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShipment)));
            
        }

        
        /// <summary>
        /// Create an externalShipment Inserts a new externalShipment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be inserted.</param>
        /// <returns>Task of ExternalShipment</returns>
        public async System.Threading.Tasks.Task<ExternalShipment> AddExternalShipmentAsync (ExternalShipment body)
        {
             ApiResponse<ExternalShipment> localVarResponse = await AddExternalShipmentAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an externalShipment Inserts a new externalShipment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be inserted.</param>
        /// <returns>Task of ApiResponse (ExternalShipment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalShipment>> AddExternalShipmentAsyncWithHttpInfo (ExternalShipment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddExternalShipment");
            
    
            var localVarPath = "/beta/externalShipment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalShipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShipment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShipment)));
            
        }
        
        /// <summary>
        /// Add new audit for an externalShipment Adds an audit to an existing externalShipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add an audit to</param> 
        /// <param name="externalShipmentAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddExternalShipmentAudit (int? externalShipmentId, string externalShipmentAudit)
        {
             AddExternalShipmentAuditWithHttpInfo(externalShipmentId, externalShipmentAudit);
        }

        /// <summary>
        /// Add new audit for an externalShipment Adds an audit to an existing externalShipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add an audit to</param> 
        /// <param name="externalShipmentAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddExternalShipmentAuditWithHttpInfo (int? externalShipmentId, string externalShipmentAudit)
        {
            
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null)
                throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling ExternalShipmentApi->AddExternalShipmentAudit");
            
            // verify the required parameter 'externalShipmentAudit' is set
            if (externalShipmentAudit == null)
                throw new ApiException(400, "Missing required parameter 'externalShipmentAudit' when calling ExternalShipmentApi->AddExternalShipmentAudit");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}/audit/{externalShipmentAudit}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            if (externalShipmentAudit != null) localVarPathParams.Add("externalShipmentAudit", Configuration.ApiClient.ParameterToString(externalShipmentAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipmentAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipmentAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an externalShipment Adds an audit to an existing externalShipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add an audit to</param>
        /// <param name="externalShipmentAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddExternalShipmentAuditAsync (int? externalShipmentId, string externalShipmentAudit)
        {
             await AddExternalShipmentAuditAsyncWithHttpInfo(externalShipmentId, externalShipmentAudit);

        }

        /// <summary>
        /// Add new audit for an externalShipment Adds an audit to an existing externalShipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add an audit to</param>
        /// <param name="externalShipmentAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddExternalShipmentAuditAsyncWithHttpInfo (int? externalShipmentId, string externalShipmentAudit)
        {
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null) throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling AddExternalShipmentAudit");
            // verify the required parameter 'externalShipmentAudit' is set
            if (externalShipmentAudit == null) throw new ApiException(400, "Missing required parameter 'externalShipmentAudit' when calling AddExternalShipmentAudit");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}/audit/{externalShipmentAudit}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            if (externalShipmentAudit != null) localVarPathParams.Add("externalShipmentAudit", Configuration.ApiClient.ParameterToString(externalShipmentAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipmentAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipmentAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an externalShipment. Adds a tag to an existing externalShipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add a tag to</param> 
        /// <param name="externalShipmentTag">The tag to add</param> 
        /// <returns></returns>
        public void AddExternalShipmentTag (int? externalShipmentId, string externalShipmentTag)
        {
             AddExternalShipmentTagWithHttpInfo(externalShipmentId, externalShipmentTag);
        }

        /// <summary>
        /// Add new tags for an externalShipment. Adds a tag to an existing externalShipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add a tag to</param> 
        /// <param name="externalShipmentTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddExternalShipmentTagWithHttpInfo (int? externalShipmentId, string externalShipmentTag)
        {
            
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null)
                throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling ExternalShipmentApi->AddExternalShipmentTag");
            
            // verify the required parameter 'externalShipmentTag' is set
            if (externalShipmentTag == null)
                throw new ApiException(400, "Missing required parameter 'externalShipmentTag' when calling ExternalShipmentApi->AddExternalShipmentTag");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}/tag/{externalShipmentTag}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            if (externalShipmentTag != null) localVarPathParams.Add("externalShipmentTag", Configuration.ApiClient.ParameterToString(externalShipmentTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an externalShipment. Adds a tag to an existing externalShipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add a tag to</param>
        /// <param name="externalShipmentTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddExternalShipmentTagAsync (int? externalShipmentId, string externalShipmentTag)
        {
             await AddExternalShipmentTagAsyncWithHttpInfo(externalShipmentId, externalShipmentTag);

        }

        /// <summary>
        /// Add new tags for an externalShipment. Adds a tag to an existing externalShipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to add a tag to</param>
        /// <param name="externalShipmentTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddExternalShipmentTagAsyncWithHttpInfo (int? externalShipmentId, string externalShipmentTag)
        {
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null) throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling AddExternalShipmentTag");
            // verify the required parameter 'externalShipmentTag' is set
            if (externalShipmentTag == null) throw new ApiException(400, "Missing required parameter 'externalShipmentTag' when calling AddExternalShipmentTag");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}/tag/{externalShipmentTag}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            if (externalShipmentTag != null) localVarPathParams.Add("externalShipmentTag", Configuration.ApiClient.ParameterToString(externalShipmentTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShipmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an externalShipment Deletes the externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be deleted.</param> 
        /// <returns></returns>
        public void DeleteExternalShipment (int? externalShipmentId)
        {
             DeleteExternalShipmentWithHttpInfo(externalShipmentId);
        }

        /// <summary>
        /// Delete an externalShipment Deletes the externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalShipmentWithHttpInfo (int? externalShipmentId)
        {
            
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null)
                throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling ExternalShipmentApi->DeleteExternalShipment");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShipment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShipment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an externalShipment Deletes the externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalShipmentAsync (int? externalShipmentId)
        {
             await DeleteExternalShipmentAsyncWithHttpInfo(externalShipmentId);

        }

        /// <summary>
        /// Delete an externalShipment Deletes the externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalShipmentAsyncWithHttpInfo (int? externalShipmentId)
        {
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null) throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling DeleteExternalShipment");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShipment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShipment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an externalShipment. Deletes an existing externalShipment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to remove tag from</param> 
        /// <param name="externalShipmentTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteExternalShipmentTag (int? externalShipmentId, string externalShipmentTag)
        {
             DeleteExternalShipmentTagWithHttpInfo(externalShipmentId, externalShipmentTag);
        }

        /// <summary>
        /// Delete a tag for an externalShipment. Deletes an existing externalShipment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to remove tag from</param> 
        /// <param name="externalShipmentTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalShipmentTagWithHttpInfo (int? externalShipmentId, string externalShipmentTag)
        {
            
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null)
                throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling ExternalShipmentApi->DeleteExternalShipmentTag");
            
            // verify the required parameter 'externalShipmentTag' is set
            if (externalShipmentTag == null)
                throw new ApiException(400, "Missing required parameter 'externalShipmentTag' when calling ExternalShipmentApi->DeleteExternalShipmentTag");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}/tag/{externalShipmentTag}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            if (externalShipmentTag != null) localVarPathParams.Add("externalShipmentTag", Configuration.ApiClient.ParameterToString(externalShipmentTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShipmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShipmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an externalShipment. Deletes an existing externalShipment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to remove tag from</param>
        /// <param name="externalShipmentTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalShipmentTagAsync (int? externalShipmentId, string externalShipmentTag)
        {
             await DeleteExternalShipmentTagAsyncWithHttpInfo(externalShipmentId, externalShipmentTag);

        }

        /// <summary>
        /// Delete a tag for an externalShipment. Deletes an existing externalShipment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to remove tag from</param>
        /// <param name="externalShipmentTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalShipmentTagAsyncWithHttpInfo (int? externalShipmentId, string externalShipmentTag)
        {
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null) throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling DeleteExternalShipmentTag");
            // verify the required parameter 'externalShipmentTag' is set
            if (externalShipmentTag == null) throw new ApiException(400, "Missing required parameter 'externalShipmentTag' when calling DeleteExternalShipmentTag");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}/tag/{externalShipmentTag}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            if (externalShipmentTag != null) localVarPathParams.Add("externalShipmentTag", Configuration.ApiClient.ParameterToString(externalShipmentTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShipmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShipmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an externalShipment by id Returns a duplicated externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be duplicated.</param> 
        /// <returns>ExternalShipment</returns>
        public ExternalShipment GetDuplicateExternalShipmentById (int? externalShipmentId)
        {
             ApiResponse<ExternalShipment> localVarResponse = GetDuplicateExternalShipmentByIdWithHttpInfo(externalShipmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an externalShipment by id Returns a duplicated externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be duplicated.</param> 
        /// <returns>ApiResponse of ExternalShipment</returns>
        public ApiResponse< ExternalShipment > GetDuplicateExternalShipmentByIdWithHttpInfo (int? externalShipmentId)
        {
            
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null)
                throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling ExternalShipmentApi->GetDuplicateExternalShipmentById");
            
    
            var localVarPath = "/beta/externalShipment/duplicate/{externalShipmentId}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateExternalShipmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateExternalShipmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExternalShipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShipment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShipment)));
            
        }

        
        /// <summary>
        /// Get a duplicated an externalShipment by id Returns a duplicated externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be duplicated.</param>
        /// <returns>Task of ExternalShipment</returns>
        public async System.Threading.Tasks.Task<ExternalShipment> GetDuplicateExternalShipmentByIdAsync (int? externalShipmentId)
        {
             ApiResponse<ExternalShipment> localVarResponse = await GetDuplicateExternalShipmentByIdAsyncWithHttpInfo(externalShipmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an externalShipment by id Returns a duplicated externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be duplicated.</param>
        /// <returns>Task of ApiResponse (ExternalShipment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalShipment>> GetDuplicateExternalShipmentByIdAsyncWithHttpInfo (int? externalShipmentId)
        {
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null) throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling GetDuplicateExternalShipmentById");
            
    
            var localVarPath = "/beta/externalShipment/duplicate/{externalShipmentId}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateExternalShipmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateExternalShipmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalShipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShipment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShipment)));
            
        }
        
        /// <summary>
        /// Search externalShipments by filter Returns the list of externalShipments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ExternalShipment&gt;</returns>
        public List<ExternalShipment> GetExternalShipmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ExternalShipment>> localVarResponse = GetExternalShipmentByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search externalShipments by filter Returns the list of externalShipments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ExternalShipment&gt;</returns>
        public ApiResponse< List<ExternalShipment> > GetExternalShipmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/externalShipment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ExternalShipment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ExternalShipment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ExternalShipment>)));
            
        }

        
        /// <summary>
        /// Search externalShipments by filter Returns the list of externalShipments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ExternalShipment&gt;</returns>
        public async System.Threading.Tasks.Task<List<ExternalShipment>> GetExternalShipmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ExternalShipment>> localVarResponse = await GetExternalShipmentByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search externalShipments by filter Returns the list of externalShipments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ExternalShipment&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ExternalShipment>>> GetExternalShipmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/externalShipment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ExternalShipment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ExternalShipment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ExternalShipment>)));
            
        }
        
        /// <summary>
        /// Get an externalShipment by id Returns the externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be returned.</param> 
        /// <returns>ExternalShipment</returns>
        public ExternalShipment GetExternalShipmentById (int? externalShipmentId)
        {
             ApiResponse<ExternalShipment> localVarResponse = GetExternalShipmentByIdWithHttpInfo(externalShipmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an externalShipment by id Returns the externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be returned.</param> 
        /// <returns>ApiResponse of ExternalShipment</returns>
        public ApiResponse< ExternalShipment > GetExternalShipmentByIdWithHttpInfo (int? externalShipmentId)
        {
            
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null)
                throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling ExternalShipmentApi->GetExternalShipmentById");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExternalShipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShipment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShipment)));
            
        }

        
        /// <summary>
        /// Get an externalShipment by id Returns the externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be returned.</param>
        /// <returns>Task of ExternalShipment</returns>
        public async System.Threading.Tasks.Task<ExternalShipment> GetExternalShipmentByIdAsync (int? externalShipmentId)
        {
             ApiResponse<ExternalShipment> localVarResponse = await GetExternalShipmentByIdAsyncWithHttpInfo(externalShipmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an externalShipment by id Returns the externalShipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to be returned.</param>
        /// <returns>Task of ApiResponse (ExternalShipment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalShipment>> GetExternalShipmentByIdAsyncWithHttpInfo (int? externalShipmentId)
        {
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null) throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling GetExternalShipmentById");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalShipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShipment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShipment)));
            
        }
        
        /// <summary>
        /// Get the tags for an externalShipment. Get all existing externalShipment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to get tags for</param> 
        /// <returns></returns>
        public void GetExternalShipmentTags (int? externalShipmentId)
        {
             GetExternalShipmentTagsWithHttpInfo(externalShipmentId);
        }

        /// <summary>
        /// Get the tags for an externalShipment. Get all existing externalShipment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetExternalShipmentTagsWithHttpInfo (int? externalShipmentId)
        {
            
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null)
                throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling ExternalShipmentApi->GetExternalShipmentTags");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}/tag";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an externalShipment. Get all existing externalShipment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetExternalShipmentTagsAsync (int? externalShipmentId)
        {
             await GetExternalShipmentTagsAsyncWithHttpInfo(externalShipmentId);

        }

        /// <summary>
        /// Get the tags for an externalShipment. Get all existing externalShipment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">Id of the externalShipment to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetExternalShipmentTagsAsyncWithHttpInfo (int? externalShipmentId)
        {
            // verify the required parameter 'externalShipmentId' is set
            if (externalShipmentId == null) throw new ApiException(400, "Missing required parameter 'externalShipmentId' when calling GetExternalShipmentTags");
            
    
            var localVarPath = "/beta/externalShipment/{externalShipmentId}/tag";
    
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
            if (externalShipmentId != null) localVarPathParams.Add("externalShipmentId", Configuration.ApiClient.ParameterToString(externalShipmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShipmentTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an externalShipment Updates an existing externalShipment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param> 
        /// <returns></returns>
        public void UpdateExternalShipment (ExternalShipment body)
        {
             UpdateExternalShipmentWithHttpInfo(body);
        }

        /// <summary>
        /// Update an externalShipment Updates an existing externalShipment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateExternalShipmentWithHttpInfo (ExternalShipment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalShipmentApi->UpdateExternalShipment");
            
    
            var localVarPath = "/beta/externalShipment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShipment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShipment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an externalShipment Updates an existing externalShipment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateExternalShipmentAsync (ExternalShipment body)
        {
             await UpdateExternalShipmentAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an externalShipment Updates an existing externalShipment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateExternalShipmentAsyncWithHttpInfo (ExternalShipment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateExternalShipment");
            
    
            var localVarPath = "/beta/externalShipment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShipment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShipment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an externalShipment custom fields Updates an existing externalShipment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param> 
        /// <returns></returns>
        public void UpdateExternalShipmentCustomFields (ExternalShipment body)
        {
             UpdateExternalShipmentCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update an externalShipment custom fields Updates an existing externalShipment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateExternalShipmentCustomFieldsWithHttpInfo (ExternalShipment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalShipmentApi->UpdateExternalShipmentCustomFields");
            
    
            var localVarPath = "/beta/externalShipment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShipmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShipmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an externalShipment custom fields Updates an existing externalShipment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateExternalShipmentCustomFieldsAsync (ExternalShipment body)
        {
             await UpdateExternalShipmentCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an externalShipment custom fields Updates an existing externalShipment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShipment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateExternalShipmentCustomFieldsAsyncWithHttpInfo (ExternalShipment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateExternalShipmentCustomFields");
            
    
            var localVarPath = "/beta/externalShipment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShipmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShipmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
