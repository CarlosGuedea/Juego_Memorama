using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carta04 : MonoBehaviour
{
    [SerializeField]
    private Scenecontrol04 controller;

    [SerializeField]
    private GameObject Carta04;

    public void OnMouseDown()
    {

        if (Carta04.activeSelf)
        {

            Carta04.SetActive(false);
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
        Carta04.SetActive(true);

    }

}


