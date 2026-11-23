using Microsoft.AspNetCore.Http.HttpResults;

namespace AeonRegistryAPI.Features.Home;

public static class HomeEndpoints
{
    public static IEndpointRouteBuilder MapHomeEndpoints(this IEndpointRouteBuilder route)
    {
        var homeGroup = route.MapGroup("/api/home");
        homeGroup.MapGet("/welcome", GetWelcomeMessage);
        return route;
    }

    private static async Task<Ok<WelcomeResponse>> GetWelcomeMessage()
    {
        var response = new WelcomeResponse("", "", "");
        return TypedResults.Ok(response);
    }
}