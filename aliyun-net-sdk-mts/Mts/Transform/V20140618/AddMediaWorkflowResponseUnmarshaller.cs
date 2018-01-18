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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class AddMediaWorkflowResponseUnmarshaller
    {
        public static AddMediaWorkflowResponse Unmarshall(UnmarshallerContext context)
        {
			AddMediaWorkflowResponse addMediaWorkflowResponse = new AddMediaWorkflowResponse();

			addMediaWorkflowResponse.HttpResponse = context.HttpResponse;
			addMediaWorkflowResponse.RequestId = context.StringValue("AddMediaWorkflow.RequestId");

			AddMediaWorkflowResponse.AddMediaWorkflow_MediaWorkflow mediaWorkflow = new AddMediaWorkflowResponse.AddMediaWorkflow_MediaWorkflow();
			mediaWorkflow.MediaWorkflowId = context.StringValue("AddMediaWorkflow.MediaWorkflow.MediaWorkflowId");
			mediaWorkflow.Name = context.StringValue("AddMediaWorkflow.MediaWorkflow.Name");
			mediaWorkflow.Topology = context.StringValue("AddMediaWorkflow.MediaWorkflow.Topology");
			mediaWorkflow.TriggerMode = context.StringValue("AddMediaWorkflow.MediaWorkflow.TriggerMode");
			mediaWorkflow.State = context.StringValue("AddMediaWorkflow.MediaWorkflow.State");
			mediaWorkflow.CreationTime = context.StringValue("AddMediaWorkflow.MediaWorkflow.CreationTime");
			addMediaWorkflowResponse.MediaWorkflow = mediaWorkflow;
        
			return addMediaWorkflowResponse;
        }
    }
}