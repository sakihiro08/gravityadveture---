using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ChaseCamera : MonoBehaviour
{
    public GameObject target;
    public float minX; // 見える範囲の最小x座標
    public float maxX; // 見える範囲の最大x座標
    public float minY; // 見える範囲の最小y座標
    public float maxY; // 見える範囲の最大y座標

    private void Update()
    {
        // ターゲットの位置を取得
        Vector3 targetPosition = target.transform.position;

        // X座標が範囲内に収まるように調整
        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);

        // Y座標が範囲内に収まるように調整
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);

        // カメラの位置を更新
        transform.position = new Vector3(newX, newY, transform.position.z);
    }
}