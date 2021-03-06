﻿using Gate.Adapters.Nancy;
using Nancy;
using Owin;
using Utils;

namespace Case05_JustNancy
{
    public class Startup
    {
        public void Configuration(IAppBuilder builder)
        {
            builder
                .Use<AppTaskDelegate>(Middleware.LogRequests)
                .RunNancy();
        }
    }

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Hello world!";
        }
    }
}
