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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class AssociateGlobalAccelerationInstanceRequest : RpcAcsRequest<AssociateGlobalAccelerationInstanceResponse>
    {
        public AssociateGlobalAccelerationInstanceRequest()
            : base("Vpc", "2016-04-28", "AssociateGlobalAccelerationInstance", "vpc", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string regionId;

		private string ownerAccount;

		private string action;

		private string backendServerId;

		private long? ownerId;

		private string globalAccelerationInstanceId;

		private string backendServerRegionId;

		private string backendServerType;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string BackendServerId
		{
			get
			{
				return backendServerId;
			}
			set	
			{
				backendServerId = value;
				DictionaryUtil.Add(QueryParameters, "BackendServerId", value);
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

		public string GlobalAccelerationInstanceId
		{
			get
			{
				return globalAccelerationInstanceId;
			}
			set	
			{
				globalAccelerationInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "GlobalAccelerationInstanceId", value);
			}
		}

		public string BackendServerRegionId
		{
			get
			{
				return backendServerRegionId;
			}
			set	
			{
				backendServerRegionId = value;
				DictionaryUtil.Add(QueryParameters, "BackendServerRegionId", value);
			}
		}

		public string BackendServerType
		{
			get
			{
				return backendServerType;
			}
			set	
			{
				backendServerType = value;
				DictionaryUtil.Add(QueryParameters, "BackendServerType", value);
			}
		}

        public override AssociateGlobalAccelerationInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AssociateGlobalAccelerationInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}