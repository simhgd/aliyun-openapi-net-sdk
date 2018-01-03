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
    public class QueryFpShotJobListResponseUnmarshaller
    {
        public static QueryFpShotJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryFpShotJobListResponse queryFpShotJobListResponse = new QueryFpShotJobListResponse();

			queryFpShotJobListResponse.HttpResponse = context.HttpResponse;
			queryFpShotJobListResponse.RequestId = context.StringValue("QueryFpShotJobList.RequestId");

			List<string> queryFpShotJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryFpShotJobList.NonExistIds.Length"); i++) {
				queryFpShotJobListResponse_nonExistIds.Add(context.StringValue("QueryFpShotJobList.NonExistIds["+ i +"]"));
			}
			queryFpShotJobListResponse.NonExistIds = queryFpShotJobListResponse_nonExistIds;

			List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob> queryFpShotJobListResponse_fpShotJobList = new List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob>();
			for (int i = 0; i < context.Length("QueryFpShotJobList.FpShotJobList.Length"); i++) {
				QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob fpShotJob = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob();
				fpShotJob.Id = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].Id");
				fpShotJob.UserData = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].UserData");
				fpShotJob.PipelineId = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].PipelineId");
				fpShotJob.State = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].State");
				fpShotJob.Code = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].Code");
				fpShotJob.Message = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].Message");
				fpShotJob.CreationTime = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].CreationTime");

				QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_InputFile inputFile = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_InputFile();
				inputFile.Bucket = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].InputFile.Bucket");
				inputFile.Location = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].InputFile.Location");
				inputFile._Object = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].InputFile.Object");
				fpShotJob.InputFile = inputFile;

				QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult fpShotResult = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult();

				List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot> fpShotResult_fpShots = new List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot>();
				for (int j = 0; j < context.Length("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots.Length"); j++) {
					QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot fpShot = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot();
					fpShot.PrimaryKey = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].PrimaryKey");
					fpShot.Similarity = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].Similarity");

					List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice> fpShot_fpShotSlices = new List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice>();
					for (int k = 0; k < context.Length("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].FpShotSlices.Length"); k++) {
						QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice fpShotSlice = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice();

						QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Input input = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Input();
						input.Start = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].FpShotSlices["+ k +"].Input.Start");
						input.Duration = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].FpShotSlices["+ k +"].Input.Duration");
						fpShotSlice.Input = input;

						QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Duplication duplication = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Duplication();
						duplication.Start = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].FpShotSlices["+ k +"].Duplication.Start");
						duplication.Duration = context.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].FpShotSlices["+ k +"].Duplication.Duration");
						fpShotSlice.Duplication = duplication;

						fpShot_fpShotSlices.Add(fpShotSlice);
					}
					fpShot.FpShotSlices = fpShot_fpShotSlices;

					fpShotResult_fpShots.Add(fpShot);
				}
				fpShotResult.FpShots = fpShotResult_fpShots;
				fpShotJob.FpShotResult = fpShotResult;

				queryFpShotJobListResponse_fpShotJobList.Add(fpShotJob);
			}
			queryFpShotJobListResponse.FpShotJobList = queryFpShotJobListResponse_fpShotJobList;
        
			return queryFpShotJobListResponse;
        }
    }
}