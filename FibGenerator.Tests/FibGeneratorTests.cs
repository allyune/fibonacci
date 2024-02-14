using System;
using System.Collections.Generic;
using FibGenerator.CommandHandlers.FibGenerator;
using NUnit.Framework;

namespace FibGenerator.Tests
{
    [TestFixture]
    public class FibGeneratorTests
    {
        private IFibGenerator _fibGenerator;

        [SetUp]
        public void SetUp()
        {
            ServiceResolver.Initialize();
            _fibGenerator = ServiceResolver.Resolve<IFibGenerator>();
        }

        [Test]
        public void GenerateFibonacciNumbers_ReturnsCorrectSequence_ForValidInput()
        {
            // Arrange
            int places = 5;
            List<int> expectedSequence = new List<int> { 0, 1, 1, 2, 3 };

            // Act
            List<int> actualSequence = _fibGenerator.GenerateFibonacciNumbers(places);

            // Assert
            Assert.That(actualSequence, Is.EqualTo(expectedSequence));
        }

        [Test]
        public void GenerateFibonacciNumbers_ReturnsEmptyList_ForZeroPlaces()
        {
            // Arrange
            int places = 0;
            List<int> expectedSequence = new List<int>();

            // Act
            List<int> actualSequence = _fibGenerator.GenerateFibonacciNumbers(places);

            // Assert
            Assert.That(actualSequence, Is.EqualTo(expectedSequence));
        }

        [Test]
        public void GenerateFibonacciNumbers_ThrowsException_ForNegativePlaces()
        {
            // Arrange
            int places = -5;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _fibGenerator.GenerateFibonacciNumbers(places));
        }

        [TearDown]
        public void TearDown()
        {
            ServiceResolver.DisposeContainer();
        }

    }
}
