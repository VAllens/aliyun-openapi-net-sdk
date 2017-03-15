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

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class ListPushRecordsResponse : AcsResponse
	{
	    public int? Total { get; set; }

	    public int? Page { get; set; }

	    public int? PageSize { get; set; }

	    public List<PushMessageInfo> PushMessageInfos { get; set; }

	    public class PushMessageInfo{
	        public long? AppKey { get; set; }

	        public string AppName { get; set; }

	        public string MessageId { get; set; }

	        public string Type { get; set; }

	        public string DeviceType { get; set; }

	        public string PushTime { get; set; }

	        public string Title { get; set; }

	        public string Body { get; set; }
	    }
	}
}