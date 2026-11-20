using UnityEngine;

public class SunGoRoundAndRound : MonoBehaviour
{
    // Make the sun go round and round
    // Make the directional object rotate on its X axis
    // X angle degree rises + 1 

    [SerializeField] private float speed = 20f; 


    // Update is called once per frame (THIS IS INFINITE LOOP)
    void Update()
    {
        // Add +1 to rotation x
        // Which command is used to rotate a game object?
        // Vector3.right = (1, 0, 0) // x axis
        transform.Rotate(Vector3.right * Time.deltaTime * speed); //deltaTime
    }                            
}
