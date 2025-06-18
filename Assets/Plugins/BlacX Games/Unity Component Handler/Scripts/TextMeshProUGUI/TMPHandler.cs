using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TMPHandler : OBJHandler
    {
        private TextMeshProUGUI _textMeshProUGUI;

        private void Initialize() => _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        private void Awake() => Initialize();
        public void SetText(string text) => _textMeshProUGUI.text = text;
        public void SetColor(Color color) => _textMeshProUGUI.color = color;
        
        public static void SetText(TMPHandler tMPHandler, string text) => tMPHandler.SetText(text);
        public static void SetColor(TMPHandler tMPHandler, Color color) => tMPHandler.SetColor(color);
        
        public static void InitializeAll()
        {
            TMPHandler[] tmpHandlers = FindObjectsByType<TMPHandler>(FindObjectsSortMode.None);
            foreach (TMPHandler item in tmpHandlers)
            {
                if (item != null)
                {
                    item.Initialize();
                }
            }
        }
    }
}
