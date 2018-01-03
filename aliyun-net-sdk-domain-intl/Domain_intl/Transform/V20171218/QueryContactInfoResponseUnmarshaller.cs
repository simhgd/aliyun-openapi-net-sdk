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
using Aliyun.Acs.Domain_intl.Model.V20171218;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain_intl.Transform.V20171218
{
    public class QueryContactInfoResponseUnmarshaller
    {
        public static QueryContactInfoResponse Unmarshall(UnmarshallerContext context)
        {
			QueryContactInfoResponse queryContactInfoResponse = new QueryContactInfoResponse();

			queryContactInfoResponse.HttpResponse = context.HttpResponse;
			queryContactInfoResponse.RequestId = context.StringValue("QueryContactInfo.RequestId");
			queryContactInfoResponse.CreateDate = context.StringValue("QueryContactInfo.CreateDate");
			queryContactInfoResponse.RegistrantName = context.StringValue("QueryContactInfo.RegistrantName");
			queryContactInfoResponse.RegistrantOrganization = context.StringValue("QueryContactInfo.RegistrantOrganization");
			queryContactInfoResponse.Country = context.StringValue("QueryContactInfo.Country");
			queryContactInfoResponse.Province = context.StringValue("QueryContactInfo.Province");
			queryContactInfoResponse.City = context.StringValue("QueryContactInfo.City");
			queryContactInfoResponse.Address = context.StringValue("QueryContactInfo.Address");
			queryContactInfoResponse.Email = context.StringValue("QueryContactInfo.Email");
			queryContactInfoResponse.PostalCode = context.StringValue("QueryContactInfo.PostalCode");
			queryContactInfoResponse.TelArea = context.StringValue("QueryContactInfo.TelArea");
			queryContactInfoResponse.Telephone = context.StringValue("QueryContactInfo.Telephone");
			queryContactInfoResponse.TelExt = context.StringValue("QueryContactInfo.TelExt");
        
			return queryContactInfoResponse;
        }
    }
}