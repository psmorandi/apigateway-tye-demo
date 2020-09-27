namespace SystemApi.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("[controller]")]
    public class SystemInfoController : ControllerBase
    {
        private readonly ILogger<SystemInfoController> _logger;

        public SystemInfoController(ILogger<SystemInfoController> logger)
        {
            this._logger = logger;
        }

        [HttpGet]
        public SystemInfo Get()
        {
            var threadId = Environment.CurrentManagedThreadId;
            var osVersion = Environment.OSVersion;
            var processId = Environment.ProcessId;

            return new SystemInfo(
                threadId,
                processId,
                osVersion.Platform.ToString(),
                osVersion.ServicePack,
                osVersion.VersionString);
        }
    }
}