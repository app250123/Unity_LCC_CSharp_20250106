using Star.tool;
using UnityEngine;

namespace Star
{ 
    /// <summary>
    /// 泛型 Generics
    /// </summary>
    public class Class_15_Generics:MonoBehaviour
    {
        private void Awake()
        {
            #region 不使用泛型
            int numberA = 7, numberB = 9;
            LogSystem.LogWithColor($"數字 A 與 B : {numberA} | {numberB}", "#f93");
            SwapNumber(ref numberA, ref numberB);
            LogSystem.LogWithColor($"數字 A 與 B : {numberA} | {numberB}", "#f93");

            char charA = '嗨', charB ='嘿';
            LogSystem.LogWithColor($"字串 A 與 B : {charA} | {charB}", "#f93");
            SwapChar(ref charA, ref charB);
            LogSystem.LogWithColor($"字串 A 與 B : {charA} | {charB}", "#f93");

            object objA = 3.5f, objB = 7.7f;
            LogSystem.LogWithColor($"物件 A 與 B : {objA} | {objB}", "#f93");
            SwapObject(ref objA, ref objB);
            LogSystem.LogWithColor($"物件 A 與 B : {objA} | {objB}", "#f93");
            #endregion
            
            bool boolA=true, boolB=false;
            LogSystem.LogWithColor($" A 與 B : {boolA} | {boolB}", "#9f9");
            Swap<bool>(ref boolA, ref boolB);
            LogSystem.LogWithColor($" A 與 B : {boolA} | {boolB}", "#9f9");

            byte byteA = 1, byteB = 9;
            LogSystem.LogWithColor($" A 與 B : {byteA} | {byteB}", "#9f9");
            Swap<byte>(ref byteA, ref byteB);
            LogSystem.LogWithColor($" A 與 B : {byteA} | {byteB}", "#9f9");

            var player1 =new DataPlayer<int>();
            player1.data = 99;
            player1.LogData(123);

            var player2 = new DataPlayer<string>();
            player1.data = 99;
            player1.LogData(123);
        }

        /// <summary>
        /// 數字對調
        /// </summary>
        /// <param name="a">第一個數字</param>
        /// <param name="b">第二個數字</param>
        public void SwapNumber(ref int a,ref int b)
        {
            int temp= a;        // 將第一個數字放去旁邊 (暫存)
            a= b;               // 將第二個數字放到第一個數字內
            b= temp;            // 將旁邊的數字放到第二個數字
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
