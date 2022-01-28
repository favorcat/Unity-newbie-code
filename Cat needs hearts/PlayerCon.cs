using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour {
    float speed = 0;    // 변수 선언
    public float 분모값 = 100.0f;
    Vector2 startPos;   // 마우스 눌렀을 떄의 위치값이 들어갈 변수
    Vector2 endPos;     // 마우스를 눌렀다 뗴었을 떄의 위치값이 들어갈 변수
    // 2차원 좌표의 벡터값(x,y) 3차원좌표의 벡터값(x,y,z)
    // Vector2는 2차원 좌표값을 가짐(x,y)
    // Vector3는 3차원 좌표값(x,y,z)

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            this.startPos = Input.mousePosition; // 마우스 버튼으로 눌렀을 때의 위치값(x,y)
        } else if(Input.GetMouseButtonUp(0)){
            this.endPos = Input.mousePosition; // 마우스 버튼을 눌렀다가 떼었을 때의 위치값(x,y)
            float length = (this.endPos.x - this.startPos.x); // 마지막 좌표값 - 처음 좌표값
            this.speed = length / 분모값;
            this.GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed*Time.deltaTime, 0, 0); // x+방향으로 이동
        this.speed *= 0.98f; // 점차 0에 가깝게 감속한다
    }
}
