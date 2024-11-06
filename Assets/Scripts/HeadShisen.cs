using UnityEngine;
using UnityEngine.XR;
//using Meta.WitAi.Data; // AudioBufferが含まれている名前空間


public class HeadObject : MonoBehaviour
{
    public GameObject targetObject; // 連動させたい3Dオブジェクト
    public Animator animator;
    Quaternion headRotation;
    

    //HMDの位置座標格納用
    private Vector3 HMDPosition;
    //HMDの回転座標格納用（クォータニオン）
    private Quaternion HMDRotationQ;
    //HMDの回転座標格納用（オイラー角）
    private Vector3 HMDRotation;
    // public GameObject micPrefab;
    // private GameObject micObject;



    void Start()
    {
        animator = GetComponent<Animator>();
        targetObject = GetComponent<GameObject>();
        //OnDestroy();
        //CreateMic();

    }

    void Update()
    {
        // Unityちゃんの頭の回転情報を取得
        //headRotation = animator.GetBoneTransform(HumanBodyBones.Head).rotation;

        // 目標の3Dオブジェクトのトランスフォームに頭の回転情報を適用
        //targetObject.transform.rotation = headRotation;

        //Head（ヘッドマウンドディスプレイ）の情報を一時保管-----------
        //位置座標を取得
        HMDPosition = InputTracking.GetLocalPosition(XRNode.Head);
        //回転座標をクォータニオンで値を受け取る
        HMDRotationQ = InputTracking.GetLocalRotation(XRNode.Head);
        //取得した値をクォータニオン → オイラー角に変換
        HMDRotation = HMDRotationQ.eulerAngles;

        //Debug.Log("HMDP:" + HMDPosition.x + ", " + HMDPosition.y + ", " + HMDPosition.z + "\n" +
        //            "HMDR:" + HMDRotation.x + ", " + HMDRotation.y + ", " + HMDRotation.z);

    }

    // Micオブジェクトを生成するメソッド
    // void CreateMic()
    // {
    //     // 既にオブジェクトが存在する場合は削除
    //     if (micObject != null)
    //     {
    //         Destroy(micObject);
    //     }

    //     // 新しいMicオブジェクトを生成
    //     micObject = Instantiate(micPrefab);

    //     // 必要に応じて初期化
    //     InitializeMic(micObject);
    // }

    // // Micの初期化メソッド
    // void InitializeMic(GameObject mic)
    // {
    //     // Micオブジェクトの初期化処理
    //     Debug.Log("Mic オブジェクトを初期化しました。");
    //     // mic.GetComponent<Mic>().Initialize(); // 必要に応じて追加
    // }

    // // AudioBufferの初期化
    // void InitializeAudioBuffer(AudioBuffer buffer)
    // {
    //     // ここでAudioBufferに必要な設定を行う
    //     Debug.Log("AudioBuffer を初期化しました。");
    //     // 例: buffer.SetSomeProperty(value);
    // }
}
