using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public PlayerSpriteManager spriteManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.right * Mathf.Round(Input.GetAxisRaw("Horizontal")) + Vector3.up * Mathf.Round(Input.GetAxisRaw("Vertical")))/5;
    }
}

public class PlayerSpriteManager : MonoBehaviour
{
    public Texture2D walkingSpritesHorizontal;
    public Texture2D walkingSpritesVertical;
}