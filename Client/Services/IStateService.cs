namespace BlazorWebAssemblyPWAHostedStateContainer.Client.Services
{
    public interface IStateService
    {
        string Data { get; set; }
        event Action OnChange;
    }
}
