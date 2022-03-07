namespace tests
{
    using domain.Entidades;
    using System.Collections.Generic;
    using services;
    using Xunit;
    public class DividerServiceTest
    {
        [Fact]
        public void NeedToReturnDividers()
        {
            DividerService dividerService = new DividerService();
            Divider divider = new Divider
            {
                Number = 10,
                Prime = false
            };
            var waitList = new List<long> { 1,2, 5, 10};

            //Act
            var result = dividerService.CalculateDivider(divider);

            //Assert
            Assert.True(result.Ok);
            Assert.Null(result.Error);
            Assert.Equal(waitList, result.Dividers);
        }

        [Fact]
        public void NeedToReturnDividersPrime()
        {
            DividerService dividerService = new DividerService();
            Divider divider = new Divider(10, true);
            var waitList = new List<long> { 2, 5 };

            //Act
            var result = dividerService.CalculateDivider(divider);

            //Assert
            Assert.True(result.Ok);
            Assert.Null(result.Error);
            Assert.Equal(waitList, result.Dividers);

        }

        [Fact]
        public void NeedToReturnInvalidNumber()
        {
            DividerService dividerService = new DividerService();
            Divider divider = new Divider(0, false);
            //Act
            var result = dividerService.CalculateDivider(divider);

            //Assert
            Assert.True(result.Ok);
            Assert.Null("Numero nao pode ser nulo ou vazio.", result.Error);
            Assert.Equal(waitList, result.Dividers);

        }
    }
}