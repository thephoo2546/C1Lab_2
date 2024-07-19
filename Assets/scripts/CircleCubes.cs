using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCubes : MonoBehaviour
{
    public GameObject cubePrefab; // Prefab ของ Cube
    public int numberOfCubes = 10; // จำนวนของ Cube ที่ต้องการวาง
    public float radius = 5f; // รัศมีของวงกลม
    public Vector3 center = Vector3.zero; // ตำแหน่งศูนย์กลางของวงกลม

    void Start()
    {
        PlaceCubesInCircle();
    }

    void PlaceCubesInCircle()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            // คำนวณมุมที่ Cube แต่ละตัวจะถูกวาง
            float angle = i * Mathf.PI * 2 / numberOfCubes;
            
            // คำนวณตำแหน่ง x และ z สำหรับ Cube
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;

            // สร้าง Cube และตั้งตำแหน่ง
            Vector3 pos = new Vector3(x, 0, z) + center;
            Instantiate(cubePrefab, pos, Quaternion.identity);
        }
    }
}

