using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class OpenMenu : MonoBehaviour
{
    public bool IsShopOpen;
    public GameObject Shop;
    public bool IsRequirementsOpen;
    public GameObject Requirements;
    public void OnClickOpenShop()
    {
        if (IsShopOpen)
        {
            Shop.transform.DOComplete();
            Shop.transform.DOMoveX(-65, 1).OnComplete(CloseShop);
        }
        else
        {
            Shop.transform.DOComplete();
            Shop.transform.DOMoveX(0, 1).OnComplete(OpenShop);
        }
    }
    void CloseShop()
    {
        IsShopOpen = false;
    }

    void OpenShop()
    {
        IsShopOpen = true;
    }
    public void OnClickOpenRequirements()
    {
        if (IsRequirementsOpen)
        {
            Requirements.transform.DOComplete();
            Requirements.transform.DOMoveX(45, 1).OnComplete(CloseRequirements);
        }
        else
        {
            Requirements.transform.DOComplete();
            Requirements.transform.DOMoveX(0, 1).OnComplete(OpenRequirements);
        }
    }
    void CloseRequirements()
    {
        IsRequirementsOpen = false;
    }

    void OpenRequirements()
    {
        IsRequirementsOpen = true;
    }
}
