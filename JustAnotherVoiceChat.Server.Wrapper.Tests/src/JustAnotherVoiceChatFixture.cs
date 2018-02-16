﻿/*
 * File: JustAnotherVoiceChatFixture.cs
 * Date: 15.2.2018,
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

using System;
using JustAnotherVoiceChat.Server.Wrapper.Interfaces;
using Moq;
using NUnit.Framework;

namespace JustAnotherVoiceChat.Server.Wrapper.Tests
{
    [TestFixture]
    public class JustAnotherVoiceChatFixture
    {
        [Test]
        public void MakingServerWillReturnNewVoiceServerInstance()
        {
            var repositoryMock = new Mock<IElementFactory>();
            repositoryMock.Setup(e => e.MakeServer(It.IsAny<IVoiceWrapper>(), It.IsAny<IVoiceWrapper3D>(), "localhost", 23332, 20));
            
            var result = JustAnotherVoiceChat.MakeServer(repositoryMock.Object, "localhost", 23332, 20);

            repositoryMock.Verify(e => e.MakeServer(It.IsAny<IVoiceWrapper>(), It.IsAny<IVoiceWrapper3D>(), "localhost", 23332, 20), Times.Once);
        }
        
        [Test]
        public void GivingNullAsRepositoryWillThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { JustAnotherVoiceChat.MakeServer(null, "localhost", 23332, 20); });
        }
    }
}