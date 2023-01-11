using UnityEngine;

public class OrbitCam : MonoBehaviour
{
    private Transform _XForm_Camera;
    private Transform _XForm_Parent;

    private Vector3 _LocalRotation;
    private float _CameraDistance = 10f;

    public float MousSensitivity = 4f;
    public float ScrollSensitivity = 2f;
    public float OrbitSpeed = 10f;
    public float ScrollSpeed = 6f;

    public bool CameraDisabled = false;
    // Start is called before the first frame update
    void Start()
    {
        this._XForm_Camera = this.transform;
        this._XForm_Parent = this.transform.parent;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetMouseButton(1))
            CameraDisabled = false;
        else
            CameraDisabled = true;
            
        if(!CameraDisabled)
        {
            if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                _LocalRotation.x += Input.GetAxis("Mouse X") * MousSensitivity;
                _LocalRotation.y += Input.GetAxis("Mouse Y") * MousSensitivity;

                _LocalRotation.y = Mathf.Clamp(_LocalRotation.y, 0f, 90f);
            }
            if(Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                float ScrollAmout = Input.GetAxis("Mouse ScrollWheel") * ScrollSensitivity;

                ScrollAmout *= (this._CameraDistance * 0.3f);
                this._CameraDistance += ScrollAmout * -1f;
                this._CameraDistance = Mathf.Clamp(this._CameraDistance, 1.5f, 100f);
            }
        }

        Quaternion QT = Quaternion.Euler(_LocalRotation.y, _LocalRotation.x, 0);
        this._XForm_Parent.rotation = Quaternion.Lerp(this._XForm_Parent.rotation, QT, Time.deltaTime * OrbitSpeed);
        if (this._XForm_Camera.localPosition.z != this._CameraDistance * -1f)
        {
            this._XForm_Camera.localPosition = new Vector3(0f, 0f, Mathf.Lerp(this._XForm_Camera.localPosition.z, this._CameraDistance * -1f, Time.deltaTime * ScrollSpeed));
        }
    }
}
