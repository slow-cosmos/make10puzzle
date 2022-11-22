using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockTriggerHandler : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        BlockHandler.Instance.blockList.Add(col.gameObject);
    }

    void OnTriggerExit(Collider col)
    {
        BlockHandler.Instance.blockList.Remove(col.gameObject);
    }
}
