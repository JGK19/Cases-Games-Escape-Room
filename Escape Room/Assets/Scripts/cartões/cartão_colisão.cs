using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartão_colisão : MonoBehaviour
{  
    public int qtd =0;
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name == "cartão1")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().enabled=false;
            qtd++;
        }
        if (collision.gameObject.name == "cartão1 (1)")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().enabled=false;
            qtd++;
        }
        if (collision.gameObject.name == "cartão1 (2)")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().enabled=false;
            qtd++;
        }
        if (collision.gameObject.name == "cartão1 (3)")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().enabled=false;
            qtd++;
        }
    }
}
