using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodeEscena : MonoBehaviour
{
    public int Escena;

    public void CambiarEscena1()
    {
        SceneManager.LoadScene(Escena);
    }
}
