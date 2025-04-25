using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames
{
    public class IFHandler : MonoBehaviour
    {
        private InputField _inputField;

        private void Awake() => _inputField = GetComponent<InputField>();
        
        public void SetText(string text) => _inputField.text = text;
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }    
}