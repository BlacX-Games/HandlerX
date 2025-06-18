using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(BoxCollider))]
    public class BCHandler : OBJHandler
    {
        private BoxCollider _boxCollider;

        private void Awake() => _boxCollider = GetComponent<BoxCollider>();
    }   
}
