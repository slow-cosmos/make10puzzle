using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockHandler : MonoBehaviour
{
    [SerializeField]
    GameObject blockPrefab;

    public List<GameObject> blockList = new List<GameObject>();

    private static BlockHandler instance = null;

    public static BlockHandler Instance
    {
        get
        {
            if(instance == null)
            {
                return null;
            }
            return instance;
        }
    }

    void Awake()
    {
        if(null == instance)
        {
            instance = this;
        }
    }

    void Start()
    {
        // 블럭 랜덤 생성
        for (int i = 0; i < 160; i++)
        {
            var block = Instantiate(blockPrefab, new Vector2(0, 0), Quaternion.identity, GameObject.Find("BlockLayout").transform);
            block.transform.GetChild(0).gameObject.GetComponent<Text>().text = Random.Range(1, 10).ToString();
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            int sum = 0;
            foreach (GameObject block in blockList)
            {
                sum += int.Parse(block.transform.GetChild(0).gameObject.GetComponent<Text>().text);
                block.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
            }

            Debug.Log(sum);

            if (sum == 10)
            {
                foreach (GameObject block in blockList)
                {
                    block.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
                    block.transform.GetChild(0).gameObject.GetComponent<Text>().color = new Color(0, 0, 0, 0);
                    block.GetComponent<BoxCollider>().isTrigger = false;
                    ScoreHandler.curScore++;
                    SoundManager.Instance.SfxPlay(1,0.2f);
                    //Destroy(block);
                }
            }
            blockList.Clear();
        }
    }

}