using UnityEngine;
using UnityEngine.UI;

public class ScrollColorChange : MonoBehaviour
{
    public ScrollRect scrollRect; // ScrollRect dari UI
    public Image panelImage; // Panel yang ingin diubah warnanya
    public float fadeSpeed = 2.0f; // Kecepatan perubahan warna

    private Color transparentColor = new Color(1, 1, 1, 0); // Transparan
    private Color solidColor = new Color(1, 1, 1, 1); // Putih

    void Start()
    {
        if (panelImage == null) panelImage = GetComponent<Image>();
        panelImage.color = transparentColor; // Mulai dalam keadaan transparan
    }

    void Update()
    {
        // Jika ScrollRect berada di atas (posisi awal)
        if (scrollRect.verticalNormalizedPosition >= 0.99f)
        {
            panelImage.color = Color.Lerp(panelImage.color, transparentColor, fadeSpeed * Time.deltaTime);
        }
        else // Jika Scroll bergerak ke bawah
        {
            panelImage.color = Color.Lerp(panelImage.color, solidColor, fadeSpeed * Time.deltaTime);
        }
    }
}
