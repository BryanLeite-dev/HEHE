using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class codigoderrota : MonoBehaviour
{
    public string cenaName;
    public void Play()
    {
        cenaName = "Menu";
        SceneManager.LoadScene(cenaName);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
