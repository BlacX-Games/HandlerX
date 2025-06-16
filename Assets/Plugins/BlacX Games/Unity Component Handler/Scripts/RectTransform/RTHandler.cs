using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames.Plugins.Utilities
{
    [RequireComponent(typeof(RectTransform))]
    public class RTHandler : OBJHandler
    {
        private RectTransform _rectTransform;

        private void Awake() => _rectTransform = GetComponent<RectTransform>();
    }
}
