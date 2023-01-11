using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonVisual : MonoBehaviour
{
    public OpenMenuUI Requirements;
    public Sprite ImageToOpen;
    public Sprite ImageToClose;
    public Image SpriteButton;

    void Update()
    {
        if(Requirements.IsMenuOpen)
        SpriteButton.sprite = ImageToClose;
        else
        SpriteButton.sprite = ImageToOpen;
    }
}
