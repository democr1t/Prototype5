using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]

public class ClickableTarget : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
<<<<<<< HEAD
    [SerializeField] private ParticleSystem _exoplositionParcticle;
    public UnityEvent GoodTargetClicked;
    public UnityEvent BadTargetClicked;
=======
    [SerializeField] private ParticleSystem _explosionParticle;
    public UnityEvent TargetClicked;
>>>>>>> e5dd97da3fe2b63df9d247df903000fe954f1413
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
<<<<<<< HEAD
        if (gameObject.CompareTag("GoodTarget"))
        {
            GoodTargetClicked.Invoke();
            Instantiate(_exoplositionParcticle, transform.position, transform.rotation);
        }
        else
        {
            BadTargetClicked.Invoke();
        }
=======
        TargetClicked.Invoke();
        Instantiate(_explosionParticle, transform.position, transform.rotation);
>>>>>>> e5dd97da3fe2b63df9d247df903000fe954f1413
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);    
    }
}
