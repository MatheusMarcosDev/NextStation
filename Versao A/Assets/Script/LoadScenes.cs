using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    //SCRIPT USADO PARA MUDANÇA DE CENARIOS

    public  void    FuncaoMudarCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}
