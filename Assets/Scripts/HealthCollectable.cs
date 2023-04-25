using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    public GameObject healthEffectPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null )
        {
            if (controller.Health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
                Instantiate(healthEffectPrefab, other.gameObject.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            }
        }
    }
}
