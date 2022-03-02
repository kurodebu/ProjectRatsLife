using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class FinishTrigger1 : MonoBehaviour
		
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Finish")
            {
				SceneManager.LoadScene("Level2");
            }
        }
    }
}
