using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public DragDrop currentObject;
    public DragDrop lastObject;
    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SwitchObject(DragDrop dragDrop)
    {
        lastObject = currentObject;
        currentObject = dragDrop;
        if (lastObject != null)
        { 
            lastObject.takeObject = false;
            lastObject.Done = true;
        }
    }
}
