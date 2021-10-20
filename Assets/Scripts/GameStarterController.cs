using UnityEngine;
using System.Linq;
using System.Security.Cryptography;

public class GameStarterController : MonoBehaviour
{
    int[] arr = new int[52];
    Card[] deck = new Card[52];
    private void Start()
    {
        for(int i = 0; i < 52; i++)
        {
            arr[i] = i + 1;
        }
        System.Random random = new System.Random();
        arr = arr.OrderBy(x => random.Next()).ToArray();
        foreach (var  i in arr)
        {
            Debug.Log(i);
        }
        for(int i = 0; i < 52; i++)
        {

        }
    }



    Card CreateCard(int number)
    {
        switch(number)
        {
            case 1:
                {
                    return new Card(1, "Diamons");
                }
            case 2:
                {
                    return new Card(2, "Diamons");
                }
            case 3:
                {
                    return new Card(3, "Diamons");
                }
            case 4:
                {
                    return new Card(4, "Diamons");
                }
            case 5:
                {
                    return new Card(5, "Diamons");
                }
            case 6:
                {
                    return new Card(6, "Diamons");
                }
            case 7:
                {
                    return new Card(7, "Diamons");
                }
            case 8:
                {
                    return new Card(8, "Diamons");
                }
            case 9:
                {
                    return new Card(9, "Diamons");
                }
            case 10:
                {
                    return new Card(10, "Diamons");
                }
            case 11:
                {
                    return new Card(11, "Diamons");
                }
            case 12:
                {
                    return new Card(12, "Diamons");
                }
            case 13:
                {
                    return new Card(13, "Diamons");
                }
            case 14:
                {
                    return new Card(1, "Hearts");
                }
        }
        return null;   

    }
}
