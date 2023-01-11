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
    public bool Grounded;
    public float ScrollSensitivity = 2f;
    private void OnMouseDown()
    {
        takeObject = !takeObject;
        if(takeObject)
            offset = transform.position - MouseWorldPosition();
    }
    private void OnMouseDrag()
    {
        if (takeObject)
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
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit, float.MaxValue, layerMask))
            {
                Debug.DrawRay(Hit.point, transform.TransformDirection(Vector3.up), Color.red, 10f);
                transform.position = Hit.point;
                Grounded = true;
            }
            else
                Grounded = false;
            if (Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                float ScrollAmout = Input.GetAxis("Mouse ScrollWheel") * ScrollSensitivity;
                transform.localRotation = Quaternion.Euler(0, ScrollAmout, 0);
            }
        }
    }
}
