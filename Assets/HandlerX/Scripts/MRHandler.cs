using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames
{
    public class MRHandler : MonoBehaviour
    {
        private MeshRenderer _meshRenderer;

        private void Awake() => _meshRenderer = GetComponent<MeshRenderer>();
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}
