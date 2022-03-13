using NUnit.Framework;

namespace wLightBox.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly Color testColor = new Color();

        [TestCase(0,0,0,0,0 , ExpectedResult = "0000000000")]
        public string GetHexConverter(int red, int green, int blue, int warmWhite, int coldWhite)
        {
            return testColor.GetHexColor(red, green, blue, warmWhite, coldWhite);
        }

    }
}