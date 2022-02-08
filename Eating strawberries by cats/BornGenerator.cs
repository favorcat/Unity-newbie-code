using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BornGenerator : MonoBehaviour
{
    public GameObject copyB;
    float respan = 1.0f; // 복제 오브젝트가 나타나는 시간(리스폰 시간)
    float delta = 0; // 일정한 시간을 비교하기 위한 시간 변수

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.respan){ // 리스폰 시간이 되면
            this.delta = 0; // 시간 초기화
            GameObject copyBorn = Instantiate(copyB) as GameObject;
            int range = Random.Range(-6,6); // Random.Range(최소값,최대값)
            float range2 = Random.Range(-6.0f,6.0f);
            copyBorn.transform.position = new Vector3 (range2, 6, 0); // 랜덤의 위치에 생성
        }
    }
}
