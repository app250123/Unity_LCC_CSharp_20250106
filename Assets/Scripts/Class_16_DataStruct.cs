using Star.tool;
using UnityEngine;
using System.Collections.Generic;  //有許多資料結構的命名空間


public class Class_16_DataStruct : MonoBehaviour
{
    //陣列
    public int[] attacks = { 10, 15, 7 };
    public float[] defens = { 1.5f, 7.5f, 0.3f };

    // 清單：泛型集合
    public List<int> speeds = new List<int>() { 3, 9, 7 };
    public List<string> props = new List<string>() { "藥水", "地圖" };
    public List<float> playerDefens;

    private void Awake()
    {
        #region 清單

        // 清單存取 : 與陣列相同
        LogSystem.LogWithColor($"第三筆速度 : {speeds[2]}", "#3f3");
        speeds[0] = 10;
        LogSystem.LogWithColor($"第一筆速度 : {speeds[0]}", "#3f3");
        // 陣列初始化後就無法增減茶度
        // 添加一筆道具
        props.Add("寶劍");
        // 刪除第一筆道具
        props.RemoveAt(0);
        // 添加頭盔到編號 1 上
        props.Insert(1, "頭盔");

        foreach(var prop in props)
        {
            LogSystem.LogWithColor($"道具 : {prop}", "#f93");
        }

        // 使用建構子帶入陣列
        playerDefens = new List<float>(defens);
        // 排序 : 由小到大
        playerDefens.Sort();
        // 反排序 : 由大到小
        playerDefens.Reverse();

        foreach(var item in playerDefens)
        {
            LogSystem.LogWithColor($"資料 : {item}", "#f93");
        }
        // count 指清單內的資料，根據 Add 或 Remove 改變
        LogSystem.LogWithColor($"數量 : {props.Count}", "#77f");
        // Capcity 指清單內的容量，系統自動分配，預設為 4 並且以倍數成長 ((C# 各版本不同)
        LogSystem.LogWithColor($"容量 : {props.Capacity}", "#77f");
        List<int> numbers = new List<int>();

        for(int i = 0; i < 20; i++)
        {

            numbers.Add(i);
            LogSystem.LogWithColor($"數量 : {numbers.Count}", "#3a3");
            LogSystem.LogWithColor($"容量 : {numbers.Capacity}", "#f39");
        }
        #endregion

        #region 堆疊
        // 堆疊 : 先進後出，類似椅子堆在一起
        Stack<string> enemys =new Stack<string>();
        // 放資料進入堆疊
        enemys.Push("史萊姆");
        enemys.Push("哥布林");
        LogStack<string>(enemys);
        // 拿資料並且不移除
        enemys.Peek();
        LogStack<string>(enemys);
        // 拿資料並移除
        enemys.Pop();
        LogStack<string>(enemys);
        // 判斷是否包含某筆資料
        LogSystem.LogWithColor($"{enemys.Contains("哥布林")} ", "#3f6");
        // 清除所有資料
        enemys.Clear();
        LogStack<string>(enemys);
        #endregion

        #region 佇列
        // Queue 佇列 : 先進先出，先放進來的資料先被拿出來
        Queue<string> player = new Queue<string>();
        player.Enqueue("盜賊");
        player.Enqueue("法師");
        player.Enqueue("戰士");
        LogQueue<string>(player);
        // 拿東西不刪除，與 peek 相同
        LogSystem.LogWithColor(player.Peek(), "#f33");
        LogQueue<string>(player);
        // 拿東西並刪除，與 Pop 相同
        LogSystem.LogWithColor(player.Dequeue(), "#f33");
        LogQueue<string>(player);
        #endregion

        // 保持排序並且不會有重複的建
        SortedList<string,int> board=new SortedList<string,int>();
        board.Add("KID", 90);
        board.Add("Kevin", 85);
        board.Add("Cherry", 90);
        // board.Add("Cheery", 75);     重複的鍵導致錯誤
        LogSortedList<string,int>(board);

        SortedDictionary<string,int> scores=new SortedDictionary<string,int>();
        scores.Add("KID", 80);
        scores.Add("Kevin", 85);
        scores.Add("Cherry", 85);
        //scores.Add("Cherry", 70);    //重複的鍵導致錯誤
        LogSortedDictionary<string,int>(scores);

        // sortedList 與 SortedDictionary 的差異
        // 1. SortedList 是使用陣列方式儲存，比較省記憶體空間
        // 2. SortedDictionary 是使用樹狀結構方式儲存，比較占記憶體空間
        // 3. SortedList 可以使用索引值存取 [0]
        LogSystem.LogWithColor($"排行榜第一筆 : {board.Keys[0]}" , "#f93");
        // LogSystem.LogWithColor($"排行榜第一筆 : {scores.Keys[0]}" , "#f93")
        // 4. SortedList 大量資料增減時比較占記憶體
        // 如果資料不需要頻繁的增減建議使用 SortedList 反之建議使用 SortedDictionary
    }

    void LogStack<T>(Stack<T> stack)
    {
        LogSystem.LogWithColor("-----------", "#fff");
        foreach(var item in stack)
        {
            LogSystem.LogWithColor($"堆疊資料 : {item}", "#f77");
        }
    }
    void LogQueue<T>(Queue<T> queue)
    {
        LogSystem.LogWithColor("-----------", "#fff");
        foreach (var item in queue)
        {
            LogSystem.LogWithColor($"堆疊資料 : {item}", "#f77");
        }
    }

    void LogSortedList<T,U>(SortedList<T,U> list)
    {
        foreach(var item in list)
        {
            LogSystem.LogWithColor($"{item.Key} 的分數 {item.Value}", "77f");
        }
        LogSystem.LogWithColor("--------", "#fff");
    }

    void LogSortedDictionary<T,U>(SortedDictionary<T,U> dict)
    {
        foreach(var item in dict)
        {
            LogSystem.LogWithColor($"{item.Key} 的分數 {item.Value}","#77f");
        }
        LogSystem.LogWithColor("--------", "#fff");
        
    }
}
