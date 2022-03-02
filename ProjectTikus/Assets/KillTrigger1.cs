using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class KillTrigger1 : MonoBehaviour
		
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Kill")
            {
				SceneManager.LoadScene("gameover");
            }
        }
    }
}