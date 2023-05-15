using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockTriggerHandler : MonoBehaviour
{
    BlockHandler blockHandler;

    void Start()
    {
        blockHandler = GameObject.Find("BlockHandler").GetComponent<BlockHandler>();
    }

    void OnTriggerEnter(Collider col)
    {
        blockHandler.AddBlock(col.gameObject);
        col.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.15f, 0.15f, 0.15f);
    }

    void OnTriggerExit(Collider col)
    {
        blockHandler.RemoveBlock(col.gameObject);
        col.gameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,0,1);
    }
}
