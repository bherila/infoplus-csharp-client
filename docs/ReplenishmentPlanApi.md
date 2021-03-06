# Infoplus.Api.ReplenishmentPlanApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReplenishmentPlan**](ReplenishmentPlanApi.md#addreplenishmentplan) | **POST** /v1.0/replenishmentPlan | Create a replenishmentPlan
[**DeleteReplenishmentPlan**](ReplenishmentPlanApi.md#deletereplenishmentplan) | **DELETE** /v1.0/replenishmentPlan/{replenishmentPlanId} | Delete a replenishmentPlan
[**GetReplenishmentPlanByFilter**](ReplenishmentPlanApi.md#getreplenishmentplanbyfilter) | **GET** /v1.0/replenishmentPlan/search | Search replenishmentPlans by filter
[**GetReplenishmentPlanById**](ReplenishmentPlanApi.md#getreplenishmentplanbyid) | **GET** /v1.0/replenishmentPlan/{replenishmentPlanId} | Get a replenishmentPlan by id
[**UpdateReplenishmentPlan**](ReplenishmentPlanApi.md#updatereplenishmentplan) | **PUT** /v1.0/replenishmentPlan | Update a replenishmentPlan


# **AddReplenishmentPlan**
> ReplenishmentPlan AddReplenishmentPlan (ReplenishmentPlan body)

Create a replenishmentPlan

Inserts a new replenishmentPlan using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentPlanExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReplenishmentPlanApi();
            var body = new ReplenishmentPlan(); // ReplenishmentPlan | ReplenishmentPlan to be inserted.

            try
            {
                // Create a replenishmentPlan
                ReplenishmentPlan result = apiInstance.AddReplenishmentPlan(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.AddReplenishmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReplenishmentPlan**](ReplenishmentPlan.md)| ReplenishmentPlan to be inserted. | 

### Return type

[**ReplenishmentPlan**](ReplenishmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteReplenishmentPlan**
> void DeleteReplenishmentPlan (int? replenishmentPlanId)

Delete a replenishmentPlan

Deletes the replenishmentPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReplenishmentPlanExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReplenishmentPlanApi();
            var replenishmentPlanId = 56;  // int? | Id of the replenishmentPlan to be deleted.

            try
            {
                // Delete a replenishmentPlan
                apiInstance.DeleteReplenishmentPlan(replenishmentPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.DeleteReplenishmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentPlanId** | **int?**| Id of the replenishmentPlan to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetReplenishmentPlanByFilter**
> List<ReplenishmentPlan> GetReplenishmentPlanByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search replenishmentPlans by filter

Returns the list of replenishmentPlans that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentPlanByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReplenishmentPlanApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search replenishmentPlans by filter
                List&lt;ReplenishmentPlan&gt; result = apiInstance.GetReplenishmentPlanByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.GetReplenishmentPlanByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Query string, used to filter results. | [optional] 
 **page** | **int?**| Result page number.  Defaults to 1. | [optional] 
 **limit** | **int?**| Maximum results per page.  Defaults to 20.  Max allowed value is 250. | [optional] 
 **sort** | **string**| Sort results by specified field. | [optional] 

### Return type

[**List<ReplenishmentPlan>**](ReplenishmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetReplenishmentPlanById**
> ReplenishmentPlan GetReplenishmentPlanById (int? replenishmentPlanId)

Get a replenishmentPlan by id

Returns the replenishmentPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentPlanByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReplenishmentPlanApi();
            var replenishmentPlanId = 56;  // int? | Id of the replenishmentPlan to be returned.

            try
            {
                // Get a replenishmentPlan by id
                ReplenishmentPlan result = apiInstance.GetReplenishmentPlanById(replenishmentPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.GetReplenishmentPlanById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentPlanId** | **int?**| Id of the replenishmentPlan to be returned. | 

### Return type

[**ReplenishmentPlan**](ReplenishmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateReplenishmentPlan**
> void UpdateReplenishmentPlan (ReplenishmentPlan body)

Update a replenishmentPlan

Updates an existing replenishmentPlan using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReplenishmentPlanExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReplenishmentPlanApi();
            var body = new ReplenishmentPlan(); // ReplenishmentPlan | ReplenishmentPlan to be updated.

            try
            {
                // Update a replenishmentPlan
                apiInstance.UpdateReplenishmentPlan(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.UpdateReplenishmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReplenishmentPlan**](ReplenishmentPlan.md)| ReplenishmentPlan to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

