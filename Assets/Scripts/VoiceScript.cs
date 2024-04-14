using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Voice;

public class VoiceScriptOtameshi : MonoBehaviour
{
    public AppVoiceExperience voiceExperience;

    // Start is called before the first frame update
    void Start()
    {
        
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
}
