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
            string actual = parameter.ToArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Default_Empty_AreEqual()
        {
            string expected = "";
            IParameter parameter = new Parameter("");
            string actual = parameter.ToArray()[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Colon_AreEqual()
        {
            string expected = "three";
            IParameter parameter = new Parameter("one:two:three:four:five", ':');
            string actual = parameter.ToArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Comma_AreEqual()
        {
            string expected = "three";
            IParameter parameter = new Parameter("one,two,three,four,five", ',');
            string actual = parameter.ToArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Period_AreEqual()
        {
            string expected = "three";
            IParameter parameter = new Parameter("one.two.three.four.five", '.');
            string actual = parameter.ToArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Pipe_AreEqual()
        {
            string expected = "three";
            IParameter parameter = new Parameter("one|two|three|four|five", '|');
            string actual = parameter.ToArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_0_AreEqual()
        {
            string expected = "one";
            IParameter parameter = new Parameter("one,two,,,five");
            string actual = parameter.GetString(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_1_AreEqual()
        {
            string expected = "two";
            IParameter parameter = new Parameter("one,two,,,five");
            string actual = parameter.GetString(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_2_AreEqual()
        {
            string expected = "";
            IParameter parameter = new Parameter("one,two,,,five");
            string actual = parameter.GetString(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_3_AreEqual()
        {
            string expected = "";
            IParameter parameter = new Parameter("one,two,,,five");
            string actual = parameter.GetString(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_4_AreEqual()
        {
            string expected = "five";
            IParameter parameter = new Parameter("one,two,,,five");
            string actual = parameter.GetString(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_5_AreEqual()
        {
            string expected = "";
            IParameter parameter = new Parameter("one,two,,,five");
            string actual = parameter.GetString(5);

            Assert.AreEqual(expected, actual);
        }
    }
}
