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
using Aliyun.Acs.Push.Model.V20150827;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20150827
{
    public class ListTagsResponseUnmarshaller
    {
        public static ListTagsResponse Unmarshall(UnmarshallerContext context)
        {
            ListTagsResponse listTagsResponse = new ListTagsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("ListTags.RequestId")
            };
            List<ListTagsResponse.TagInfo> tagInfos = new List<ListTagsResponse.TagInfo>();
			for (int i = 0; i < context.Length("ListTags.TagInfos.Length"); i++) {
                ListTagsResponse.TagInfo tagInfo = new ListTagsResponse.TagInfo()
                {
                    TagName = context.StringValue($"ListTags.TagInfos[{i}].TagName")
                };
                tagInfos.Add(tagInfo);
			}
			listTagsResponse.TagInfos = tagInfos;
        
			return listTagsResponse;
        }
    }
}