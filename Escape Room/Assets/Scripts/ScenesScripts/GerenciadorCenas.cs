using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorCenas : MonoBehaviour
{
 
   public void PlayAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
        Debug.Log("Loading game...");
    }
    public void QuitMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("menu");
        Debug.Log("Loading menu...");
    }
}
