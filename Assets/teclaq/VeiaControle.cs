using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class VeiaControle : MonoBehaviour
{
    [SerializeField] private Animator animator_veia;
    [SerializeField] private InputAction ataque;
    [SerializeField] private InputAction andar;
    [SerializeField] private InputAction voltar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ataque.Enable();
        ataque.performed += Atacar;

        andar.Enable();
        andar.performed += Andar;
        andar.canceled += AndarParar;

        voltar.Enable();
        voltar.performed += Voltar;
        voltar.canceled += VoltarParar;

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

    public void Andar(InputAction.CallbackContext context)
    {
        animator_veia.SetBool("WalkForward", true);
        Debug.Log("Andando");
        
    }

    public void AndarParar(InputAction.CallbackContext context)
    {
        animator_veia.SetBool("WalkForward", false);
    }

    public void Voltar(InputAction.CallbackContext context)
    {
        animator_veia.SetBool("WalkBackward", true);
        Debug.Log("Voltando");
    }

    public void VoltarParar(InputAction.CallbackContext context)
    {
        animator_veia.SetBool("WalkBackward", false);
    }
}