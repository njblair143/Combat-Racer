using UnityEngine;

[RequireComponent(typeof(VehicleMotor))]

public class VehicleController : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;

    private VehicleMotor motor;

    private void Start()
    {
        motor = GetComponent<VehicleMotor>();
    }

    private void Update()
    {
        //Calculate movement velocity as a 3D vector
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");

        Vector3 _movHorizontal = transform.right * _xMov;
        Vector3 _movVertical = transform.forward * _zMov;

        //Final movement vector
        Vector3 _velocity = (_movHorizontal + _movVertical).normalized * speed;

        //Apply movement
        motor.Move(_velocity);

    }

}
