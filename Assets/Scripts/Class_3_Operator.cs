using UnityEngine;
/// <summary>
/// �ҵ{ 3: �B��l
/// �ɥR: Unity ����ݩʡBUnity �ƥ�
/// </summary>
public class Class_3_Operator : MonoBehaviour
{
    #region �򥻪�����ݩ�
    // C# �ܼ� =��� Field
    // ����ݩ� Field Attritube
    // [���D(���D��r)]:�b�ݩʭ��O�W��ܼ��D��r
    [Header("����")]
    public int lv = 1;
    // [����(���ܤ�r)]:�b�ݩʭ��O�ƹ����d�b�ܼƤW���
    [Tooltip("�o�O���⪺���ʳt�סA����ĳ�W�L100�C")]
    public float moveSpeed = 2.5f;
    //[�d��(�̤p�A�̤j)]:���ƭ������K�[�d��(���O�W�אּ�Ʊ�)
    [Range(1, 100)]
    public byte count = 100;
    //�d�򤣯�ϥΦb�D�ƭ������W�A�|���"Use Range With"
    [Range(0, 10)]
    public string weapon = "�P��";
    //[��r�d��(�̤p��A�̤j��)]: �ϥΦb�r��W�A�]�w���O�W����r�ؽd��
    [TextArea(2, 5)]
    public string itemDescription = "�o�̬O�D��y�z�A�o�̬O�D��y�z�A�o�̬O�D��y�z�C";
    //�h������ݩ�
    [Header("��q")]
    [Range(0, 100)]
    public int hp = 100;
    [Header("�����O"), Range(0, 100)]
    public float attack = 30.5f;
    //[�b�ݩʭ��O����]:�N���}�ܼ�����
    [HideInInspector]
    public string password = "�ڬO�K�X";
    //[�ǦC�����]:�N�p�H�ܼ����
    [SerializeField]
    private float mp = 500;
    #endregion
    //�ϥ� Unity ���ƥ�
    //1. �����b�}���᭱�K�[:MonoBehaviour(�~��)
    //2. �ϥ�����r�ֳt�����A�Ҧp:��XAawake �D��n�ϥΪ��ƥ�� Enter
    // ����ƥ�:����C����|���檺�Ĥ@�Өƥ�A�u����@��
    //�ƥ�W�٬O�Ŧ⪺(�S���ܦ⤣�v�T)
    private void Awake()
    {
        #region ��X�T��
        //�N�p�A�������T����X��Unity��Console����x���O
        //Ctrl+shift+c �}�ұ���x���O
        Debug.Log("���o�A�U�w :D"); //��X��r
        Debug.Log(hp); //��X�ܼƪ���
        Debug.Log("�����O: " + attack); // �r��P�ܼ�
        Debug.Log($"�����O: +{attack}"); //$�r��榡
        Debug.Log("�����O: +{ attack}"); //�S���g$
        // ��X:#����������šA�ƭ�:0~9�Aa~f �V�k���C��V�G #000 �� #fff ��
        Debug.Log("<color=#66aaff>�Ŧ�</color>");
        Debug.Log("<color=#6af>�Ŧ�</color>");
        #endregion
        #region ��N�B��l
        Debug.Log("<color=#f93>--- ��N�B��l ---</color>");
        // �B��l:
        // 1. ��ƹB��l
        // �[�B��B���B���B�l
        // +�B-�B*�B/�B%
        Debug.Log(10 + 3); //13
        Debug.Log(10 - 3); //7
        Debug.Log(10 * 3); //30
        Debug.Log(10 / 3); //3
        Debug.Log(10 % 3); //10 / 3 = 3 �l 1�A���G


        Debug.Log("<color=#f93>--- ��ƹB��l: �ϰ��ܼ� ---</color>");
        // �ϰ��ܼ�:�Ȧb���j�A�����s�� (���ݭn�׹������ܼ�)
        float numberA = 10;
        float numberB = 3;


        Debug.Log(numberA + numberB);
        Debug.Log(numberA - numberB);
        Debug.Log(numberA * numberB);
        Debug.Log(numberA / numberB);
        Debug.Log(numberA % numberB);
        #endregion
        Debug.Log("<color=#f93>--- ����B��l ---</color>");
        // ����B��l�A�ϥΫ�|�o�쥬�L��
        int numberC = 100, numberD = 1;
        
        Debug.Log(numberC > numberD); //�j�� True
        Debug.Log(numberC < numberD); //�p�� True
        Debug.Log(numberC >= numberD); //�j�󵥩� True
        Debug.Log(numberC <= numberD); //�p�󵥩� True
        Debug.Log(numberC == numberD); //���� True
        Debug.Log(numberC != numberD); //������ True

    }
}






