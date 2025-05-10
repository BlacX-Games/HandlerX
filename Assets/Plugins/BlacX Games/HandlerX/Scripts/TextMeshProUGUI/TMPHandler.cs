using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BlacXGames.Plugins.Utilities
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TMPHandler : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshProUGUI;

        private void Awake() => _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        
        public void SetText(string text) => _textMeshProUGUI.text = text;
        public void SetColor(Color color) => _textMeshProUGUI.color = color;
        
        public static void SetText(TMPHandler tMPHandler, string text) => tMPHandler.SetText(text);
        public static void SetColor(TMPHandler tMPHandler, Color color) => tMPHandler.SetColor(color);
    }
}
