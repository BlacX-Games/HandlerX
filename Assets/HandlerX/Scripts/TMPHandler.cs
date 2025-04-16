using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BlacXGames
{
    public class TMPHandler : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshProUGUI;

        private void Awake() => _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        
        public void SetText(string text) => _textMeshProUGUI.text = text;
        public void SetColor(Color color) => _textMeshProUGUI.color = color;
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }
}
