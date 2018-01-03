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
    public class NodeProcessCreateRequest : RpcAcsRequest<NodeProcessCreateResponse>
    {
        public NodeProcessCreateRequest()
            : base("Cms", "2017-03-01", "NodeProcessCreate", "cms", "openAPI")
        {
        }

		private string instanceId;

		private string processName;

		private string name;

		private string processUser;

		private string command;

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

		public string ProcessName
		{
			get
			{
				return processName;
			}
			set	
			{
				processName = value;
				DictionaryUtil.Add(QueryParameters, "ProcessName", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string ProcessUser
		{
			get
			{
				return processUser;
			}
			set	
			{
				processUser = value;
				DictionaryUtil.Add(QueryParameters, "ProcessUser", value);
			}
		}

		public string Command
		{
			get
			{
				return command;
			}
			set	
			{
				command = value;
				DictionaryUtil.Add(QueryParameters, "Command", value);
			}
		}

        public override NodeProcessCreateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return NodeProcessCreateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}