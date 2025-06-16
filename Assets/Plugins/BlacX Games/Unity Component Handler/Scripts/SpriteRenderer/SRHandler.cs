using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames.Plugins.Utilities
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class SRHandler : OBJHandler
    {
        private SpriteRenderer _spriteRenderer;

        private void Awake() => _spriteRenderer = GetComponent<SpriteRenderer>();
        
        public void SetSprite(Sprite sprite) => _spriteRenderer.sprite = sprite;
        public void SetColor(Color color) => _spriteRenderer.color = color;
    }
}
