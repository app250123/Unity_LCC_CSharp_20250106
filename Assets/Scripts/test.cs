using Star.tool;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{

    public int n; //�ܼ�n
    int sum; //�`�M

    void Start()
    {
        TypeFor();  //For�j�鰵�k
        TypeWhile(); //While�j�鰵�k
    }

    void TypeFor() //For�j�鰵�k
    {
        sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }
        Debug.Log(sum);
    }

    void TypeWhile() //While�j�鰵�k
    {
        sum = 0;
        int tmpn = n; //�Ȧsn�ܼ�
       while (tmpn > 0)
        {
            sum = sum + tmpn;
            tmpn--;
        }           
        Debug.Log(sum);
    }

    
}
