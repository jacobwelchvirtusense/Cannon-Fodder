/******************************************************************
 * Created by: Jacob Welch
 * Email: jacobw@virtusense.com
 * Company: Virtusense
 * Project: Cannon Fodder
 * Creation Date: 4/14/2023 4:29:36 PM
 * 
 * Description: TODO
******************************************************************/
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static InspectorValues;
using static ValidCheck;

[RequireComponent(typeof(Rigidbody2D))]
public class CannonProjectile : MonoBehaviour
{
    #region Fields
    private Rigidbody2D rigidbodyComponent;
    private string[] collisionTags;
    #endregion

    #region Functions
    // Start is called before the first frame update
    private void Awake()
    {
        rigidbodyComponent = GetComponent<Rigidbody2D>();
    }

    private void OnDisable()
    {
        collisionTags = null;
    }

    public void InitializeMovement(float moveSpeed, string[] collisionTags)
    {
        rigidbodyComponent.velocity = transform.right * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collisionTags == null) return;

        if (collisionTags.Contains(other.gameObject.tag))
        {
            ObjectPooler.ReturnObjectToPool(gameObject.name, gameObject);
        }
    }
    #endregion
}
