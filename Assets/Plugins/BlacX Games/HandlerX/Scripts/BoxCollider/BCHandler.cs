using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames.Plugins.Utilities
{
    [RequireComponent(typeof(BoxCollider))]
    public class BCHandler : OBJHandler
    {
        private BoxCollider _boxCollider;

        private void Awake() => _boxCollider = GetComponent<BoxCollider>();
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}
