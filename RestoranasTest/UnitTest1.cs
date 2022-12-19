using Restoranas;
using Restoranas.Models;

namespace RestoranasTest
{
    public class UnitTest1
    {
        [Fact]
        public void StaliukasRepozitorija_StaliukasInfo_IvestasStaliukoNumerisGrazinaTeisingaStaliukoVietuSkaiicu()
        {
            // Arrange

            int staliukoNumeris = 1;
            StaliukasRepozitorija staliukasRepozitoria = new ();
            var expected = 6;

            //Act
            var actual = (staliukasRepozitoria.StaliukoInfo(staliukoNumeris).SedimosVietos);

            // Assert
            Assert.Equal(expected, actual);
            Assert.True(actual == expected);
            Assert.IsType<int>(actual);
        }
    }
}