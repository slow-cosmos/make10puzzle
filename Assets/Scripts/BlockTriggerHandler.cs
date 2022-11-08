using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockTriggerHandler : MonoBehaviour
{
    List<GameObject> blockList = new List<GameObject>();

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            int sum = 0;
            foreach (GameObject block in blockList)
            {
                sum += int.Parse(block.transform.GetChild(0).gameObject.GetComponent<Text>().text);
            }

            Debug.Log(sum);

            if (sum == 10)
            {
                foreach (GameObject block in blockList)
                {
                    Destroy(block);
                }
            }
            else
            {
                blockList.Clear();
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("trigger");
        blockList.Add(col.gameObject);
    }

    void OnTriggerExit(Collider col)
    {
        blockList.Remove(col.gameObject);
    }
}
