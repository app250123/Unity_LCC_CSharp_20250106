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
            
            //裝箱
            // 將實質型別資料放到參考型別資料內
            box = number;
            LogSystem.LogWithColor(box.ToString(),"#6f6");
        }

    }
}
