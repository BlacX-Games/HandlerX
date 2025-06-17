using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(Button))]
    public class BTNHandler : OBJHandler
    {
        private Button _button;

        private void Awake() => _button = GetComponent<Button>();
        
        public void SetInteractable(bool state) => _button.interactable = state;
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}
