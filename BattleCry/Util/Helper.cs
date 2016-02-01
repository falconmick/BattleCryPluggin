using System.IO;
using System.Reflection;

namespace BattleCry.Util
{
    public static class Helper
    {
        public static string GetPluginDllLocation()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
    }
}
