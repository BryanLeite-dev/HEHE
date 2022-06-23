using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text textScore;
    public GameObject bacanamaisbacana;
    public Transform daoralegal;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        textScore.text = "Pontos: " + score;
        if(score>=5){
           Instantiate(bacanamaisbacana, daoralegal.position, daoralegal.rotation);
        }
    }
}