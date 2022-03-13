using Xunit;
using wLightBoxLibrary;

namespace wLightBox.Tests
{
    public class UnitTest1
    {
        private readonly Color _testColor;

        public UnitTest1()
        {
            _testColor = new Color();
        }

        [Theory]
        [InlineData(0, 0, 0, 0, 0)]

        public void HexTest(int red, int green, int blue, int warmWhite, int coldWhite)
        {
            Assert.Equal("0000000000", _testColor.GetHexColor( red, green, blue, warmWhite, coldWhite));
        }

    }
}