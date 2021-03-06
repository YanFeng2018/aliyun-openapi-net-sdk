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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class DeleteMaterialResponseUnmarshaller
    {
        public static DeleteMaterialResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteMaterialResponse deleteMaterialResponse = new DeleteMaterialResponse();

			deleteMaterialResponse.HttpResponse = context.HttpResponse;
			deleteMaterialResponse.RequestId = context.StringValue("DeleteMaterial.RequestId");
			deleteMaterialResponse.Success = context.BooleanValue("DeleteMaterial.Success");
			deleteMaterialResponse.ErrorMsg = context.StringValue("DeleteMaterial.ErrorMsg");
			deleteMaterialResponse.ErrorCode = context.StringValue("DeleteMaterial.ErrorCode");
        
			return deleteMaterialResponse;
        }
    }
}
