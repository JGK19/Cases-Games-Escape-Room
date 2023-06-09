using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganhou : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _bonusTempo;
    [SerializeField] private TextMeshProUGUI _Total;
    [SerializeField]
    private TextMeshProUGUI _T;
    public Timer _tempo;
    private float x;
    [SerializeField] private GameObject _cano;
    [SerializeField] private GameObject _fios;
    [SerializeField] private GameObject _papeis;
    [SerializeField] private GameObject _cartoes;
    [SerializeField] private GameObject _bonust;
    [SerializeField] private GameObject _bonust1;
    [SerializeField] private GameObject _bonust2;
    [SerializeField] private GameObject _pontosTotais;
    private int k;
    

    // Start is called before the first frame update
    void Start()
    {
        
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
        if (!_cano.activeSelf)
        {
            _cano.SetActive(true);
        }
        else if (!_papeis.activeSelf)
        {
            _papeis.SetActive(true);
        }
        else if (!_fios.activeSelf)
        {
            _fios.SetActive(true);

        }
        else if (!_cartoes.activeSelf)
        {
            _cartoes.SetActive(true);
        }
        else if((!_bonust.activeSelf && !_bonust1.activeSelf)&& !_bonust2.activeSelf)
        {
            _bonust.SetActive(true);
            _bonust1.SetActive(true);
            _bonust2.SetActive(true);
        }
        else if (!_pontosTotais.activeSelf)
        {
            _pontosTotais.SetActive(true);
        }
    }

    public void Bonus()
    {
        x = _tempo.timeValue;
        _T.text = _tempo.timeText.text;
        if (x < 300)
        {
            _bonusTempo.color = Color.red;
        }else if(x>1200){
            _bonusTempo.color = Color.green;
        }
        x=x*2.75f;
        k=Mathf.FloorToInt(x/1);
        _bonusTempo.text = "+"+ k.ToString();
        k += 4500;
        _Total.text =k.ToString();
    }
}
