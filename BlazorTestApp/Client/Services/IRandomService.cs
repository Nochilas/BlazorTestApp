namespace BlazorTestApp.Client.Services
{
    //Example src: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-6.0
    public interface IRandomService
    {
        Guid RandomID { get; }
    }

    public interface IRandomServiceTransient : IRandomService { }
    public interface IRandomServiceScoped : IRandomService { }
    public interface IRandomServiceSingleton : IRandomService { }
}
