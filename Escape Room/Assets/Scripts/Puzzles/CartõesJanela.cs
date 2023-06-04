using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CartõesJanela : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI Cartões;

    private string qtd;

    [SerializeField]
    private cartão_colisão p;
    
    private int x;

    private void Update()
    {
        x = 4 - p.qtd;

        qtd = x.ToString();
        Cartões.text = qtd;
    }
}
