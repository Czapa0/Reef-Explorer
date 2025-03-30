using UnityEngine;
using UnityEngine.InputSystem;

public class Flashlight : MonoBehaviour {
    private bool _turnedOn;
    public GameObject Spotlight;

    private void Start() {
        _turnedOn = false;
        Spotlight.SetActive(_turnedOn);
        InputManager.Instance.Controls.Player.Flashlight.performed += SwitchFlashlight;
    }

    private void OnDisable() {
        _turnedOn = false;
        Spotlight.SetActive(_turnedOn);
        InputManager.Instance.Controls.Player.Flashlight.performed -= SwitchFlashlight;
    }

    private void SwitchFlashlight(InputAction.CallbackContext context) {
        _turnedOn = !_turnedOn;
        Spotlight.SetActive(_turnedOn);
    }
}
