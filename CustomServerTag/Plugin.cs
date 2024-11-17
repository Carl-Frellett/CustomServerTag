using Exiled.API.Features;
using HarmonyLib;

namespace CustomServerTag
{
    class Plugin : Plugin<Config>
    {
        public override string Name => "CustomServerTag";
        public override string Author => "Carl Frellet";
        public Harmony Harmony { get; private set; }
        private int yee;
        public override void OnEnabled()
        {
            base.OnEnabled();
            Harmony = new Harmony($"CustomServerTag.{++yee}");
            Harmony.PatchAll();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
            Harmony.UnpatchAll();
        }
    }
}
