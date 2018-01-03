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
    public class QueryDomainByInstanceIdResponseUnmarshaller
    {
        public static QueryDomainByInstanceIdResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDomainByInstanceIdResponse queryDomainByInstanceIdResponse = new QueryDomainByInstanceIdResponse();

			queryDomainByInstanceIdResponse.HttpResponse = context.HttpResponse;
			queryDomainByInstanceIdResponse.UserId = context.StringValue("QueryDomainByInstanceId.UserId");
			queryDomainByInstanceIdResponse.DomainName = context.StringValue("QueryDomainByInstanceId.DomainName");
			queryDomainByInstanceIdResponse.InstanceId = context.StringValue("QueryDomainByInstanceId.InstanceId");
			queryDomainByInstanceIdResponse.RegistrationDate = context.StringValue("QueryDomainByInstanceId.RegistrationDate");
			queryDomainByInstanceIdResponse.ExpirationDate = context.StringValue("QueryDomainByInstanceId.ExpirationDate");
			queryDomainByInstanceIdResponse.RegistrantOrganization = context.StringValue("QueryDomainByInstanceId.RegistrantOrganization");
			queryDomainByInstanceIdResponse.RegistrantName = context.StringValue("QueryDomainByInstanceId.RegistrantName");
			queryDomainByInstanceIdResponse.Email = context.StringValue("QueryDomainByInstanceId.Email");
			queryDomainByInstanceIdResponse.UpdateProhibitionLock = context.StringValue("QueryDomainByInstanceId.UpdateProhibitionLock");
			queryDomainByInstanceIdResponse.TransferProhibitionLock = context.StringValue("QueryDomainByInstanceId.TransferProhibitionLock");
			queryDomainByInstanceIdResponse.DomainNameProxyService = context.BooleanValue("QueryDomainByInstanceId.DomainNameProxyService");
			queryDomainByInstanceIdResponse.Premium = context.BooleanValue("QueryDomainByInstanceId.Premium");
			queryDomainByInstanceIdResponse.EmailVerificationStatus = context.IntegerValue("QueryDomainByInstanceId.EmailVerificationStatus");
			queryDomainByInstanceIdResponse.EmailVerificationClientHold = context.BooleanValue("QueryDomainByInstanceId.EmailVerificationClientHold");

			List<string> queryDomainByInstanceIdResponse_dnsList = new List<string>();
			for (int i = 0; i < context.Length("QueryDomainByInstanceId.DnsList.Length"); i++) {
				queryDomainByInstanceIdResponse_dnsList.Add(context.StringValue("QueryDomainByInstanceId.DnsList["+ i +"]"));
			}
			queryDomainByInstanceIdResponse.DnsList = queryDomainByInstanceIdResponse_dnsList;
        
			return queryDomainByInstanceIdResponse;
        }
    }
}