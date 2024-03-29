using CloudCustomers.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using Xunit;

namespace CloudCustomers.UnitTests.Systems.Controllers;

public class TestUsersController
{

    [Fact]
    public async Task Get_OnSuccess_ReturnsStatusCode200() 
    {
        var sut = new UsersController();

        var result = (OkObjectResult)await sut.Get();

        result.StatusCode.Should().Be(200);

    }
}