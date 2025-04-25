using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames
{
    public class SLDHandler : MonoBehaviour
    {
        private Slider _slider;

        private void Awake() => _slider = GetComponent<Slider>();
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}
