using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public SpriteRenderer diceSpriteRenderer;
    public Sprite dice1;
    public Sprite dice2;
    public Sprite dice3;
    public Sprite dice4;
    public Sprite dice5;
    public Sprite dice6;
    public AudioSource diceShuffleNoise;
    List<Sprite> listOfDiceIndices = new List<Sprite>();
    public int diceIndex = 0;

    void Start(){
        listOfDiceIndices.Add(dice1);
        listOfDiceIndices.Add(dice2);
        listOfDiceIndices.Add(dice3);
        listOfDiceIndices.Add(dice4);
        listOfDiceIndices.Add(dice5);
        listOfDiceIndices.Add(dice6);

        diceSpriteRenderer.sprite = listOfDiceIndices[diceIndex];
    }
    
    void Update(){
        if (Input.GetKeyDown("up") || Input.GetKeyDown("w")){
            diceShuffleNoise.Play();
            if (diceIndex == 5){
                diceIndex = 0;
                diceSpriteRenderer.sprite = listOfDiceIndices[diceIndex];
            }
            else {
                diceIndex++;
                diceSpriteRenderer.sprite = listOfDiceIndices[diceIndex];
            }
        }
        
        if (Input.GetKeyDown("down") || Input.GetKeyDown("s")){
            diceShuffleNoise.Play();
            if (diceIndex == 0){
                diceIndex = 5;
                diceSpriteRenderer.sprite = listOfDiceIndices[diceIndex];
            }
            else {
                diceIndex--;
                diceSpriteRenderer.sprite = listOfDiceIndices[diceIndex];
            }
        }
    }
}
