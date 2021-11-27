using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class carta31 : MonoBehaviour

{

    [SerializeField]
    private Scenecontrol31 controller;

    [SerializeField]
    private GameObject Carta31;

    public void OnMouseDown()
    {

        if (Carta31.activeSelf)
        {

            Carta31.SetActive(false);
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
        Carta31.SetActive(true);

    }

}


