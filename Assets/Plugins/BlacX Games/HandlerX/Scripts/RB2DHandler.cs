using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class RB2DHandler : MonoBehaviour
    {
        private Rigidbody2D _ridiRigidbody;

        private void Awake() => _ridiRigidbody = GetComponent<Rigidbody2D>();
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}
