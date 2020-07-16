using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MemoryCard : MonoBehaviour
{
    public GameObject cardBack;
    public Sprite image;
    public SceneController controller;
    private int _id;
    public int id
    {
        get { return _id; }
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = image;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.canReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }

    public void SetCard(int id, Sprite Img)
    {
        _id = id;
        image = Img;
        GetComponent<SpriteRenderer>().sprite = image;
    }
}
