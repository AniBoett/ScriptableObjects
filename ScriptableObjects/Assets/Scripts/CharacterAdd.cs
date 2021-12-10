using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CharacterAdd : MonoBehaviour
{
    public Characters character;

    public Text nameText;

    public Image artworkImage;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = character.name;


    }


}
