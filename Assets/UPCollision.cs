using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UPCollision : MonoBehaviour
{

    public GameObject floorPrefab; // 床のPrefabをInspectorからアサインする
    // Start is called before the first frame update
    void Start()
    {
        // プレイヤーオブジェクトの床としてのPrefabのインスタンス化と親の設定
        GameObject instantiatedFloor = Instantiate(floorPrefab, transform.position, Quaternion.identity);
        transform.SetParent(instantiatedFloor.transform);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        // 縦方向のトリガーイベントを検出
        if (col.tag == "floor")
        {
            //// プレイヤーオブジェクトを床オブジェクトの子に設定
            this.gameObject.transform.SetParent(floorPrefab.gameObject.transform);
        }
    }

    void OnTriggerExit(Collider col)
    {
        // 縦方向のトリガーイベントを検出
        if (col.tag == "floor")
        {
            // プレイヤーオブジェクトと床オブジェクトの親子関係を解除
            this.gameObject.transform.SetParent(null);
        }
    }
}
