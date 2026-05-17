using DogJwtApi.Extensions;
using DogJwtApi.Models;

namespace DogJwtApi.Endpoints;

public static class DogEndpoints
{
    public static WebApplication MapDogEndpoints(this WebApplication app)
    {
        app.MapGet("/dog/bark-loudly", () => TypedResults.Text(new Dog().BarkLoudly()));

        return app;
    }
}
