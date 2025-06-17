using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(MeshCollider))]
    public class MCHandler : OBJHandler
    {
        private MeshCollider _meshCollider;

        private void Awake() => _meshCollider = GetComponent<MeshCollider>();
    }   
}
