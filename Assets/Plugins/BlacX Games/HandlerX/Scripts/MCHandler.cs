using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames
{
    [RequireComponent(typeof(MeshCollider))]
    public class MCHandler : MonoBehaviour
    {
        private MeshCollider _meshCollider;

        private void Awake() => _meshCollider = GetComponent<MeshCollider>();
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}
