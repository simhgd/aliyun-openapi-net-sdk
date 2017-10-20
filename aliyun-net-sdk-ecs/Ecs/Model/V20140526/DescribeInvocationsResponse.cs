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
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeInvocationsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeInvocations_InvocationItem> invocation;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeInvocations_InvocationItem> Invocation
		{
			get
			{
				return invocation;
			}
			set	
			{
				invocation = value;
			}
		}

		public class DescribeInvocations_InvocationItem
		{

			private string invokeId;

			private string commandId;

			private string commandType;

			private string commandName;

			private bool? timed;

			private string invokeStatus;

			private List<DescribeInvocations_InvokeItemItem> invokeItem;

			public string InvokeId
			{
				get
				{
					return invokeId;
				}
				set	
				{
					invokeId = value;
				}
			}

			public string CommandId
			{
				get
				{
					return commandId;
				}
				set	
				{
					commandId = value;
				}
			}

			public string CommandType
			{
				get
				{
					return commandType;
				}
				set	
				{
					commandType = value;
				}
			}

			public string CommandName
			{
				get
				{
					return commandName;
				}
				set	
				{
					commandName = value;
				}
			}

			public bool? Timed
			{
				get
				{
					return timed;
				}
				set	
				{
					timed = value;
				}
			}

			public string InvokeStatus
			{
				get
				{
					return invokeStatus;
				}
				set	
				{
					invokeStatus = value;
				}
			}

			public List<DescribeInvocations_InvokeItemItem> InvokeItem
			{
				get
				{
					return invokeItem;
				}
				set	
				{
					invokeItem = value;
				}
			}

			public class DescribeInvocations_InvokeItemItem
			{

				private string instanceId;

				private string status;

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}
		}
	}
}