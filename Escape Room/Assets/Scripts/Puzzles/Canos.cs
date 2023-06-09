using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canos : MonoBehaviour
{
    [SerializeField] private GameObject puzzelPanel;
    [SerializeField] private GameObject puzzle;
    [SerializeField] private GameObject canos;
    [SerializeField] private GameObject interacao;   
    private bool canShowPuzzel;
    [SerializeField] private GameManager gManager;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && canShowPuzzel)
        {
        puzzle.SetActive(true);    
        }
        if(gManager.pingente == true)
        {
        puzzle.SetActive(false);
        interacao.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.E) && canShowPuzzel)
        {
        interacao.SetActive(false);    
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {      
        if (collision.CompareTag("Player"))
        {
        canShowPuzzel = true;
        interacao.SetActive(true);
        }
  
        if (collision.CompareTag("Player") && gManager.pingente == true)
        {
        canShowPuzzel = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
        canShowPuzzel = false;
        canos.SetActive(false);
        interacao.SetActive(false);       
        }
    }
}
