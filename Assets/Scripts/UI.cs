using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject Options;
    public GameObject Close;

    public void AppearOptions()
    {
        Time.timeScale = 0;
        Options.SetActive(true);
    }

    public void DissapearOptions()
    {
        Time.timeScale = 1;
        Options.SetActive(false);
    }
}
