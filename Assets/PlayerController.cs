using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // デフォルトの画像(爆弾の画像)
    public Sprite defaultImage;
    // 画像描画用のコンポーネント
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        // SpriteのSpriteRendererコンポーネントを取得
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   //プレイヤーのワールド座標
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += 0.05f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= 0.05f;
        }
        transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Key2"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Key3"))
        {
            Destroy(other.gameObject);
        }   
        if (other.gameObject.CompareTag("next"))
            {
                SceneManager.LoadScene("Main stage");
            }
        if (other.gameObject.CompareTag("Goal"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Goal");
        }
        if (other.collider.tag == "explanation")
        {
            // デフォルトの画像を爆発後の画像に切り替える
            sr.sprite = defaultImage;
        }
    }
   
    }
