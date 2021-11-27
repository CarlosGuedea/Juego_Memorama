using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class carta23 : MonoBehaviour

{

    [SerializeField]
    private Scenecontrol23 controller;

    [SerializeField]
    private GameObject Carta23;

    public void OnMouseDown()
    {

        if (Carta23.activeSelf)
        {

            Carta23.SetActive(false);
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
        Carta23.SetActive(true);

    }

}


