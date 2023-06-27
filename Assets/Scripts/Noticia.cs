using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Noticia : MonoBehaviour
{
    public void IrParaNoticia()
    {
        SceneManager.LoadScene("noticia");
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
