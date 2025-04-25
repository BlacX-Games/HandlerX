using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames
{
    public class RTHandler : MonoBehaviour
    {
        private RectTransform _rectTransform;

        private void Awake() => _rectTransform = GetComponent<RectTransform>();
    
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }
}
