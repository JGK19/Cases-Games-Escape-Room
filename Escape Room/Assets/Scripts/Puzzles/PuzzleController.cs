using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Collider2D))]
public class PuzzleController : MonoBehaviour
{
    private bool b1, b2, b3, b4, b5, b6;
    [SerializeField] private UnityEvent _puzzleFeito;
    [SerializeField] private GameObject puzzlePanel;
    [SerializeField] private GameObject puzzleDialogo;
    [SerializeField] private GameObject stage1;
    [SerializeField] private GameObject stage2;
    [SerializeField] private GameObject stage3;
    [SerializeField] private GameObject stage4;
    [SerializeField] private GameObject stage5;
    [SerializeField] private GameObject stage6;
    [SerializeField] private Timer t;
    [SerializeField] private GameObject _ganhou;
    [SerializeField] private GameObject _perdeu;
    [SerializeField] private GameObject _tempo;
    [SerializeField] private Animator player;
    public GameObject puzzleFio;
    public GameObject puzzlePapel;
    public GameObject puzzleCano;
    public GameObject puzzleCanoDialogo;
    public GameObject puzzleCanoDialogo1;

    void Start()
    {
        _perdeu.SetActive(false);
        _ganhou.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (t.timeValue <= 0)
        {
            Menu(t.timeValue);
        }
        if (b1 == true)
        {
            stage1.SetActive(true);
        }
        else stage1.SetActive(false);
        if (b2 == true)
        {
            stage2.SetActive(true);
        }
        else stage2.SetActive(false);
        if (b3 == true)
        {
            stage3.SetActive(true);
        }
        else stage3.SetActive(false);
        if (b4 == true)
        {
            stage4.SetActive(true);
        }
        else stage4.SetActive(false);
        if (b5 == true)
        {
            stage5.SetActive(true);
        }
        else stage5.SetActive(false);
        if (b6 == true)
        {
            stage6.SetActive(true);
        }
        else stage6.SetActive(false);
        if ((b1==true && b2==true)&&(b6==true &&((b2==true && b3==true)&&(b4==true && b5 == true))))
        {
            puzzlePanel.SetActive(false);
            player.SetBool("Ganhou", true);
            _puzzleFeito.Invoke();
            puzzlePanel.SetActive(false);
        }
       

    }
    private void OnTriggerEnter2D(Collider2D colission)
    {
        Menu(t.timeValue);
    }
    public void Menu(float tempoFaltando)
    {
        if (tempoFaltando <= 0)
        {
            _tempo.SetActive(false);
            puzzleDialogo.SetActive(false);
            puzzlePanel.SetActive(false);
            puzzleCanoDialogo1.SetActive(false);
            puzzleCano.SetActive(false);
            puzzleCanoDialogo.SetActive(false);
            puzzleFio.SetActive(false);
            puzzlePapel.SetActive(false);
            
            _perdeu.SetActive(true);
        }
        else
        {
            _tempo.SetActive(false);
            puzzleDialogo.SetActive(false);
            puzzlePanel.SetActive(false);
            puzzleCanoDialogo1.SetActive(false);
            puzzleCano.SetActive(false);
            puzzleCanoDialogo.SetActive(false);
            puzzleFio.SetActive(false);
            puzzlePapel.SetActive(false);
            _ganhou.SetActive(true);
        }


    }
    public void CloseWindow()
    {
        puzzlePanel.SetActive(false);
    }
    public void CloseWindowDialogo()
    {
        puzzleDialogo.SetActive(false);
    }
    public void Branco1()
    {
        if (((b1 == true && b2 == true) && (b3 == true && b4 == true)) && b5 == false)
        {
            b5 = true;
        }
        else { b1 = true;
            b2 = b3 = b4 = b5 = b6 = false;
        }
        
    }
    public void Vermelho3()
    {
        if (((b5==true)&&((b1==true && b2==true)&&(b3==true && b4==true)))&& b6==false)
        {
            b6 = true;
        }
        else if (b1 == true && b2==false)
        {
            b2 = true;
        }
        else b1 = b2 = b3= b4=b5=b6= false;
    }
    public void Preto4()
    {
        if((b1==true && b2 == true) && b3==false)
        {
            b3 = true;
        }else
        b1 =b2=b3= false;
    }
    public void Azul2()
    {
        if ((b1 == true && (b2 == true && b3 == true))&& b4==false)
        {
            b4 = true;
        }
        else b1 = b2 = b3 = b4 = false;
    }
}
