using Star.tool;
using UnityEngine;

/// <summary>
/// ����
/// </summary>
public class Class_17_Tuple:MonoBehaviour
{
    private void Awake()
    {
        // ���� : �x�s�h�����P���������
        // �ŧi�覡 1 : ���w�����P�W��
        (string name, int cost, int index) card1 = ("�v�ܩi", 1, 7);
        LogSystem.LogWithColor($"{card1.name} |" + $"���� : {card1.cost} | �s�� : {card1.index}", "#f49");

        // �ŧi�覡 2 : ���w����
        // ���o������Ʈɨϥ� Item1 ~ ItemN
        (string, int, int) card2 = ("�����L", 2, 23);
        LogSystem.LogWithColor($"{card2.Item1} | " + $"���� : {card2.Item2} | �s�� : {card2.Item3}", "#f49");

        // �ŧi�覡 3 :�ϥ� var
        var card3 = ("���", 4, 50);
        LogSystem.LogWithColor($"{card3.Item1} | " + $"���� : {card3.Item2} | �s�� :{card3.Item3}", "#f49");

        // �ŧi�覡 4 : �ϥ� var �H�Ϋ��W
        var card4 = (name: "����", cost: 2, index: 6);
        LogSystem.LogWithColor($"{card4.name} | " + $"���� : {card4.cost} | �s��:{card4.index}", "#f49");

        UseCard(card1);
        UseCard(card2);
        UseCard(("���s",7,199));
        
    }

    /// <summary>
    /// �ϥΥd�P
    /// </summary>
    /// <param name="card">�d�P�����A�W�١B���ӻP�s��</param>
    private void UseCard((string name, int cost , int index) card)
    {
        LogSystem.LogWithColor($"����{card.cost} �ϥΥd�� : {card.name}", "#7f7");
    }
}
