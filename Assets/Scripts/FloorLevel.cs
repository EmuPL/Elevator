using TMPro;
using UnityEngine;

public class FloorLevel : MonoBehaviour
{
    [SerializeField] private Transform Floor;
    [SerializeField] private TextMeshProUGUI ScoreText;

    private void Update()
    {
        int FloorLevels = (int)Floor.position.y / 15;
        ScoreText.text = (FloorLevels).ToString();
    }
}