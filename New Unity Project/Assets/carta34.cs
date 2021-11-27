using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class carta34 : MonoBehaviour

{

    [SerializeField]
    private Scenecontrol34 controller;

    [SerializeField]
    private GameObject Carta34;

    public void OnMouseDown()
    {

        if (Carta34.activeSelf)
        {

            Carta34.SetActive(false);
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
        Carta34.SetActive(true);

    }

}


