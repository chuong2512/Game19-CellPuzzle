using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickBuy : MonoBehaviour
{
    public int Coin;
    public Text _text;
    private Button _button;

    void Start()
    {
        _button = GetComponent<Button>();

        _text.text = $"{Coin} <size=25>COINS</size>";

        _button.onClick.AddListener(Buy);
    }

    private void Buy()
    {
        switch (Coin)
        {
            case 200:
                IAPManager.OnPurchaseSuccess = () =>
                    GameData.coins += 200;

                IAPManager.Instance.BuyProductID(IAPKey.PACK1);
                break;
            case 500:
                IAPManager.OnPurchaseSuccess = () =>
                    GameData.coins += 500;
                IAPManager.Instance.BuyProductID(IAPKey.PACK2);
                break;
            case 1000:
                IAPManager.OnPurchaseSuccess = () =>
                    GameData.coins += 1000;
                IAPManager.Instance.BuyProductID(IAPKey.PACK3);
                break;
            case 2000:
                IAPManager.OnPurchaseSuccess = () =>
                    GameData.coins += 2000;
                IAPManager.Instance.BuyProductID(IAPKey.PACK4);
                break;
            case 10000:
                IAPManager.OnPurchaseSuccess = () =>
                    GameData.coins += 10000;
                IAPManager.Instance.BuyProductID(IAPKey.PACK5);
                break;
        }
    }
}