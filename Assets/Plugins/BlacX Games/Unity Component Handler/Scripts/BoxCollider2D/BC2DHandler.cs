using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class BC2DHandler : OBJHandler
    {
        private BoxCollider2D _boxCollider;

        private void Awake() => _boxCollider = GetComponent<BoxCollider2D>();
    }   
}