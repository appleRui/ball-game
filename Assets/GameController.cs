using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Canvas canvas;
    public ParticleSystem ps;

    // Start is called before the first frame update
    void Start(){
        // canvasを非表示にする
        canvas.enabled = false;

        // Particle Systemを非表示にする
        ps.Stop();
    }

    // Update is called once per frame
    void Update(){
        
    }

    // ゴール（Cube(7)）に衝突したときの処理
    void OnCollisionEnter(Collision collisionInfo){
        // 衝突したオブジェクトが「Sphere」だったら
        if (collisionInfo.gameObject.name.Equals("goal")){
            // canvasを表示する
            canvas.enabled = true;

            // Particle Systemを表示する
            ps.Play();
        }
    }
}
