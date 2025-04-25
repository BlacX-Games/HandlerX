using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames
{
    [RequireComponent(typeof(Image))]
    public class IMGHandler : MonoBehaviour
    {
        private Image _image;
        
        private void Awake() => _image = GetComponent<Image>();
        
        public void SetSprite(Sprite sprite) => _image.sprite = sprite;
        public void SetColor(Color color) => _image.color = color;
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }
}
