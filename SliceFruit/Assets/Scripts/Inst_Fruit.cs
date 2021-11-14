using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inst_Fruit : MonoBehaviour
{
    public GameObject[] Fruit;
    public float Sec = 2;
    public int max;
    private Vector3 X_Num;
    private int i;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SetInterial", 0f, Sec);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetInterial()
    {
        if (Game_Sart.Game_State == true)
        {
            X_Num.x = Random.Range(-2, 3);
            transform.position = new Vector3(X_Num.x, 5.44f, 0);
            if (transform.position.x > 2.4f)
            {
                transform.position = new Vector3(2.4f, transform.position.y, 0);
            }

            if (transform.position.x < -2)
            {
                transform.position = new Vector3(-2, transform.position.y, 0);
            }

            i = Random.Range(0, max);

            if (i == 0)
            {
                Instantiate(Fruit[0], transform.position, transform.rotation);
            }

            else if (i == 1)
            {
                Instantiate(Fruit[1], transform.position, transform.rotation);
            }

            else if (i == 2)
            {
                Instantiate(Fruit[2], transform.position, transform.rotation);
            }

            else if (i == 3)
            {
                Instantiate(Fruit[3], transform.position, transform.rotation);
            }

            else if (i == 4)
            {
                Instantiate(Fruit[4], transform.position, transform.rotation);
            }

            else if (i >= 5)
            {
                Instantiate(Fruit[5], transform.position, transform.rotation);
            }
        }
    }
}
