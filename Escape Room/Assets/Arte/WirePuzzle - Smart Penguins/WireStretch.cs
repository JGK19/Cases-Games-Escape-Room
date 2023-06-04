using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireStretch : MonoBehaviour
{
    public SpriteRenderer wireEnd;
    public GameObject lightOn;
    Vector3 startPoint;
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.parent.position;
        startPosition = transform.position;
    }

    // Update is called once per frame
    private void OnMouseDrag()
    {
       //Nova posição seguindo a posição mundial do mouse
       Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       newPosition.z = 0;

        //Checagem para conexões de fio proximas
        Collider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, .2f);
        foreach(Collider2D collider in colliders)
        {
            //Verifica se não é o proprio colisor
            if(collider.gameObject != gameObject)
            {
                //Atualiza o fio para o ponto de conexao
                UpdateWire(collider.transform.position);

                //Verifica se as cores dos fios são iguais
                if(transform.parent.name.Equals(collider.transform.parent.name))
                {
                    //Conta as conexoes
                    Main.Instance.SwitchChange(1);

                    //Passo de finalizacao
                    collider.GetComponent<WireStretch>()?.Done();
                    Done();
                }

                return;
            }
        }

        //Atualiza o fio
        UpdateWire(newPosition);
    }

    void Done()
    {
        //Liga a luz
        lightOn.SetActive(true);

        //Destroi o script
        Destroy(this);
    }

    private void OnMouseUp() {
        //Faz o reset na posição do fio
        UpdateWire(startPosition);
    }

    void UpdateWire(Vector3 newPosition)
    {
        //Atualiza o fio para a posição
        transform.position = newPosition;

        //Atualiza a direção
        Vector3 direction = newPosition - startPoint;
        transform.right = direction * transform.lossyScale.x;

        //Atualiza a escala
        float dist = Vector2.Distance(startPoint, newPosition);
        wireEnd.size = new Vector2(dist, wireEnd.size.y);
    }
}
