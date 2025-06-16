using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames.Plugins.Utilities.Uch
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class RB2DHandler : OBJHandler
    {
        private Rigidbody2D _ridiRigidbody;

        private void Awake() => _ridiRigidbody = GetComponent<Rigidbody2D>();
    }   
}
