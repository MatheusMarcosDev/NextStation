using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_GameController : MonoBehaviour
{
    public GameObject panelCredits;
    [SerializeField] private bool isPanelCredits;

    private void Start()
    {
        panelCredits.SetActive(false);

        isPanelCredits = false;
    }

    public void Play()
    {

    }

    public void Tutorial()
    {

    }

    public void Options()
    {

    }

    public void Credits()
    {
        if(!isPanelCredits)
        {
            panelCredits.SetActive(true);
            isPanelCredits = !isPanelCredits;
            Debug.Log("Abrir");
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                panelCredits.SetActive(false);
                isPanelCredits = !isPanelCredits;
                Debug.Log("Fechar");
            }
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
