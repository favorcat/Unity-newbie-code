using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {
    public void LButtonDown() { // 왼쪽 버튼 클릭했을 때
        if (this.transform.position.x > -5.8) {
            transform.Translate(-1.0f, 0, 0); // 왼쪽으로 이동
            this.GetComponent<SpriteRenderer>().flipX = false; // 플레이어 왼쪽 바라보기
        }
    }

    public void RButtonDown() { // 오른쪽 버튼 클릭했을 때
        if (this.transform.position.x < 5.8) {
            transform.Translate(1.0f, 0, 0); // 오른쪽으로 이동
            this.GetComponent<SpriteRenderer>().flipX = true; // 플레이어 오른쪽 바라보기
        }
    }
}
