using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{
    public Material ColorCarta;
    public int NumCarta=0; 

    
    void OnMouseDown()
    {
       print (NumCarta.ToString ());
    }

    
    public void PonerColor(Material color_)
    {
        GetComponent <SpriteRenderer> ().material = color_;
        ColorCarta = color_;
    }
}
