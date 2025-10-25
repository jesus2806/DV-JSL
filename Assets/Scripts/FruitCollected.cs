using Unity.VisualScripting;
using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            Object.FindFirstObjectByType<FruitManager>().AllFruitsCollected();

            Destroy(gameObject, 0.5f);
        }
        
    }

}
