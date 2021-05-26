namespace UnityWebBrowser.EventData
{
#if !BROWSER_PROCESS
    [UnityEngine.Scripting.Preserve]
#endif
    public class ExecuteJsEvent : IEventData
    {
        public string Js { get; set; }
        public EventType EventType { get; set; } = EventType.ExecuteJsEvent;
    }
}