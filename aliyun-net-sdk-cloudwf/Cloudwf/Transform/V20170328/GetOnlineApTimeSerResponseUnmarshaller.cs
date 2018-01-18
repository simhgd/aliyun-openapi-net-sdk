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
using Aliyun.Acs.cloudwf.Model.V20170328;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.cloudwf.Transform.V20170328
{
    public class GetOnlineApTimeSerResponseUnmarshaller
    {
        public static GetOnlineApTimeSerResponse Unmarshall(UnmarshallerContext context)
        {
			GetOnlineApTimeSerResponse getOnlineApTimeSerResponse = new GetOnlineApTimeSerResponse();

			getOnlineApTimeSerResponse.HttpResponse = context.HttpResponse;
			getOnlineApTimeSerResponse.RequestId = context.StringValue("GetOnlineApTimeSer.RequestId");
			getOnlineApTimeSerResponse.Success = context.BooleanValue("GetOnlineApTimeSer.Success");
			getOnlineApTimeSerResponse.Message = context.StringValue("GetOnlineApTimeSer.Message");
			getOnlineApTimeSerResponse.Data = context.StringValue("GetOnlineApTimeSer.Data");
			getOnlineApTimeSerResponse.ErrorCode = context.IntegerValue("GetOnlineApTimeSer.ErrorCode");
			getOnlineApTimeSerResponse.ErrorMsg = context.StringValue("GetOnlineApTimeSer.ErrorMsg");
        
			return getOnlineApTimeSerResponse;
        }
    }
}