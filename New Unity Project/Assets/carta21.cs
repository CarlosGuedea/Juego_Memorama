using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carta21 : MonoBehaviour
{
    [SerializeField]
    private Scenecontrol21 controller;

    [SerializeField]
    private GameObject Carta21;

    public void OnMouseDown()
    {

        if (Carta21.activeSelf)
        {

            Carta21.SetActive(false);
            controller.CardReveaLed(this);

        }

    }

    private int _id;
    public int id
    {

        get { return _id; }

    }

    public void ChangeSprite(int id, Sprite image)
    {

        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;

    }

    public void Unreveal()
    {
        Carta21.SetActive(true);

    }

}

