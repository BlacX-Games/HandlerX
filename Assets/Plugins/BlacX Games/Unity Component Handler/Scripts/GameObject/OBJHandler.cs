using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlacXGames
{
    public abstract class OBJHandler : MonoBehaviour, IOBJHandler
    {
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }   
}
