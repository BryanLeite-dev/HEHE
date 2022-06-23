using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    // Start is called before the first frame update

    public int vida = 1; 

    void Awake()
    {
        transform.tag = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
