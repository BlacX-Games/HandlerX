using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Utilities
{
    [RequireComponent(typeof(Slider))]
    public class SLDHandler : OBJHandler
    {
        private Slider _slider;

        private void Awake() => _slider = GetComponent<Slider>();
    }   
}
