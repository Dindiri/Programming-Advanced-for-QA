﻿using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    Vehicles _vehicles;

    [SetUp]
    public void SetUp()
    {
        _vehicles = new Vehicles();
    }
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string[] input = new string[] { "Truck/Volvo/VNL/500", "Car/Toyota/Camry/150", "Car/Ford/Focus/120" };
        string expected = $"Cars:" +
            $"{Environment.NewLine}Ford: Focus - 120hp" +
            $"{Environment.NewLine}Toyota: Camry - 150hp" +
            $"{Environment.NewLine}" +
            $"Trucks:" +
            $"{Environment.NewLine}" +
            $"Volvo: VNL - 500kg";

        // Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        string expected = $"Cars:" +
            $"{Environment.NewLine}" +
            $"Trucks:";
            

        // Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
