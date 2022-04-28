using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCntroller : MonoBehaviour
{
    // Vector3の型に初期値を設定する
    Vector3 startPos = new Vector3(-0.66f, 0.9719369f, 0);
    // Rigidbody型の変数rbを使用する
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // 重力を使用する（摩擦なども考慮される）
        rb = this.transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < -10)
        {
            // テーブルから落ちたらスタート位置に戻す
            this.transform.position = startPos;

            // 落ちたら初速度をゼロにする
            rb.velocity = Vector3.zero;
        }
    }
}
