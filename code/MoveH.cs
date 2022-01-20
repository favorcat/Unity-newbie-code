using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveH : MonoBehaviour {
    public float speed = 1.0f; // 속도값, 이 변수는 퍼블리 변수이기 때문에 인스펙터에서 변경 가ㄴ

    void Update() {
        this.transform.Translate(speed / 50, 0, 0); // 수평이동 (+x 축 방향으로 이동)
    }
}
