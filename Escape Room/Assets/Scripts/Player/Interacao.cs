using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao : MonoBehaviour
{
    public bool Interagindo{get; set; }
    void Update()
    {
        if(Input.GetButtonDown("Interage"))
        {
            Interagindo = true;
        }
        else
        {
            Interagindo = false;
        }
    }
}
