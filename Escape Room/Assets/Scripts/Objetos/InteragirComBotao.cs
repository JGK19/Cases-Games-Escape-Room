using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider2D))]
public class InteragirComBotao : MonoBehaviour
{
    [SerializeField]
    private Interacao _jogadorInterage;
    [SerializeField]
    private UnityEvent _botaoApertado;
    public GameObject PauseMenu;
    private bool _podeExecutar;
    public GameObject _seta;
    public GameObject abriu;
    // Start is called before the first frame update
    void Start()
    {
        _seta.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.activeSelf) { 
        if (_podeExecutar)
        {
            if(_jogadorInterage.Interagindo == true)
            {
                _botaoApertado.Invoke();
                    

            }
        }
        }
    }
    private void OnTriggerEnter2D(Collider2D colission)
    {
        if (abriu.activeSelf)
        {
            _seta.SetActive(true);
        }
        
        _podeExecutar = true;
    }
    private void OnTriggerExit2D(Collider2D colission)
    {
        _seta.SetActive(false);
        _podeExecutar = false;
    }
}
