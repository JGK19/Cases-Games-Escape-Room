using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartão_surge : MonoBehaviour
{
    public Transform cartão1_1;
    public SpriteRenderer cartão1;
    void Update ()
    {
        if (cartão1.GetComponent<SpriteRenderer>().enabled==false)
        {
            cartão1_1.GetComponent<SpriteRenderer>().enabled=true;
        }
    }
    
}
