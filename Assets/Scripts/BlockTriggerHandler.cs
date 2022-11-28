using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockTriggerHandler : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        BlockHandler.Instance.blockList.Add(col.gameObject);
        col.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.15f, 0.15f, 0.15f);
    }

    void OnTriggerExit(Collider col)
    {
        BlockHandler.Instance.blockList.Remove(col.gameObject);
        col.gameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,0,1);
    }
}
