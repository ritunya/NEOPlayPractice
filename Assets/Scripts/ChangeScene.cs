using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Meta.WitAi.Data; // AudioBuffer の名前空間

public class ChangeScene: MonoBehaviour
{
    // Start is called before the first frame update
    //どの世界にも飛べる
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //shisen2へ
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
    public void ChangeScene1()
    {
        StopAudioBuffer(); // シーン切り替え前にAudioBufferを停止
        SceneManager.LoadScene("shisen1");
    }
    public void StopAudioBuffer()
    {
        var audioBuffer = AudioBuffer.Instance;
        if (audioBuffer != null)
        {
            audioBuffer.StopRecording(this);
        }
    }

}
