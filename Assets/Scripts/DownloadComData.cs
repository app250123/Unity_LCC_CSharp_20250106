using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.UI;
/// <summary>
/// 下載店家資訊
/// </summary>
public class DownloadComData : MonoBehaviour
{

    /// <summary>
    /// 考題省略呼叫Main2的前文內容，請觀察並優化Json Data架構
    /// </summary>
    public void Main2(string path)
    {
        // 解析 JSON 並直接將資料映射到 DownloadCom 物件中
        var companyData = JsonUtility.FromJson<GetCompanyData>(path);

        // 使用簡化的方式將資料傳遞給 DownloadCom 類別
        var downloadCom = new DownloadCom(companyData);
        // 使用 downloadCom 做後續處理
    }
}

[System.Serializable]
public class GetCompanyData
{
    public List<string> Baccount;
    public List<string> ComName;
    public List<string> ComContent;
    public List<string> Comphone;
    public List<string> Commail;
    public List<string> Comboss;
    public List<string> Comaddress;
}

[System.Serializable]
public class DownloadCom
{
    // 簡化屬性設置，無需手動設置 getter 和 setter
    public List<string> Baccount { get; set; }
    public List<string> ComName { get; set; }
    public List<string> ComContent { get; set; }

    // 使用構造函數來直接設置資料
    public DownloadCom(GetCompanyData data)
    {
        Baccount = data.Baccount;
        ComName = data.ComName;
        ComContent = data.ComContent;
    }
}