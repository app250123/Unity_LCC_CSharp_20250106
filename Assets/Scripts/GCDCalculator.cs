using UnityEngine;

public class GCDCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    public int num1;
    public int num2;
    void Start()
    {
        // �I�s GCD ��ƨæb Console ����ܵ��G
        int result = GCD(num1, num2);
        Debug.Log("�̤j������: " + result);
    }

    // ����۰��k�j���@
    int GCD(int a, int b)
    {
        // �򥻱��p�G�� b �� 0 �ɡAa �N�O�̤j������
        if (b == 0)
            return a;

        // ���j�I�s GCD(b, a % b)
        return GCD(b, a % b);
    }
}
