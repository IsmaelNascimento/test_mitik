using UnityEngine;

public class BallonFly : MonoBehaviour
{
    [SerializeField] private float timeReset = 30f; 
    [SerializeField] private float speedFly;
    private Vector3 startPosition;
    public bool flyNow;

    #region METHODS_MONOBEHAVIOR

    private void Start()
    {
        startPosition = transform.position;
        InvokeRepeating("ResetPosition", timeReset, timeReset);
    }

    private void Update()
    {
        if (!flyNow)
            return;

        transform.Translate(Vector3.up * Time.deltaTime * speedFly, Space.World);
    }

    #endregion

    #region METHODS_PUBLIC

    public void ResetPosition()
    {
        transform.position = startPosition;
    }

    #endregion

    #region METHODS_BUTTON

    public void OnClicked()
    {
        GetComponent<AudioSource>().Play();
        transform.position = startPosition;
    }

    public void SetFlyNow()
    {
        flyNow = true;
    }

    #endregion
}
