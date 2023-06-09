using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject ui1,ui2;
    public static bool ispaused = false;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((!ui1.activeSelf) && (!ui2.activeSelf)) { 
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(ispaused) {
                resumeGame();
            } else {
                pauseGame();
            }
        }
        }
    }

    public void pauseGame() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }

    public void resumeGame() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }

    public void LoadMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("menu");
        Debug.Log("Loading menu...");
    }
}
