using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    //private
    private float timer;
    private bool shoot;

    //public
    public float strenght;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
       // ball = GameObject.FindGameObjectWithTag("bullet");
        timer = 0;
        shoot = true;
    }

    void FixedUpdate()
    {
        if (gameObject.tag == "P1")
        {
            if (Input.GetKeyDown(KeyCode.LeftControl) && shoot)
            {
                GameObject aux = Instantiate(ball, transform.position, Quaternion.identity);
                //aux.GetComponent<destroyByTime>().temps = 2;
                aux.GetComponent<Rigidbody>().AddForce(new Vector3(1.0f, 1.0f, 0.0f) * strenght, ForceMode.Impulse);
                timer = 0;
                shoot = false;
            }
        }

        if (gameObject.tag == "P2")
        {
            if (Input.GetKeyDown(KeyCode.RightControl) && shoot)
            {
                GameObject aux = Instantiate(ball, transform.position, Quaternion.identity);
                //aux.GetComponent<destroyByTime>().temps = 2;
                aux.GetComponent<Rigidbody>().AddForce(new Vector3(-1.0f, 1.0f, 0.0f) * strenght, ForceMode.Impulse);
                timer = 0;
                shoot = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5)
        {
            shoot = true;
        }

    }

    public float getStrenght()
    {
        return strenght;
    }
}
