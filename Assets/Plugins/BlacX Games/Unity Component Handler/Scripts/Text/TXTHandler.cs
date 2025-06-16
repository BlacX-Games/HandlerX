using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Utilities
{
    [RequireComponent(typeof(Text))]
    public class TXTHandler : OBJHandler
    {
        private Text _text;

        private void Awake() => _text = GetComponent<Text>();
        
        public void SetText(string text) => _text.text = text;
        public void SetColor(Color color) => _text.color = color;
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}
