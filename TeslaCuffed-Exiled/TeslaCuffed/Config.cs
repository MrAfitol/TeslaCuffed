using Exiled.API.Features;
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCuffed
{
    public class Config : IConfig
    {
        [Description("Whether or not this plugin is enabled")]
        public bool IsEnabled { get; set; } = true;
    }
}
