using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour, ICollectable
{
    public int myCoinNumber;
    public void CollectCoin(int coin)
    {
        Player player = GetComponent<Player>();
        coin++;
        player.myCoin = coin;
        myCoinNumber = player.myCoin;
        print(coin);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectable mycoin = collision.GetComponent<ICollectable>();
        Player player = GetComponent<Player>();
        if (mycoin != null)
        {
            mycoin.CollectCoin(myCoinNumber);
        }
    }
}
