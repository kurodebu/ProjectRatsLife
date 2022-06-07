using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class FinishTrigger1 : MonoBehaviour
    {
        public GameObject Win;
        public GameObject Controller;
        public GameObject Pause;
        public AudioSource BG;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Finish")
            {
				Time.timeScale=0;
                BG.Stop();
                Win.SetActive(true);
                Controller.SetActive(false);
                Pause.SetActive(false);
            }
        }
    }
}
