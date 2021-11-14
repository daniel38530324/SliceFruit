using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay_Exit_Btn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }


    public void Exit_Fun()
    {
        Application.Quit();
    }
}
