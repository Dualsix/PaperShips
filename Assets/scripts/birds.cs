using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birds : MonoBehaviour
{
    //public
    public float velocity;

    //private
    private bool derecha;

    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x < Camera.main.transform.position.x)
        {
            derecha = true;
        }
        else
        {
            derecha = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (derecha)
        {
            transform.position += new Vector3(1, 0, 0) * velocity;
        }
        else
        {
            transform.position -= new Vector3(1, 0, 0) * velocity;
        }
    }
}
