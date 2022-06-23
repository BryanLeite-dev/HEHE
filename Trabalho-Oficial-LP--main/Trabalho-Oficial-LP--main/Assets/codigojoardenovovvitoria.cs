using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class codigojoardenovovvitoria : MonoBehaviour
{
    public string cenaName;
    public void Play()
    {
        cenaName = "fase 1";
        SceneManager.LoadScene(cenaName);
    }

    public void Exit()
    {
        Application.Quit();
    }
}