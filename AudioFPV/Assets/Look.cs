using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    //utils pour coordonnées
    public struct Coords
    {

        public float X;
        public float Y;

        public Coords(float x, float y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"({X}, {Y})";
    }


    public float vertical;
    public float horizontal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Coords mousePosition = new Coords(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        //vertical = Mathf.Clamp(vertical, _mouseYLimit.x, _mouseYLimit.y);
        //rotation du joueur
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, horizontal, transform.eulerAngles.z);
        //rotation de la camera
        //_cameraTransform.eulerAngles = new Vector3(_vertical, _cameraTransform.eulerAngles.y, _cameraTransform.eulerAngles.z);
    }
}
