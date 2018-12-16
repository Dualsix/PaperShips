using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyByContact : MonoBehaviour
{
    //publics
    public GameObject explosion;

    //private

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //desaparece la bala p1
        if (gameObject.tag == "ball_p1")
        {
            if (collision.gameObject.tag != "ballon_p1" && collision.gameObject.tag != "P1")
            {
                Destroy(gameObject);
            }
        }

        //desaparece la bala p2
        if (gameObject.tag == "ball_p2")
        {
            if (collision.gameObject.tag != "ballon_p2" && collision.gameObject.tag != "P2")
            {
                Destroy(gameObject);
            }
        }

        //explotan globos p1
        if (gameObject.tag == "ballon_p1")
        {
            if (collision.gameObject.tag != "ball_p1" && collision.gameObject.tag != "P1")
            {
                GameObject.FindGameObjectWithTag("P1").GetComponent<move>().balloons -= 1;
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }

        //explotan globos p2
        if (gameObject.tag == "ballon_p2")
        {
            if (collision.gameObject.tag != "ball_p2" && collision.gameObject.tag != "P2")
            {
                GameObject.FindGameObjectWithTag("P2").GetComponent<move>().balloons -= 1;
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
