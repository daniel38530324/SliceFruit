using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slice : MonoBehaviour
{
    public Sprite Texture;
    public AudioClip Catch_Sound;
    public GameObject[] ShowScore;
    public float Y_Num = 0.5f;
    private Vector3 Y_Pos;
    private bool Slice_State = false;
    public GameObject music;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        if (Slice_State == false)
        {
            Slice_State = true;
            Y_Pos.y = Y_Num;
            //transform.position += new Vector3(0, Y_Pos.y, 0);
            //transform.rotation = Quaternion.Euler(0, 0, 0);

            if (gameObject.tag == "Watermelon")
            {
                Score_Time.Score_Num += 20;
                Instantiate(ShowScore[0], transform.position, Quaternion.Euler(0, 0, 0));

            }

            if (gameObject.tag == "Banana")
            {
                Score_Time.Score_Num += 10;
                Instantiate(ShowScore[1], transform.position, Quaternion.Euler(0, 0, 0));
            }

            if (gameObject.tag == "Apple")
            {
                Score_Time.Score_Num += 8;
                Instantiate(ShowScore[2], transform.position, Quaternion.Euler(0, 0, 0));
            }

            if (gameObject.tag == "Orange")
            {
                Score_Time.Score_Num += 5;
                Instantiate(ShowScore[3], transform.position, Quaternion.Euler(0, 0, 0));
            }

            if (gameObject.tag == "Strawberry")
            {
                Score_Time.Score_Num += 2;
                Instantiate(ShowScore[4], transform.position, Quaternion.Euler(0, 0, 0));
            }

            if (gameObject.tag == "Bonk")
            {
                Score_Time.Score_Num -= 20;
                Instantiate(ShowScore[5], transform.position, Quaternion.Euler(0, 0, 0));
                Instantiate(ShowScore[6], transform.position, Quaternion.Euler(0, 0, 0));
                GetComponent<Rotate_Myself>().enabled = false;
            }

            GetComponent<SpriteRenderer>().sprite = Texture;
            GetComponent<AudioSource>().PlayOneShot(Catch_Sound);
            Destroy(gameObject,0.3f);
        }
    }
}
