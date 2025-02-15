using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewHotelDatabase", menuName = "Hotel/Hotel Database")]
public class HotelDatabase : ScriptableObject
{
    public List<HotelData> hotels = new List<HotelData>();
}
