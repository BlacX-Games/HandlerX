using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(Dropdown))]
    public class DRPHandler : OBJHandler
    {
        private Dropdown _dropdown;

        public void Initialize() => _dropdown = GetComponent<Dropdown>();
        private void Awake() => Initialize();
        
        public static void InitializeAll()
        {
            DRPHandler[] imgHandlers = FindObjectsByType<DRPHandler>(FindObjectsSortMode.None);
            foreach (DRPHandler item in imgHandlers)
            {
                if (item != null)
                {
                    item.Initialize();
                }
            }
        }
    }   
}
