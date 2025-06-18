using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(Slider))]
    public class SLDHandler : OBJHandler
    {
        private Slider _slider;

        public void Initialize() => _slider = GetComponent<Slider>();
        private void Awake() => Initialize();
        
        public static void InitializeAll()
        {
            SLDHandler[] imgHandlers = FindObjectsByType<SLDHandler>(FindObjectsSortMode.None);
            foreach (SLDHandler item in imgHandlers)
            {
                if (item != null)
                {
                    item.Initialize();
                }
            }
        }
    }   
}
