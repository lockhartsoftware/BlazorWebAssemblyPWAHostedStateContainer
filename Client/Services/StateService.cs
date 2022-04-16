namespace BlazorWebAssemblyPWAHostedStateContainer.Client.Services
{
    public class StateService : IStateService
    {
        private string stateData = "";
        public string Data
        {
            get => stateData;
            set
            {
                stateData = value;
                NotifyStateChanged();
            }
        }
        public event Action OnChange;
        void NotifyStateChanged() => OnChange?.Invoke();
    }
}
