using Star.tool;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{

    public int n; //變數n
    int sum; //總和

    void Start()
    {
        TypeFor();  //For迴圈做法
        TypeWhile(); //While迴圈做法
    }

    void TypeFor() //For迴圈做法
    {
        sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }
        Debug.Log(sum);
    }

    void TypeWhile() //While迴圈做法
    {
        sum = 0;
        int tmpn = n; //暫存n變數
       while (tmpn > 0)
        {
            sum = sum + tmpn;
            tmpn--;
        }           
        Debug.Log(sum);
    }

    
}
