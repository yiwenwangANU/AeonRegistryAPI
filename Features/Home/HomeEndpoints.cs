using Microsoft.AspNetCore.Http.HttpResults;

namespace AeonRegistryAPI.Features.Home;

public static class HomeEndpoints
{
    public static IEndpointRouteBuilder MapHomeEndpoints(this IEndpointRouteBuilder route)
    {
        var homeGroup = route.MapGroup("/api/home").WithTags("Home");
        homeGroup.MapGet("/welcome", GetWelcomeMessage).WithName("GetWelcomeMessage");
        return route;
    }

    private static async Task<Ok<WelcomeResponse>> GetWelcomeMessage()
    {
        var response = new WelcomeResponse("Welcome to Aeon Registry!", "0.0.0", DateTime.Now.ToString());
        return TypedResults.Ok(response);
    }
}