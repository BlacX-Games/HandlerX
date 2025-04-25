using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BlacXGames
{
    [RequireComponent(typeof(TMP_InputField))]
    public class TMPIFHandler : MonoBehaviour
    {
        private TMP_InputField _inputField;

        private void Awake() => _inputField = GetComponent<TMP_InputField>();
        
        public void SetText(string text) => _inputField.text = text;
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}
