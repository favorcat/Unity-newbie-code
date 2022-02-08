using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    void Update() {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){ // 왼쪽 화살표 키 눌렀을 때
            if(this.transform.position.x > -5.8) {
                transform.Translate(-1.0f, 0,0); // 왼쪽으로 이동
                this.GetComponent<SpriteRenderer>().flipX = false; // 플레이어 왼쪽 바라보기
            }
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){ // 오른쪽 화살표 키 눌렀을 때
            if(this.transform.position.x < 5.8) {
                transform.Translate(1.0f,0,0); // 오른쪽으로 이동
                this.GetComponent<SpriteRenderer>().flipX = true; // 플레이어 오른쪽 바라보기
            }
        }
    }
}
