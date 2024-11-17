using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CustomServerTag
{
    class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("The server tag you want (You can use <color>)")]
        public string ServerTag { get; set; } = "<color=#00000000>CustomServerTag</color>";
    }
}
