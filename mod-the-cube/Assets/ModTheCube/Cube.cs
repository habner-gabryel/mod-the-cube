using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float rangMin = 0.0F;
    public float rangMax = 180.0F;
    public float rangeMaxColor = 1F;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 6.0f, 0.9f, 0.4f);
    }
    
    void Update()
    {
        float rotate = Random.Range(rangMin, rangMax);

        transform.Rotate(rotate * Time.deltaTime, 0.0F, 0.0F);

        Material material = Renderer.material;

        float randomFirst = Random.Range(rangMin, rangeMaxColor);
        float randomSec = Random.Range(rangMin, rangeMaxColor);
        float randomThrid = Random.Range(rangMin, rangeMaxColor);
        float randomFourth = Random.Range(rangMin, rangeMaxColor);
        
        material.color = new Color(randomFirst, randomSec, randomThrid, randomFourth);
    }
}
