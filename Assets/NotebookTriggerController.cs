using UnityEngine;

public class NotebookTriggerController : MonoBehaviour
{
    private bool isTriggerOn;

    private GameObject targetGameObject;

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Diary"))
        {
            isTriggerOn = true;
            
            targetGameObject = otherCollider.gameObject;
            
            Debug.Log(targetGameObject.name);
        }
    }

    private void OnTriggerExit(Collider otherCollider)
    {
        if (otherCollider.gameObject == targetGameObject)
        {
            isTriggerOn = false;

            targetGameObject = null;
        }
    }

    private void Update()
    {
        if (isTriggerOn)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(targetGameObject);
            }
        }
    }
}
