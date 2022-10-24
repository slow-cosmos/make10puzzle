using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHandler : MonoBehaviour
{
    private Vector2 mPosCur;   // 실시간(현재 프레임) 마우스 좌표
    private Vector2 mPosBegin; // 드래그 시작 지점 마우스 좌표
    private Vector2 mPosMin;   // Rect의 최소 지점 좌표
    private Vector2 mPosMax;   // Rect의 최대 지점 좌표
    private bool showSelection;

    private void Update()
    {
        showSelection = Input.GetMouseButton(0);
        if (!showSelection) return;

        mPosCur = Input.mousePosition;
        mPosCur.y = Screen.height - mPosCur.y; // Y 좌표(상하) 반전

        if (Input.GetMouseButtonDown(0))
        {
            mPosBegin = mPosCur;
        }

        mPosMin = Vector2.Min(mPosCur, mPosBegin);
        mPosMax = Vector2.Max(mPosCur, mPosBegin);
    }

    private void OnGUI()
    {
        if (!showSelection) return;
        Rect rect = new Rect();
        rect.min = mPosMin;
        rect.max = mPosMax;

        GUI.Box(rect, "");
    }
}
