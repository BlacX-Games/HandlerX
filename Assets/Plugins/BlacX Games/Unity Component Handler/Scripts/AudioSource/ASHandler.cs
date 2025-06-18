using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace BlacXGames.Plugins.Uch
{
    [RequireComponent(typeof(AudioSource))]
    public class ASHandler : OBJHandler
    {
        private AudioSource _audioSource;

        public void Initialize() => _audioSource = GetComponent<AudioSource>();
        private void Awake() => Initialize();
        
        public static void InitializeAll()
        {
            ASHandler[] asHandlers = FindObjectsByType<ASHandler>(FindObjectsSortMode.None);
            foreach (ASHandler item in asHandlers)
            {
                if (item != null)
                {
                    item.Initialize();
                }
            }
        }
    }
}
