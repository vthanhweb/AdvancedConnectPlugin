﻿/*
Copyright 2016 TGW Software Services GmbH

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance 
with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the License is 
distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
See the License for the specific language governing permissions and limitations under the License.
*/
using System;
using System.Diagnostics;

namespace AdvancedConnectPlugin.Tools
{
    public static class StartProcess
    {
        public static void Start(String path, String arguments)
        {
            using (Process process = new Process()) {
                if (arguments.EndsWith("dos"))
                {
                    arguments = arguments.Remove(arguments.Length - 3).Trim();
                }
                else
                {
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = true;
                }
                process.StartInfo.FileName = path;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.UseShellExecute = false;
                process.Start();
            }
        }

    }
}
