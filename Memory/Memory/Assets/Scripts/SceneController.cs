using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private MemoryCard originalCard;
    [SerializeField] private Sprite[] images;
    void Start()
    {
        int id = Random.Range(0, images.Length);
        originalCard.SetCard(id, images[id]);
    }
}
