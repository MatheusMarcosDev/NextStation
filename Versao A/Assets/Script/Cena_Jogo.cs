using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cena_Jogo : MonoBehaviour
{
    [Header ("Configuração de Velocidade Trem")]
    public int velocidadeRapida;
    public int velocidadeMedia;
    public int velocidadeLenta;
    public int velocidadeAtual;
    public GameObject Indicador;
    public GameObject indicadorRapido;
    public GameObject indicadorMedio;
    public GameObject indicadorLento;

    [Header("Configuração para Descarrilhar")]
    public Transform indicadorDescarrilhar;
    public float valorDescarrilharLPos;
    public float valorDescarrilharMPos;
    public float valorDescarrilharRPos;
    public float valorDescarrilharLNeg;
    public float valorDescarrilharMNeg;
    public float valorDescarrilharRNeg;
    public float posXIndicador;
    public float posYIndicador;

    private MoveOffset scriptMoveOffset;
    // Start is called before the first frame update
    void Start()
    {
        scriptMoveOffset = FindObjectOfType(typeof(MoveOffset)) as MoveOffset;
        velocidadeAtual = velocidadeRapida;
        StartCoroutine("IndicadorDescarrilhar");
    }

    // Update is called once per frame
    void Update()
    {
        MudarVelocidade();
        IndicadorVelocidade();
        ControleTrilho();
        indicadorDescarrilhar.transform.position = new Vector2(posXIndicador, posYIndicador);
    }

    public  void    MudarVelocidade()
    {
        if (velocidadeAtual == 3 || velocidadeAtual == 2 || velocidadeAtual == 1)
        {
            if(Input.GetKeyDown(KeyCode.S))
            {
                velocidadeAtual -= 1;
            }

            else if (Input.GetKeyDown(KeyCode.W))
            {
                velocidadeAtual += 1;
            }
        }

        else if (velocidadeAtual == 0)
        {
            velocidadeAtual = 1;
        }

        else if (velocidadeAtual == 4)
        {
            velocidadeAtual = 3;
        }
    }

    public  void    IndicadorVelocidade()
    {
        switch(velocidadeAtual)
        {
            case 1:
                scriptMoveOffset.Incremento = 0.02f;
                Indicador.transform.position = (new Vector2 (indicadorLento.transform.position.x, indicadorLento.transform.position.y));
                break;

            case 2:
                scriptMoveOffset.Incremento = 0.05f;
                Indicador.transform.position = (new Vector2(indicadorMedio.transform.position.x, indicadorMedio.transform.position.y));
                break;

            case 3:
                scriptMoveOffset.Incremento = 0.1f;
                Indicador.transform.position = (new Vector2(indicadorRapido. transform.position.x, indicadorRapido.transform.position.y));
                break;
        }
    }

    IEnumerator IndicadorDescarrilhar()
    {
        yield return new WaitForSeconds(1);
        switch (velocidadeAtual)
        {
            case 1:
                if(posXIndicador >= 0)
                {
                    posXIndicador += valorDescarrilharLPos;
                }
                else
                {
                    posXIndicador += valorDescarrilharLNeg;
                }
                break;

            case 2:
                if (posXIndicador >= 0)
                {
                    posXIndicador += valorDescarrilharMPos;
                }
                else
                {
                    posXIndicador += valorDescarrilharMNeg;
                }
                break;

            case 3:
                if (posXIndicador >= 0)
                {
                    posXIndicador += valorDescarrilharRPos;
                }
                else
                {
                    posXIndicador += valorDescarrilharRNeg;
                }
                break;
        }
        StartCoroutine("IndicadorDescarrilhar");
    }

    public  void    ControleTrilho()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            switch (velocidadeAtual)
            {
                case 1:
                    posXIndicador += valorDescarrilharLNeg;
                    break;

                case 2:
                    posXIndicador += valorDescarrilharMNeg;
                    break;

                case 3:
                    posXIndicador += valorDescarrilharRNeg;
                    break;
            }
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            switch (velocidadeAtual)
            {
                case 1:
                    posXIndicador += valorDescarrilharLPos;
                    break;

                case 2:
                    posXIndicador += valorDescarrilharMPos;
                    break;

                case 3:
                    posXIndicador += valorDescarrilharRPos;
                    break;
            }
        }
    }
}
