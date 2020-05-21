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
using Aliyun.Acs.fnf.Model.V20190315;

namespace Aliyun.Acs.fnf.Transform.V20190315
{
    public class StartExecutionResponseUnmarshaller
    {
        public static StartExecutionResponse Unmarshall(UnmarshallerContext context)
        {
			StartExecutionResponse startExecutionResponse = new StartExecutionResponse();

			startExecutionResponse.HttpResponse = context.HttpResponse;
			startExecutionResponse.RequestId = context.StringValue("StartExecution.RequestId");
			startExecutionResponse.Name = context.StringValue("StartExecution.Name");
			startExecutionResponse.FlowName = context.StringValue("StartExecution.FlowName");
			startExecutionResponse.FlowDefinition = context.StringValue("StartExecution.FlowDefinition");
			startExecutionResponse.Input = context.StringValue("StartExecution.Input");
			startExecutionResponse.Output = context.StringValue("StartExecution.Output");
			startExecutionResponse.Status = context.StringValue("StartExecution.Status");
			startExecutionResponse.StartedTime = context.StringValue("StartExecution.StartedTime");
			startExecutionResponse.StoppedTime = context.StringValue("StartExecution.StoppedTime");
			startExecutionResponse.ExternalInputUri = context.StringValue("StartExecution.ExternalInputUri");
			startExecutionResponse.ExternalOutputUri = context.StringValue("StartExecution.ExternalOutputUri");
        
			return startExecutionResponse;
        }
    }
}
