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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20170301;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20170301
{
    public class DeleteCustomMetricRequest : RpcAcsRequest<DeleteCustomMetricResponse>
    {
        public DeleteCustomMetricRequest()
            : base("Cms", "2017-03-01", "DeleteCustomMetric", "cms", "openAPI")
        {
        }

		private string groupId;

		private string metricName;

		private string uUID;

		private string md5;

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string MetricName
		{
			get
			{
				return metricName;
			}
			set	
			{
				metricName = value;
				DictionaryUtil.Add(QueryParameters, "MetricName", value);
			}
		}

		public string UUID
		{
			get
			{
				return uUID;
			}
			set	
			{
				uUID = value;
				DictionaryUtil.Add(QueryParameters, "UUID", value);
			}
		}

		public string Md5
		{
			get
			{
				return md5;
			}
			set	
			{
				md5 = value;
				DictionaryUtil.Add(QueryParameters, "Md5", value);
			}
		}

        public override DeleteCustomMetricResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DeleteCustomMetricResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}