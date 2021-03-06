using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour

{
    public float scrollSpeed;
    public bool scroll = true;
    private Material backgroundMaterial;

    private void Awake()
    {
        backgroundMaterial = GetComponent<Renderer>().material;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (scroll)
        {
            Vector2 offset = new Vector2(scrollSpeed * Time.time, 0);
            backgroundMaterial.mainTextureOffset = offset;

            // For better user experience, you can consider moving background parallelly with player. it'll look like 3d.
        }
    }

}
