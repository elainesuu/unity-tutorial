using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*

Changes the image displayed on a "canvas" -- used to change the background of each image output

*/

public class ChangeImage : MonoBehaviour
{
    public Image image;
    public Sprite[] loadedMaterials;

    // Start is called before the first frame update
    void Start()
    {
        loadedMaterials = (Sprite[])Resources.LoadAll("Backgrounds", typeof(Sprite));
    }

    // Update is called once per frame
    void Update()
    {
        image = GetComponent<Image>(); 
        image.sprite = loadedMaterials[Random.Range(0, loadedMaterials.Length-1)];
    }
}
