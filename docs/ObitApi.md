# Obada.Client.Api.ObitApi

All URIs are relative to *https://dev.api.obada.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateObit**](ObitApi.md#createobit) | **POST** /obits | 
[**RemoveObit**](ObitApi.md#removeobit) | **DELETE** /obits/{obit_did} | 
[**SearchObits**](ObitApi.md#searchobits) | **GET** /obits | 
[**ShowObit**](ObitApi.md#showobit) | **GET** /obits/{obit_did} | 
[**ShowObitHistory**](ObitApi.md#showobithistory) | **GET** /obits/{obit_did}/history | 
[**UpdateObit**](ObitApi.md#updateobit) | **PUT** /obits/{obit_did} | 



## CreateObit

> InlineResponse201 CreateObit (Obit obit = null)



Creates a new obit.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class CreateObitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var obit = new Obit(); // Obit |  (optional) 

            try
            {
                InlineResponse201 result = apiInstance.CreateObit(obit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.CreateObit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **obit** | [**Obit**](Obit.md)|  | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Collection of historical changes for given obit |  -  |
| **422** | The submitted entity could not be processed. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveObit

> void RemoveObit (string obitDid)



Changes Obit status to DISABLED_BY_OWNER

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class RemoveObitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var obitDid = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID argument

            try
            {
                apiInstance.RemoveObit(obitDid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.RemoveObit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **obitDid** | **string**| The given ObitDID argument | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request was successful and no content was returned. |  -  |
| **404** | The requested resource could not be found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchObits

> InlineResponse2005 SearchObits (string serialNumberHash = null, string obitStatus = null, string manufacturer = null, string partNumber = null, string usn = null, string ownerDid = null, int? offset = null, int? limit = null)



Search obits by given filters.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class SearchObitsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var serialNumberHash = fe403a1afe16203f4b8bb3a0e72d3e17567897bc15293e4a87b663e441030aea;  // string | Query argument that filters by serial number hash (optional) 
            var obitStatus = obitStatus_example;  // string | Query argument that filters by obit status (optional) 
            var manufacturer = Sony;  // string | Query argument that filters by manufacturer (optional) 
            var partNumber = MWCN2LL/A;  // string | Query argument that filters by part number (optional) 
            var usn = 2zEz-xLJR;  // string | Universal serial number (optional) 
            var ownerDid = did:obada:owner:123456;  // string | OBADA owner DID (optional) 
            var offset = 56;  // int? | Number of records to skip for pagination. (optional)  (default to 0)
            var limit = 56;  // int? | Maximum number of records to return. (optional)  (default to 0)

            try
            {
                InlineResponse2005 result = apiInstance.SearchObits(serialNumberHash, obitStatus, manufacturer, partNumber, usn, ownerDid, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.SearchObits: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serialNumberHash** | **string**| Query argument that filters by serial number hash | [optional] 
 **obitStatus** | **string**| Query argument that filters by obit status | [optional] 
 **manufacturer** | **string**| Query argument that filters by manufacturer | [optional] 
 **partNumber** | **string**| Query argument that filters by part number | [optional] 
 **usn** | **string**| Universal serial number | [optional] 
 **ownerDid** | **string**| OBADA owner DID | [optional] 
 **offset** | **int?**| Number of records to skip for pagination. | [optional] [default to 0]
 **limit** | **int?**| Maximum number of records to return. | [optional] [default to 0]

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of obits responded by given arguments. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ShowObit

> Obit ShowObit (string obitDid)



Shows the information about single Obit by given ObitDID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class ShowObitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var obitDid = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID argument

            try
            {
                Obit result = apiInstance.ShowObit(obitDid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.ShowObit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **obitDid** | **string**| The given ObitDID argument | 

### Return type

[**Obit**](Obit.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Obit in response |  -  |
| **404** | The requested resource could not be found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ShowObitHistory

> InlineResponse2006 ShowObitHistory (string obitDid)



Shows the history of changes by given Obit with ObitDID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class ShowObitHistoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var obitDid = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID argument

            try
            {
                InlineResponse2006 result = apiInstance.ShowObitHistory(obitDid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.ShowObitHistory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **obitDid** | **string**| The given ObitDID argument | 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Collection of historical changes for given obit |  -  |
| **404** | The requested resource could not be found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateObit

> void UpdateObit (string obitDid, Obit obit = null)



Updates Obit by given ObitDID with payload

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class UpdateObitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var obitDid = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID argument
            var obit = new Obit(); // Obit |  (optional) 

            try
            {
                apiInstance.UpdateObit(obitDid, obit);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.UpdateObit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **obitDid** | **string**| The given ObitDID argument | 
 **obit** | [**Obit**](Obit.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The request was successful and the resource was created. |  -  |
| **404** | The requested resource could not be found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

