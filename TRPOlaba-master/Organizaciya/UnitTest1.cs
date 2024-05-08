using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting; // Убедитесь, что используете правильный using для MSTest

namespace ClassLibrary1Tests
{
    [TestClass]
    public class OrganizaciyaTests
    {
        [TestMethod]
        public void Organizaciya_CorrectInitialization_PropertiesAreSet()
        {
            // Arrange
            var nazvanie = "ООО Ромашка";
            var yuridicheskiyAdres = "123456, Москва, ул. Пушкина, д. 1";
            var fakticheskiyAdres = "123456, Москва, ул. Колотушкина, д. 2";

            // Act
            var organizaciya = new Organizaciya(nazvanie, yuridicheskiyAdres, fakticheskiyAdres);

            // Assert
            Assert.AreEqual(nazvanie, organizaciya.Nazvanie, "Название не соответствует ожидаемому.");
            Assert.AreEqual(yuridicheskiyAdres, organizaciya.YuridicheskiyAdres, "Юридический адрес не соответствует ожидаемому.");
            Assert.AreEqual(fakticheskiyAdres, organizaciya.FakticheskiyAdres, "Фактический адрес не соответствует ожидаемому.");
        }

        [TestMethod]
        public void Organizaciya_InvalidTest_YuridicheskiyAndFakticheskiyAdresAreNotEqual()
        {
            // Arrange
            var nazvanie = "ООО Ромашка";
            var yuridicheskiyAdres = "123456, Москва, ул. Пушкина, д. 1";
            var fakticheskiyAdres = "123456, Москва, ул. Пушкина, д. 1"; // Сделаем адреса одинаковыми

            // Act
            var organizaciya = new Organizaciya(nazvanie, yuridicheskiyAdres, fakticheskiyAdres);

            // Assert
            Assert.AreNotEqual(organizaciya.YuridicheskiyAdres, organizaciya.FakticheskiyAdres, "Юридический и фактический адреса не должны быть одинаковыми, но они одинаковы.");
        }
    }
}
