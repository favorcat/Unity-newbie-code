using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour {
    public float speed = 5; // public 공개, 데이터형(int(정수), float(정수)) 변수 이름 speed, 변수값 5.0f
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        this.transform.Translate( speed / 50.0f, 0, 0);
    }
}
