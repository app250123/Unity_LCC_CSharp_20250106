using UnityEngine;
using Star.tool;

public class Class_10_1_Inherit : MonoBehaviour
{

    private void Awake()
    {
        var goblin1 = new Goblin(10,1);
        LogSystem.LogWithColor($"�����L1�������� :{goblin1.attack}", "#f3d");
        var slime1=new Slime(3,2);
        LogSystem.LogWithColor($"�v�ܩi1�������� :{slime1.attack}", "#f3d");
        goblin1.Move();
        slime1.Move();
        slime1.Initlize();

        // �P�_�v�ܩi�O�_�~�ӭ����L
        // ���OA is ���OB :���L��
        var slimeIsGoblin= slime1 is Goblin;
        LogSystem.LogWithColor($"�v�ܩi1���O�_�������L:{slimeIsGoblin}","#f33");
        
        var spider1 =new Spider(15,3);
        var spiderIsSlime=spider1 is Slime;
        var spiderIsGoblin=spider1 is Goblin;
        LogSystem.LogWithColor($"�j��1���O�_���v�ܩi:{spiderIsSlime}", "#f33");
        LogSystem.LogWithColor($"�j��1���O�_�������L:{spiderIsGoblin}", "#f33");
    }

    public class Goblin
    {
        public int attack; // ���}:�Ҧ����O���i�H�s��
        public int defense;
        private float moveSpeed; // �p�H: �����O�i�H�s��
        protected float hp; // �O�@: �l���O�i�H�s��
        protected int lv = 5;

        public Goblin(int _attack, int _defense)
        {
            attack = _attack;
            defense = _defense;
        }
        // virtual ����:���\�l���O�мg
        public virtual void Move()
        {
            LogSystem.LogWithColor("����L����", "#9f9");
        }
    }
    //�~�������O�i�H�~�ӥt�@�����O�A�֦������O������
    //�l���O:�����O
    //C# �ȴ��ѳ�@�~��(�u���~�Ӥ@�����O)
    public class Slime : Goblin
    {
        protected int lv = 10; //���L�C:���ܤ����O���ۦP�������W��
        public Slime(int _attack,int _defense):base( _attack, _defense)
        { 

        }
        public void Initlize()
        {
            attack = 7;  // ���}:�i�H�s��
            //moveSpeed = 3.5f; //�p�H: �L�k�s��
            hp = 10;  //�O�@:�i�H�s��
            LogSystem.LogWithColor($"����:{lv}","#78f");
            LogSystem.LogWithColor($"����:{base.lv} (�����O)","#78f");
        }

        //override �мg:�мg�����O�� Virtual ����r������
        // override ��ܭn�мg������ > ���U Enter �۰ʧ���
        public override void Move()
        {
            //base.move() // �����O�즳�����e
            LogSystem.LogWithColor("����", "#3f3");
        }

    }
    public class Spider : Slime
    {
        public Spider(int _attack,int _defense):base ( _attack, _defense)
        {

        }
    }
}
