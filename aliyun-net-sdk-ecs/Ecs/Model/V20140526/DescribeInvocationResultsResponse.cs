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
	public class DescribeInvocationResultsResponse : AcsResponse
	{

		private string requestId;

		private DescribeInvocationResults_Invocation invocation;

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

		public DescribeInvocationResults_Invocation Invocation
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

		public class DescribeInvocationResults_Invocation
		{

			private string invokeId;

			private long? pageSize;

			private long? pageNumber;

			private long? totalCount;

			private string status;

			private List<DescribeInvocationResults_ResultItem> resultLists;

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

			public List<DescribeInvocationResults_ResultItem> ResultLists
			{
				get
				{
					return resultLists;
				}
				set	
				{
					resultLists = value;
				}
			}

			public class DescribeInvocationResults_ResultItem
			{

				private string instanceId;

				private string finishedTime;

				private string output;

				private long? exitCode;

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

				public string FinishedTime
				{
					get
					{
						return finishedTime;
					}
					set	
					{
						finishedTime = value;
					}
				}

				public string Output
				{
					get
					{
						return output;
					}
					set	
					{
						output = value;
					}
				}

				public long? ExitCode
				{
					get
					{
						return exitCode;
					}
					set	
					{
						exitCode = value;
					}
				}
			}
		}
	}
}