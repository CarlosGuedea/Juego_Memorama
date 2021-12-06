using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenecontrol02 : MonoBehaviour
{
    public const int griRows = 2;
    public const int griCols = 9;
    public const float offsetX = 4f;
    public const float offeseY = 5f;

    [SerializeField]
    private carta02 originalCard;
    [SerializeField]
    private Sprite[] images;

    public int score = 0;


    private void Start()
    {
        Vector3 startPos = originalCard.transform.position;
        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };
        numbers = ShuffleArray(numbers);

        for (int i = 0; i < griCols; i++)
        {
            for (int j = 0; j < griRows; j++)
            {
                carta02 card;
                if (i == 0 && j == 0)
                {
                    card = originalCard;


                }
                else
                {

                    card = Instantiate(originalCard) as carta02;

                }

                int index = j * griCols + i;
                int id = numbers[index];
                card.ChangeSprite(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = (offeseY * j) + startPos.y;

                card.transform.position = new Vector3(posX, posY, startPos.z);


            }

        }
    }

    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++)
        {


            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }

        return newArray;

    }

    private carta02 _firstReveaLed;
    private carta02 _sconReveaLed;

    private int _score = 0;

    [SerializeField]
    private TextMesh scoreLabel;

    public bool canReveal
    {
        get { return _sconReveaLed = null; }

    }

    public void CardReveaLed(carta02 card)
    {
        if
            (_firstReveaLed == null)
        {
            _firstReveaLed = card;
        }
        else
        {

            _sconReveaLed = card;
            StartCoroutine(CheckedMatch());
        }

    }

    private IEnumerator CheckedMatch()
    {
        if (_firstReveaLed.id == _sconReveaLed.id)
        {
            _score++;
            scoreLabel.text = "Score: " + _score;
            if (_score == 9)
                SceneManager.LoadScene("Números2");


        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            _firstReveaLed.Unreveal();
            _sconReveaLed.Unreveal();

        }

        _firstReveaLed = null;
        _sconReveaLed = null;

    }

    void cardCoparion(List<int> c)
    {


    }

}