using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlacklistItem
{
    public Collision Object = null;
    public float CurrentTime = 0.0f;
}

public class BlacklistedFilterForCollisions : MonoBehaviour
{
    private List<BlacklistItem> BlacklistedColliders = new List<BlacklistItem>();

    [SerializeField] private bool CanUseBlacklist = true;

    [SerializeField] private float TimeToBeTrimmed = 1.0f;

    public GameObject MainEntity;

    private void Update()
    {
        if (BlacklistedColliders.Count == 0)
            return;

        IncrementTimerOnBlacklist();
        TrimBlacklist();
    }

    private void IncrementTimerOnBlacklist()
    {
        for (int i = 0; i < BlacklistedColliders.Count; ++i)
        {
            BlacklistedColliders[i].CurrentTime += Time.deltaTime;
        }
    }

    private void TrimBlacklist()
    {
        for (int i = BlacklistedColliders.Count - 1; i >= 0; --i)
        {
            if (BlacklistedColliders[i].CurrentTime > TimeToBeTrimmed || BlacklistedColliders[i].Object == null)
            {
                BlacklistedColliders.RemoveAt(i);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!CanUseBlacklist)
        {
            Debug.Log(other.gameObject.name);
            return;
        }

        if (DoesBlacklistContainItem(other))
            return;

        // Add And Initialize The Trackable Object
        BlacklistedColliders.Add(new BlacklistItem() { Object = other, CurrentTime = 0 });

        Debug.Log(other.gameObject.name);
        if(other.gameObject.tag == "HEAVY")
            {
                StartCoroutine(MainEntity.GetComponent<_ENTITY>().REACT1());
            }
            else if (other.gameObject.tag == "LIGHT")
            {
                StartCoroutine(MainEntity.GetComponent<_ENTITY>().REACT2());
                
            }
    }

    private bool DoesBlacklistContainItem(Collision CollidedObject)
    {
        for (int i = 0; i < BlacklistedColliders.Count; ++i)
        {
            if (BlacklistedColliders[i].Object == CollidedObject)
                return true;
        }

        return false;
    }
}

