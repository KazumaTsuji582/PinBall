using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //これないとUI関連、画像とかも使えない　52行目Textを使うために関数の宣言を行う import mathみたいな

public class ScoreController : MonoBehaviour
{
    //表示するスコアを設定 スコープの観点からここに書く void statだとスコープ外
    int score = 0;

    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            score += 10;
            //Debug.Log("small");
        }
        else if (collision.gameObject.tag == "LargeStarTag") 
        {
            score += 20;
            //Debug.Log("LargeS");
            //Debug.Log(score);
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 5;
            //Debug.Log("SC");
            //Debug.Log(score);
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 50;
            //Debug.Log(score);
        }
        //Debug.Log(score);
        
        //Debug.Log(collision.gameObject.tag);    //debuglog(tag)だと、自身のタグを参照するため、予測変換機能を用いつつタグ全般を表すもののありかを探して指定している
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = score +"points";
    }
}
