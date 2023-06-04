using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider2D))]

public class InteragirComPuzzleCima : MonoBehaviour
{
    [SerializeField]
    private cartão_colisão quantidade;
    [SerializeField]
    private Interacao _jogadorInterage;
    [SerializeField]
    private UnityEvent _botaoApertado;
    [SerializeField]
    private UnityEvent _qtdErrada;

    private bool _podeExecutar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_podeExecutar)
        {
            if (_jogadorInterage.Interagindo == true)
            {
                if (quantidade.qtd == 4)
                {
                    _botaoApertado.Invoke();
                }else
                {
                    _qtdErrada.Invoke();
                }
                


            }
        }
    }
    private void OnTriggerEnter2D(Collider2D colission)
    {
        
       
            _podeExecutar = true;
        
        
    }
    private void OnTriggerExit2D(Collider2D colission)
    {
        _podeExecutar = false;
    }
}
