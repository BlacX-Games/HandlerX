using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Utilities.Uch
{
    [RequireComponent(typeof(Image))]
    public class IMGHandler : OBJHandler
    {
        private Image _image;
        
        private void Awake() => _image = GetComponent<Image>();
        
        public void SetSprite(Sprite sprite) => _image.sprite = sprite;
        public void SetColor(Color color) => _image.color = color;
        public void SetFillAmount(float amount) => _image.fillAmount = amount;
        public void SetFillAmountToMin(float amount) => _image.fillAmount = 0;
        public void SetFillAmountToMax(float amount) => _image.fillAmount = 1;
        
        public static void SetSprite(IMGHandler imgHandler, Sprite sprite) => imgHandler.SetSprite(sprite);
        public static void SetColor(IMGHandler imgHandler, Color color) => imgHandler.SetColor(color);
    }
}
