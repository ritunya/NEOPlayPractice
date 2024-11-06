using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using Oculus.Platform.Models;
using OVR;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using static UnityEngine.GraphicsBuffer;

public class RabbitEscapeRun : MonoBehaviour
{
    private Animator anim;  //Animatorをanimという変数で定義する
    GameObject UserUtterance; //User Utteranceそのものが入る変数
    WordHantei wordHanteiScript; // WordHanteiScriptが入る変数
    //public WordHantei word;
    public TextMeshProUGUI userText;
    string target = "撫でられるかな";

    public WordHantei word;

    // Start is called before the first frame update
    void Start()
    {
        //変数animに、Animatorコンポーネントを設定する
        anim = gameObject.GetComponent<Animator>();

        //user utteranceの中にあるWordHanteiScriptを取得して変数に格納する
        //wordHanteiScript = UserUtterance.GetComponent<WordHantei>();
    }

    // Update is called once per frame
    void Update()
    {
        // transformを取得
        Transform myTransform = this.transform;
        // 座標を取得
        Vector3 pos = myTransform.position;
        Quaternion myRotation = transform.rotation;

        //userText = this.GetComponent<TextMeshProUGUI>();
        //userText = word.userText;


        //Debug.Log(wordHanteiScript.userText.text);
        //↑エラー、音声をテキスト化したものをlogに出したいが、中身がないと言われる

        // "rabbit_escape"パラメータがtrueの場合に処理を実行
        if (anim.GetBool("rabbit_escape"))
        {
            // ここにrabbit_escapeがtrueの場合に実行したい処理を書く
            //Debug.Log("rabbit_escape is true!");

            //pos.x += 0.01f;    // x座標へ0.01加算
            //pos.y += 0.01f;    // y座標へ0.01加算
            pos.z += 0.01f;    // z座標へ0.01加算

            myTransform.position = pos;  // 座標を設定
        }
    }

    // 他のオブジェクトとのすり抜け中
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Look")
        {
            
            if (Time.timeSinceLevelLoad > 10.0f)
            {
                Debug.Log("すり抜け"); // ログを表示する

                if (userText.text.Contains("でられるかな"))
                {
                    Debug.Log($"{target}が文章の中に含まれていました。");
                    //Bool型のパラメーターをTrueにする
                    //anim.SetBool("rabbit_escape", true);
                    transform.Rotate(0f, 150f, 0f);  // y軸を100°回転
                    anim.SetBool("rabbit_escape", true);
                }
                else
                {
                    Debug.Log($"{target}は文章の中に含まれていません。");
                }

                //Bool型のパラメーターをTrueにする
                //anim.SetBool("rabbit_escape", true);

            }
        }
    }

        // 当たった時に呼ばれる関数　衝突開始
    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Look")
    //    {

    //        if (Time.timeSinceLevelLoad > 10.0f)
    //        {
    //            Debug.Log("衝突"); // ログを表示する

    //            transform.Rotate(0f, 150f, 0f);  // y軸を100°回転

    //            //Bool型のパラメーターをTrueにする
    //            anim.SetBool("rabbit_escape", true);
    //        }
    //    }
    //}
}

