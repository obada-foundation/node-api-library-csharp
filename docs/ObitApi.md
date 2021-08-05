# Obada.Client.Api.ObitApi

All URIs are relative to *http://obs.node.obada.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Checksum**](ObitApi.md#checksum) | **POST** /obit/checksum | Generates Obit checksum
[**GenerateDID**](ObitApi.md#generatedid) | **POST** /obit/did | Generate Obit DID
[**Get**](ObitApi.md#get) | **GET** /obits/{obit_did} | Get Obit by DID or USN
[**History**](ObitApi.md#history) | **GET** /obits/{obit_did}/history | Get Obit history by DID or USN
[**Save**](ObitApi.md#save) | **POST** /obits | Save Obit
[**Search**](ObitApi.md#search) | **GET** /obits | Search obits by query



## Checksum

> Checksum Checksum (Obit obit = null)

Generates Obit checksum

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class ChecksumExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var obit = new Obit(); // Obit |  (optional) 

            try
            {
                // Generates Obit checksum
                Checksum result = apiInstance.Checksum(obit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.Checksum: " + e.Message );
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

[**Checksum**](Checksum.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Obit checksum response |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GenerateDID

> ObitDID GenerateDID (RequestObitDID requestObitDID = null)

Generate Obit DID

Returns the Obit DID for a given device_id, part_number and serial_number input.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GenerateDIDExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var requestObitDID = new RequestObitDID(); // RequestObitDID |  (optional) 

            try
            {
                // Generate Obit DID
                ObitDID result = apiInstance.GenerateDID(requestObitDID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.GenerateDID: " + e.Message );
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
 **requestObitDID** | [**RequestObitDID**](RequestObitDID.md)|  | [optional] 

### Return type

[**ObitDID**](ObitDID.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Obit DID response |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Get

> Obit Get (string obitDid)

Get Obit by DID or USN

Get a single Obit by given ObitDID or USN

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var obitDid = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID or USN argument

            try
            {
                // Get Obit by DID or USN
                Obit result = apiInstance.Get(obitDid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.Get: " + e.Message );
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
 **obitDid** | **string**| The given ObitDID or USN argument | 

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
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## History

> InlineResponse200 History (string obitDid)

Get Obit history by DID or USN

Shows the history of changes by given Obit with ObitDID or USN

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class HistoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var obitDid = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID or USN argument

            try
            {
                // Get Obit history by DID or USN
                InlineResponse200 result = apiInstance.History(obitDid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.History: " + e.Message );
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
 **obitDid** | **string**| The given ObitDID or USN argument | 

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
| **200** | Collection of historical changes for given obit |  -  |
| **404** | The requested resource could not be found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Save

> void Save (Obit obit = null)

Save Obit

Returns Obit with updated checksum if data was changed.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class SaveExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var obit = new Obit(); // Obit |  (optional) 

            try
            {
                // Save Obit
                apiInstance.Save(obit);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.Save: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Search

> Obits Search (string q = null, int? offset = null)

Search obits by query

Implements a fulltext search for obits by \"searchTerm\".

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class SearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            var apiInstance = new ObitApi(Configuration.Default);
            var q = fe403a1afe16203f4b8bb3a0e72d3e17567897bc15293e4a87b663e441030aea;  // string | Query argument that used for a fulltext search (optional) 
            var offset = 56;  // int? | Number of records to skip for pagination. (optional)  (default to 0)

            try
            {
                // Search obits by query
                Obits result = apiInstance.Search(q, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.Search: " + e.Message );
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
 **q** | **string**| Query argument that used for a fulltext search | [optional] 
 **offset** | **int?**| Number of records to skip for pagination. | [optional] [default to 0]

### Return type

[**Obits**](Obits.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of obits with pagination responded by given arguments. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

