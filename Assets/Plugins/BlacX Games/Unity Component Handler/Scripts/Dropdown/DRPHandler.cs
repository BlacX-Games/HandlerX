using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(Dropdown))]
    public class DRPHandler : OBJHandler
    {
        private Dropdown _dropdown;

        private void Awake() => _dropdown = GetComponent<Dropdown>();
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}
