﻿using JWT.Bearer.Claims.Auth.Extractor.Middleware;
using Microsoft.AspNetCore.Builder;

namespace JWT.Bearer.Claims.Auth.Extractor;
/// <summary>
/// The middleware extensions.
/// </summary>

public static class MiddlewareExtensions
{
    /// <summary>
    /// Uses the jwt token claims middleware.
    /// </summary>
    /// <param name="builder">The builder.</param>
    /// <returns>An IApplicationBuilder.</returns>
    public static IApplicationBuilder UseJwtTokenClaimsMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<JwtBearerTokenMiddleware>();
    }

    //public static IApplicationBuilder UseJwtExceptionMiddleware(this IApplicationBuilder builder)
    //{
    //    return builder.UseMiddleware<JwtExceptionMiddleware>();
    //}
}