using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public LayerMask layerMask; 
    Vector3 offset;
    Plane plane = new Plane(Vector3.up, 0);
    public bool takeObject;
    private void OnMouseDown()
    {
        takeObject = !takeObject;
        if(takeObject)
            offset = transform.position - MouseWorldPosition();
        if (!takeObject)
        {

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity, layerMask))
            {
                transform.position = hit.point;
            }
        }
    }
    private void OnMouseDrag()
    {
        if(takeObject)
            transform.position = MouseWorldPosition() + offset;
    }

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
    private void Update()
    {
        if (takeObject)
        {
            var mouseScreenPos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mouseScreenPos);
            float enter = 0f;
            if (plane.Raycast(ray, out enter))
            {
                transform.position = new Vector3(ray.GetPoint(enter).x, ray.GetPoint(enter).y, ray.GetPoint(enter).z);
            }
        }
            
    }
}
