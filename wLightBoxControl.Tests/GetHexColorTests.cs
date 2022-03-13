using wLightBoxLibrary;
using Xunit;

namespace wLightBoxControl.Tests
{
    public class GetHexColorTests
    {
        
        [Theory]
        [InlineData(0,0,0,0,0,"0000000000")]
        [InlineData(255,0,0,0,0,"FF00000000")]
        [InlineData(0,255,0,0,0,"00FF000000")]
        [InlineData(0,0,255,0,0,"0000FF0000")]
        [InlineData(0,0,0,255,0,"000000FF00")]
        [InlineData(0,0,0,0,255,"00000000FF")]
        [InlineData(255,255,255,255,255,"FFFFFFFFFF")]

        
        public void HexColorTest(int red, int green, int blue, int wWhite, int CWhite, string expected)
        {
            var testColor = new wLightBoxLibrary.Color();

            var actual = testColor.GetHexColor(red, green, blue, wWhite, CWhite);

            Assert.Equal(expected, actual);
        }
    }
}