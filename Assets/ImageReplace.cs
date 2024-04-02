using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bombController : MonoBehaviour
{
    // デフォルトの画像(爆弾の画像)
    public Sprite defaultImage;
    // 画像描画用のコンポーネント
    SpriteRenderer sr;

    void Start()
    {
        // SpriteのSpriteRendererコンポーネントを取得
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Playerタグがついたオブジェクトと衝突した時に処理
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "explanation")
        {
            // デフォルトの画像を爆発後の画像に切り替える
            sr.sprite = defaultImage;
        }
    }
}