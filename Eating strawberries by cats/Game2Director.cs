using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game2Director : MonoBehaviour {
    GameObject hpGauge;
    GameObject player;
    GameObject score;
    float time = 0;

    void Start() {
        this.hpGauge = GameObject.Find("HP"); // HP라는 이름을 가진 오브젝트를 hpGauage GameObject에 대입
        this.player = GameObject.Find("Player"); // Player이라는 이름을 가진 오브젝트를 player GameObject에 대입
        this.score = GameObject.Find("Score"); // Score이라는 이름을 가진 오브젝트를 score GameObject에 대입
    }

    void Update(){
        time += Time.deltaTime;
        this.score.GetComponent<Text>().text = "SCORE" + " : " + time.ToString("F2");
        // ToString("D숫자") 정수형, ToString("F숫자") 실수형
    }

    public void DecreaseHp(){ // HP 깎는 메소드
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f; // HP 깎기
        if (this.hpGauge.GetComponent<Image>().fillAmount == 0) { // HP가 0이 되면
            SceneManager.LoadScene("GameOver"); // GameOver으로 변경
        }
    }

    public void IncreaseHp(){ // HP 충전하는 메소드
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f; // HP 충전
        this.player.GetComponent<AudioSource>().Play(); // HP 충전되는 소리 재생
    }
}
