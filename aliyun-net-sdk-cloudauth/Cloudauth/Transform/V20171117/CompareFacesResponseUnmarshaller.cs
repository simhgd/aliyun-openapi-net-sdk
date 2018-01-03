/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cloudauth.Model.V20171117;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cloudauth.Transform.V20171117
{
    public class CompareFacesResponseUnmarshaller
    {
        public static CompareFacesResponse Unmarshall(UnmarshallerContext context)
        {
			CompareFacesResponse compareFacesResponse = new CompareFacesResponse();

			compareFacesResponse.HttpResponse = context.HttpResponse;
			compareFacesResponse.RequestId = context.StringValue("CompareFaces.RequestId");
			compareFacesResponse.Success = context.BooleanValue("CompareFaces.Success");
			compareFacesResponse.Code = context.StringValue("CompareFaces.Code");
			compareFacesResponse.Message = context.StringValue("CompareFaces.Message");

			CompareFacesResponse.CompareFaces_Data data = new CompareFacesResponse.CompareFaces_Data();
			data.SimilarityScore = context.FloatValue("CompareFaces.Data.SimilarityScore");
			data.ConfidenceThresholds = context.StringValue("CompareFaces.Data.ConfidenceThresholds");
			compareFacesResponse.Data = data;
        
			return compareFacesResponse;
        }
    }
}