using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider2D))]
public class InteragirComBotaoDireitaBaixo : MonoBehaviour
{
    [SerializeField]
    private Interacao _jogadorInterage;
    [SerializeField]
    private UnityEvent _botaoApertado;
    public GameObject PauseMenu;
    private bool _podeExecutar;
    public GameObject _seta;
    [SerializeField] private GameManager gManager;
    private bool canShowPainel;
    [SerializeField] private GameObject fechada;

    void Start()
    {
        _seta.SetActive(false);
    }

    void Update()
    {

        if (!PauseMenu.activeSelf) { 
        if (_podeExecutar)
        {
            if(_jogadorInterage.Interagindo == true && gManager.pingente == true)
            {
                _botaoApertado.Invoke();
            }
            if(gManager.pingente == false && canShowPainel == true)
            {
            fechada.SetActive(true);
            }    
        }
        }
    }         

    private void OnTriggerEnter2D(Collider2D colission)
    {
        _seta.SetActive(true);
        _podeExecutar = true;

    if (colission.CompareTag("Player"))
    {
    canShowPainel = true;
    }

    }
    private void OnTriggerExit2D(Collider2D colission)
    {
        _seta.SetActive(false);
        _podeExecutar = false;

    if (colission.CompareTag("Player"))
    {
    canShowPainel = false;
    }
    if (colission.CompareTag("Player"))
    {    
    fechada.SetActive(false);
    }    
    }
}





