
using UnityEngine;

namespace Jack
{



public class Class_5_1_Selection : MonoBehaviour
{
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        public string weapon;
        private void Awake()
        {
            if (true)
            {
                Debug.Log("布林值為 true，會執行這裡");
            }

            if (false)
            {
                Debug.Log("布林值為 false，不會執行這裡而且會有綠蚯蚓");
            }
        }
        private void Update()
        {
            Debug.Log("<color=#79f> 更新事件</color>");

            if (isOpen)
            {
                Debug.Log("<color=#f93>已經開門<color>");
            }
            switch (weapon)
            {
                case "蝴蝶刀":
                    Debug.Log("<color=#ff3>攻擊力:20></color>");
                    break;
                case "小刀":
                    Debug.Log("<color=#793f>攻擊力:10></color>");
                    break;
                case "掃把":
                    Debug.Log("<color=#793f>不可用></color>");
                    break;
            }
        }
       
    }
}
