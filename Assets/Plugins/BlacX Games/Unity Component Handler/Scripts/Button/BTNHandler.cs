using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(Button))]
    public class BTNHandler : OBJHandler
    {
        private Button _button;

        public void Initialize() => _button = GetComponent<Button>();
        private void Awake() => Initialize();
        public void SetInteractable(bool state) => _button.interactable = state;
        
        public static void SetInteractable(BTNHandler btnHandler, bool state) => btnHandler.SetInteractable(state);
        
        public static void InitializeAll()
        {
            BTNHandler[] imgHandlers = FindObjectsByType<BTNHandler>(FindObjectsSortMode.None);
            foreach (BTNHandler item in imgHandlers)
            {
                if (item != null)
                {
                    item.Initialize();
                }
            }
        }
    }   
}
