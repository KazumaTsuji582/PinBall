using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //����Ȃ���UI�֘A�A�摜�Ƃ����g���Ȃ��@52�s��Text���g�����߂Ɋ֐��̐錾���s�� import math�݂�����

public class ScoreController : MonoBehaviour
{
    //�\������X�R�A��ݒ� �X�R�[�v�̊ϓ_���炱���ɏ��� void stat���ƃX�R�[�v�O
    int score = 0;

    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
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
        
        //Debug.Log(collision.gameObject.tag);    //debuglog(tag)���ƁA���g�̃^�O���Q�Ƃ��邽�߁A�\���ϊ��@�\��p���^�O�S�ʂ�\�����̂̂��肩��T���Ďw�肵�Ă���
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = score +"points";
    }
}
