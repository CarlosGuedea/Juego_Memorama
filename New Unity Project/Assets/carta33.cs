using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class carta33 : MonoBehaviour

{

    [SerializeField]
    private Scenecontrol33 controller;

    [SerializeField]
    private GameObject Carta33;

    public void OnMouseDown()
    {

        if (Carta33.activeSelf)
        {

            Carta33.SetActive(false);
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
        Carta33.SetActive(true);

    }

}


