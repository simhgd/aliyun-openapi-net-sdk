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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class CopyImageRequest : RpcAcsRequest<CopyImageResponse>
    {
        public CopyImageRequest()
            : base("Ecs", "2014-05-26", "CopyImage", "ecs", "openAPI")
        {
        }

		private string tag4Value;

		private long? resourceOwnerId;

		private string imageId;

		private string tag2Key;

		private string tag5Key;

		private string resourceOwnerAccount;

		private string destinationImageName;

		private string destinationRegionId;

		private string ownerAccount;

		private string tag3Key;

		private long? ownerId;

		private string tag5Value;

		private string tag1Key;

		private string tag1Value;

		private bool? encrypted;

		private string regionId;

		private string tag2Value;

		private string action;

		private string tag4Key;

		private string destinationDescription;

		private string tag3Value;

		public string Tag4Value
		{
			get
			{
				return tag4Value;
			}
			set	
			{
				tag4Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.Value", value);
			}
		}

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

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public string Tag2Key
		{
			get
			{
				return tag2Key;
			}
			set	
			{
				tag2Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.Key", value);
			}
		}

		public string Tag5Key
		{
			get
			{
				return tag5Key;
			}
			set	
			{
				tag5Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.Key", value);
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

		public string DestinationImageName
		{
			get
			{
				return destinationImageName;
			}
			set	
			{
				destinationImageName = value;
				DictionaryUtil.Add(QueryParameters, "DestinationImageName", value);
			}
		}

		public string DestinationRegionId
		{
			get
			{
				return destinationRegionId;
			}
			set	
			{
				destinationRegionId = value;
				DictionaryUtil.Add(QueryParameters, "DestinationRegionId", value);
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

		public string Tag3Key
		{
			get
			{
				return tag3Key;
			}
			set	
			{
				tag3Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.Key", value);
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

		public string Tag5Value
		{
			get
			{
				return tag5Value;
			}
			set	
			{
				tag5Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.Value", value);
			}
		}

		public string Tag1Key
		{
			get
			{
				return tag1Key;
			}
			set	
			{
				tag1Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.Key", value);
			}
		}

		public string Tag1Value
		{
			get
			{
				return tag1Value;
			}
			set	
			{
				tag1Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.Value", value);
			}
		}

		public bool? Encrypted
		{
			get
			{
				return encrypted;
			}
			set	
			{
				encrypted = value;
				DictionaryUtil.Add(QueryParameters, "Encrypted", value.ToString());
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

		public string Tag2Value
		{
			get
			{
				return tag2Value;
			}
			set	
			{
				tag2Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.Value", value);
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

		public string Tag4Key
		{
			get
			{
				return tag4Key;
			}
			set	
			{
				tag4Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.Key", value);
			}
		}

		public string DestinationDescription
		{
			get
			{
				return destinationDescription;
			}
			set	
			{
				destinationDescription = value;
				DictionaryUtil.Add(QueryParameters, "DestinationDescription", value);
			}
		}

		public string Tag3Value
		{
			get
			{
				return tag3Value;
			}
			set	
			{
				tag3Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.Value", value);
			}
		}

        public override CopyImageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CopyImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}