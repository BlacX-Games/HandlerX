using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BlacXGames.Plugins.Utilities.Uch
{
    [RequireComponent(typeof(TMP_InputField))]
    public class TMPIFHandler : OBJHandler
    {
        private TMP_InputField _inputField;

        private void Awake() => _inputField = GetComponent<TMP_InputField>();
        
        public void SetText(string text) => _inputField.text = text;
    }   
}
