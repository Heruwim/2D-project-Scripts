using UnityEngine;

public class DeleteBlocks : MonoBehaviour
{
    private void Start()
    {
        
        GameObject[] bloks = GameObject.FindGameObjectsWithTag("BlockToDelete");
        foreach (GameObject blokc in bloks)
        {
            blokc.GetComponent<SpriteRenderer> ().color = Color.red;
        }
    }    
}
