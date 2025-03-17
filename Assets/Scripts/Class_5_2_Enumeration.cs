using UnityEngine;

public class Class_5_2_Enumeration : MonoBehaviour
{
 private enum Season
    {
        Spring,Summer,april,Winter
    }
    [SerializeField,Header("©u¸`")]
    private Season season=Season.Spring;

    private void Awake()
    {
        season = (Season)2;
        Debug.Log(season) ;
    }
}

