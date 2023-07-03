using UnityEngine;

public class StandardCoin : Coin
{
    [SerializeField, Range(0, 50)] private int _value;

    protected override void AddCoins(ICoinPicker coinPicker) => coinPicker.Add(_value);
}
