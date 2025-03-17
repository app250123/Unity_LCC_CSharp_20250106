using Star.tool;
using UnityEngine;

namespace Star
{ 
    /// <summary>
    /// �x�� Generics
    /// </summary>
    public class Class_15_Generics:MonoBehaviour
    {
        private void Awake()
        {
            #region ���ϥΪx��
            int numberA = 7, numberB = 9;
            LogSystem.LogWithColor($"�Ʀr A �P B : {numberA} | {numberB}", "#f93");
            SwapNumber(ref numberA, ref numberB);
            LogSystem.LogWithColor($"�Ʀr A �P B : {numberA} | {numberB}", "#f93");

            char charA = '��', charB ='�K';
            LogSystem.LogWithColor($"�r�� A �P B : {charA} | {charB}", "#f93");
            SwapChar(ref charA, ref charB);
            LogSystem.LogWithColor($"�r�� A �P B : {charA} | {charB}", "#f93");

            object objA = 3.5f, objB = 7.7f;
            LogSystem.LogWithColor($"���� A �P B : {objA} | {objB}", "#f93");
            SwapObject(ref objA, ref objB);
            LogSystem.LogWithColor($"���� A �P B : {objA} | {objB}", "#f93");
            #endregion
            
            bool boolA=true, boolB=false;
            LogSystem.LogWithColor($" A �P B : {boolA} | {boolB}", "#9f9");
            Swap<bool>(ref boolA, ref boolB);
            LogSystem.LogWithColor($" A �P B : {boolA} | {boolB}", "#9f9");

            byte byteA = 1, byteB = 9;
            LogSystem.LogWithColor($" A �P B : {byteA} | {byteB}", "#9f9");
            Swap<byte>(ref byteA, ref byteB);
            LogSystem.LogWithColor($" A �P B : {byteA} | {byteB}", "#9f9");

            var player1 =new DataPlayer<int>();
            player1.data = 99;
            player1.LogData(123);

            var player2 = new DataPlayer<string>();
            player1.data = 99;
            player1.LogData(123);
        }

        /// <summary>
        /// �Ʀr���
        /// </summary>
        /// <param name="a">�Ĥ@�ӼƦr</param>
        /// <param name="b">�ĤG�ӼƦr</param>
        public void SwapNumber(ref int a,ref int b)
        {
            int temp= a;        // �N�Ĥ@�ӼƦr��h���� (�Ȧs)
            a= b;               // �N�ĤG�ӼƦr���Ĥ@�ӼƦr��
            b= temp;            // �N���䪺�Ʀr���ĤG�ӼƦr
        }

        public void SwapChar(ref char a, ref char b)
        {
            char temp = a;        
            a = b;               
            b = temp;            
        }

        public void SwapObject(ref object a, ref object b)
        {
            object temp = a;        
            a = b;               
            b = temp;            
        }

        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public class DataPlayer<T>
        {
            public T data;

            public void LogData(T data)
            {
               // LogSystem.LogWithColor( data , "#3ff");
            }
        }
    }
}
