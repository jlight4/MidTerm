using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney;

    public static int Lives;
    public int startLives;

    public static int Rounds;
    public int rounds;


    // Start is called before the first frame update
    void Start()
    {
        Money = startMoney;
        Lives = startLives;

        Rounds = 6;
    }
}
