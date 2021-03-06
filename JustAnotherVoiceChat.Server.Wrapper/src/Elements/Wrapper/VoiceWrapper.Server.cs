﻿/*
 * File: VoiceWrapper.Server.cs
 * Date: 21.2.2018,
 *
 * MIT License
 *
 * Copyright (c) 2018 JustAnotherVoiceChat
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System.Security;
using JustAnotherVoiceChat.Server.Wrapper.Elements.Models;
using JustAnotherVoiceChat.Server.Wrapper.Enums;
using JustAnotherVoiceChat.Server.Wrapper.Interfaces;

namespace JustAnotherVoiceChat.Server.Wrapper.Elements.Wrapper
{
    [SecurityCritical]
    internal partial class VoiceWrapper : IVoiceWrapper
    {
        public void CreateNativeServer(VoiceServerConfiguration configuration)
        {
            NativeLibary.JV_CreateServer(configuration.Port, configuration.TeamspeakServerId, configuration.TeamspeakChannelId, configuration.TeamspeakChannelPassword);
        }

        public void DestroyNativeServer()
        {
            NativeLibary.JV_DestroyServer();
        }

        public bool StartNativeServer()
        {
            return NativeLibary.JV_StartServer();
        }

        public void StopNativeServer()
        {
            NativeLibary.JV_StopServer();
        }

        public void Set3DSettings(float distanceFactor, float rolloffFactor)
        {
            NativeLibary.JV_Set3DSettings(distanceFactor, rolloffFactor);
        }

        public void SetLogLevel(LogLevel logLevel)
        {
            NativeLibary.JV_SetLogLevel((int) logLevel);
        }
    }
}
