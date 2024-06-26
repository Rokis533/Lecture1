﻿using Microsoft.AspNetCore.SignalR;

namespace DependencyInjection.Services
{
    public interface ITestService 
    {
        public Run GetRun();
    }

    public class TestService : ITestService
    {
        private readonly IMyScopedService _scopedService;
        private readonly IMySingletonService _singletonService;
        private readonly IMyTransientService _transientService;
        public TestService(IMyScopedService myScopedService, IMySingletonService mySingletonService, IMyTransientService transientService)
        {
            _scopedService = myScopedService;
            _singletonService = mySingletonService;
            _transientService = transientService;
        }

        public Run GetRun()
        {
            return new Run()
            {
                Transient = _transientService.GetGuid(),
                Scoped = _scopedService.GetGuid(),
                Singleton = _singletonService.GetGuid()
            };
        }
    }
}
