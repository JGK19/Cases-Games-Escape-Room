using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject canosRodantes;
    [SerializeField] private GameObject[] pipes;

    [SerializeField] private int totalCanos = 0; 
    [SerializeField] private int correctedCanos = 0;

    public bool pingente = false;

    void Start()
    {
        totalCanos = canosRodantes.transform.childCount;

        pipes = new GameObject[totalCanos];

        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i] = canosRodantes.transform.GetChild(i).gameObject;
        }
    }


    public void correctMove()
    {
        correctedCanos += 1;

        if(correctedCanos == totalCanos)
        {
        pingente = true;
        }
    }

    public void wrongMove()
    {
        correctedCanos -= 1;
        pingente = false;
    }

}