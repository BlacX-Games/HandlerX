using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames
{
    public class ASHandler : MonoBehaviour
    {
        private AudioSource _audioSource;

        private void Awake() => _audioSource = GetComponent<AudioSource>();
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }
}
