
# Obada.Client.Model.Obit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObitDid** | **string** | OBADA decentralized identifier | [optional] 
**Usn** | **string** | Test An 8-12 character “URL Shortened” obit. Create the USN by Base(58) encoding the OBIT ID. Take the first 8 characters. Check for duplicates. With 16 million OBITs there is a 40% chance of collision. If so, add 4 characters. Repeat as necessary until a unique USN is generated.  | [optional] 
**ObitAlternateIds** | **List&lt;string&gt;** | Client generated things. First hash + last hash | [optional] 
**OwnerDid** | **string** | Owner is the person/entity that owns the obit and the physical asset it represents. Format is a DID like did:obada:owner:1234. However in the current version only test numbers will be used. | 
**ObdDid** | **string** | Future use. The OBD DID is formatted like did:obada:obd:1234, which represents a utility token tracking orders and proofs. | [optional] 
**ObitStatus** | **string** | Represent available Obit statuses:   - FUNCTIONAL   - NON_FUNCTIONAL   - DISPOSED   - STOLEN   - DISABLED_BY_OWNER  | [optional] 
**Manufacturer** | **string** | Waiting more specific details from Rohi | 
**PartNumber** | **string** | Manufacturer provided. In cases where no part number is provided for the product, use model, or the most specific ID available from the manufacturer. MWCN2LL/A (an iPhone 11 Pro, Silver, 256GB, model A2160) | 
**SerialNumberHash** | **string** | Serial number hashed with sha256 hash function | 
**Metadata** | [**List&lt;MetaDataRecord&gt;**](MetaDataRecord.md) | Get description from Rohi | [optional] 
**DocLinks** | [**List&lt;DocumentLink&gt;**](DocumentLink.md) | To generate this link, take an SHA-256 hash of the document, and link to it as https://www.some-website.com?h1&#x3D;hash-of-document. Note this does not yet adhere to the hashlink standard.  | [optional] 
**StructuredData** | [**List&lt;StructureDataRecord&gt;**](StructureDataRecord.md) | Same as metadata but bigger. Key (string) &#x3D;&gt; Value (string) (hash per line sha256(key + value)) | [optional] 
**ModifiedOn** | **long** | UNIX timestamp | [optional] 
**Checksum** | **string** | Hash calculated by SHA256 (previous Obit checksum + Obit data).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

