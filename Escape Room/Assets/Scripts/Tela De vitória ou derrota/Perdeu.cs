using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Perdeu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _Total;
    [SerializeField] private GameObject _cano;
    [SerializeField] private GameObject _fios;
    [SerializeField] private GameObject _papeis;
    [SerializeField] private GameObject _cartoes;
    [SerializeField] private TextMeshProUGUI _cards;
    [SerializeField] private GameObject _pontosTotais;
    [SerializeField] private GameObject bonus1;
    [SerializeField] private GameObject bonus2;
    [SerializeField] private GameManager gManager;
    [SerializeField] private Puzzle_papeis pManager;
    [SerializeField] private PortaPuzzleFio fManager;
    public cartão_colisão q;
    private int k=-3000;
    private bool aux,aux2;
    int l,m=-1500;


    // Start is called before the first frame update
    void Start()
    {
        aux =aux2= true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Prox()
    {
        if (gManager.pingente == true)
        {
            _cano.SetActive(true);
            k += 1000;
            gManager.pingente = false;
        }
        else if (pManager.complete == true&& aux2==true)
        {
            _papeis.SetActive(true);
            k += 1500;
            pManager.complete = false;
            aux2 = false;
        }
        else if (fManager.feito == true && aux == true)
        {
            _fios.SetActive(true);
            k += 500;
            fManager.feito = false;
            aux = false;

        }
        else if (q.qtd>=0) {
            l = q.qtd;
            k += l * 375;
            q.qtd = -1;
            _cartoes.SetActive(true);
            m += l * 375;
            if (q.qtd == 4) { _cards.text = "Cartões     " + m; 
            }
            else
            _cards.text = "Cartões     " + m;


        }
        else if (!bonus1.activeSelf)
        {

            bonus2.SetActive(true);
            bonus1.SetActive(true);
        }
        else if (!_pontosTotais.activeSelf)
        {
            _Total.text = k.ToString();
            _pontosTotais.SetActive(true);
        }
    }

   
}
