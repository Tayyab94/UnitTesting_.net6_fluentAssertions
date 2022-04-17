using FluentAssertions;
using FluentAssertions.Extensions;
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
        private readonly NetworkService _pingService;
        public NetworkServiceTest()
        {
            _pingService = new NetworkService();
        }
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            // Arrange



            //Act
            var result = _pingService.SendPing();

            //Assert
            result.Should().Be("Success: ping sent");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Success", Exactly.Once());
        }

        [Theory]

        [InlineData(2, 2, 4)]
        //[InlineData(1,1,2)]
        public void NetworkService_TimeOut_RetunInt(int a, int b, int expected)
        {
            // Arrange
            //  Act

            var result = _pingService.TimeOut(a, b);

            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(3);
            //result.Should().Equals(2);
            result.Should().NotBeInRange(-1000, 1);
        }

        [Fact]
        public void NetworkServic_ListPingDate_ReturnDate()
        {
            var result = _pingService.ListPingDate();

            // Assert
            result.Should().BeAfter(1.May(2020));
            result.Should().BeBefore(20.April(2022));
        }
    }
}
