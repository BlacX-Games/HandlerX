using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames
{
    public class RBHandler : MonoBehaviour
    {
        private Rigidbody _ridiRigidbody;

        private void Awake() => _ridiRigidbody = GetComponent<Rigidbody>();
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}