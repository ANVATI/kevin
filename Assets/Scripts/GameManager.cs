using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Niveles;
    public GameObject Options;

    public void AppearOptions()
    {
        Time.timeScale = 0;
        Menu.SetActive(true);
    }

    public void DissapearOptions()
    {
        Time.timeScale = 1;
    }

    public void StartLevel()
    {
        Menu.SetActive(false);
        Niveles.SetActive(true);
    }

    public void FirstLevel()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void SecondLevel()
    {
        SceneManager.LoadScene("Nivel2");
    }

}
