using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Puzzle_papeis : MonoBehaviour
{

    public GameObject puzzle;
    [SerializeField]
    private bool complete;
    [SerializeField]
    private UnityEvent _puzzleCompleto;

    private int button1 = 1;
    private int button2 = 2;
    private int button3 = 3;
    private int button4 = 4;

    private List<int> nums = new List<int>();

    private List<int> resposta = new List<int>();

    private bool quit = false;

    // Start is called before the first frame update
    void Start()
    {
        resposta.Add(button1);
        resposta.Add(button2);
        resposta.Add(button3);
        resposta.Add(button4);
        puzzle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (quit == true) {
            nums = new List<int>();
            quit = false;
        }
        if (complete == true) {
            _puzzleCompleto.Invoke();
            puzzle.SetActive(false);
        }

        if(listcmp(nums, resposta)) {
            complete = true;
        }
    }

    public void open_puzzle() {
        puzzle.SetActive(true);
    }

    public void press1() {
        nums.Add(button1);
    }
    public void press2() {
        nums.Add(button2);
    }
    public void press3() {
        nums.Add(button3);
    }
    public void press4() {
        nums.Add(button4);
    }
    public void cancel() {
        puzzle.SetActive(false);
        quit = true;
    }


    private bool listcmp(List<int> lista1, List<int> lista2) {
        if (lista1.Count != lista2.Count) {
            return false;
        }
        for (int i = 0; i < lista1.Count; i++) {
            if (lista1[i] != lista2[i]) {
                return false;
            }
        }
        return true;
    }
}
