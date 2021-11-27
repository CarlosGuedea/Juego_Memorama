using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carta22 : MonoBehaviour
{
    [SerializeField]
    private Scenecontrol22 controller;

    [SerializeField]
    private GameObject Carta22;

    public void OnMouseDown()
    {

        if (Carta22.activeSelf)
        {

            Carta22.SetActive(false);
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
        Carta22.SetActive(true);

    }

}
