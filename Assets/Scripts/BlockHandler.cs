using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockHandler : MonoBehaviour
{
    [SerializeField]
    GameObject blockPrefab;

    void Start()
    {
        // 블럭 랜덤 생성
        for (int i = 0; i < 160; i++)
        {
            var block = Instantiate(blockPrefab, new Vector2(0, 0), Quaternion.identity, GameObject.Find("BlockLayout").transform);
            block.transform.GetChild(0).gameObject.GetComponent<Text>().text = Random.Range(1, 10).ToString();
        }
    }
}
