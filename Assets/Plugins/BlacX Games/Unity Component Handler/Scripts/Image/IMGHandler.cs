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
        public void SetFillAmountToMin() => _image.fillAmount = 0;
        public void SetFillAmountToMax() => _image.fillAmount = 1;
        
        public static void SetSprite(IMGHandler imgHandler, Sprite sprite) => imgHandler.SetSprite(sprite);
        public static void SetColor(IMGHandler imgHandler, Color color) => imgHandler.SetColor(color);
        public static void SetMaterial(IMGHandler imgHandler, Material material) => imgHandler.SetMaterial(material);
        public static void SetRaycastTarget(IMGHandler imgHandler, bool state) => imgHandler.SetRaycastTarget(state);
        public static void SetMaskable(IMGHandler imgHandler, bool state) => imgHandler.SetMaskable(state);
        public static void SetType(IMGHandler imgHandler, Image.Type type) => imgHandler.SetType(type);
        public static void SetTypeToSimple(IMGHandler imgHandler) => imgHandler.SetTypeToSimple();
        public static void SetTypeToSliced(IMGHandler imgHandler) => imgHandler.SetTypeToSliced();
        public static void SetTypeToTiled(IMGHandler imgHandler) => imgHandler.SetTypeToTiled();
        public static void SetTypeToFilled(IMGHandler imgHandler) => imgHandler.SetTypeToFilled();
        public static void SetFillAmount(IMGHandler imgHandler, float amount) => imgHandler.SetFillAmount(amount);
        public static void SetFillAmountToMin(IMGHandler imgHandler) => imgHandler.SetFillAmountToMin();
        public static void SetFillAmountToMax(IMGHandler imgHandler) => imgHandler.SetFillAmountToMax();
    }
}
