using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.UI;
public class ShowText : MonoBehaviour
{
    //called before the first frame update
    public GameObject gameStartText;
    void Start( )
    {
        StartCoroutine(Gamestart());
    }


   private IEnumerator Gamestart()
    {
        yield return new WaitForSeconds(1);
        gameStartText.SetActive(true);
        yield return new WaitForSeconds(3);
        gameStartText.SetActive(false);
    }

}
