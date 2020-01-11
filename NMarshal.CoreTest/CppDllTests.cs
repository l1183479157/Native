﻿using Xunit;
using static NMarshal.CoreTest.CppDll.NativeMethods;

namespace NMarshal.CoreTest
{
    public class CppDllTests
    {
        [Fact]
        public void TestMethod1()
        {
            using var pstr = new AutoCharPtr(10);
            WriteString(pstr);
            Assert.Equal("a string", pstr.Value);
        }

    }
}