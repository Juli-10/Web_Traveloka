using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HotelSearch : MonoBehaviour
{
    public HotelDatabase hotelDatabase; // Referensi ke ScriptableObject Database
    public TMP_InputField searchInput;
    public Transform resultParent; // Parent untuk hasil pencarian
    public GameObject hotelItemPrefab; // Prefab untuk item hotel

    private List<GameObject> spawnedItems = new List<GameObject>();

    void Start()
    {
        searchInput.onValueChanged.AddListener(UpdateSearchResults);
    }

    void UpdateSearchResults(string query)
    {
        ClearResults();

        if (string.IsNullOrEmpty(query)) return;

        foreach (var hotel in hotelDatabase.hotels)
        {
            if (hotel.hotelName.ToLower().Contains(query.ToLower()) ||
                hotel.location.ToLower().Contains(query.ToLower()))
            {
                GameObject item = Instantiate(hotelItemPrefab, resultParent);
                item.GetComponent<HotelItem>().Setup(hotel.image, hotel.hotelName, hotel.location);
                spawnedItems.Add(item);
            }
        }
    }

    void ClearResults()
    {
        foreach (var item in spawnedItems)
        {
            Destroy(item);
        }
        spawnedItems.Clear();
    }
}
