using UnityEngine;

// extends from block
public class AudioPlayer : Block
{
    AudioSource audioData;

    void Start()
    {

    }

    void Update()
    {
        audioData = GetComponent<AudioSource>();
        if (this.gameObject.name == "Smooth")
        {
            Block smoothScript = GetComponent<Block>();
            if (smoothScript.state == MoveStates.moving)
            {
                audioData.Play(0);
            }
        }
        else if (this.gameObject.name == "Slide")
        {
            Slidey slideScript = GetComponent<Slidey>();
            if (slideScript.state == MoveStates.moving)
            {
                audioData.Play(0);
            }
        }
        else if (this.gameObject.name == "Stick")
        {
            Sticky stickScript = GetComponent<Sticky>();
            if (stickScript.state == MoveStates.moving)
            {
                audioData.Play(0);
            }
        }
    }
}