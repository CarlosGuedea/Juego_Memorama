using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCartas : MonoBehaviour
{
    public GameObject CartaPrefab;
    public int Ancho;
    public int Alto;
    public Material Blanco;
    public Material Negro;

    void Start(){
        Crear ();
    }

    public void Crear()
    {
        int count = 0;
        for(int i=0;i<Ancho;i++){
            for(int x=0;x<Alto;x++){
                GameObject CartaTemp=Instantiate(CartaPrefab, new Vector2(x,i),Quaternion.identity);
                CartaTemp.GetComponent<Carta>().NumCarta=count;
                count++;
            }
        }
    }
}
