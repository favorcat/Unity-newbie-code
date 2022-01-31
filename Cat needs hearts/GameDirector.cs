using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // UI를 쓸 때는 꼭 사용해야 함
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {
    GameObject player;      // 플레이어 오브젝트를 대입할 변수 데이터형 GameObject
    GameObject goal;       // 목표물 오브젝트를 대입할 변수 데이터형 GameObject
    GameObject distance;    // 플레이어 오브젝트와 목표물 오브젝트 사이의 거리를 표시할 UI 오브젝트를 대입할 변수 데이터형 GameObject

    // Start is called before the first frame update
    void Start(){
        this.player = GameObject.Find("meaw");
        this.goal = GameObject.Find("heart");
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update(){
        float lengthDis = this.goal.transform.position.x - this.player.transform.position.x;
        if (lengthDis >= 0) {
            this.distance.GetComponent<Text>().text = "GOAL" + " : " + lengthDis.ToString("F3") + "m";
            // ToString("D숫자") 정수형, ToString("F숫자") 실수형
        } else {
            SceneManager.LoadScene("GameOver"); // GameOver으로 변경
        }
    }
}
