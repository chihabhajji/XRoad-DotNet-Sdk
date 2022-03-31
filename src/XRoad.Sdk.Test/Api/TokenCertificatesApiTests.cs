/*
 * X-Road Security Server Admin API
 *
 * X-Road Security Server Admin API. Note that the error metadata responses described in some endpoints are subjects to change and may be updated in upcoming versions.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: info@niis.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using XRoad.Sdk.Api;
using Xunit;

// uncomment below to import models
//using XRoad.Sdk.Model;

namespace XRoad.Sdk.Test.Api;

/// <summary>
///  Class for testing TokenCertificatesApi
/// </summary>
/// <remarks>
/// Please update the test case below to test the API endpoint.
/// </remarks>
public class TokenCertificatesApiTests : IDisposable
{
    private TokenCertificatesApi instance;

    public TokenCertificatesApiTests()
    {
        instance = new TokenCertificatesApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    /// Test an instance of TokenCertificatesApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' TokenCertificatesApi
        //Assert.IsType<TokenCertificatesApi>(instance);
    }

    /// <summary>
    /// Test ActivateCertificate
    /// </summary>
    [Fact]
    public void ActivateCertificateTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string hash = null;
        //instance.ActivateCertificate(hash);
    }

    /// <summary>
    /// Test DeleteCertificate
    /// </summary>
    [Fact]
    public void DeleteCertificateTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string hash = null;
        //instance.DeleteCertificate(hash);
    }

    /// <summary>
    /// Test DisableCertificate
    /// </summary>
    [Fact]
    public void DisableCertificateTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string hash = null;
        //instance.DisableCertificate(hash);
    }

    /// <summary>
    /// Test GetCertificate
    /// </summary>
    [Fact]
    public void GetCertificateTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string hash = null;
        //var response = instance.GetCertificate(hash);
        //Assert.IsType<TokenCertificate>(response);
    }

    /// <summary>
    /// Test GetPossibleActionsForCertificate
    /// </summary>
    [Fact]
    public void GetPossibleActionsForCertificateTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string hash = null;
        //var response = instance.GetPossibleActionsForCertificate(hash);
        //Assert.IsType<List<PossibleAction>>(response);
    }

    /// <summary>
    /// Test ImportCertificate
    /// </summary>
    [Fact]
    public void ImportCertificateTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //System.IO.Stream body = null;
        //var response = instance.ImportCertificate(body);
        //Assert.IsType<TokenCertificate>(response);
    }

    /// <summary>
    /// Test ImportCertificateFromToken
    /// </summary>
    [Fact]
    public void ImportCertificateFromTokenTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string hash = null;
        //var response = instance.ImportCertificateFromToken(hash);
        //Assert.IsType<TokenCertificate>(response);
    }

    /// <summary>
    /// Test MarkAuthCertForDeletion
    /// </summary>
    [Fact]
    public void MarkAuthCertForDeletionTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string hash = null;
        //instance.MarkAuthCertForDeletion(hash);
    }

    /// <summary>
    /// Test RegisterCertificate
    /// </summary>
    [Fact]
    public void RegisterCertificateTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string hash = null;
        //SecurityServerAddress securityServerAddress = null;
        //instance.RegisterCertificate(hash, securityServerAddress);
    }

    /// <summary>
    /// Test UnregisterAuthCertificate
    /// </summary>
    [Fact]
    public void UnregisterAuthCertificateTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string hash = null;
        //instance.UnregisterAuthCertificate(hash);
    }
}