using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lixeira : MonoBehaviour
{
    [SerializeField] private GameObject dentro;
    [SerializeField] private GameObject card;
    private bool abracadabra;


    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && abracadabra == true)
        {
        card.SetActive(true); 
        dentro.SetActive(false);
        GetComponent<Collider2D>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {      
        if (collision.CompareTag("Player"))
        {
        abracadabra = true;
        dentro.SetActive(true);
       }

    }

        private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
        abracadabra = false;
        dentro.SetActive(false);    
        }
    }
}
