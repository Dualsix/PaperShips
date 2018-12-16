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
                GameObject aux = Instantiate(ball, new Vector3 (transform.position.x, transform.position.y, 1.0f), Quaternion.identity);
                aux.gameObject.tag = "ball_p1";
                aux.GetComponent<Rigidbody2D>().AddForce(new Vector3(1.0f, 1.0f, 0.0f) * strenght, ForceMode2D.Impulse);
                timer = 0;
                shoot = false;
            }
        }

        if (gameObject.tag == "P2")
        {
            if (Input.GetKeyDown(KeyCode.RightControl) && shoot)
            {
                GameObject aux = Instantiate(ball, new Vector3 (transform.position.x, transform.position.y, 1.0f), Quaternion.identity);
                aux.gameObject.tag = "ball_p2";
                aux.GetComponent<Rigidbody2D>().AddForce(new Vector3(-1.0f, 1.0f, 0.0f) * strenght, ForceMode2D.Impulse);
                timer = 0;
                shoot = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            shoot = true;
        }

    }

    public float getStrenght()
    {
        return strenght;
    }
}
