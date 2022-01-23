using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Turn : MonoBehaviour {
    public int speed = 5;
    public float angle = 90.0f; // 초기 각도값
    public float maxCount = 50.0f; // 초기 빈도값
    int count = 0; // 카운터용

    // Start is called before the first frame update
    void Start() {
        count = 0;
    }

    // Update is called once per frame
    void Update() {
        Debug.Log(count);
        if (count >= maxCount) {
            this.transform.Rotate(0, 0, angle); // Rotate (x,y,z)
            count = 0;
        }
        // down 눌렀을때만, up 떼었을 때
        // 마우스 버튼 0:왼쪽, 1:오른쪽, 2:휠
        if (Input.GetMouseButtonDown(1)) {
            transform.Translate(speed, 0, 0);
            count += speed;
        }
        else if (Input.GetMouseButtonDown(0)) {
            transform.Translate(-speed, 0, 0);
            count += speed;
        }
    }
}
