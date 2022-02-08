using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_act : MonoBehaviour {
    void Update() {
        if (Input.GetKey("space"))
        {  // 스페이스 키 눌렀을 때,
            SceneManager.LoadScene("GameScene2"); // GameOver으로 변경
        }
    }
}
