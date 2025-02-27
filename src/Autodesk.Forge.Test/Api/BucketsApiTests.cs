/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *

 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Autodesk.Forge.Client;
using Autodesk.Forge;
using Autodesk.Forge.Model;

namespace Autodesk.Forge.Test
{
    /// <summary>
    ///  Class for testing BucketsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BucketsApiTests
    {
        private BucketsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BucketsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BucketsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BucketsApi
            //Assert.IsInstanceOfType(typeof(BucketsApi), instance, "instance is a BucketsApi");
        }

        
        /// <summary>
        /// Test CreateBucket
        /// </summary>
        [Test]
        public void CreateBucketTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostBucketsPayload postBuckets = null;
            //string xAdsRegion = null;
            //var response = instance.CreateBucket(postBuckets, xAdsRegion);
            //Assert.IsInstanceOf<Bucket> (response, "response is Bucket");
        }
        
        /// <summary>
        /// Test DeleteBucket
        /// </summary>
        [Test]
        public void DeleteBucketTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketKey = null;
            //instance.DeleteBucket(bucketKey);
            
        }
        
        /// <summary>
        /// Test GetBucketDetails
        /// </summary>
        [Test]
        public void GetBucketDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketKey = null;
            //var response = instance.GetBucketDetails(bucketKey);
            //Assert.IsInstanceOf<Bucket> (response, "response is Bucket");
        }
        
        /// <summary>
        /// Test GetBuckets
        /// </summary>
        [Test]
        public void GetBucketsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string region = null;
            //int? limit = null;
            //string startAt = null;
            //var response = instance.GetBuckets(region, limit, startAt);
            //Assert.IsInstanceOf<Buckets> (response, "response is Buckets");
        }
        
    }

}
