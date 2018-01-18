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
using Aliyun.Acs.Sas_api.Transform;
using Aliyun.Acs.Sas_api.Transform.V20170705;
using System.Collections.Generic;

namespace Aliyun.Acs.Sas_api.Model.V20170705
{
    public class RenewInstanceRequest : RpcAcsRequest<RenewInstanceResponse>
    {
        public RenewInstanceRequest()
            : base("Sas_api", "2017-07-05", "RenewInstance")
        {
        }

		private int? duration;

		private string instanceId;

		private string clientToken;

		private int? buyNumber;

		private long? ownerId;

		private string pricingCycle;

		public int? Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
				DictionaryUtil.Add(QueryParameters, "Duration", value.ToString());
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public int? BuyNumber
		{
			get
			{
				return buyNumber;
			}
			set	
			{
				buyNumber = value;
				DictionaryUtil.Add(QueryParameters, "BuyNumber", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string PricingCycle
		{
			get
			{
				return pricingCycle;
			}
			set	
			{
				pricingCycle = value;
				DictionaryUtil.Add(QueryParameters, "PricingCycle", value);
			}
		}

        public override RenewInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RenewInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}