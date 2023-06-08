using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PortaPuzzleFio : MonoBehaviour
{
    [SerializeField] private GameObject _ui;
    [SerializeField] private GameObject fioVerde;
    [SerializeField] private GameObject fioAzul;
    [SerializeField] private GameObject fioVermelho;
    [SerializeField] private GameObject fioAmarelo;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _paredes1;
    [SerializeField] private GameObject _paredes2;
    [SerializeField]private UnityEvent _Feito;
    void Start()
    {
        
    }
    void Update()
    {
        if ((fioAmarelo.activeSelf && fioAzul.activeSelf) && (fioVerde.activeSelf && fioVermelho.activeSelf))
        {
            PuzzleFeito();
        }
    }



    // Update is called once per frame
    public void Apertou()
    {
        _player.SetActive(false);
        _paredes1.SetActive(false);
        _paredes2.SetActive(false);
        _ui.SetActive(true);
    }
    public void Fechou()
    {
        _player.SetActive(true);
        _paredes1.SetActive(true);
        _paredes2.SetActive(true);
        _ui.SetActive(false);
    }
 public void PuzzleFeito()
    {

        _ui.SetActive(false);
        _player.SetActive(true);
        _paredes1.SetActive(true);
        _paredes2.SetActive(true);
        _Feito.Invoke();

    }

}
