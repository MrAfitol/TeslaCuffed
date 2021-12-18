using Exiled.API.Features;
using Exiled.API.Interfaces;
using System;
using System.ComponentModel;

namespace TeslaCuffed
{
    public class Config : IConfig
    {
        [Description("Whether or not this plugin is enabled")]
        public bool IsEnabled { get; set; } = true;
    }
}
