using UnityEngine;
using UnityEngine.InputSystem;

public class AnimaBeba : MonoBehaviour
{
    [SerializeField] private Animator animator_beba;
    [SerializeField] private InputAction ataque;

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
        animator_beba.SetTrigger("PunchTrigger");
        Debug.Log("Atacando");
    }
}