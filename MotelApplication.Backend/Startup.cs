﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MotelApplication.Backend.Startup))]
namespace MotelApplication.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
