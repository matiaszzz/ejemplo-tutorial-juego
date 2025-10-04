using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    /// <summary>
    /// Fuerza que se aplicará al objeto
    /// </summary>
    private Vector3 forceToApply;
    /// <summary>
    /// Representa el tiempo transcurrido desde la última aplicación de fuerza
    /// </summary>
    private float timeSinceLastForce;
    /// <summary>
    /// Indica el intervalo de tiempo entre cada aplicación de fuerza
    /// </summary>
    private float intervalTime;
    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    #region Ciclo de vida del script 

    private void Start()
    {
        forceToApply = new Vector3(0, 0, 5);
        timeSinceLastForce = 0f;
        intervalTime = 2f; // Apply force every 2 seconds

    }

    private void FixedUpdate()
    {
        timeSinceLastForce += Time.fixedDeltaTime;
        if (timeSinceLastForce >= intervalTime)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(forceToApply, ForceMode.Impulse);
            timeSinceLastForce = 0f; 
        }

    }
    #endregion
}
