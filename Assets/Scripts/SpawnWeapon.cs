using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class SpawnWeapon : MonoBehaviour
{
    [SerializeField] private TextAsset textFile;

    [Header("GunObjects")]
    [SerializeField] GameObject[] weapons;

    public void ReadFile()
    {
        switch (textFile.text)
        {
            case "Rifle":
                Instantiate(weapons[0]);
                break;
            case "SMG":
                Instantiate(weapons[1]);
                break;
            case "MG":
                Instantiate(weapons[2]);
                break;
            default:
                Debug.Log("Something went wrong here...");
                break;
        }
    }
}
