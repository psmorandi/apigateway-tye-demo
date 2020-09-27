namespace SystemApi.Controllers
{
    public class SystemInfo
    {
        public SystemInfo(int threadId, int processId, string platform, string servicePack, string osVersion)
        {
            this.ThreadId = threadId;
            this.ProcessId = processId;
            this.Platform = platform;
            this.ServicePack = servicePack;
            this.OsVersion = osVersion;
        }

        public string OsVersion { get; }
        public string Platform { get; }
        public int ProcessId { get; }
        public string ServicePack { get; }
        public int ThreadId { get; }
    }
}