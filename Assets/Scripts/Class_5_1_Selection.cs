
using UnityEngine;

namespace Jack
{



public class Class_5_1_Selection : MonoBehaviour
{
        [SerializeField, Header("�O�_�}��")]
        private bool isOpen;
        public string weapon;
        private void Awake()
        {
            if (true)
            {
                Debug.Log("���L�Ȭ� true�A�|����o��");
            }

            if (false)
            {
                Debug.Log("���L�Ȭ� false�A���|����o�̦ӥB�|����L�C");
            }
        }
        private void Update()
        {
            Debug.Log("<color=#79f> ��s�ƥ�</color>");

            if (isOpen)
            {
                Debug.Log("<color=#f93>�w�g�}��<color>");
            }
            switch (weapon)
            {
                case "�����M":
                    Debug.Log("<color=#ff3>�����O:20></color>");
                    break;
                case "�p�M":
                    Debug.Log("<color=#793f>�����O:10></color>");
                    break;
                case "����":
                    Debug.Log("<color=#793f>���i��></color>");
                    break;
            }
        }
       
    }
}
