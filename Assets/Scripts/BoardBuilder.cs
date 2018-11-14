using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BoardBuilder : MonoBehaviour
{
    public GameObject waterTilePrefab;
    public GameObject addressTilePrefab;
    public GameObject canvas;
    public Text addressTileText;
    float id;

    // Use this for initialization
    void Start()
    {
        buildBoard();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void buildBoard()
    {

        
        float y = transform.position.y;
        for (int j = 0; j < 10; j++)
        {
            float x = transform.position.x;
            for (int i = 0; i < 10; i++)
            {
                Vector3 position = new Vector3(x, y, 0);
                GameObject waterTile = Instantiate(waterTilePrefab, position, Quaternion.identity);
                waterTile.transform.parent = canvas.transform;
                x += (float).5;


            }
            y += (float).5;
        }
    }
    

}