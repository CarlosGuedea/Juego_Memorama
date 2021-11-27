using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class carta32 : MonoBehaviour

{

    [SerializeField]
    private Scenecontrol32 controller;

    [SerializeField]
    private GameObject Carta32;

    public void OnMouseDown()
    {

        if (Carta32.activeSelf)
        {

            Carta32.SetActive(false);
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
        Carta32.SetActive(true);

    }

}


