using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;

public class AuthControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public AuthControllerIntegrationTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.WithWebHostBuilder(builder =>
        {
            builder.UseEnvironment("Testing");
        }).CreateClient();
    }

    [Fact]
    public async Task Register_Endpoint_Should_Create_User()
    {
        var registerData = new
        {
            Username = "testuser",
            Password = "TestPassword123"
        };
        var content = new StringContent(JsonConvert.SerializeObject(registerData), Encoding.UTF8, "application/json");

        var response = await _client.PostAsync("/api/Auth/register", content);

        response.EnsureSuccessStatusCode();
    }
}
