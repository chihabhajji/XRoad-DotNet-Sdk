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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Api;
// uncomment below to import models
//using ChihabHajji.XRoad.Sdk.Model;

namespace ChihabHajji.XRoad.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing LanguageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LanguageApiTests : IDisposable
    {
        private LanguageApi instance;

        public LanguageApiTests()
        {
            instance = new LanguageApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LanguageApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LanguageApi
            //Assert.IsType<LanguageApi>(instance);
        }

        /// <summary>
        /// Test Language
        /// </summary>
        [Fact]
        public void LanguageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string code = null;
            //var response = instance.Language(code);
            //Assert.IsType<Language>(response);
        }
    }
}
