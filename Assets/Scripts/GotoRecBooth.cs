using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Meta.WitAi.Data; // AudioBuffer の名前空間

public class GotoRecBooth : MonoBehaviour
{
    //public GotoShisen1 shisen1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //shisen2へ
        if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstick))
        {
            Invoke("ChangeScene3", 1.5f);
            Debug.Log("change!");
        }
        if (OVRInput.GetUp(OVRInput.Button.SecondaryThumbstick))
        {
            Invoke("shisen1.ChangeScene1", 1.5f);
            Debug.Log("change!");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Invoke("ChangeScene3", 1.5f);
            Debug.Log("change!");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Invoke("ChangeScene1", 1.5f);
            Debug.Log("change!");
        }

    }
    public void ChangeScene3()
    {
        StopAudioBuffer(); // シーン切り替え前にAudioBufferを停止
        SceneManager.LoadScene("recoding booth");
    }
    public void ChangeScene1()
    {
        StopAudioBuffer(); // シーン切り替え前にAudioBufferを停止
        SceneManager.LoadScene("shisen1");
    }
    void StopAudioBuffer()
    {
        var audioBuffer = AudioBuffer.Instance;
        if (audioBuffer != null)
        {
            audioBuffer.StopRecording(this);
        }
    }

}
