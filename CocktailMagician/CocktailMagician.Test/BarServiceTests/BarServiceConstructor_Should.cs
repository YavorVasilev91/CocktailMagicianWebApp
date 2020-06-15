using System;
using System.Collections.Generic;
using System.Text;
using CocktailMagician.Data;
using CocktailMagician.Models;
using CocktailMagician.Services;
using CocktailMagician.Services.DtoEntities;
using CocktailMagician.Services.DtoMappers.Contracts;
using CocktailMagician.Services.Providers.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CocktailMagician.Test.BarServiceTests
{
    [TestClass]
    public class BarServiceConstructor_Should
    {
        [TestMethod]
        public void Constructor_CreateInstance()
        {
            //Arrange
            var options = TestUtilities.GetOptions(nameof(Constructor_CreateInstance));
            var mockDateTimeProvider = new Mock<IDateTimeProvider>();
            var mockBarDtoMapper = new Mock<IDtoMapper<Bar, BarDTO>>();

            //Act and Assert
            using (var assertContext = new CocktailMagicianContext(options))
            {
                var sut = new BarService(assertContext, mockBarDtoMapper.Object, mockDateTimeProvider.Object);
                Assert.IsNotNull(sut);
            }
        }
        [TestMethod]
        public void Constructor_Throw_WhenContextIsNull()
        {
            //Arrange
            var options = TestUtilities.GetOptions(nameof(Constructor_Throw_WhenContextIsNull));
            var mockDateTimeProvider = new Mock<IDateTimeProvider>();
            var mockBarDtoMapper = new Mock<IDtoMapper<Bar, BarDTO>>();

            //Act and Assert
            using (var assertContext = new CocktailMagicianContext(options))
            {
                Assert.ThrowsException<ArgumentNullException>(() => new BarService(null, mockBarDtoMapper.Object, mockDateTimeProvider.Object));
            }
        }
        [TestMethod]
        public void Constructor_Throw_WhenProviderIsNull()
        {
            //Arrange
            var options = TestUtilities.GetOptions(nameof(Constructor_Throw_WhenProviderIsNull));
            var mockBarDtoMapper = new Mock<IDtoMapper<Bar, BarDTO>>();

            //Act and Assert
            using (var assertContext = new CocktailMagicianContext(options))
            {
                Assert.ThrowsException<ArgumentNullException>(() => new BarService(assertContext, mockBarDtoMapper.Object,null));
            }
        }
        [TestMethod]
        public void Constructor_Throw_WhenDtoMapperIsNull()
        {
            //Arrange
            var options = TestUtilities.GetOptions(nameof(Constructor_Throw_WhenContextIsNull));
            var mockDateTimeProvider = new Mock<IDateTimeProvider>();

            //Act and Assert
            using (var assertContext = new CocktailMagicianContext(options))
            {
                Assert.ThrowsException<ArgumentNullException>(() => new BarService(assertContext, null, mockDateTimeProvider.Object));
            }
        }
    }
}


