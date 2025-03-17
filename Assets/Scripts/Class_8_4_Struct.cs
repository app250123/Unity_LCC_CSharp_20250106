using System.Drawing;
using UnityEngine;

namespace Star.tool
{ 
public class LogSystem
{

        public static string LogWithColor(string massage,string color)
        {
            string result = $"<color={color}>{massage}</color>";
            Debug.Log(result);
            return result ;
        }

        public static string LogStack(string massage,string color)
        {
            string result = $"<color={color}>{massage}</color>";
            Debug.Log(result);
            return result;
        }


   
}
}
