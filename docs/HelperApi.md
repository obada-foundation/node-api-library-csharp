# Obada.Client.Api.HelperApi

All URIs are relative to *https://dev.api.obada.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FetchObitFromChain**](HelperApi.md#fetchobitfromchain) | **GET** /api/server/obit/{obit_did} | Get Obit From Blockchain
[**GenerateObitDef**](HelperApi.md#generateobitdef) | **GET** /api/obit/definition | Generate Obit Definition
[**GenerateRootHash**](HelperApi.md#generateroothash) | **POST** /api/obit/hash | Generates The Root Hash using the data provided.
[**GetClientObit**](HelperApi.md#getclientobit) | **GET** /api/client/obit/{obit_did} | Get Client Obit
[**GetClientObits**](HelperApi.md#getclientobits) | **GET** /api/client/obits | Returns a list of client obits
[**SaveClientObit**](HelperApi.md#saveclientobit) | **POST** /api/client/obit | Save Client Obit



## FetchObitFromChain

> InlineResponse2002 FetchObitFromChain (string obitDid)

Get Obit From Blockchain

Retrieves Obit information from blockchain but does not download it.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class FetchObitFromChainExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new HelperApi(Configuration.Default);
            var obitDid = did:obada:81413bc1ad2074a6ae35d1f65f64f1bca2e8a20959f37ef0349a729ddc567d9b;  // string | Required.

            try
            {
                // Get Obit From Blockchain
                InlineResponse2002 result = apiInstance.FetchObitFromChain(obitDid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HelperApi.FetchObitFromChain: " + e.Message );
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
 **obitDid** | **string**| Required. | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Blockchain obit response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GenerateObitDef

> InlineResponse2004 GenerateObitDef (string manufacturer, string partNumber, string serialNumber)

Generate Obit Definition

Returns the Obit Definition for a given device_id, part_number and serial_number input.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GenerateObitDefExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new HelperApi(Configuration.Default);
            var manufacturer = Apple;  // string | Device Id (Required)
            var partNumber = 123456789;  // string | Part Number (Required)
            var serialNumber = 123456789;  // string | Serial Number (Required)

            try
            {
                // Generate Obit Definition
                InlineResponse2004 result = apiInstance.GenerateObitDef(manufacturer, partNumber, serialNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HelperApi.GenerateObitDef: " + e.Message );
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
 **manufacturer** | **string**| Device Id (Required) | 
 **partNumber** | **string**| Part Number (Required) | 
 **serialNumber** | **string**| Serial Number (Required) | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Obit definition response |  -  |
| **404** | The request was malformed. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GenerateRootHash

> InlineResponse2003 GenerateRootHash (LocalObit localObit = null)

Generates The Root Hash using the data provided.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GenerateRootHashExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new HelperApi(Configuration.Default);
            var localObit = new LocalObit(); // LocalObit |  (optional) 

            try
            {
                // Generates The Root Hash using the data provided.
                InlineResponse2003 result = apiInstance.GenerateRootHash(localObit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HelperApi.GenerateRootHash: " + e.Message );
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
 **localObit** | [**LocalObit**](LocalObit.md)|  | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Obit root hash response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetClientObit

> InlineResponse2001 GetClientObit (string obitDid)

Get Client Obit

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GetClientObitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new HelperApi(Configuration.Default);
            var obitDid = did:obada:81413bc1ad2074a6ae35d1f65f64f1bca2e8a20959f37ef0349a729ddc567d9b;  // string | Required.

            try
            {
                // Get Client Obit
                InlineResponse2001 result = apiInstance.GetClientObit(obitDid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HelperApi.GetClientObit: " + e.Message );
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
 **obitDid** | **string**| Required. | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client obit response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetClientObits

> InlineResponse200 GetClientObits ()

Returns a list of client obits

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GetClientObitsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new HelperApi(Configuration.Default);

            try
            {
                // Returns a list of client obits
                InlineResponse200 result = apiInstance.GetClientObits();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HelperApi.GetClientObits: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client obits response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SaveClientObit

> InlineResponse2001 SaveClientObit (LocalObit localObit = null)

Save Client Obit

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class SaveClientObitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.api.obada.io";
            var apiInstance = new HelperApi(Configuration.Default);
            var localObit = new LocalObit(); // LocalObit |  (optional) 

            try
            {
                // Save Client Obit
                InlineResponse2001 result = apiInstance.SaveClientObit(localObit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HelperApi.SaveClientObit: " + e.Message );
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
 **localObit** | [**LocalObit**](LocalObit.md)|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client obit response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

