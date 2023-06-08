using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCano : MonoBehaviour
{
    float[] rotations = { 0,90 };
    [SerializeField] private float correctRotation;
    [SerializeField] private bool isPlaced = false;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Start()
    {   
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

        if (transform.eulerAngles.z == correctRotation)
        {
            isPlaced = true;
            gameManager.correctMove();
        }
    }
    
    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));

        if(transform.eulerAngles.z == correctRotation && isPlaced == false)
        {
            isPlaced = true;
            gameManager.correctMove();
        }
        else if(isPlaced == true)
        {
            isPlaced = false;
            gameManager.wrongMove();
        }        
    }

    void Update()
    {
    }

}