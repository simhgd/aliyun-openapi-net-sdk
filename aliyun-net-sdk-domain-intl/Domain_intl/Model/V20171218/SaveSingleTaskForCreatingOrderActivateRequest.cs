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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain_intl.Transform;
using Aliyun.Acs.Domain_intl.Transform.V20171218;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
    public class SaveSingleTaskForCreatingOrderActivateRequest : RpcAcsRequest<SaveSingleTaskForCreatingOrderActivateResponse>
    {
        public SaveSingleTaskForCreatingOrderActivateRequest()
            : base("Domain_intl", "2017-12-18", "SaveSingleTaskForCreatingOrderActivate", "domain", "openAPI")
        {
        }

		private int? subscriptionDuration;

		private bool? permitPremiumActivation;

		private string userClientIp;

		private string domainName;

		private long? registrantProfileId;

		private bool? enableDomainProxy;

		private string lang;

		public int? SubscriptionDuration
		{
			get
			{
				return subscriptionDuration;
			}
			set	
			{
				subscriptionDuration = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionDuration", value.ToString());
			}
		}

		public bool? PermitPremiumActivation
		{
			get
			{
				return permitPremiumActivation;
			}
			set	
			{
				permitPremiumActivation = value;
				DictionaryUtil.Add(QueryParameters, "PermitPremiumActivation", value.ToString());
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public long? RegistrantProfileId
		{
			get
			{
				return registrantProfileId;
			}
			set	
			{
				registrantProfileId = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantProfileId", value.ToString());
			}
		}

		public bool? EnableDomainProxy
		{
			get
			{
				return enableDomainProxy;
			}
			set	
			{
				enableDomainProxy = value;
				DictionaryUtil.Add(QueryParameters, "EnableDomainProxy", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveSingleTaskForCreatingOrderActivateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveSingleTaskForCreatingOrderActivateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}