using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCima : MonoBehaviour
{
    [SerializeField]private GameObject _ui;

    [SerializeField] private GameObject _uidialogo;

    [SerializeField] private cart�o_colis�o m;
    void Start()
    {
     
    }
    public void Apertou()
    {
        if (m.qtd == 4)
        {
            _ui.SetActive(true);
        }else
        {
            _uidialogo.SetActive(true);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
