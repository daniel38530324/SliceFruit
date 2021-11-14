using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float Move_Speed = 5f;
    public Sprite[] Texture;
    public float Sec=0.5f;
    private int Num=0;
    private bool Walk_State = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Game_Sart.Game_State == true)
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                transform.Translate(Move_Speed * Time.deltaTime, 0, 0);
                transform.rotation = Quaternion.Euler(0, 180, 0);
                if (Walk_State == false)
                {
                    Walk_State = true;
                    InvokeRepeating("SetInterial", 0f, Sec);
                }
            }

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                transform.Translate(Move_Speed * Time.deltaTime, 0, 0);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                if (Walk_State == false)
                {
                    Walk_State = true;
                    InvokeRepeating("SetInterial", 0f, Sec);
                }
            }



            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                CancelInvoke();
                Walk_State = false;
            }

            if (transform.position.x > 6)
            {
                transform.position = new Vector3(6, transform.position.y, 0);
            }

            if (transform.position.x < -6)
            {
                transform.position = new Vector3(-6, transform.position.y, 0);
            }
        }

    }

    void SetInterial()
    {
        if (Num == 0)
        {
            GetComponent<SpriteRenderer>().sprite = Texture[0];
            Num += 1;
        }

        else if(Num == 1)
        {
            GetComponent<SpriteRenderer>().sprite = Texture[1];
            Num -= 1;
        }
    }
}
