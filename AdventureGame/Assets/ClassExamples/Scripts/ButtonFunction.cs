using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
  
    public void ButtonDoesThings()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonQuits()
    {
        Application.Quit();
    }
    
}
