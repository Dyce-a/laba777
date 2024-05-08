using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting; // ���������, ��� ����������� ���������� using ��� MSTest

namespace ClassLibrary1Tests
{
    [TestClass]
    public class OrganizaciyaTests
    {
        [TestMethod]
        public void Organizaciya_CorrectInitialization_PropertiesAreSet()
        {
            // Arrange
            var nazvanie = "��� �������";
            var yuridicheskiyAdres = "123456, ������, ��. �������, �. 1";
            var fakticheskiyAdres = "123456, ������, ��. �����������, �. 2";

            // Act
            var organizaciya = new Organizaciya(nazvanie, yuridicheskiyAdres, fakticheskiyAdres);

            // Assert
            Assert.AreEqual(nazvanie, organizaciya.Nazvanie, "�������� �� ������������� ����������.");
            Assert.AreEqual(yuridicheskiyAdres, organizaciya.YuridicheskiyAdres, "����������� ����� �� ������������� ����������.");
            Assert.AreEqual(fakticheskiyAdres, organizaciya.FakticheskiyAdres, "����������� ����� �� ������������� ����������.");
        }

        [TestMethod]
        public void Organizaciya_InvalidTest_YuridicheskiyAndFakticheskiyAdresAreNotEqual()
        {
            // Arrange
            var nazvanie = "��� �������";
            var yuridicheskiyAdres = "123456, ������, ��. �������, �. 1";
            var fakticheskiyAdres = "123456, ������, ��. �������, �. 1"; // ������� ������ �����������

            // Act
            var organizaciya = new Organizaciya(nazvanie, yuridicheskiyAdres, fakticheskiyAdres);

            // Assert
            Assert.AreNotEqual(organizaciya.YuridicheskiyAdres, organizaciya.FakticheskiyAdres, "����������� � ����������� ������ �� ������ ���� �����������, �� ��� ���������.");
        }
    }
}
