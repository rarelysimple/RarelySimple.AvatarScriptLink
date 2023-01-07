using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class IsValidUrlTests
    {
        [TestMethod]
        [TestCategory("Helpers-IsValidUrl")]
        public void IsValidUrl_Absolute_HTTP()
        {
            string strUrl = "http://everydaymatters.com";
            Assert.IsTrue(ScriptLinkHelpers.IsValidUrl(strUrl));
        }

        [TestMethod]
        [TestCategory("Helpers-IsValidUrl")]
        public void IsValidUrl_Absolute_HTTPS()
        {
            string strUrl = "https://everydaymatters.com";
            Assert.IsTrue(ScriptLinkHelpers.IsValidUrl(strUrl));
        }

        [TestMethod]
        [TestCategory("Helpers-IsValidUrl")]
        public void IsValidUrl_Absolute_HTTP_QueryString()
        {
            string strUrl = "http://everydaymatters.com/?e=123";
            Assert.IsTrue(ScriptLinkHelpers.IsValidUrl(strUrl));
        }

        [TestMethod]
        [TestCategory("Helpers-IsValidUrl")]
        public void IsValidUrl_Absolute_HTTPS_QueryString()
        {
            string strUrl = "https://everydaymatters.com/?e=123";
            Assert.IsTrue(ScriptLinkHelpers.IsValidUrl(strUrl));
        }

        [TestMethod]
        [TestCategory("Helpers-IsValidUrl")]
        public void IsValidUrl_Absolute_HTTP_IsFalse()
        {
            string strUrl = "everydaymatters.com";
            Assert.IsFalse(ScriptLinkHelpers.IsValidUrl(strUrl));
        }

        [TestMethod]
        [TestCategory("Helpers-IsValidUrl")]
        public void IsValidUrl_Absolute_HTTPS_IsFalse()
        {
            string strUrl = "every day matters.com:443";
            Assert.IsFalse(ScriptLinkHelpers.IsValidUrl(strUrl));
        }
    }
}
