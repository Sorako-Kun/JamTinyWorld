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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsLock)
            ImageLock.enabled = false;
        else
            ImageLock.enabled = true;
    }
}
