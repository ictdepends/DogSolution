using DogJwtApi.Models;

namespace DogJwtApi.Extensions;

public static class DogExtensions
{
    public static string BarkLoudly(this Dog dog)
    {
        ArgumentNullException.ThrowIfNull(dog);
        return "WOOF";
    }
}
