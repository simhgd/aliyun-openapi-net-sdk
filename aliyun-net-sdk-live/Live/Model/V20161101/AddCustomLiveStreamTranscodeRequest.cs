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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class AddCustomLiveStreamTranscodeRequest : RpcAcsRequest<AddCustomLiveStreamTranscodeResponse>
    {
        public AddCustomLiveStreamTranscodeRequest()
            : base("live", "2016-11-01", "AddCustomLiveStreamTranscode")
        {
        }

		private string app;

		private string template;

		private int? fPS;

		private long? ownerId;

		private string version;

		private string accessKeyId;

		private string securityToken;

		private string templateType;

		private string domain;

		private int? width;

		private string action;

		private int? videoBitrate;

		private int? height;

		public string App
		{
			get
			{
				return app;
			}
			set	
			{
				app = value;
				DictionaryUtil.Add(QueryParameters, "App", value);
			}
		}

		public string Template
		{
			get
			{
				return template;
			}
			set	
			{
				template = value;
				DictionaryUtil.Add(QueryParameters, "Template", value);
			}
		}

		public int? FPS
		{
			get
			{
				return fPS;
			}
			set	
			{
				fPS = value;
				DictionaryUtil.Add(QueryParameters, "FPS", value.ToString());
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

		public string Version
		{
			get
			{
				return version;
			}
			set	
			{
				version = value;
				DictionaryUtil.Add(QueryParameters, "Version", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string TemplateType
		{
			get
			{
				return templateType;
			}
			set	
			{
				templateType = value;
				DictionaryUtil.Add(QueryParameters, "TemplateType", value);
			}
		}

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
			}
		}

		public int? Width
		{
			get
			{
				return width;
			}
			set	
			{
				width = value;
				DictionaryUtil.Add(QueryParameters, "Width", value.ToString());
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

		public int? VideoBitrate
		{
			get
			{
				return videoBitrate;
			}
			set	
			{
				videoBitrate = value;
				DictionaryUtil.Add(QueryParameters, "VideoBitrate", value.ToString());
			}
		}

		public int? Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(QueryParameters, "Height", value.ToString());
			}
		}

        public override AddCustomLiveStreamTranscodeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AddCustomLiveStreamTranscodeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}