using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level : MonoBehaviour
{   public static int  LevelIndex = 0;
    // Start is called before the first frame update
    public Text index;
    void Start()
    {
        index = GetComponent<Text>();
       LevelIndex = PersistentData.Instance.GetIndex();
    }

    // Update is called once per frame
    void Update()
    {
        index.text = "LEVEL:" + LevelIndex;
    }
}
