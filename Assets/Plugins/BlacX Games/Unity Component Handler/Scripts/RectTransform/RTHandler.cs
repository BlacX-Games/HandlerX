using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(RectTransform))]
    public class RTHandler : OBJHandler
    {
        private RectTransform _rectTransform;

        public void Initialize() => _rectTransform = GetComponent<RectTransform>();
        private void Awake() => Initialize();
        
        public static void InitializeAll()
        {
            RTHandler[] imgHandlers = FindObjectsByType<RTHandler>(FindObjectsSortMode.None);
            foreach (RTHandler item in imgHandlers)
            {
                if (item != null)
                {
                    item.Initialize();
                }
            }
        }
    }
}
