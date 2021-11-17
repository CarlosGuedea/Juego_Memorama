using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carta02 : MonoBehaviour
{
    [SerializeField]
    private Scenecontrol02 controller;

    [SerializeField]
    private GameObject Carta02;

    public void OnMouseDown()
    {

        if (Carta02.activeSelf)
        {

            Carta02.SetActive(false);
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
        Carta02.SetActive(true);

    }

}


