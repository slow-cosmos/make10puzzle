using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseHandler : MonoBehaviour
{
    [SerializeField]
    GameObject dragSquare;

    GameObject square;

    Vector3 startPos, nowPos, deltaPos;
    float deltaX, deltaY;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z * -1));
            square = Instantiate(dragSquare, new Vector3(0, 0, 0), Quaternion.identity);
        }

        if (Input.GetMouseButton(0))
        {
            nowPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z * -1));
            deltaX = Mathf.Abs(nowPos.x - startPos.x);
            deltaY = Mathf.Abs(nowPos.y - startPos.y);
            deltaPos = startPos + (nowPos - startPos) / 2;
            square.transform.position = deltaPos;
            square.transform.localScale = new Vector3(deltaX,deltaY,0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Destroy(square);
        }
    }
}
