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
using Aliyun.Acs.Ons.Transform;
using Aliyun.Acs.Ons.Transform.V20170918;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Model.V20170918
{
    public class OnsMqttQueryMsgByPubInfoRequest : RpcAcsRequest<OnsMqttQueryMsgByPubInfoResponse>
    {
        public OnsMqttQueryMsgByPubInfoRequest()
            : base("Ons", "2017-09-18", "OnsMqttQueryMsgByPubInfo")
        {
        }

		private long? preventCache;

		private string onsRegionId;

		private string clientId;

		private string onsPlatform;

		private string topic;

		private long? endTime;

		private long? beginTime;

		public long? PreventCache
		{
			get
			{
				return preventCache;
			}
			set	
			{
				preventCache = value;
				DictionaryUtil.Add(QueryParameters, "PreventCache", value.ToString());
			}
		}

		public string OnsRegionId
		{
			get
			{
				return onsRegionId;
			}
			set	
			{
				onsRegionId = value;
				DictionaryUtil.Add(QueryParameters, "OnsRegionId", value);
			}
		}

		public string ClientId
		{
			get
			{
				return clientId;
			}
			set	
			{
				clientId = value;
				DictionaryUtil.Add(QueryParameters, "ClientId", value);
			}
		}

		public string OnsPlatform
		{
			get
			{
				return onsPlatform;
			}
			set	
			{
				onsPlatform = value;
				DictionaryUtil.Add(QueryParameters, "OnsPlatform", value);
			}
		}

		public string Topic
		{
			get
			{
				return topic;
			}
			set	
			{
				topic = value;
				DictionaryUtil.Add(QueryParameters, "Topic", value);
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		public long? BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
				DictionaryUtil.Add(QueryParameters, "BeginTime", value.ToString());
			}
		}

        public override OnsMqttQueryMsgByPubInfoResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OnsMqttQueryMsgByPubInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}