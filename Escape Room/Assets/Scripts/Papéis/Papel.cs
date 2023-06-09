using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Papel : MonoBehaviour
{    
    public SpriteRenderer papel1_1;
    public GameObject Seta;
    private bool triggerEntered;
    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.E)&& triggerEntered == true)
        {
        papel1_1.GetComponent<SpriteRenderer>().enabled=true;
        }
        if (triggerEntered == false)
        {
          papel1_1.GetComponent<SpriteRenderer>().enabled=false;   
        }
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        Seta.SetActive(true);
           triggerEntered = true;
        
    }
    private void OnTriggerExit2D (Collider2D collision)
    {
           triggerEntered = false;
        Seta.SetActive(false);
    }
}
