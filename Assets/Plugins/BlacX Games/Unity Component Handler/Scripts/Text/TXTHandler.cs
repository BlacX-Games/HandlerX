using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(Text))]
    public class TXTHandler : OBJHandler
    {
        private Text _text;

        public void Initialize() => _text = GetComponent<Text>();
        private void Awake() => Initialize();
        public void SetText(string text) => _text.text = text;
        public void SetColor(Color color) => _text.color = color;
        
        public static void SetText(TXTHandler txtPHandler, string text) => txtPHandler.SetText(text);
        public static void SetColor(TXTHandler txtPHandler, Color color) => txtPHandler.SetColor(color);
        
        public static void InitializeAll()
        {
            IMGHandler[] imgHandlers = FindObjectsByType<IMGHandler>(FindObjectsSortMode.None);
            foreach (IMGHandler item in imgHandlers)
            {
                if (item != null)
                {
                    item.Initialize();
                }
            }
        }
    }   
}
