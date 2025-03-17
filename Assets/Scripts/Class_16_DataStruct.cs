using Star.tool;
using UnityEngine;
using System.Collections.Generic;  //���\�h��Ƶ��c���R�W�Ŷ�


public class Class_16_DataStruct : MonoBehaviour
{
    //�}�C
    public int[] attacks = { 10, 15, 7 };
    public float[] defens = { 1.5f, 7.5f, 0.3f };

    // �M��G�x�����X
    public List<int> speeds = new List<int>() { 3, 9, 7 };
    public List<string> props = new List<string>() { "�Ĥ�", "�a��" };
    public List<float> playerDefens;

    private void Awake()
    {
        #region �M��

        // �M��s�� : �P�}�C�ۦP
        LogSystem.LogWithColor($"�ĤT���t�� : {speeds[2]}", "#3f3");
        speeds[0] = 10;
        LogSystem.LogWithColor($"�Ĥ@���t�� : {speeds[0]}", "#3f3");
        // �}�C��l�ƫ�N�L�k�W�����
        // �K�[�@���D��
        props.Add("�_�C");
        // �R���Ĥ@���D��
        props.RemoveAt(0);
        // �K�[�Y����s�� 1 �W
        props.Insert(1, "�Y��");

        foreach(var prop in props)
        {
            LogSystem.LogWithColor($"�D�� : {prop}", "#f93");
        }

        // �ϥΫغc�l�a�J�}�C
        playerDefens = new List<float>(defens);
        // �Ƨ� : �Ѥp��j
        playerDefens.Sort();
        // �ϱƧ� : �Ѥj��p
        playerDefens.Reverse();

        foreach(var item in playerDefens)
        {
            LogSystem.LogWithColor($"��� : {item}", "#f93");
        }
        // count ���M�椺����ơA�ھ� Add �� Remove ����
        LogSystem.LogWithColor($"�ƶq : {props.Count}", "#77f");
        // Capcity ���M�椺���e�q�A�t�Φ۰ʤ��t�A�w�]�� 4 �åB�H���Ʀ��� ((C# �U�������P)
        LogSystem.LogWithColor($"�e�q : {props.Capacity}", "#77f");
        List<int> numbers = new List<int>();

        for(int i = 0; i < 20; i++)
        {

            numbers.Add(i);
            LogSystem.LogWithColor($"�ƶq : {numbers.Count}", "#3a3");
            LogSystem.LogWithColor($"�e�q : {numbers.Capacity}", "#f39");
        }
        #endregion

        #region ���|
        // ���| : ���i��X�A�����Ȥl��b�@�_
        Stack<string> enemys =new Stack<string>();
        // ���ƶi�J���|
        enemys.Push("�v�ܩi");
        enemys.Push("�����L");
        LogStack<string>(enemys);
        // ����ƨåB������
        enemys.Peek();
        LogStack<string>(enemys);
        // ����ƨò���
        enemys.Pop();
        LogStack<string>(enemys);
        // �P�_�O�_�]�t�Y�����
        LogSystem.LogWithColor($"{enemys.Contains("�����L")} ", "#3f6");
        // �M���Ҧ����
        enemys.Clear();
        LogStack<string>(enemys);
        #endregion

        #region ��C
        // Queue ��C : ���i���X�A����i�Ӫ���ƥ��Q���X��
        Queue<string> player = new Queue<string>();
        player.Enqueue("�s��");
        player.Enqueue("�k�v");
        player.Enqueue("�Ԥh");
        LogQueue<string>(player);
        // ���F�褣�R���A�P peek �ۦP
        LogSystem.LogWithColor(player.Peek(), "#f33");
        LogQueue<string>(player);
        // ���F��çR���A�P Pop �ۦP
        LogSystem.LogWithColor(player.Dequeue(), "#f33");
        LogQueue<string>(player);
        #endregion

        // �O���ƧǨåB���|�����ƪ���
        SortedList<string,int> board=new SortedList<string,int>();
        board.Add("KID", 90);
        board.Add("Kevin", 85);
        board.Add("Cherry", 90);
        // board.Add("Cheery", 75);     ���ƪ���ɭP���~
        LogSortedList<string,int>(board);

        SortedDictionary<string,int> scores=new SortedDictionary<string,int>();
        scores.Add("KID", 80);
        scores.Add("Kevin", 85);
        scores.Add("Cherry", 85);
        //scores.Add("Cherry", 70);    //���ƪ���ɭP���~
        LogSortedDictionary<string,int>(scores);

        // sortedList �P SortedDictionary ���t��
        // 1. SortedList �O�ϥΰ}�C�覡�x�s�A����ٰO����Ŷ�
        // 2. SortedDictionary �O�ϥξ𪬵��c�覡�x�s�A����e�O����Ŷ�
        // 3. SortedList �i�H�ϥί��ޭȦs�� [0]
        LogSystem.LogWithColor($"�Ʀ�]�Ĥ@�� : {board.Keys[0]}" , "#f93");
        // LogSystem.LogWithColor($"�Ʀ�]�Ĥ@�� : {scores.Keys[0]}" , "#f93")
        // 4. SortedList �j�q��ƼW��ɤ���e�O����
        // �p�G��Ƥ��ݭn�W�c���W���ĳ�ϥ� SortedList �Ϥ���ĳ�ϥ� SortedDictionary
    }

    void LogStack<T>(Stack<T> stack)
    {
        LogSystem.LogWithColor("-----------", "#fff");
        foreach(var item in stack)
        {
            LogSystem.LogWithColor($"���|��� : {item}", "#f77");
        }
    }
    void LogQueue<T>(Queue<T> queue)
    {
        LogSystem.LogWithColor("-----------", "#fff");
        foreach (var item in queue)
        {
            LogSystem.LogWithColor($"���|��� : {item}", "#f77");
        }
    }

    void LogSortedList<T,U>(SortedList<T,U> list)
    {
        foreach(var item in list)
        {
            LogSystem.LogWithColor($"{item.Key} ������ {item.Value}", "77f");
        }
        LogSystem.LogWithColor("--------", "#fff");
    }

    void LogSortedDictionary<T,U>(SortedDictionary<T,U> dict)
    {
        foreach(var item in dict)
        {
            LogSystem.LogWithColor($"{item.Key} ������ {item.Value}","#77f");
        }
        LogSystem.LogWithColor("--------", "#fff");
        
    }
}
