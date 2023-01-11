using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ShopMenuUI : MonoBehaviour
{
    public GameObject ObjectToDrag;
    
    bool IsLock = true;
    public Image ImageLock;
    public TextMeshProUGUI TextCost;
    public int Cost;

    void Start()
    {
        TextCost.text = "" + Cost;
    }

    void Update()
    {
        if (!IsLock)
            ImageLock.enabled = false;
        else
            ImageLock.enabled = true;
    }
}
