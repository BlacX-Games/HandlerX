using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames.Plugins.Utilities
{
    [RequireComponent(typeof(Rigidbody))]
    public class RBHandler : OBJHandler
    {
        private Rigidbody _ridiRigidbody;

        private void Awake() => _ridiRigidbody = GetComponent<Rigidbody>();
    }   
}