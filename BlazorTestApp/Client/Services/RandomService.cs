namespace BlazorTestApp.Client.Services
{
    public class RandomService
    {
        //Source: https://www.youtube.com/watch?v=gjvyM240B-Q&list=PLUOequmGnXxPrY79JGnF72e1Pba8z93zo&index=5
        public static Guid RandomID { get; } = Guid.NewGuid();
    }
}
