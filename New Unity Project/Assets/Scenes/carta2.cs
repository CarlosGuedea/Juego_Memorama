﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class carta2 : MonoBehaviour
{
    [SerializeField]
    private GameObject Carta;
    public void OnMouseDown()
    {
        if(Carta.activeSelf)
        {
            Carta.SetActive(false);
        }
    }
}
