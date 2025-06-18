using BlacXGames.Plugins.Utilities;
using UnityEngine;

namespace BlacXGames.Plugins.Uch
{
    public class ComponentHandler
    {
        public static void Initialize()
        {
            IMGHandler.InitializeAll();
            TMPHandler.InitializeAll();
        }
    }   
}
