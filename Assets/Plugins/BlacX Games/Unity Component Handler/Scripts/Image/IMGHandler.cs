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
        public void SetMaterial(Material material) => _image.material = material;
        public void SetRaycastTarget(bool state) => _image.raycastTarget = state;
        public void SetMaskable(bool state) => _image.maskable = state;
        public void SetType(Image.Type type) => _image.type = type;
        public void SetTypeToSimple() => _image.type = Image.Type.Simple;
        public void SetTypeToSliced() => _image.type = Image.Type.Sliced;
        public void SetTypeToTiled() => _image.type = Image.Type.Tiled;
        public void SetTypeToFilled() => _image.type = Image.Type.Filled;
        public void SetFillAmount(float amount) => _image.fillAmount = amount;
        public void SetFillAmountToMin(float amount) => _image.fillAmount = 0;
        public void SetFillAmountToMax(float amount) => _image.fillAmount = 1;
        
        public static void SetSprite(IMGHandler imgHandler, Sprite sprite) => imgHandler.SetSprite(sprite);
        public static void SetColor(IMGHandler imgHandler, Color color) => imgHandler.SetColor(color);
    }
}
