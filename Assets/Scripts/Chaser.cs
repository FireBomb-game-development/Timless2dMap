using UnityEngine;

/**
 * This component chases a given target object.
 */
public class Chaser : TargetMover
{
    [Tooltip("The object that we try to chase")]
    [SerializeField] public Transform targetObject = null;

    public Vector3 TargetObjectPosition()
    {
        return targetObject.position;
    }

    private void Update()
    {
        if (!ReferenceEquals(targetObject, null))
        {
            SetTarget(targetObject.position);
        }
    }
}