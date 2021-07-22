/*
 * OBADA API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: techops@obada.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Obada.Client.Client;
using Obada.Client.Api;
using Obada.Client.Model;

namespace Obada.Client.Test
{
    /// <summary>
    ///  Class for testing HelperApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class HelperApiTests
    {
        private HelperApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HelperApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HelperApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' HelperApi
            //Assert.IsInstanceOf(typeof(HelperApi), instance);
        }

        
        /// <summary>
        /// Test FetchObitFromChain
        /// </summary>
        [Test]
        public void FetchObitFromChainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string obitDid = null;
            //var response = instance.FetchObitFromChain(obitDid);
            //Assert.IsInstanceOf(typeof(InlineResponse2002), response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test GenerateObitDef
        /// </summary>
        [Test]
        public void GenerateObitDefTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string manufacturer = null;
            //string partNumber = null;
            //string serialNumber = null;
            //var response = instance.GenerateObitDef(manufacturer, partNumber, serialNumber);
            //Assert.IsInstanceOf(typeof(InlineResponse2004), response, "response is InlineResponse2004");
        }
        
        /// <summary>
        /// Test GenerateRootHash
        /// </summary>
        [Test]
        public void GenerateRootHashTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocalObit localObit = null;
            //var response = instance.GenerateRootHash(localObit);
            //Assert.IsInstanceOf(typeof(InlineResponse2003), response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test GetClientObit
        /// </summary>
        [Test]
        public void GetClientObitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string obitDid = null;
            //var response = instance.GetClientObit(obitDid);
            //Assert.IsInstanceOf(typeof(InlineResponse2001), response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test GetClientObits
        /// </summary>
        [Test]
        public void GetClientObitsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetClientObits();
            //Assert.IsInstanceOf(typeof(InlineResponse200), response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test SaveClientObit
        /// </summary>
        [Test]
        public void SaveClientObitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocalObit localObit = null;
            //var response = instance.SaveClientObit(localObit);
            //Assert.IsInstanceOf(typeof(InlineResponse2001), response, "response is InlineResponse2001");
        }
        
    }

}