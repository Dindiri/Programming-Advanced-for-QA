using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PlanetTests
{
    // TODO: finish test
    [Test]
    public void Test_CalculateGravity_ReturnsCorrectCalculation()
    {
        // Arrange
        Planet earth = new("Earth", 12742, 149600000, 1);
        double mass = 1000;
        double expectedGravity = mass * 6.67430e-11 / Math.Pow(earth.Diameter / 2, 2);

        // Act
        double result = earth.CalculateGravity(mass);

        // Assert
        Assert.That(result, Is.EqualTo(expectedGravity));
    }

    [Test]
    public void Test_GetPlanetInfo_ReturnsCorrectInfo()
    {
        // Arrange
        Planet jupiter = new Planet("Jupiter", 142984, 778_412_027, 79);
        string expected = $"Planet: Jupiter{Environment.NewLine}" +
                          $"Diameter: 142984 km{Environment.NewLine}" +
                          $"Distance from the Sun: 778412027 km{Environment.NewLine}" +
                          $"Number of Moons: 79";

        // Act
        string result = jupiter.GetPlanetInfo();

        // Assert
        Assert.That (result, Is.EqualTo(expected));

    }
}
