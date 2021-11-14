using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_MoveUp : MonoBehaviour
{
    public int Up_Speed = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0 * Time.deltaTime, Up_Speed * Time.deltaTime, 0 * Time.deltaTime);
        Destroy(gameObject, 0.5f);
    }
}
