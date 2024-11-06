using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Voice;
// using Meta.WitAi.Data; // AudioBufferが含まれている名前空間
// using Meta.WitAi;
// using Meta.WitAi.Configuration;


public class VoiceScriptOtameshi : MonoBehaviour
{
    public AppVoiceExperience voiceExperience;
    // private AudioBuffer audioBuffer;
    // public Wit witService; // Wit コンポーネントをアタッチ


    // Start is called before the first frame update
    void Start()
    {
        //  // AudioBuffer を取得または初期化
        // audioBuffer = AudioBuffer.Instance;
        // if (audioBuffer == null)
        // {
        //     Debug.LogWarning("AudioBuffer not found. Initializing manually.");
        //     GameObject audioBufferObject = new GameObject("AudioBuffer");
        //     audioBuffer = audioBufferObject.AddComponent<AudioBuffer>();
        // }

        // シーンの開始時に音声認識を開始
        //StartVoiceRecognition();

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.One))
        {
            voiceExperience.Activate();
        }
        if (Input.GetKey(KeyCode.Return))
        {
            voiceExperience.Activate();
        }

    }
    // void StartVoiceRecognition()
    // {
    //     if (witService != null && audioBuffer != null)
    //     {
    //         // Wit サービスを有効にして音声認識を開始
    //         witService.Activate();
    //         Debug.Log("Voice recognition started automatically.");
    //     }
    //     else
    //     {
    //         Debug.LogError("Wit service or AudioBuffer is not assigned or initialized.");
    //     }
    // }
}
