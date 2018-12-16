using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn_birds : MonoBehaviour
{
    //private
    private float timer;
    private float timer2;

    private float timer3;
    private float timer4;

    private float timer5;
    private float timer6;

    private float timer7;
    private float timer8;

    private float timer9;


    //public
    public GameObject scroll;

    public GameObject bird_r;
    public float respawn_b;

    public GameObject plane_r;
    public float respawn_p;

    public GameObject satelite_r;
    public float respawn_s;

    public GameObject meteo_r;
    public float respawn_m;

    public GameObject cohete_r;
    public float respawn_c;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        timer2 = 2;

        timer3 = 0;
        timer4 = 3;

        timer5 = 0;
        timer6 = 4;

        timer7 = 0;
        timer8 = 3;

        timer9 = 0;

    }

    // Update is called once per frame
    void Update()
    {
        float height = 2f * Camera.main.orthographicSize;
        float width = height * Camera.main.aspect;

        //respawneamos pajaros
        if (scroll.transform.position.y > 200)
        {
            timer += Time.deltaTime;
            timer2 += Time.deltaTime;

            if (timer > respawn_b)
            {
                timer = 0;
                float y = Random.Range(-height / 2, height / 2);
                float x = Random.Range(-width, -width + width / 2);
                Vector3 position = new Vector3(x, y, 1);
                Instantiate(bird_r, position, Quaternion.identity);
            }

            if (timer2 > respawn_b)
            {
                timer2 = 0;
                float y = Random.Range(-height / 2, height / 2);
                float x = Random.Range(width, width - width / 2);
                Vector3 position = new Vector3(x, y, 1);
                Vector3 rot = bird_r.transform.rotation.eulerAngles;
                rot = new Vector3(rot.x, rot.y + 180, rot.z);
                Instantiate(bird_r, position, Quaternion.Euler(rot));
            }
        }
        //respawneamos aviones
        if (scroll.transform.position.y <= 300 && scroll.transform.position.y >= 0)
        {
            timer3 += Time.deltaTime;
            timer4 += Time.deltaTime;

            if (timer3 > respawn_p)
            {
                timer3 = 0;
                float y = Random.Range(-height / 2, height / 2);
                float x = Random.Range(-width, -width + width / 5);
                Vector3 position = new Vector3(x, y, 1);
                Vector3 rot = plane_r.transform.rotation.eulerAngles;
                rot = new Vector3(rot.x, rot.y, rot.z);
                Instantiate(plane_r, position, Quaternion.Euler(rot));
            }

            if (timer4 > respawn_p)
            {
                timer4 = 0;
                float y = Random.Range(-height / 2, height / 2);
                float x = Random.Range(width, width + width / 5);
                Vector3 position = new Vector3(x, y, 1);
                Vector3 rot = plane_r.transform.rotation.eulerAngles;
                rot = new Vector3(rot.x, rot.y + 180, rot.z);
                Instantiate(plane_r, position, Quaternion.Euler(rot));
            }
        }

        //respawneamos satelites
        if (scroll.transform.position.y <= -100 && scroll.transform.position.y >= -300)
        {
            timer5 += Time.deltaTime;
            timer6 += Time.deltaTime;

            if (timer5 > respawn_s)
            {
                timer5 = 0;
                float y = Random.Range(-height / 2, height / 2);
                float x = Random.Range(-width, -width + width / 2);
                Vector3 position = new Vector3(x, y, 1);
                Vector3 rot = satelite_r.transform.rotation.eulerAngles;
                rot = new Vector3(rot.x, rot.y, rot.z);
                Instantiate(satelite_r, position, Quaternion.Euler(rot));
            }

            if (timer6 > respawn_s)
            {
                timer6 = 0;
                float y = Random.Range(-height / 2, height / 2);
                float x = Random.Range(width, width - width / 2);
                Vector3 position = new Vector3(x, y, 1);
                Vector3 rot = satelite_r.transform.rotation.eulerAngles;
                rot = new Vector3(rot.x, rot.y + 180, rot.z);
                Instantiate(satelite_r, position, Quaternion.Euler(rot));
            }
        }

        //respawneamos meteoritos
        if (scroll.transform.position.y <= -250)
        {
            timer7 += Time.deltaTime;
            timer8 += Time.deltaTime;

            if (timer7 > respawn_m)
            {
                timer7 = 0;
                float y = Random.Range(-height / 2, height / 2);
                float x = Random.Range(-width, -width + width / 2);
                Vector3 position = new Vector3(x, y, 1);
                Vector3 rot = meteo_r.transform.rotation.eulerAngles;
                rot = new Vector3(rot.x, rot.y, rot.z);
                Instantiate(meteo_r, position, Quaternion.Euler(rot));
            }

            if (timer8 > respawn_m)
            {
                timer8 = 0;
                float y = Random.Range(-height / 2, height / 2);
                float x = Random.Range(width, width - width / 2);
                Vector3 position = new Vector3(x, y, 1);
                Vector3 rot = meteo_r.transform.rotation.eulerAngles;
                rot = new Vector3(rot.x, rot.y + 180, rot.z);
                Instantiate(meteo_r, position, Quaternion.Euler(rot));
            }
        }

        //respawneamos cohete
        if (scroll.transform.position.y <= 100 && scroll.transform.position.y > -100)
        {
            timer9 += Time.deltaTime;

            if (timer9 > respawn_c)
            {
                timer9 = 0;
                float y = Random.Range(-height, -height + height/ 2);
                float x = Random.Range(-width/2, width / 2);
                Vector3 position = new Vector3(x, y, 1);
                Vector3 rot = cohete_r.transform.rotation.eulerAngles;
                rot = new Vector3(rot.x, rot.y, rot.z);
                Instantiate(cohete_r, position, Quaternion.Euler(rot));
            }
        }
    }
}
