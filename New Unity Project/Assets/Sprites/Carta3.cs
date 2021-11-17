using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Carta3 : MonoBehaviour

{

    [SerializeField]
    private Scenecontrol3 controller;

    [SerializeField]
    private GameObject carta3;

    public void OnMouseDown()
    {

        if (carta3.activeSelf)
        {

            carta3.SetActive(false);
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
        carta3.SetActive(true);

    }

}
