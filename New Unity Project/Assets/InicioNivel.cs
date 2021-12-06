using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioNivel : MonoBehaviour
{
    public int escena;

    public void InicioNivel01()
    {
        SceneManager.LoadScene("Alimemtos");
    }
}