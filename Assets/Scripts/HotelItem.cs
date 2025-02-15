using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HotelItem : MonoBehaviour
{
    public Image Image;
    public TextMeshProUGUI hotelNameText;
    public TextMeshProUGUI locationText;

    public void Setup(Sprite image, string hotelName, string location)
    {
        Image.sprite = image;
        hotelNameText.text = hotelName;
        locationText.text = location;
    }
}
