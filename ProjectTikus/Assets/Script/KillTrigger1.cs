using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class KillTrigger1 : MonoBehaviour
    {
        public GameObject GO;
        public GameObject Controller;
        public GameObject Pause;
        public AudioSource BG;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Kill")
            {
				Time.timeScale=0;
                BG.Stop();
                GO.SetActive(true);
                Controller.SetActive(false);
                Pause.SetActive(false);
            }
        }
    }
}