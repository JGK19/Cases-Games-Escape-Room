using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartão_colisão : MonoBehaviour
{
    [SerializeField] private GameObject cartao1;
    [SerializeField] private GameObject cartao2;
    [SerializeField] private GameObject cartao3;
    [SerializeField] private GameObject cartao4;
    [SerializeField] private GameObject cartão1_inv;
    [SerializeField] private GameObject cartão2_inv;
    [SerializeField] private GameObject cartão3_inv;
    [SerializeField] private GameObject cartão4_inv;
    public int qtd =0;
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name == "cartão1")
        {
            cartao1.SetActive(false);
            cartão1_inv.SetActive(true);
            qtd++;
        }
        if (collision.gameObject.name == "cartão1 (1)")
        {
            cartao2.SetActive(false);
            cartão2_inv.SetActive(true);
            qtd++;
        }
        if (collision.gameObject.name == "cartão1 (2)")
        {
            cartao3.SetActive(false);
            cartão3_inv.SetActive(true);
            qtd++;
        }
        if (collision.gameObject.name == "cartão1 (3)")
        {
            cartao4.SetActive(false);
            cartão4_inv.SetActive(true);
            qtd++;
        }
    }
}
