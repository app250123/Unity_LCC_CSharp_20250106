using UnityEngine;
using Star.tool;
namespace Star
{


public class Class_9_1_Boxing:MonoBehaviour
{
        private int number = 100;

        private object box;

        private void Awake()
        {
            
            //�˽c
            // �N��諬�O��Ʃ��Ѧҫ��O��Ƥ�
            box = number;
            LogSystem.LogWithColor(box.ToString(),"#6f6");
        }

    }
}
