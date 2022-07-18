using UnityEngine;
using System.Collections.Generic;

public class DiceSelection : MonoBehaviour
{
    public SpriteRenderer diceOneSelectionBox;
    public ChangeSprite diceOneChangeSprite;
    public SpriteRenderer diceTwoSelectionBox;
    public ChangeSprite diceTwoChangeSprite;
    public SpriteRenderer diceThreeSelectionBox;
    public ChangeSprite diceThreeChangeSprite;
    public AudioSource diceSelectionNoise;
    List<int> diceList = new List<int> {0, 1, 2};
    int currentIndex;

    void Start(){
        currentIndex = 0;
        diceOneSelectionBox.enabled = false;
        diceTwoSelectionBox.enabled = false;
        diceThreeSelectionBox.enabled = false;
        diceOneChangeSprite.enabled = false;
        diceTwoChangeSprite.enabled = false;
        diceThreeChangeSprite.enabled = false;
    }

    void Update(){

        if (Input.GetKeyDown("d") || Input.GetKeyDown("right")){
            diceSelectionNoise.Play();
            if (currentIndex == 2){
                currentIndex = 0;
            }       
            else {
                currentIndex += 1;
            }
        }

        if (Input.GetKeyDown("a") || Input.GetKeyDown("left")){
            diceSelectionNoise.Play();
            if (currentIndex == 0){
                currentIndex = 2;
            }
            else {
                currentIndex -= 1;
            }
        }

        if (diceList[currentIndex] == 0){
            diceOneSelectionBox.enabled = true;
            diceTwoSelectionBox.enabled = false;
            diceThreeSelectionBox.enabled = false;
            diceOneChangeSprite.enabled = true;
            diceTwoChangeSprite.enabled = false;
            diceThreeChangeSprite.enabled = false;
        }
        else if (diceList[currentIndex] == 1){
            diceOneSelectionBox.enabled = false;
            diceTwoSelectionBox.enabled = true;
            diceThreeSelectionBox.enabled = false;
            diceOneChangeSprite.enabled = false;
            diceTwoChangeSprite.enabled = true;
            diceThreeChangeSprite.enabled = false;
        }
        else if (diceList[currentIndex] == 2){ 
            diceOneSelectionBox.enabled = false;
            diceTwoSelectionBox.enabled = false;
            diceThreeSelectionBox.enabled = true;
            diceOneChangeSprite.enabled = false;
            diceTwoChangeSprite.enabled = false;
            diceThreeChangeSprite.enabled = true;
        }
    }
}
