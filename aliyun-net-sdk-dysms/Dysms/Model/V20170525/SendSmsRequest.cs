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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Sms.Transform.V20170525;

namespace Aliyun.Acs.Sms.Model.V20170525
{
    public class SendSmsRequest : RpcAcsRequest<SendSmsResponse>
    {
        public SendSmsRequest()
            : base("Dysmsapi", "2017-05-25", "SendSms")
        {
        }

        private string phoneNumbers;
        public string PhoneNumbers { get => phoneNumbers; set => DictionaryUtil.Add(QueryParameters, nameof(PhoneNumbers), phoneNumbers = value); }

        private string signName;
        public string SignName { get => signName; set => DictionaryUtil.Add(QueryParameters, nameof(SignName), signName = value); }

        private string templateCode;
        public string TemplateCode { get => templateCode; set => DictionaryUtil.Add(QueryParameters, nameof(TemplateCode), templateCode = value); }

        public string templateParam;
        public string TemplateParam { get => templateParam; set => DictionaryUtil.Add(QueryParameters, nameof(TemplateParam), templateParam = value); }

        private string outId;
        public string OutId { get => outId; set => DictionaryUtil.Add(QueryParameters, nameof(OutId), outId = value); }

        public override SendSmsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SendSmsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}