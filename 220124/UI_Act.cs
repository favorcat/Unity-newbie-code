using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Act : MonoBehaviour {
    // Update is called once per frame
    void Update() {
        if(Input.GetKey("return")){  // 엔터 키 눌렀을 때,
            SceneManager.LoadScene("GameOver"); // GameOver으로 변경
        }
    }
}
