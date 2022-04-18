namespace BlazorTestApp.Client.Services
{
    public class RandomServiceTwo : IRandomServiceTransient, IRandomServiceScoped, IRandomServiceSingleton
    {
        //TODO: Change this service because it is identical to the other RandomService
        //For now, it's just a basic example
        public Guid RandomID { get; } = Guid.NewGuid();
    }
}
