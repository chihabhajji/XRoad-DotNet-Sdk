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
    ///  Class for testing EndpointsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EndpointsApiTests : IDisposable
    {
        private EndpointsApi instance;

        public EndpointsApiTests()
        {
            instance = new EndpointsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EndpointsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EndpointsApi
            //Assert.IsType<EndpointsApi>(instance);
        }

        /// <summary>
        /// Test AddEndpointServiceClients
        /// </summary>
        [Fact]
        public void AddEndpointServiceClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ServiceClients serviceClients = null;
            //var response = instance.AddEndpointServiceClients(id, serviceClients);
            //Assert.IsType<List<ServiceClient>>(response);
        }

        /// <summary>
        /// Test DeleteEndpoint
        /// </summary>
        [Fact]
        public void DeleteEndpointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteEndpoint(id);
        }

        /// <summary>
        /// Test DeleteEndpointServiceClients
        /// </summary>
        [Fact]
        public void DeleteEndpointServiceClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ServiceClients serviceClients = null;
            //instance.DeleteEndpointServiceClients(id, serviceClients);
        }

        /// <summary>
        /// Test GetEndpoint
        /// </summary>
        [Fact]
        public void GetEndpointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetEndpoint(id);
            //Assert.IsType<Endpoint>(response);
        }

        /// <summary>
        /// Test GetEndpointServiceClients
        /// </summary>
        [Fact]
        public void GetEndpointServiceClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetEndpointServiceClients(id);
            //Assert.IsType<List<ServiceClient>>(response);
        }

        /// <summary>
        /// Test UpdateEndpoint
        /// </summary>
        [Fact]
        public void UpdateEndpointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EndpointUpdate endpointUpdate = null;
            //var response = instance.UpdateEndpoint(id, endpointUpdate);
            //Assert.IsType<Endpoint>(response);
        }
    }
}