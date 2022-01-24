using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    float move_Speed = 0.2f; // 속도 초기값
    float x_Speed = 0; // x축 방향 속도변수
    float y_Speed = 0; // y축 방향 속도변수
    bool leftFlag = false; // 캐릭터 뒤집기 플래그

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        x_Speed = 0; // x축 방향 속도
        y_Speed = 0; // y축 방향 속도
        
        if(Input.GetKey("right")){  // 오른쪽 키 눌렀을 때,
            x_Speed = move_Speed;   // x축 방향 속도 주기
            leftFlag = false;      // flipX를 위한 플래그 false (체크x)
        }
        if(Input.GetKey("left")){   // 왼쪽 키 눌렀을 때,
            x_Speed = -move_Speed;  // x축 방향 -로 속도 주기
            leftFlag = true;       // flipX를 위한 플래그 true (체크o)
        }
        if(Input.GetKey("up")){     // 위쪽 키 눌렀을 떄,
            y_Speed = move_Speed;   // y축 방향 속도 주기
        }
        if(Input.GetKey("down")){   // 아래쪽 키 눌렀을 때,
            y_Speed = -move_Speed;  // y축 방향 -로 속도 주기
        }
    }
    void FixedUpdate() {
        // 네 방향으로 이동
        this.transform.Translate(x_Speed, y_Speed, 0);    
        // 오른쪽, 왼쪽 방향으로 이동 시, 스프라이트 방향 전환
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
