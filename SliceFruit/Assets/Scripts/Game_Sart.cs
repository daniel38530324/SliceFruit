using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Sart : MonoBehaviour
{
    public static bool Game_State = false;
    public GameObject UI;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GameStart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GameStart()
    {
        yield return new WaitForSeconds(2f);
        UI.SetActive(false);
        Game_State = true;
    }
}
