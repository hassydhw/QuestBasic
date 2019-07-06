using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLaser : MonoBehaviour
{

    // 右手
    [SerializeField]
    private Transform _RightHandAnchor;

    // 左手
    [SerializeField]
    private Transform _LeftHandAnchor;

    // 目の中心
    [SerializeField]
    private Transform _CenterEyeAnchor;

    // 距離
    [SerializeField]
    private float _MaxDistance = 100.0f;

    // LineRenderer
    [SerializeField]
    private LineRenderer _LaserPointerRenderer;

    // コントローラー
    private Transform Pointer
    {
        get
        {
            // 現在アクティブなコントローラーを取得
            var controller = OVRInput.GetActiveController();
            if (controller == OVRInput.Controller.RTrackedRemote)
            {
                return _RightHandAnchor;
            }
            else if (controller == OVRInput.Controller.LTrackedRemote)
            {
                return _LeftHandAnchor;
            }
            // どちらも取れなければ目の間からビームが出る
            return _CenterEyeAnchor;
        }
    }

    void Update()
    {
        // コントローラーを取得
        var pointer = Pointer;

        // コントローラーがない or LineRendererがなければ何もしない
        if (pointer == null || _LaserPointerRenderer == null)
        {
            return;
        }

        // コントローラー位置からRayを飛ばす
        Ray pointerRay = new Ray(pointer.position, pointer.forward);

        // レーザーの起点
        _LaserPointerRenderer.SetPosition(0, pointerRay.origin);

        RaycastHit hitInfo;
        if (Physics.Raycast(pointerRay, out hitInfo, _MaxDistance))
        {
            // Rayがヒットしたらそこまで
            _LaserPointerRenderer.SetPosition(1, hitInfo.point);
        }
        else
        {
            // Rayがヒットしなかったら向いている方向にMaxDistance伸ばす
            _LaserPointerRenderer.SetPosition(1, pointerRay.origin + pointerRay.direction * _MaxDistance);
        }
    }
}