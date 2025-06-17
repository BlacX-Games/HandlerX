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

        private void Awake() => _inputField = GetComponent<InputField>();
        
        public void SetText(string text) => _inputField.text = text;
    }    
}