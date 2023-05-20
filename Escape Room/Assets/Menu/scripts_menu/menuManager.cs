using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{

    public string cena;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quitGame() 
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }

    public void playGame()
    {
        SceneManager.LoadScene(cena);
    }
}
