using UnityEngine;

[System.Serializable]
public class Dialogue2
{
    public string[] names;

    [TextArea(3, 10)]
    public string[] sentences;
}
