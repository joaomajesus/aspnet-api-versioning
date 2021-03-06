﻿namespace Microsoft.AspNetCore.Mvc.Simulators
{
    using System;
    using System.Threading.Tasks;

    [Route( "api/[controller]" )]
    public sealed class ConventionsController : Controller
    {
        public string Get() => "Test (1.0)";

        [HttpGet( "{id:int}" )]
        public string Get( int id ) => $"Test {id} (1.0)";

        public string GetV2() => "Test (2.0)";

        [HttpGet( "{id:int}" )]
        public string GetV2( int id ) => $"Test {id} (2.0)";
    }
}
