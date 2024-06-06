using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEngine.GraphicsBuffer;

public class OtameshiWordHantei : MonoBehaviour
{
    public TextMeshProUGUI userText;
    string target = "かわいい";

    // Start is called before the first frame update
    void Start()
    {

        //テキスト反映
        //userText.text = "果てしなき時の彼方より願い継がれる想いがある";
        Debug.Log(userText.text);


    }

    // Update is called once per frame
    void Update()
    {
        //テキストボックス取得
        userText = this.GetComponent<TextMeshProUGUI>();

        if(userText.text.Contains(target))
        {
            Debug.Log($"{target}が文章の中に含まれていました。");
        }
        else
        {
            Debug.Log($"{target}は文章の中に含まれていません。");
        }
    }

    public void TextSet()
    {

    }
}
