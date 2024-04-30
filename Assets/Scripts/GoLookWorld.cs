using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Invoke("ChangeScene", 1.5f);
            Debug.Log("change!");
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("shisen");
    }
}