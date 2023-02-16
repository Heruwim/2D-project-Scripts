using UnityEngine;

public class DeleteBlocks : MonoBehaviour
{
    private void Start()
    {
        GameObject block1 = GameObject.Find("Block1");
        Destroy(block1);
        GameObject[] bloks = GameObject.FindGameObjectsWithTag("BlockToDelete");
        foreach (GameObject blokc in bloks)
        {
            Destroy(blokc);
        }
    }    
}
