using System;
using SampSharp.Core;
using Default_SampSharp.Gamemodes;

namespace Default_SampSharp
{
    class Default
    {
        static void Main(string[] args)
        {
            new GameModeBuilder().Use<Bare>().Run();
        }
    }
}
