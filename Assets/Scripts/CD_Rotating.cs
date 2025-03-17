using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Linq;

public class CD_Rotating : MonoBehaviour
{
    public List<string> TargetListStr01 = new List<string>{"1","2","3","4","5"};
    // Start is called before the first frame update
    void Start()
    {
        Question01();
        StartCoroutine(Question02());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator Print01()
    {
       for (int i = 0; i < TargetListStr01.Count; i++)
        {
            Debug.Log(TargetListStr01[i]);
        }
        yield break;
    }

    private void Question01() //請將Print01()改成FOR迴圈
    {
    }

    private IEnumerator Question02()
    {
        StartCoroutine(Print01());
        yield break;
    }
}
