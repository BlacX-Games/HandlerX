using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(Toggle))]
    public class TGLHandler : OBJHandler
    {
        private Toggle _toggle;

        private void Awake() => _toggle = GetComponent<Toggle>();
    }   
}