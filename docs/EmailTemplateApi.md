# Infoplus.Api.EmailTemplateApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddEmailTemplate**](EmailTemplateApi.md#addemailtemplate) | **POST** /v1.0/emailTemplate | Create an emailTemplate
[**DeleteEmailTemplate**](EmailTemplateApi.md#deleteemailtemplate) | **DELETE** /v1.0/emailTemplate/{emailTemplateId} | Delete an emailTemplate
[**GetEmailTemplateByFilter**](EmailTemplateApi.md#getemailtemplatebyfilter) | **GET** /v1.0/emailTemplate/search | Search emailTemplates by filter
[**GetEmailTemplateById**](EmailTemplateApi.md#getemailtemplatebyid) | **GET** /v1.0/emailTemplate/{emailTemplateId} | Get an emailTemplate by id
[**UpdateEmailTemplate**](EmailTemplateApi.md#updateemailtemplate) | **PUT** /v1.0/emailTemplate | Update an emailTemplate


# **AddEmailTemplate**
> EmailTemplate AddEmailTemplate (EmailTemplate body)

Create an emailTemplate

Inserts a new emailTemplate using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddEmailTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new EmailTemplateApi();
            var body = new EmailTemplate(); // EmailTemplate | EmailTemplate to be inserted.

            try
            {
                // Create an emailTemplate
                EmailTemplate result = apiInstance.AddEmailTemplate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.AddEmailTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmailTemplate**](EmailTemplate.md)| EmailTemplate to be inserted. | 

### Return type

[**EmailTemplate**](EmailTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteEmailTemplate**
> void DeleteEmailTemplate (int? emailTemplateId)

Delete an emailTemplate

Deletes the emailTemplate identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteEmailTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new EmailTemplateApi();
            var emailTemplateId = 56;  // int? | Id of the emailTemplate to be deleted.

            try
            {
                // Delete an emailTemplate
                apiInstance.DeleteEmailTemplate(emailTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.DeleteEmailTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailTemplateId** | **int?**| Id of the emailTemplate to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetEmailTemplateByFilter**
> List<EmailTemplate> GetEmailTemplateByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search emailTemplates by filter

Returns the list of emailTemplates that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetEmailTemplateByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new EmailTemplateApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search emailTemplates by filter
                List&lt;EmailTemplate&gt; result = apiInstance.GetEmailTemplateByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.GetEmailTemplateByFilter: " + e.Message );
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

[**List<EmailTemplate>**](EmailTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetEmailTemplateById**
> EmailTemplate GetEmailTemplateById (int? emailTemplateId)

Get an emailTemplate by id

Returns the emailTemplate identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetEmailTemplateByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new EmailTemplateApi();
            var emailTemplateId = 56;  // int? | Id of the emailTemplate to be returned.

            try
            {
                // Get an emailTemplate by id
                EmailTemplate result = apiInstance.GetEmailTemplateById(emailTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.GetEmailTemplateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailTemplateId** | **int?**| Id of the emailTemplate to be returned. | 

### Return type

[**EmailTemplate**](EmailTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateEmailTemplate**
> void UpdateEmailTemplate (EmailTemplate body)

Update an emailTemplate

Updates an existing emailTemplate using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateEmailTemplateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new EmailTemplateApi();
            var body = new EmailTemplate(); // EmailTemplate | EmailTemplate to be updated.

            try
            {
                // Update an emailTemplate
                apiInstance.UpdateEmailTemplate(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.UpdateEmailTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmailTemplate**](EmailTemplate.md)| EmailTemplate to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

