using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewHotelData", menuName = "Hotel/Searchable Hotel Data")]
public class HotelData : ScriptableObject
{
    public Sprite image;
    public string hotelName;
    public string location;
}
