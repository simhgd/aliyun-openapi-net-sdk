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
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;
using System.Collections.Generic;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class OnoffGroupApRadioRequest : RpcAcsRequest<OnoffGroupApRadioResponse>
    {
        public OnoffGroupApRadioRequest()
            : base("cloudwf", "2017-03-28", "OnoffGroupApRadio")
        {
        }

		private long? apgroupId;

		private int? disabled;

		private string accessKeyId;

		public long? ApgroupId
		{
			get
			{
				return apgroupId;
			}
			set	
			{
				apgroupId = value;
				DictionaryUtil.Add(QueryParameters, "ApgroupId", value.ToString());
			}
		}

		public int? Disabled
		{
			get
			{
				return disabled;
			}
			set	
			{
				disabled = value;
				DictionaryUtil.Add(QueryParameters, "Disabled", value.ToString());
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

        public override OnoffGroupApRadioResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OnoffGroupApRadioResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}