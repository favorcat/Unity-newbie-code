using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotBlock : MonoBehaviour{
    public float rotSpeed = 3;  // 회전 속도 선언

    // Update is called once per frame
    void Update() {
        transform.Rotate(0, 0, rotSpeed);   // 회전 속도만큼 블록을 회전
    }
}