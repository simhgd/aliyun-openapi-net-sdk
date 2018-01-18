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
using Aliyun.Acs.Cms.Model.V20170301;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20170301
{
    public class DeleteNotifyPolicyResponseUnmarshaller
    {
        public static DeleteNotifyPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteNotifyPolicyResponse deleteNotifyPolicyResponse = new DeleteNotifyPolicyResponse();

			deleteNotifyPolicyResponse.HttpResponse = context.HttpResponse;
			deleteNotifyPolicyResponse.Code = context.StringValue("DeleteNotifyPolicy.Code");
			deleteNotifyPolicyResponse.Message = context.StringValue("DeleteNotifyPolicy.Message");
			deleteNotifyPolicyResponse.Success = context.StringValue("DeleteNotifyPolicy.Success");
			deleteNotifyPolicyResponse.TraceId = context.StringValue("DeleteNotifyPolicy.TraceId");
			deleteNotifyPolicyResponse.Result = context.IntegerValue("DeleteNotifyPolicy.Result");
        
			return deleteNotifyPolicyResponse;
        }
    }
}