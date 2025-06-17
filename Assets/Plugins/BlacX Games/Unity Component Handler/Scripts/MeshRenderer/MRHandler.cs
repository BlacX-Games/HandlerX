using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(MeshRenderer))]
    public class MRHandler : OBJHandler
    {
        private MeshRenderer _meshRenderer;

        private void Awake() => _meshRenderer = GetComponent<MeshRenderer>();
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}
