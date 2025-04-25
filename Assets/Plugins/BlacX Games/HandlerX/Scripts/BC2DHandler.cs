using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames.Plugins.Utilities
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class BC2DHandler : MonoBehaviour
    {
        private BoxCollider2D _boxCollider;

        private void Awake() => _boxCollider = GetComponent<BoxCollider2D>();
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}