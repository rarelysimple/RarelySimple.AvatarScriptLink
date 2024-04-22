using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Objects
{
    [TestClass]
    public class ParameterTests
    {
        [TestMethod]
        public void Parameter_Default_ScriptName_AreEqual()
        {
            string expected = "one";
            Parameter parameter = new("one,two,three,four,five");
            string actual = parameter.ScriptName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Default__Count_AreEqual()
        {
            int expected = 5;
            Parameter parameter = new("one,two,three,four,five");
            int actual = parameter.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Default_AreEqual()
        {
            string expected = "three";
            Parameter parameter = new("one,two,three,four,five");
            string actual = parameter.ToArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Default_Empty_AreEqual()
        {
            string expected = "";
            Parameter parameter = new("");
            string actual = parameter.ToArray()[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Colon_AreEqual()
        {
            string expected = "three";
            Parameter parameter = new("one:two:three:four:five", ':');
            string actual = parameter.ToArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Comma_AreEqual()
        {
            string expected = "three";
            Parameter parameter = new("one,two,three,four,five", ',');
            string actual = parameter.ToArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Period_AreEqual()
        {
            string expected = "three";
            Parameter parameter = new("one.two.three.four.five", '.');
            string actual = parameter.ToArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_Pipe_AreEqual()
        {
            string expected = "three";
            Parameter parameter = new("one|two|three|four|five", '|');
            string actual = parameter.ToArray()[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_0_AreEqual()
        {
            string expected = "one";
            Parameter parameter = new("one,two,,,five");
            string actual = parameter.GetString(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_1_AreEqual()
        {
            string expected = "two";
            Parameter parameter = new("one,two,,,five");
            string actual = parameter.GetString(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_2_AreEqual()
        {
            string expected = "";
            Parameter parameter = new("one,two,,,five");
            string actual = parameter.GetString(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_3_AreEqual()
        {
            string expected = "";
            Parameter parameter = new("one,two,,,five");
            string actual = parameter.GetString(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_4_AreEqual()
        {
            string expected = "five";
            Parameter parameter = new("one,two,,,five");
            string actual = parameter.GetString(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parameter_GetString_5_AreEqual()
        {
            string expected = "";
            Parameter parameter = new("one,two,,,five");
            string actual = parameter.GetString(5);

            Assert.AreEqual(expected, actual);
        }
    }
}
