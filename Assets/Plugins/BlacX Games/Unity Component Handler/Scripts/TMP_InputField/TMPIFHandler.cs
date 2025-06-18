using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(TMP_InputField))]
    public class TMPIFHandler : OBJHandler
    {
        private TMP_InputField _inputField;

        public void Initialize() => _inputField = GetComponent<TMP_InputField>();
        private void Awake() => Initialize();
        public void SetText(string text) => _inputField.text = text;
        
        public static void SetText(TMPIFHandler tmpifHandler, string text) => tmpifHandler.SetText(text);
        
        public static void InitializeAll()
        {
            TMPIFHandler[] imgHandlers = FindObjectsByType<TMPIFHandler>(FindObjectsSortMode.None);
            foreach (TMPIFHandler item in imgHandlers)
            {
                if (item != null)
                {
                    item.Initialize();
                }
            }
        }
    }   
}
