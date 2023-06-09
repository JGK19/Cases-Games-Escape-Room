using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]


public class PortaCima : MonoBehaviour
{
    
    [SerializeField] private GameObject playerFinal;
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Abre()
    {
        _animator.SetBool("Aberto", true);
        
        playerFinal.SetActive(true);
        
    }
}
