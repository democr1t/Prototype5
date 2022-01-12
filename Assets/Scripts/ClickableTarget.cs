using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]

public class ClickableTarget : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private ParticleSystem _exoplositionParcticle;
    public UnityEvent GoodTargetClicked;
    public UnityEvent BadTargetClicked;
    private float _randomX;
    private float _randomY;
    private float _randomZ;

    private void Start()
    {
        _randomX = Random.Range(-4, 5);
        _randomY = Random.Range(10, 15);
        _randomZ = Random.Range(-20, 30);
        _rigidbody.AddForce(Vector3.up * _randomY, ForceMode.Impulse);
        _rigidbody.AddTorque(_randomX, _randomY,_randomZ, ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }

    private void Update()
    {
        if(transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }

    private Vector3 RandomSpawnPos()
    {
        return new Vector3(_randomX, 0, 0);
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("GoodTarget"))
        {
            GoodTargetClicked.Invoke();
            Instantiate(_exoplositionParcticle, transform.position, transform.rotation);
        }
        else
        {
            BadTargetClicked.Invoke();
        }
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);    
    }
}
