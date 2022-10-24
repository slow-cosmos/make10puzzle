using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBlock : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log("collider");
            }
        }
    }
}
