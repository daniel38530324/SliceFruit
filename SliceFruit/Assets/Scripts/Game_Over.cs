using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Over : MonoBehaviour
{
    public GameObject UI;
    public GameObject Replay_Btn;
    public GameObject Exit_Btn;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Score_Time.Time_Num <= 0 && Score_Time.Score_Num < score)
        {
            Game_Sart.Game_State = false;
            StartCoroutine("Show_UI");
           
        }
    }

    IEnumerator Show_UI()
    {
        UI.SetActive(true);
        yield return new WaitForSeconds(0.8f);
        Replay_Btn.SetActive(true);
        Exit_Btn.SetActive(true);
    }
}
