using UnityEngine;
using UnityEngine.InputSystem;

public class Mana : MonoBehaviour
{
    public PlayerMana playerMana;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        manaUse();
        manaEmpty();

    }

    void manaUse()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            playerMana.mana -= 10;
        }

    }

    void manaEmpty()
    {

        if (playerMana.mana <= 0)
        {
            playerMana.mana = 0;
            playerMana.manaText.text = "Mana: 0";
        }
    }

}
