using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carta03 : MonoBehaviour
{
    [SerializeField]
    private Scenecontrol03 controller;

    [SerializeField]
    private GameObject Carta03;

    public void OnMouseDown()
    {

        if (Carta03.activeSelf)
        {

            Carta03.SetActive(false);
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
        Carta03.SetActive(true);

    }

}

