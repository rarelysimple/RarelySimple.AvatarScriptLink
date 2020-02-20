using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Tests.Objects
{
    [TestClass]
    public class ParameterTests
    {
        [TestMethod]
        public void Parameter_Default_ScriptName_AreEqual()
        {
            string expected = "one";
            IParameter parameter = new Parameter("one,two,three,four,five");
            string actual = parameter.ScriptName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Default__Count_AreEqual()
        {
            int expected = 5;
            IParameter parameter = new Parameter("one,two,three,four,five");
            int actual = parameter.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Default_AreEqual()
        {
            string expected = "three";
            IParameter parameter = new Parameter("one,two,three,four,five");
            string actual = parameter.ParameterArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Default_Empty_AreEqual()
        {
            string expected = "";
            IParameter parameter = new Parameter("");
            string actual = parameter.ParameterArray()[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Colon_AreEqual()
        {
            string expected = "three";
            IParameter parameter = new Parameter("one:two:three:four:five", ':');
            string actual = parameter.ParameterArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Comma_AreEqual()
        {
            string expected = "three";
            IParameter parameter = new Parameter("one,two,three,four,five", ',');
            string actual = parameter.ParameterArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Period_AreEqual()
        {
            string expected = "three";
            IParameter parameter = new Parameter("one.two.three.four.five", '.');
            string actual = parameter.ParameterArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Pipe_AreEqual()
        {
            string expected = "three";
            IParameter parameter = new Parameter("one|two|three|four|five", '|');
            string actual = parameter.ParameterArray()[2];

            Assert.AreEqual(expected, actual);
        }
    }
}
