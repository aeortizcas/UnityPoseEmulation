using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.Entity;

public class AnimationCode : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Body;
    List<string> lines;
    void Start()
    {
        lines = System.IO.File.ReadLines("Assets/AnimationFile.txt").ToList();
    }

    // Update is called once per frame
    void Update()
    {
        print(lines[0]);
    }
}
