using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class OpenMenuUI : MonoBehaviour
{
    public bool IsMenuOpen;
    public GameObject Menu;

    public void OnClickOpenMenuToLeft()
    {
        if (IsMenuOpen)
        {
            Menu.transform.DOComplete();
            Menu.transform.DOMoveX(-70, 1).OnComplete(CloseMenu);
        }
        else
        {
            Menu.transform.DOComplete();
            Menu.transform.DOMoveX(0, 1).OnComplete(OpenMenu);
        }
    }
    public void OnClickOpenMenuToRight()
    {
        if (IsMenuOpen)
        {
            Menu.transform.DOComplete();
            Menu.transform.DOMoveX(45, 1).OnComplete(CloseMenu);
        }
        else
        {
            Menu.transform.DOComplete();
            Menu.transform.DOMoveX(0, 1).OnComplete(OpenMenu);
        }
    }
    public void OnClickOpenMenuToDown()
    {
        if (IsMenuOpen)
        {
            Menu.transform.DOComplete();
            Menu.transform.DOMoveY(-45, 1).OnComplete(CloseMenu);
        }
        else
        {
            Menu.transform.DOComplete();
            Menu.transform.DOMoveY(0, 1).OnComplete(OpenMenu);
        }
    }
    void CloseMenu()
    {
        IsMenuOpen = false;
    }

    void OpenMenu()
    {
        IsMenuOpen = true;
    }
}
