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
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class ListCallDetailRecordsRequest : RpcAcsRequest<ListCallDetailRecordsResponse>
    {
        public ListCallDetailRecordsRequest()
            : base("CCC", "2017-07-05", "ListCallDetailRecords", "CCC", "openAPI")
        {
        }

		private string instanceId;

		private string contactDisposition;

		private string contactType;

		private string criteria;

		private string phoneNumber;

		private int? pageSize;

		private long? startTime;

		private long? stopTime;

		private int? pageNumber;

		private string accessKeyId;

		private bool? withRecording;

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

		public string ContactDisposition
		{
			get
			{
				return contactDisposition;
			}
			set	
			{
				contactDisposition = value;
				DictionaryUtil.Add(QueryParameters, "ContactDisposition", value);
			}
		}

		public string ContactType
		{
			get
			{
				return contactType;
			}
			set	
			{
				contactType = value;
				DictionaryUtil.Add(QueryParameters, "ContactType", value);
			}
		}

		public string Criteria
		{
			get
			{
				return criteria;
			}
			set	
			{
				criteria = value;
				DictionaryUtil.Add(QueryParameters, "Criteria", value);
			}
		}

		public string PhoneNumber
		{
			get
			{
				return phoneNumber;
			}
			set	
			{
				phoneNumber = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNumber", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
			}
		}

		public long? StopTime
		{
			get
			{
				return stopTime;
			}
			set	
			{
				stopTime = value;
				DictionaryUtil.Add(QueryParameters, "StopTime", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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

		public bool? WithRecording
		{
			get
			{
				return withRecording;
			}
			set	
			{
				withRecording = value;
				DictionaryUtil.Add(QueryParameters, "WithRecording", value.ToString());
			}
		}

        public override ListCallDetailRecordsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListCallDetailRecordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}