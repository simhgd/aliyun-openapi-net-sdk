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
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class GetPhotosResponseUnmarshaller
    {
        public static GetPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			GetPhotosResponse getPhotosResponse = new GetPhotosResponse();

			getPhotosResponse.HttpResponse = context.HttpResponse;
			getPhotosResponse.Code = context.StringValue("GetPhotos.Code");
			getPhotosResponse.Message = context.StringValue("GetPhotos.Message");
			getPhotosResponse.RequestId = context.StringValue("GetPhotos.RequestId");
			getPhotosResponse.Action = context.StringValue("GetPhotos.Action");

			List<GetPhotosResponse.GetPhotos_Photo> getPhotosResponse_photos = new List<GetPhotosResponse.GetPhotos_Photo>();
			for (int i = 0; i < context.Length("GetPhotos.Photos.Length"); i++) {
				GetPhotosResponse.GetPhotos_Photo photo = new GetPhotosResponse.GetPhotos_Photo();
				photo.Id = context.LongValue("GetPhotos.Photos["+ i +"].Id");
				photo.Title = context.StringValue("GetPhotos.Photos["+ i +"].Title");
				photo.FileId = context.StringValue("GetPhotos.Photos["+ i +"].FileId");
				photo.State = context.StringValue("GetPhotos.Photos["+ i +"].State");
				photo.Md5 = context.StringValue("GetPhotos.Photos["+ i +"].Md5");
				photo.IsVideo = context.BooleanValue("GetPhotos.Photos["+ i +"].IsVideo");
				photo.Remark = context.StringValue("GetPhotos.Photos["+ i +"].Remark");
				photo.Width = context.LongValue("GetPhotos.Photos["+ i +"].Width");
				photo.Height = context.LongValue("GetPhotos.Photos["+ i +"].Height");
				photo.Ctime = context.LongValue("GetPhotos.Photos["+ i +"].Ctime");
				photo.Mtime = context.LongValue("GetPhotos.Photos["+ i +"].Mtime");
				photo.TakenAt = context.LongValue("GetPhotos.Photos["+ i +"].TakenAt");
				photo.InactiveTime = context.LongValue("GetPhotos.Photos["+ i +"].InactiveTime");
				photo.ShareExpireTime = context.LongValue("GetPhotos.Photos["+ i +"].ShareExpireTime");
				photo.Like = context.LongValue("GetPhotos.Photos["+ i +"].Like");

				getPhotosResponse_photos.Add(photo);
			}
			getPhotosResponse.Photos = getPhotosResponse_photos;
        
			return getPhotosResponse;
        }
    }
}