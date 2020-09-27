namespace Frontend.DTO
{
    public class SystemInfoDto
    {
        public string OsVersion { get; set; }
        public string Platform { get; set; }
        public int ProcessId { get; set; }
        public string ServicePack { get; set; }
        public int ThreadId { get; set; }
    }
}