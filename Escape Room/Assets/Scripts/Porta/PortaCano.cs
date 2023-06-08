using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaCano : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Abre()
    {
        _animator.SetBool("Aberto", true);
    }
}