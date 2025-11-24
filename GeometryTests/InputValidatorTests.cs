using Microsoft.VisualStudio.TestTools.UnitTesting;
using пр2_пис2;
using System;
using System.Collections.Generic;
namespace GeometryTests;

[TestClass]
public class InputValidatorTestss
{
    public class InputValidatorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateFilePath_EmptyString_ShouldThrowException()
        {
            // Act
            InputValidator.ValidateFilePath("");
        }

        [TestMethod]
        public void ValidatePointCount_PositiveNumber_ShouldNotThrow()
        {
            // Act & Assert - не должно быть исключения
            InputValidator.ValidatePointCount(5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidatePointCount_Zero_ShouldThrowException()
        {
            // Act
            InputValidator.ValidatePointCount(0);
        }
    }
}