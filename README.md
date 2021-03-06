# ChihabHajji.XRoad.Sdk - the C# library for the X-Road Security Server Admin API

X-Road Security Server Admin API. Note that the error metadata responses described in some endpoints are subjects to change and may be updated in upcoming versions.

This C# SDK is automatically generated using NSwag:

- API version: 7.0.1
- SDK version: 1.0.1

## Frameworks supported

.net6.0

## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
        string token = "<YOUR-TOKEN>";
        var clientHandler = new HttpClientHandler();
        // When using docker standalone-security-server, ignore SSL certificate
        clientHandler.ServerCertificateCustomValidationCallback = (_, _, _, _) => true;
        var client = new HttpClient(clientHandler);
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-Road-ApiKey", $"token={token}");
        _instance = new XRoadClient(client)
        {
            BaseUrl = "https://<SECURITY-SERVER-URL>/api/v1",
        };
```

## Documentation for API Endpoints

All URIs are relative to */api/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BackupsApi* | [**AddBackup**](docs/BackupsApi.md#addbackup) | **POST** /backups | add new backup for the security server
*BackupsApi* | [**AddBackupExt**](docs/BackupsApi.md#addbackupext) | **POST** /backups/ext | add new backup for the security server and return extra backup state
*BackupsApi* | [**DeleteBackup**](docs/BackupsApi.md#deletebackup) | **DELETE** /backups/{filename} | delete security server backup
*BackupsApi* | [**DownloadBackup**](docs/BackupsApi.md#downloadbackup) | **GET** /backups/{filename}/download | download security server backup
*BackupsApi* | [**GetBackups**](docs/BackupsApi.md#getbackups) | **GET** /backups | get security server backups
*BackupsApi* | [**RestoreBackup**](docs/BackupsApi.md#restorebackup) | **PUT** /backups/{filename}/restore | restore security server configuration from backup
*BackupsApi* | [**UploadBackup**](docs/BackupsApi.md#uploadbackup) | **POST** /backups/upload | upload new backup for the security server
*CertificateAuthoritiesApi* | [**GetApprovedCertificateAuthorities**](docs/CertificateAuthoritiesApi.md#getapprovedcertificateauthorities) | **GET** /certificate-authorities | view the approved certificate authorities
*CertificateAuthoritiesApi* | [**GetSubjectFieldDescriptions**](docs/CertificateAuthoritiesApi.md#getsubjectfielddescriptions) | **GET** /certificate-authorities/{ca_name}/csr-subject-fields | get description of subject DN fields for CSR
*ClientsApi* | [**AddClient**](docs/ClientsApi.md#addclient) | **POST** /clients | Add new client for the security server.
*ClientsApi* | [**AddClientLocalGroup**](docs/ClientsApi.md#addclientlocalgroup) | **POST** /clients/{id}/local-groups | add new local group for the security server client
*ClientsApi* | [**AddClientServiceDescription**](docs/ClientsApi.md#addclientservicedescription) | **POST** /clients/{id}/service-descriptions | add new service description for the security server client
*ClientsApi* | [**AddClientTlsCertificate**](docs/ClientsApi.md#addclienttlscertificate) | **POST** /clients/{id}/tls-certificates | add new certificate for the security server client
*ClientsApi* | [**AddServiceClientAccessRights**](docs/ClientsApi.md#addserviceclientaccessrights) | **POST** /clients/{id}/service-clients/{sc_id}/access-rights | Add new access rights for selected service client. If service client did not exist yet, one is created.
*ClientsApi* | [**ChangeOwner**](docs/ClientsApi.md#changeowner) | **PUT** /clients/{id}/make-owner | make client Security Server's owner. Client must be a member and already registered on the Security Server
*ClientsApi* | [**DeleteClient**](docs/ClientsApi.md#deleteclient) | **DELETE** /clients/{id} | delete security server client
*ClientsApi* | [**DeleteClientTlsCertificate**](docs/ClientsApi.md#deleteclienttlscertificate) | **DELETE** /clients/{id}/tls-certificates/{hash} | delete certificate
*ClientsApi* | [**DeleteOrphans**](docs/ClientsApi.md#deleteorphans) | **DELETE** /clients/{id}/orphans | delete orphaned sign keys, certificates and csrs left behind a delete client
*ClientsApi* | [**DeleteServiceClientAccessRights**](docs/ClientsApi.md#deleteserviceclientaccessrights) | **POST** /clients/{id}/service-clients/{sc_id}/access-rights/delete | remove access rights
*ClientsApi* | [**FindClients**](docs/ClientsApi.md#findclients) | **GET** /clients | find security server clients
*ClientsApi* | [**FindServiceClientCandidates**](docs/ClientsApi.md#findserviceclientcandidates) | **GET** /clients/{id}/service-client-candidates | find ServiceClient candidates for a specific client
*ClientsApi* | [**GetClient**](docs/ClientsApi.md#getclient) | **GET** /clients/{id} | get security server client information
*ClientsApi* | [**GetClientLocalGroups**](docs/ClientsApi.md#getclientlocalgroups) | **GET** /clients/{id}/local-groups | get local groups for the selected client
*ClientsApi* | [**GetClientOrphans**](docs/ClientsApi.md#getclientorphans) | **GET** /clients/{id}/orphans | get information about orphaned sign keys, certificates and csrs left behind a delete client
*ClientsApi* | [**GetClientServiceClients**](docs/ClientsApi.md#getclientserviceclients) | **GET** /clients/{id}/service-clients | get service clients for the selected client's services
*ClientsApi* | [**GetClientServiceDescriptions**](docs/ClientsApi.md#getclientservicedescriptions) | **GET** /clients/{id}/service-descriptions | get security server client service descriptions
*ClientsApi* | [**GetClientSignCertificates**](docs/ClientsApi.md#getclientsigncertificates) | **GET** /clients/{id}/sign-certificates | get security server client certificates information
*ClientsApi* | [**GetClientTlsCertificate**](docs/ClientsApi.md#getclienttlscertificate) | **GET** /clients/{id}/tls-certificates/{hash} | get TLS certificate
*ClientsApi* | [**GetClientTlsCertificates**](docs/ClientsApi.md#getclienttlscertificates) | **GET** /clients/{id}/tls-certificates | get security server client TLS certificates information
*ClientsApi* | [**GetServiceClient**](docs/ClientsApi.md#getserviceclient) | **GET** /clients/{id}/service-clients/{sc_id} | get single service client by client id and service client id
*ClientsApi* | [**GetServiceClientAccessRights**](docs/ClientsApi.md#getserviceclientaccessrights) | **GET** /clients/{id}/service-clients/{sc_id}/access-rights | get access rights for the selected service client.
*ClientsApi* | [**RegisterClient**](docs/ClientsApi.md#registerclient) | **PUT** /clients/{id}/register | register security server client
*ClientsApi* | [**UnregisterClient**](docs/ClientsApi.md#unregisterclient) | **PUT** /clients/{id}/unregister | unregister security server client
*ClientsApi* | [**UpdateClient**](docs/ClientsApi.md#updateclient) | **PATCH** /clients/{id} | update security server client information
*DiagnosticsApi* | [**GetGlobalConfDiagnostics**](docs/DiagnosticsApi.md#getglobalconfdiagnostics) | **GET** /diagnostics/globalconf | view global configuration diagnostics information
*DiagnosticsApi* | [**GetOcspRespondersDiagnostics**](docs/DiagnosticsApi.md#getocsprespondersdiagnostics) | **GET** /diagnostics/ocsp-responders | view ocsp responders diagnostics information
*DiagnosticsApi* | [**GetTimestampingServicesDiagnostics**](docs/DiagnosticsApi.md#gettimestampingservicesdiagnostics) | **GET** /diagnostics/timestamping-services | view timestamping services diagnostics information
*EndpointsApi* | [**AddEndpointServiceClients**](docs/EndpointsApi.md#addendpointserviceclients) | **POST** /endpoints/{id}/service-clients | add access rights for given service clients to the selected endpoint
*EndpointsApi* | [**DeleteEndpoint**](docs/EndpointsApi.md#deleteendpoint) | **DELETE** /endpoints/{id} | delete endpoint
*EndpointsApi* | [**DeleteEndpointServiceClients**](docs/EndpointsApi.md#deleteendpointserviceclients) | **POST** /endpoints/{id}/service-clients/delete | remove access rights from specified service clients to the selected endpoint
*EndpointsApi* | [**GetEndpoint**](docs/EndpointsApi.md#getendpoint) | **GET** /endpoints/{id} | Get an endpoint by its id
*EndpointsApi* | [**GetEndpointServiceClients**](docs/EndpointsApi.md#getendpointserviceclients) | **GET** /endpoints/{id}/service-clients | get service clients who have access rights for the selected endpoint
*EndpointsApi* | [**UpdateEndpoint**](docs/EndpointsApi.md#updateendpoint) | **PATCH** /endpoints/{id} | Update an endpoint
*InitializationApi* | [**GetInitializationStatus**](docs/InitializationApi.md#getinitializationstatus) | **GET** /initialization/status | Check the initialization status of the Security Server
*InitializationApi* | [**InitSecurityServer**](docs/InitializationApi.md#initsecurityserver) | **POST** /initialization | Initialize a new security server with the provided initial configuration
*KeysApi* | [**DeleteCsr**](docs/KeysApi.md#deletecsr) | **DELETE** /keys/{id}/csrs/{csr_id} | delete csr from the selected key
*KeysApi* | [**DeleteKey**](docs/KeysApi.md#deletekey) | **DELETE** /keys/{id} | delete key
*KeysApi* | [**DownloadCsr**](docs/KeysApi.md#downloadcsr) | **GET** /keys/{id}/csrs/{csr_id} | download a CSR binary
*KeysApi* | [**GenerateCsr**](docs/KeysApi.md#generatecsr) | **POST** /keys/{id}/csrs | generate csr for the selected key
*KeysApi* | [**GetKey**](docs/KeysApi.md#getkey) | **GET** /keys/{id} | get information for the selected key in selected token
*KeysApi* | [**GetPossibleActionsForCsr**](docs/KeysApi.md#getpossibleactionsforcsr) | **GET** /keys/{id}/csrs/{csr_id}/possible-actions | get possible actions for one csr
*KeysApi* | [**GetPossibleActionsForKey**](docs/KeysApi.md#getpossibleactionsforkey) | **GET** /keys/{id}/possible-actions | get possible actions for one key
*KeysApi* | [**UpdateKey**](docs/KeysApi.md#updatekey) | **PATCH** /keys/{id} | update key information
*LanguageApi* | [**Language**](docs/LanguageApi.md#language) | **PUT** /language/{code} | change language
*LocalGroupsApi* | [**AddLocalGroupMember**](docs/LocalGroupsApi.md#addlocalgroupmember) | **POST** /local-groups/{group_id}/members | add new member for the local group
*LocalGroupsApi* | [**DeleteLocalGroup**](docs/LocalGroupsApi.md#deletelocalgroup) | **DELETE** /local-groups/{group_id} | delete local group
*LocalGroupsApi* | [**DeleteLocalGroupMember**](docs/LocalGroupsApi.md#deletelocalgroupmember) | **POST** /local-groups/{group_id}/members/delete | delete member from local group
*LocalGroupsApi* | [**GetLocalGroup**](docs/LocalGroupsApi.md#getlocalgroup) | **GET** /local-groups/{group_id} | get local group information
*LocalGroupsApi* | [**UpdateLocalGroup**](docs/LocalGroupsApi.md#updatelocalgroup) | **PATCH** /local-groups/{group_id} | update local group information
*MemberClassesApi* | [**GetMemberClasses**](docs/MemberClassesApi.md#getmemberclasses) | **GET** /member-classes | get list of known member classes
*MemberClassesApi* | [**GetMemberClassesForInstance**](docs/MemberClassesApi.md#getmemberclassesforinstance) | **GET** /member-classes/{id} | get list of known member classes for a given instance
*MemberNamesApi* | [**FindMemberName**](docs/MemberNamesApi.md#findmembername) | **GET** /member-names | find member name by member class and member code
*OpenapiApi* | [**DownloadOpenApi**](docs/OpenapiApi.md#downloadopenapi) | **GET** /openapi.yaml | download security server's openapi definition
*SecurityServersApi* | [**GetSecurityServer**](docs/SecurityServersApi.md#getsecurityserver) | **GET** /security-servers/{id} | get security server information
*SecurityServersApi* | [**GetSecurityServers**](docs/SecurityServersApi.md#getsecurityservers) | **GET** /security-servers | get all security servers
*ServiceDescriptionsApi* | [**DeleteServiceDescription**](docs/ServiceDescriptionsApi.md#deleteservicedescription) | **DELETE** /service-descriptions/{id} | delete service description
*ServiceDescriptionsApi* | [**DisableServiceDescription**](docs/ServiceDescriptionsApi.md#disableservicedescription) | **PUT** /service-descriptions/{id}/disable | disable selected service description
*ServiceDescriptionsApi* | [**EnableServiceDescription**](docs/ServiceDescriptionsApi.md#enableservicedescription) | **PUT** /service-descriptions/{id}/enable | enable selected service description
*ServiceDescriptionsApi* | [**GetServiceDescription**](docs/ServiceDescriptionsApi.md#getservicedescription) | **GET** /service-descriptions/{id} | get service description with provided id
*ServiceDescriptionsApi* | [**GetServiceDescriptionServices**](docs/ServiceDescriptionsApi.md#getservicedescriptionservices) | **GET** /service-descriptions/{id}/services | get services for the selected service description
*ServiceDescriptionsApi* | [**RefreshServiceDescription**](docs/ServiceDescriptionsApi.md#refreshservicedescription) | **PUT** /service-descriptions/{id}/refresh | refresh selected service description
*ServiceDescriptionsApi* | [**UpdateServiceDescription**](docs/ServiceDescriptionsApi.md#updateservicedescription) | **PATCH** /service-descriptions/{id} | update url or service code for the selected service description
*ServicesApi* | [**AddEndpoint**](docs/ServicesApi.md#addendpoint) | **POST** /services/{id}/endpoints | create endpoint
*ServicesApi* | [**AddServiceServiceClients**](docs/ServicesApi.md#addserviceserviceclients) | **POST** /services/{id}/service-clients | add access rights to selected service for new ServiceClients
*ServicesApi* | [**DeleteServiceServiceClients**](docs/ServicesApi.md#deleteserviceserviceclients) | **POST** /services/{id}/service-clients/delete | remove access to selected service from given ServiceClients
*ServicesApi* | [**GetService**](docs/ServicesApi.md#getservice) | **GET** /services/{id} | get service
*ServicesApi* | [**GetServiceServiceClients**](docs/ServicesApi.md#getserviceserviceclients) | **GET** /services/{id}/service-clients | get service clients who have access rights for the selected service
*ServicesApi* | [**UpdateService**](docs/ServicesApi.md#updateservice) | **PATCH** /services/{id} | update service
*SystemApi* | [**AddConfiguredTimestampingService**](docs/SystemApi.md#addconfiguredtimestampingservice) | **POST** /system/timestamping-services | add a configured timestamping service
*SystemApi* | [**DeleteConfiguredTimestampingService**](docs/SystemApi.md#deleteconfiguredtimestampingservice) | **POST** /system/timestamping-services/delete | delete configured timestamping service
*SystemApi* | [**DownloadAnchor**](docs/SystemApi.md#downloadanchor) | **GET** /system/anchor/download | download configuration anchor information
*SystemApi* | [**DownloadSystemCertificate**](docs/SystemApi.md#downloadsystemcertificate) | **GET** /system/certificate/export | download the security server certificate as gzip compressed tar archive
*SystemApi* | [**GenerateSystemCertificateRequest**](docs/SystemApi.md#generatesystemcertificaterequest) | **POST** /system/certificate/csr | generate new certificate request
*SystemApi* | [**GenerateSystemTlsKeyAndCertificate**](docs/SystemApi.md#generatesystemtlskeyandcertificate) | **POST** /system/certificate | generate a new internal TLS key and cert
*SystemApi* | [**GetAnchor**](docs/SystemApi.md#getanchor) | **GET** /system/anchor | view the configuration anchor information
*SystemApi* | [**GetConfiguredTimestampingServices**](docs/SystemApi.md#getconfiguredtimestampingservices) | **GET** /system/timestamping-services | view the configured timestamping services
*SystemApi* | [**GetNodeType**](docs/SystemApi.md#getnodetype) | **GET** /system/node-type | get the node type
*SystemApi* | [**GetSystemCertificate**](docs/SystemApi.md#getsystemcertificate) | **GET** /system/certificate | view the security server certificate information
*SystemApi* | [**ImportSystemCertificate**](docs/SystemApi.md#importsystemcertificate) | **POST** /system/certificate/import | import new internal TLS certificate.
*SystemApi* | [**PreviewAnchor**](docs/SystemApi.md#previewanchor) | **POST** /system/anchor/previews | Read and the configuration anchor file and return the hash for a preview.
*SystemApi* | [**ReplaceAnchor**](docs/SystemApi.md#replaceanchor) | **PUT** /system/anchor | Upload a configuration anchor file to replace an existing one.
*SystemApi* | [**SystemVersion**](docs/SystemApi.md#systemversion) | **GET** /system/version | get information for the system version
*SystemApi* | [**UploadInitialAnchor**](docs/SystemApi.md#uploadinitialanchor) | **POST** /system/anchor | Upload a new configuration anchor file when initializing a new security server.
*TimestampingServicesApi* | [**GetApprovedTimestampingServices**](docs/TimestampingServicesApi.md#getapprovedtimestampingservices) | **GET** /timestamping-services | view the approved timestamping services
*TokenCertificatesApi* | [**ActivateCertificate**](docs/TokenCertificatesApi.md#activatecertificate) | **PUT** /token-certificates/{hash}/activate | activate certificate
*TokenCertificatesApi* | [**DeleteCertificate**](docs/TokenCertificatesApi.md#deletecertificate) | **DELETE** /token-certificates/{hash} | delete certificate
*TokenCertificatesApi* | [**DisableCertificate**](docs/TokenCertificatesApi.md#disablecertificate) | **PUT** /token-certificates/{hash}/disable | deactivate certificate
*TokenCertificatesApi* | [**GetCertificate**](docs/TokenCertificatesApi.md#getcertificate) | **GET** /token-certificates/{hash} | get certificate information
*TokenCertificatesApi* | [**GetPossibleActionsForCertificate**](docs/TokenCertificatesApi.md#getpossibleactionsforcertificate) | **GET** /token-certificates/{hash}/possible-actions | get possible actions for one certificate
*TokenCertificatesApi* | [**ImportCertificate**](docs/TokenCertificatesApi.md#importcertificate) | **POST** /token-certificates | import new certificate
*TokenCertificatesApi* | [**ImportCertificateFromToken**](docs/TokenCertificatesApi.md#importcertificatefromtoken) | **POST** /token-certificates/{hash}/import | import an existing certificate from a token by cert hash
*TokenCertificatesApi* | [**MarkAuthCertForDeletion**](docs/TokenCertificatesApi.md#markauthcertfordeletion) | **PUT** /token-certificates/{hash}/mark-for-deletion | marks an auth certificate for deletion
*TokenCertificatesApi* | [**RegisterCertificate**](docs/TokenCertificatesApi.md#registercertificate) | **PUT** /token-certificates/{hash}/register | register certificate
*TokenCertificatesApi* | [**UnregisterAuthCertificate**](docs/TokenCertificatesApi.md#unregisterauthcertificate) | **PUT** /token-certificates/{hash}/unregister | unregister authentication certificate
*TokensApi* | [**AddKey**](docs/TokensApi.md#addkey) | **POST** /tokens/{id}/keys | add new key
*TokensApi* | [**AddKeyAndCsr**](docs/TokensApi.md#addkeyandcsr) | **POST** /tokens/{id}/keys-with-csrs | add a new key and generate a csr for it
*TokensApi* | [**GetToken**](docs/TokensApi.md#gettoken) | **GET** /tokens/{id} | get security server token information
*TokensApi* | [**GetTokens**](docs/TokensApi.md#gettokens) | **GET** /tokens | get security server tokens
*TokensApi* | [**LoginToken**](docs/TokensApi.md#logintoken) | **PUT** /tokens/{id}/login | login to token
*TokensApi* | [**LogoutToken**](docs/TokensApi.md#logouttoken) | **PUT** /tokens/{id}/logout | logout from token
*TokensApi* | [**UpdateToken**](docs/TokensApi.md#updatetoken) | **PATCH** /tokens/{id} | update security server token information
*TokensApi* | [**UpdateTokenPin**](docs/TokensApi.md#updatetokenpin) | **PUT** /tokens/{id}/pin | update security server software token pin code
*UserApi* | [**GetUser**](docs/UserApi.md#getuser) | **GET** /user | get user data for the logged user
*XroadInstancesApi* | [**GetXroadInstances**](docs/XroadInstancesApi.md#getxroadinstances) | **GET** /xroad-instances | get list of known xroad instance identifiers


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccessRight](docs/AccessRight.md)
 - [Model.AccessRights](docs/AccessRights.md)
 - [Model.Anchor](docs/Anchor.md)
 - [Model.Backup](docs/Backup.md)
 - [Model.BackupExt](docs/BackupExt.md)
 - [Model.CertificateAuthority](docs/CertificateAuthority.md)
 - [Model.CertificateAuthorityOcspResponse](docs/CertificateAuthorityOcspResponse.md)
 - [Model.CertificateDetails](docs/CertificateDetails.md)
 - [Model.CertificateOcspStatus](docs/CertificateOcspStatus.md)
 - [Model.CertificateStatus](docs/CertificateStatus.md)
 - [Model.ClientAdd](docs/ClientAdd.md)
 - [Model.ClientStatus](docs/ClientStatus.md)
 - [Model.CodeWithDetails](docs/CodeWithDetails.md)
 - [Model.ConfigurationStatus](docs/ConfigurationStatus.md)
 - [Model.ConnectionType](docs/ConnectionType.md)
 - [Model.ConnectionTypeWrapper](docs/ConnectionTypeWrapper.md)
 - [Model.CsrFormat](docs/CsrFormat.md)
 - [Model.CsrGenerate](docs/CsrGenerate.md)
 - [Model.CsrSubjectFieldDescription](docs/CsrSubjectFieldDescription.md)
 - [Model.DiagnosticStatusClass](docs/DiagnosticStatusClass.md)
 - [Model.DistinguishedName](docs/DistinguishedName.md)
 - [Model.Endpoint](docs/Endpoint.md)
 - [Model.EndpointUpdate](docs/EndpointUpdate.md)
 - [Model.ErrorInfo](docs/ErrorInfo.md)
 - [Model.GlobalConfDiagnostics](docs/GlobalConfDiagnostics.md)
 - [Model.GroupMember](docs/GroupMember.md)
 - [Model.IgnoreWarnings](docs/IgnoreWarnings.md)
 - [Model.InitialServerConf](docs/InitialServerConf.md)
 - [Model.InitializationStatus](docs/InitializationStatus.md)
 - [Model.Key](docs/Key.md)
 - [Model.KeyLabel](docs/KeyLabel.md)
 - [Model.KeyLabelWithCsrGenerate](docs/KeyLabelWithCsrGenerate.md)
 - [Model.KeyName](docs/KeyName.md)
 - [Model.KeyUsage](docs/KeyUsage.md)
 - [Model.KeyUsageType](docs/KeyUsageType.md)
 - [Model.KeyValuePair](docs/KeyValuePair.md)
 - [Model.KeyWithCertificateSigningRequestId](docs/KeyWithCertificateSigningRequestId.md)
 - [Model.Language](docs/Language.md)
 - [Model.LocalGroup](docs/LocalGroup.md)
 - [Model.LocalGroupAdd](docs/LocalGroupAdd.md)
 - [Model.LocalGroupDescription](docs/LocalGroupDescription.md)
 - [Model.MemberName](docs/MemberName.md)
 - [Model.Members](docs/Members.md)
 - [Model.ModelClient](docs/ModelClient.md)
 - [Model.NodeType](docs/NodeType.md)
 - [Model.NodeTypeResponse](docs/NodeTypeResponse.md)
 - [Model.OcspResponder](docs/OcspResponder.md)
 - [Model.OcspResponderDiagnostics](docs/OcspResponderDiagnostics.md)
 - [Model.OcspStatus](docs/OcspStatus.md)
 - [Model.OrphanInformation](docs/OrphanInformation.md)
 - [Model.PossibleAction](docs/PossibleAction.md)
 - [Model.SecurityServer](docs/SecurityServer.md)
 - [Model.SecurityServerAddress](docs/SecurityServerAddress.md)
 - [Model.Service](docs/Service.md)
 - [Model.ServiceClient](docs/ServiceClient.md)
 - [Model.ServiceClientType](docs/ServiceClientType.md)
 - [Model.ServiceClients](docs/ServiceClients.md)
 - [Model.ServiceDescription](docs/ServiceDescription.md)
 - [Model.ServiceDescriptionAdd](docs/ServiceDescriptionAdd.md)
 - [Model.ServiceDescriptionDisabledNotice](docs/ServiceDescriptionDisabledNotice.md)
 - [Model.ServiceDescriptionUpdate](docs/ServiceDescriptionUpdate.md)
 - [Model.ServiceType](docs/ServiceType.md)
 - [Model.ServiceUpdate](docs/ServiceUpdate.md)
 - [Model.TimestampingService](docs/TimestampingService.md)
 - [Model.TimestampingServiceDiagnostics](docs/TimestampingServiceDiagnostics.md)
 - [Model.TimestampingStatus](docs/TimestampingStatus.md)
 - [Model.Token](docs/Token.md)
 - [Model.TokenCertificate](docs/TokenCertificate.md)
 - [Model.TokenCertificateSigningRequest](docs/TokenCertificateSigningRequest.md)
 - [Model.TokenInitStatus](docs/TokenInitStatus.md)
 - [Model.TokenName](docs/TokenName.md)
 - [Model.TokenPassword](docs/TokenPassword.md)
 - [Model.TokenPinUpdate](docs/TokenPinUpdate.md)
 - [Model.TokenStatus](docs/TokenStatus.md)
 - [Model.TokenType](docs/TokenType.md)
 - [Model.TokensLoggedOut](docs/TokensLoggedOut.md)
 - [Model.User](docs/User.md)
 - [Model.VersionInfo](docs/VersionInfo.md)

### Integration with official x-road documentation
    Feel free to contribute!

