using System;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public event Action NumberCoinHasChanged;

    public int CoinCount { get; set; }

    public void TakeCoin(int coin)
    {
        CoinCount += coin;

        NumberCoinHasChanged?.Invoke();
    }
}
