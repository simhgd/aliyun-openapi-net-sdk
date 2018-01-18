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
using Aliyun.Acs.Sas_api.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Sas_api.Transform.V20170705
{
    public class CreateInstanceResponseUnmarshaller
    {
        public static CreateInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			CreateInstanceResponse createInstanceResponse = new CreateInstanceResponse();

			createInstanceResponse.HttpResponse = context.HttpResponse;
			createInstanceResponse.Code = context.StringValue("CreateInstance.Code");
			createInstanceResponse.Message = context.StringValue("CreateInstance.Message");
			createInstanceResponse.OrderId = context.StringValue("CreateInstance.OrderId");
			createInstanceResponse.InstanceId = context.StringValue("CreateInstance.InstanceId");
			createInstanceResponse.RequestId = context.StringValue("CreateInstance.RequestId");

			List<string> createInstanceResponse_instanceIds = new List<string>();
			for (int i = 0; i < context.Length("CreateInstance.InstanceIds.Length"); i++) {
				createInstanceResponse_instanceIds.Add(context.StringValue("CreateInstance.InstanceIds["+ i +"]"));
			}
			createInstanceResponse.InstanceIds = createInstanceResponse_instanceIds;
        
			return createInstanceResponse;
        }
    }
}