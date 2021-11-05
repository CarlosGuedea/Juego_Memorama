using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scenecontrol : MonoBehaviour {

    public const int griRows = 2;
    public const int griCols = 5;
    public const float offsetX = 4f;
    public const float offeseY = 5f;

    [SerializeField]
    private carta2 originalCard;
    [SerializeField]
    private Sprite [] images;

    public int score = 0;

    private void Start()
    {
        Vector3 startPos = originalCard.transform.position;
        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4};
        numbers = ShuffleArray(numbers);

        for (int i = 0; i <griCols; i++ )
        {
            for (int j = 0; j <griRows; j++) 
            {
                carta2 card;
                if (i == 0 && j == 0)
                {
                    card = originalCard;


                }
                else
                {

                    card = Instantiate(originalCard) as carta2;



                }

                int index = j * griCols +i;
                int id = numbers[index];
                card.ChangeSprite(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = (offeseY * j) + startPos.y;

                card.transform.position = new Vector3(posX, posY, startPos.z);
                

                }

            }


        }

        private int [] ShuffleArray (int[] numbers){
            int[] newArray = numbers.Clone() as int[];
            for (int i =0; i <newArray.Length; i++){


                int tmp = newArray[i];
                int r = Random.Range(i, newArray.Length);
                newArray[i] = newArray[r];
                newArray[r] = tmp;
            }

            return newArray;


        }

    }
    


