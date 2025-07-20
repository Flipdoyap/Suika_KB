using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float moveSpeed = 0.5f; // 移動速度を調整するための変数

    // 毎フレーム呼ばれるメソッド
    void Update()
    {
        // 現在のCubeの位置を取得
        Vector3 currentPosition = transform.position;

        // X軸方向に移動する新しい位置を計算
        // Time.deltaTimeを使うことで、フレームレートに依存しない移動を実現
        Vector3 newPosition = currentPosition + new Vector3(moveSpeed * Time.deltaTime, 0, 0);

        // Cubeの位置を更新
        transform.position = newPosition;
    }
}