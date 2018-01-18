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
    public class AliyunRegisterApAssetRequest : RpcAcsRequest<AliyunRegisterApAssetResponse>
    {
        public AliyunRegisterApAssetRequest()
            : base("cloudwf", "2017-03-28", "AliyunRegisterApAsset")
        {
        }

		private long? apgroupId;

		private string mac;

		private string accessKeyId;

		private string serialNo;

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

		public string Mac
		{
			get
			{
				return mac;
			}
			set	
			{
				mac = value;
				DictionaryUtil.Add(QueryParameters, "Mac", value);
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

		public string SerialNo
		{
			get
			{
				return serialNo;
			}
			set	
			{
				serialNo = value;
				DictionaryUtil.Add(QueryParameters, "SerialNo", value);
			}
		}

        public override AliyunRegisterApAssetResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AliyunRegisterApAssetResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}