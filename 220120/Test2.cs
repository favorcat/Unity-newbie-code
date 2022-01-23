using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 클래스 이름은 스크립트 파일이름과 같아야 합니다.
public class Test2 : MonoBehaviour {
    // Start is called before the first frame update
    // 매번 프레임이 갱신되어도 스타트 메소드 안에 있는 내용은 한 번만 실행한다.
    void Start() {
    }

    // Update is called once per frame
    // 매 프레임마다 계속적으로 갱신(추가)가 되는 메소드로 계속적으로 실행한다.
    void Update() {
        // 이 스크립트가 속해 있는 게임 오브젝트의 트랜스폼 컴포넌트를 이동시킨다.
        this.transform.Translate(0.1f, 0, 0);
    }
}