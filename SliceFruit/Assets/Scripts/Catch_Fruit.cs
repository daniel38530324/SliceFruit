using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch_Fruit : MonoBehaviour
{
    public AudioClip Catch_Sound;
    public GameObject[] ShowScore;
    public float Y_Num = 0.5f;
    private Vector3 Y_Pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("Score_Time.Score_Num="+ Score_Time.Score_Num);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Y_Pos.y = Y_Num;
        collision.transform.position += new Vector3(0, Y_Pos.y, 0);
        collision.transform.rotation = Quaternion.Euler(0, 0, 0);

        if (collision.gameObject.tag == "Watermelon")
        {
            Score_Time.Score_Num += 20;
            Instantiate(ShowScore[0], collision.transform.position, collision.transform.rotation);

        }

        if (collision.gameObject.tag == "Banana")
        {
            Score_Time.Score_Num += 10;
            Instantiate(ShowScore[1], collision.transform.position, collision.transform.rotation);
        }

        if (collision.gameObject.tag == "Apple")
        {
            Score_Time.Score_Num += 8;
            Instantiate(ShowScore[2], collision.transform.position, collision.transform.rotation);
        }

        if (collision.gameObject.tag == "Orange")
        {
            Score_Time.Score_Num += 5;
            Instantiate(ShowScore[3], collision.transform.position, collision.transform.rotation);
        }

        if (collision.gameObject.tag == "Strawberry")
        {
            Score_Time.Score_Num += 2;
            Instantiate(ShowScore[4], collision.transform.position, collision.transform.rotation);
        }

        GetComponent<AudioSource>().PlayOneShot(Catch_Sound);
        Destroy(collision.gameObject);
   
    }
}
