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
        //shisen1へ
        if (OVRInput.GetUp(OVRInput.Button.Three))
        {
            Invoke("ChangeScene1", 1.5f);
            Debug.Log("change!");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Invoke("ChangeScene1", 1.5f);
            Debug.Log("change!");
        }

    }


}