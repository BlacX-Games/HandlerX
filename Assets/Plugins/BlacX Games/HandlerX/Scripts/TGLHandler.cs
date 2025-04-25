using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames
{
    public class TGLHandler : MonoBehaviour
    {
        private Toggle _toggle;

        private void Awake() => _toggle = GetComponent<Toggle>();
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}