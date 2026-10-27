using UnityEngine;
using UnityEngine.InputSystem;

public class VeiaControle : MonoBehaviour
{
    [SerializeField] private Animator animator_veia;
    [SerializeField] private InputAction ataque;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ataque.Enable();
        ataque.performed += Atacar;
    }

    // Update is called once per frame
    private void OnDestroy()
    {
        ataque.performed -= Atacar;
    }

    public void Atacar(InputAction.CallbackContext context)
    {
        animator_veia.SetTrigger("PunchTrigger");
        Debug.Log("Atacando");
    }
}