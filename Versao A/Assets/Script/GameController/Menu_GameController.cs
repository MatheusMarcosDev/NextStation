using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//CLASSE RESPONSAVEL POR GERENCIAR O MENU INICIAL
public class Menu_GameController : MonoBehaviour
{
    public GameObject panelCredits; //GAME OBJECT DO PAINEL DE CREDITOS
    private bool isPanelCredits; //BOOLEANO PARA CHECAGEM DO PAINEL DE CREDITOS

    public GameObject panelOptions; //GAME OBJECT DO PAINEL DE OPCOES
    private bool isPanelOptions; //BOOLEANO PARA CHECAGEM DO PAINEL DE OPCOES

    public GameObject panelTutorial; //GAME OBJECT DO PAINEL DE TUTORIAL
    private bool isPanelTutorial; //BOOLEANO PARA CHECAGEM DO PAINEL DE TUTORIAL

    void Start()
    {
        isPanelCredits = false; //BOOLEANO DO PAINEL DE CREDITOS INICIA FALSO
        panelCredits.SetActive(false); //PAINEL CREDITOS INICIA DESATIVADO

        isPanelOptions = false; //BOOLEANO DO PAINEL DE CREDITOS INICIA OPCOES
        panelOptions.SetActive(false); //PAINEL OPCOES INICIA DESATIVADO

        isPanelTutorial = false; //BOOLEANO DO PAINEL DE CREDITOS INICIA TUTORIAL
        panelTutorial.SetActive(false); //PAINEL TUTORIAL INICIA DESATIVADO
    }

    void Update()
    {
        if (isPanelCredits) //SE O ISPANELCREDITS FOR TRUE, ELE CHAMA A FUNCAO CREDITS
        {
            Credits();
        }
    }

    public void Play(string sceneName) //FUNCAO PLAYER COM PARAMETRO QUE É CHAMADA NO BOTAO PLAY
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Tutorial()
    {
        if (!isPanelTutorial)
        {
            isPanelTutorial = !isPanelTutorial;
            panelTutorial.SetActive(true);
        }
        else
        {
            isPanelTutorial = !isPanelTutorial;
            panelTutorial.SetActive(false);
        }
    }

    public void Options()
    {
        if (!isPanelOptions)
        {
            isPanelOptions = !isPanelOptions;
            panelOptions.SetActive(true);
        }
        else
        {
            isPanelOptions = !isPanelOptions;
            panelOptions.SetActive(false);
        }
    }

    public void Credits()
    {
        if(!isPanelCredits)
        {
            isPanelCredits = !isPanelCredits;
            panelCredits.SetActive(true);
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                isPanelCredits = !isPanelCredits;
                panelCredits.SetActive(false);
            }
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
