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
    public class ListStaStatusRequest : RpcAcsRequest<ListStaStatusResponse>
    {
        public ListStaStatusRequest()
            : base("cloudwf", "2017-03-28", "ListStaStatus")
        {
        }

		private string orderCol;

		private string searchGroupName;

		private int? searchStatus;

		private int? length;

		private string searchUsername;

		private string orderDir;

		private string accessKeyId;

		private string searchProtocal;

		private string searchSsid;

		private string searchApName;

		private string searchIp;

		private int? pageIndex;

		private string searchMac;

		private string searchDescription;

		public string OrderCol
		{
			get
			{
				return orderCol;
			}
			set	
			{
				orderCol = value;
				DictionaryUtil.Add(QueryParameters, "OrderCol", value);
			}
		}

		public string SearchGroupName
		{
			get
			{
				return searchGroupName;
			}
			set	
			{
				searchGroupName = value;
				DictionaryUtil.Add(QueryParameters, "SearchGroupName", value);
			}
		}

		public int? SearchStatus
		{
			get
			{
				return searchStatus;
			}
			set	
			{
				searchStatus = value;
				DictionaryUtil.Add(QueryParameters, "SearchStatus", value.ToString());
			}
		}

		public int? Length
		{
			get
			{
				return length;
			}
			set	
			{
				length = value;
				DictionaryUtil.Add(QueryParameters, "Length", value.ToString());
			}
		}

		public string SearchUsername
		{
			get
			{
				return searchUsername;
			}
			set	
			{
				searchUsername = value;
				DictionaryUtil.Add(QueryParameters, "SearchUsername", value);
			}
		}

		public string OrderDir
		{
			get
			{
				return orderDir;
			}
			set	
			{
				orderDir = value;
				DictionaryUtil.Add(QueryParameters, "OrderDir", value);
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

		public string SearchProtocal
		{
			get
			{
				return searchProtocal;
			}
			set	
			{
				searchProtocal = value;
				DictionaryUtil.Add(QueryParameters, "SearchProtocal", value);
			}
		}

		public string SearchSsid
		{
			get
			{
				return searchSsid;
			}
			set	
			{
				searchSsid = value;
				DictionaryUtil.Add(QueryParameters, "SearchSsid", value);
			}
		}

		public string SearchApName
		{
			get
			{
				return searchApName;
			}
			set	
			{
				searchApName = value;
				DictionaryUtil.Add(QueryParameters, "SearchApName", value);
			}
		}

		public string SearchIp
		{
			get
			{
				return searchIp;
			}
			set	
			{
				searchIp = value;
				DictionaryUtil.Add(QueryParameters, "SearchIp", value);
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
				DictionaryUtil.Add(QueryParameters, "PageIndex", value.ToString());
			}
		}

		public string SearchMac
		{
			get
			{
				return searchMac;
			}
			set	
			{
				searchMac = value;
				DictionaryUtil.Add(QueryParameters, "SearchMac", value);
			}
		}

		public string SearchDescription
		{
			get
			{
				return searchDescription;
			}
			set	
			{
				searchDescription = value;
				DictionaryUtil.Add(QueryParameters, "SearchDescription", value);
			}
		}

        public override ListStaStatusResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListStaStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}