using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BornController : MonoBehaviour {
    GameObject player; // player 변수에는 GameObject를 대입
    void Start() {
        this.player = GameObject.Find("Player"); // 이름이 Player인 GameObject를 변수 player에 대입
    }

    void Update() {
        transform.Translate(0, -0.1f, 0);
        if(transform.position.y < -6.25f) Destroy(gameObject); // 화면에서 벗어나면 오브젝트 삭제
        
        // 자신의 x,y 좌표값을 변수 p1에 대입
        Vector2 p1 = transform.position;
        // player의 x,y 좌표를 변수 p2에 대입
        Vector2 p2 = this.player.transform.position;

        Vector2 dir = p1 - p2; // 변수 dir은 p1-p2 값을 대입
        float d = dir.magnitude; // 벡터 dir의 길이를 실수로 변환
        float r1 = 0.8f; // r1(자신)의 오브젝트의 반지름
        float r2 = 1.0f; // r2(player) 오브젝트의 반지름
        if (d < r1+r2) {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<Game2Director>().DecreaseHp(); // 게임디렉터의 피 깎는 메소드 실행
            Destroy(gameObject); // 이 오브젝트를 삭제
        }
    }
}
