using System;
using System.IO;
using System.Reflection;

namespace BotWSaveManager.Command
{
    public static class Globals
    {
        public static readonly string AppPath = Directory.GetParent(new Uri(Assembly.GetEntryAssembly().CodeBase).LocalPath).FullName;
    }
}
