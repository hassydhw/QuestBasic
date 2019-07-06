using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerLineRenderer : MonoBehaviour
{
    public Transform rightHandAnchor = null;
    public LineRenderer lineRenderer = null;
    public float maxRayDistance = 500.0f;

    void Update()
    {
        // 右手のコントローラの位置と向いている方向からRayを作成
        Ray laserPointer = new Ray(rightHandAnchor.position, rightHandAnchor.forward);

        // 作成したRay上にColliderがあるか判定
        RaycastHit hit;
        if (Physics.Raycast(laserPointer, out hit, maxRayDistance))
        {
            // Colliderがあれば、衝突箇所までレーザーを描画
            renderLaserToHit(laserPointer, hit);

            GameObject pointedObject = hit.collider.gameObject;
            //            pointedObject.transform.SendMessage("OnPointerEnter");

        }
        else
        {
            // Colliderがなければ、最大長のレーザーを描画
            renderLaserFullLength(laserPointer);
        }
    }

    private void renderLaserToHit(Ray ray, RaycastHit hit)
    {
        renderLaser(ray.origin, hit.point);
    }

    private void renderLaserFullLength(Ray ray)
    {
        renderLaser(ray.origin, ray.origin + ray.direction * maxRayDistance);
    }

    private void renderLaser(Vector3 from, Vector3 to)
    {
        // Line Rendererの1点目と2点目の位置を指定する
        lineRenderer.SetPosition(0, from);
        lineRenderer.SetPosition(1, to);
    }

}
