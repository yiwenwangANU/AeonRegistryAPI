using AeonRegistryAPI.Models;

namespace AeonRegistryAPI.Features.Auth;

public static class AuthEndpoints{
    public static IEndpointRouteBuilder MapAuthEndpoints(this IEndpointRouteBuilder route)
    {
        var authGroup = route.MapGroup("/api/auth");
        authGroup.MapIdentityApi<ApplicationUser>();
        return route;
    }
}