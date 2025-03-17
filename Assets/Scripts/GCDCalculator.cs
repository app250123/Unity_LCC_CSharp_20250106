using UnityEngine;

public class GCDCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    public int num1;
    public int num2;
    void Start()
    {
        // 呼叫 GCD 函數並在 Console 中顯示結果
        int result = GCD(num1, num2);
        Debug.Log("最大公約數: " + result);
    }

    // 輾轉相除法迴圈實作
    int GCD(int a, int b)
    {
        // 基本情況：當 b 為 0 時，a 就是最大公約數
        if (b == 0)
            return a;

        // 遞迴呼叫 GCD(b, a % b)
        return GCD(b, a % b);
    }
}
