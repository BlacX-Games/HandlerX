using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(InputField))]
    public class IFHandler : OBJHandler
    {
        private InputField _inputField;

        public void Initialize() => _inputField = GetComponent<InputField>();
        private void Awake() => Initialize();
        public void SetText(string text) => _inputField.text = text;
        
        public static void SetText(IFHandler ifHandler, string text) => ifHandler.SetText(text);
        
        public static void InitializeAll()
        {
            IFHandler[] imgHandlers = FindObjectsByType<IFHandler>(FindObjectsSortMode.None);
            foreach (IFHandler item in imgHandlers)
            {
                if (item != null)
                {
                    item.Initialize();
                }
            }
        }
    }    
}