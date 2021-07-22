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
    ///  Class for testing ObitApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObitApiTests
    {
        private ObitApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ObitApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ObitApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ObitApi
            //Assert.IsInstanceOf(typeof(ObitApi), instance);
        }

        
        /// <summary>
        /// Test CreateObit
        /// </summary>
        [Test]
        public void CreateObitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Obit obit = null;
            //var response = instance.CreateObit(obit);
            //Assert.IsInstanceOf(typeof(InlineResponse201), response, "response is InlineResponse201");
        }
        
        /// <summary>
        /// Test RemoveObit
        /// </summary>
        [Test]
        public void RemoveObitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string obitDid = null;
            //instance.RemoveObit(obitDid);
            
        }
        
        /// <summary>
        /// Test SearchObits
        /// </summary>
        [Test]
        public void SearchObitsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serialNumberHash = null;
            //string obitStatus = null;
            //string manufacturer = null;
            //string partNumber = null;
            //string usn = null;
            //string ownerDid = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.SearchObits(serialNumberHash, obitStatus, manufacturer, partNumber, usn, ownerDid, offset, limit);
            //Assert.IsInstanceOf(typeof(InlineResponse2005), response, "response is InlineResponse2005");
        }
        
        /// <summary>
        /// Test ShowObit
        /// </summary>
        [Test]
        public void ShowObitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string obitDid = null;
            //var response = instance.ShowObit(obitDid);
            //Assert.IsInstanceOf(typeof(Obit), response, "response is Obit");
        }
        
        /// <summary>
        /// Test ShowObitHistory
        /// </summary>
        [Test]
        public void ShowObitHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string obitDid = null;
            //var response = instance.ShowObitHistory(obitDid);
            //Assert.IsInstanceOf(typeof(InlineResponse2006), response, "response is InlineResponse2006");
        }
        
        /// <summary>
        /// Test UpdateObit
        /// </summary>
        [Test]
        public void UpdateObitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string obitDid = null;
            //Obit obit = null;
            //instance.UpdateObit(obitDid, obit);
            
        }
        
    }

}
