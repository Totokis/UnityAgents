using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sheep:Agent
{
    public TMP_Text info;
    
    private List<string> _names = new List<string>
    {
        "Sophia",
        "Sebastian",
        "Samuel",
        "Sofia",
        "Scarlett",
        "Santiago",
        "Stella",
        "Sawyer",
    };
    
    public int hungary;

    private void Awake()
    {
        info.text = _names[Mathf.FloorToInt(Random.Range(0, _names.Count))];
    }
}