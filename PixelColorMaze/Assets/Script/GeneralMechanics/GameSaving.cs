using UnityEngine;
using System.IO;

public class GameSaving
{
    public string sceneName; // This will be written in the json file
    public Vector3 serializedPosition; // This will be written in the json file
    public Quaternion serializedRotation; // This will be written too.
    public static Vector3 position; // Static fields doesnt write into json
    public static Quaternion rotation; // Static fields doesnt write into json
    public static bool loaded = false;
}
