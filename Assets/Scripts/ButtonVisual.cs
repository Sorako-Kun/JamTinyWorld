using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonVisual : MonoBehaviour
{
    public OpenMenu shop;
    public Sprite ImageToOpen;
    public Sprite ImageToClose;
    public Image SpriteButton;

    void Update()
    {
        if(shop.IsShopOpen)
        SpriteButton.sprite = ImageToClose;
        else
        SpriteButton.sprite = ImageToOpen;
    }
}
