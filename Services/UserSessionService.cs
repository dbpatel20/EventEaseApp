namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        public string? UserName { get; private set; }
        public string? RegisteredEvent { get; private set; }

        public bool IsRegistered => !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(RegisteredEvent);

        public void Register(string name, string selectedEvent)
        {
            UserName = name;
            RegisteredEvent = selectedEvent;
        }

        public void ClearSession()
        {
            UserName = null;
            RegisteredEvent = null;
        }
    }
}
