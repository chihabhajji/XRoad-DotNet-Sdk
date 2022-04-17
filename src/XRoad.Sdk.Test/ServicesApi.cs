/*
 * X-Road Security Server Admin API
 *
 * X-Road Security Server Admin API. Note that the error metadata responses described in some endpoints are subjects to change and may be updated in upcoming versions.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: info@niis.org
 */

using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Xunit;

namespace XRoad.Sdk.Test;

/// <summary>
///  Class for testing ServicesApi
/// </summary>
/// <remarks>
/// Please update the test case below to test the API endpoint.
/// </remarks>
public class ServicesApiTests
{
    private readonly XRoadClient _instance;
    public ServicesApiTests()
    {
        string token = "d0d6da7f-f73d-467b-98b6-1e6bc0a9876f";
        var clientHandler = new HttpClientHandler();
        // When using docker standalone-security-server, ignore SSL certificate
        clientHandler.ServerCertificateCustomValidationCallback = (_, _, _, _) => true;
        var client = new HttpClient(clientHandler);
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-Road-ApiKey", $"token={token}");
        _instance = new XRoadClient(client)
        {
            BaseUrl = "https://localhost:4000/api/v1",
        };
    }
    
    /// <summary>
    /// Test an instance of ServicesApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        Assert.IsType<XRoadClient>(_instance);
    }


    /// <summary>
    /// Test GetService
    /// </summary>
    [Fact]
    public async Task GetServiceTest()
    {
        var response = await _instance.FindClientsAsync(null,null,null,null,null,null,null,null,null, CancellationToken.None);
        Assert.NotNull(response);
    }
}