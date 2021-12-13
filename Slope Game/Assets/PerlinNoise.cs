using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is used to generate the perlin noise for the scpiked terrain which is around the path
public class PerlinNoise : MonoBehaviour {
    public int terrain = 10;
    public int width = 10;
    public int height = 256;

    // How much of the terrain you can see in the scene view
    public float scale = 10f;

    // Positional area of the terrain you can see in the scene view
    public float offsetX = 10f;
    public float offsetY = 10f;
    public float offsetZ = 10f;

    private void Start() {
       GenerateOffset();
       Terrain terrain = GetComponent<Terrain>();
       terrain.terrainData = GenerateTerrain(terrain.terrainData);
    }
    void GenerateOffset() {
        // Terrain around you is being generated
        offsetX = Random.Range(0f, 100f);
        offsetY = Random.Range(0f, 100f);
        offsetZ = Random.Range(0f, 100f);
    }
    TerrainData GenerateTerrain(TerrainData terrainData) {
        terrainData.heightmapResolution = width+1;
        terrainData.size = new Vector3(width, terrain, height);
        terrainData.SetHeights(0, 0, GenerateHeights());

        return terrainData;
    }

    // Build 2D array of heights
    float[,] GenerateHeights() {
        float[,] heights = new float[width, height];
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                heights[x, y] = CalculateHeight(x, y);
            }
        }
        return heights;
    }

    // Calculate height of each point
    float CalculateHeight(int x, int y) {
        float xCoord = (float)x / width * scale + offsetX;
        float yCoord = (float)y / height * scale + offsetY;
        return Mathf.PerlinNoise(xCoord, yCoord);
    }

    // Update is called once per frame
    void Update() {

    }
}
