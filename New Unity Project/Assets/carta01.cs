using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class carta01 : MonoBehaviour

{

    [SerializeField]
    private Scenecontrol01 controller;

    [SerializeField]
    private GameObject Carta01;

    public void OnMouseDown()
    {

        if (Carta01.activeSelf)
        {

            Carta01.SetActive(false);
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
        Carta01.SetActive(true);

    }

}



