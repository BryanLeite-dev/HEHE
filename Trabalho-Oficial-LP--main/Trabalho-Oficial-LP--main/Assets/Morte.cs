using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Morte : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("menosbacana"))
           {
              SceneManager.LoadScene("Derrota");  
           }
    }
}
