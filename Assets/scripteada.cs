
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


public class scripteada : MonoBehaviour
{
    public Text inputText;
    public string password;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Aceptar () 
    { 
    
    if (inputText.text == password) // contraseña123 
        {

            Debug.Log("acces garanted");
            
        }else { Debug.Log("acces denied"); }
    
    }
}
