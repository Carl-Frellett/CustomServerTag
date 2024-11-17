using HarmonyLib;

namespace CustomServerTag
{
    [HarmonyPatch(typeof(ServerConsole), nameof(ServerConsole.ReloadServerName))]
    public class Patch
    {
        private void Postfix()
        {
            Config config = new Config();
            ServerConsole serverConsole = new ServerConsole();
            serverConsole.name += $"<size=1>{config.ServerTag}</size>";
        }
    }
}
