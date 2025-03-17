using UnityEngine;
using Star.tool;

public class Class_11_Abstract:MonoBehaviour
{
    private void Awake()
    {
        // ��H���O
        // 1. �����ϥ�����r abstract
        // 2. ����Q��Ҥ� (new)
        // 3. �p�G����H��k�����A���ݭn�D�� (�j�A��)
        // 4. ��H���������Q�l���O��@ (override)
        var FlyDragon=new FlyDragon();
        var threeHornDragon=new ThreeHornDragon();

        // var monster =new Monster();   // ���~ : �L�k��ҤƩ�H���O

        FlyDragon.Attack();
        threeHornDragon.Attack();

        // �V�W�૬ Upcasting : ��Ҥƫ�s�������O
        // �V�W�૬�i�H�ϥΦh��
        Monster fly =new FlyDragon();
        fly.Attack();
    }
}

// abstract ��H���O
public abstract class Monster
{
    public float hp;
    public float moveSpeed;

    public abstract void Attack();

    public void Track()
    {
        LogSystem.LogWithColor("�l��","#f93");
    }
}

public class FlyDragon : Monster
{
    public override void Attack()
    {
        LogSystem.LogWithColor("���s����", "#f77");
    }
    
    public void Track(int speed)
    {
        LogSystem.LogWithColor($"�l�ܡA�t�� : {speed}", "#f93");
    }

}

public class ThreeHornDragon : Monster
{
    public override void Attack()
    {
        LogSystem.LogWithColor("�T���s����", "#7f7");
    }
}
