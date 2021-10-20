using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public int rank;
    public string suit;
    //public Sprite sprite;

    public Card(int rank, string suit/*, Sprite sprite*/)
    {
        this.rank = rank;
        this.suit = suit;
        //this.sprite = sprite;
    }
}
