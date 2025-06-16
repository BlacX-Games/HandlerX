using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace BlacXGames.Plugins.Utilities
{
    [RequireComponent(typeof(AudioSource))]
    public class ASHandler : OBJHandler
    {
        private AudioSource _audioSource;

        private void Awake() => _audioSource = GetComponent<AudioSource>();
    }
}
