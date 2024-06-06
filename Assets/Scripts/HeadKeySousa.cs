using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadKeySousa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
//#if UNITY_EDITOR || UNITY_STANDALONE
        // if (OVRInput.GetControllerPositionTracked(OVRInput.Controller.RTouch) == false)
        // {
        // DevLog.Log("コントローラ4");
        // DevLog.Log("コントローラがnull!");
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float thirdAxis = (Input.GetKey(KeyCode.Q) ? 1.0f : 0f) + (Input.GetKey(KeyCode.Z) ? -1.0f : 0f);
        // DevLog.Log(horizontal + ", " + thirdAxis + ", " + vertical);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // キーボード入力に基づいてカメラ角度を回転させる
            // ovrCameraRigTransform!.eulerAngles = ovrCameraRigTransform.eulerAngles + new Vector3(horizontal, thirdAxis, vertical) * rotateSpeed * Time.deltaTime;
            // キーボード入力に基づいてカメラを並行移動させる
            Transform center = GameObject.Find("CenterEyeAnchor").transform;
            //center!.Translate(new Vector3(horizontal, thirdAxis, vertical) * moveSpeed * Time.deltaTime);
        }
        else
        {
            // キーボード入力に基づいてオブジェクトを移動させる
            //myTransform.Translate(new Vector3(-vertical, thirdAxis, horizontal) * moveSpeed * Time.deltaTime);
        }
        // }
//#endif
    }
}
