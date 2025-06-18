using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(Toggle))]
    public class TGLHandler : OBJHandler
    {
        private Toggle _toggle;

        public void Initialize() => _toggle = GetComponent<Toggle>();
        private void Awake() => Initialize();
        
        public static void InitializeAll()
        {
            TGLHandler[] imgHandlers = FindObjectsByType<TGLHandler>(FindObjectsSortMode.None);
            foreach (TGLHandler item in imgHandlers)
            {
                if (item != null)
                {
                    item.Initialize();
                }
            }
        }
    }   
}