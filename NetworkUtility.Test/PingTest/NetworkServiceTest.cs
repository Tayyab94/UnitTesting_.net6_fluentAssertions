using FluentAssertions;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NetworkUtility.Test.PingTest
{
    public class NetworkServiceTest
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            // Arrange

            var pingService = new NetworkService();

            //Act
            var result= pingService.SendPing();

            //Assert
            result.Should().Be("Success: ping sent");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Success", Exactly.Once());
        }

        [Theory]
      
        [InlineData(2,2,4)]
        //[InlineData(1,1,2)]
        public void NetworkService_TimeOut_RetunInt(int a, int b, int expected)
        {   
            // Arrange

            var pingService= new NetworkService();
            //  Act

            var result = pingService.TimeOut(a, b);

        //
        result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(3);
            //result.Should().Equals(2);
            result.Should().NotBeInRange(-1000, 1);
        }
    }
}
