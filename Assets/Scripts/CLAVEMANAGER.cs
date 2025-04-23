using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CLAVEMANAGER : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TMP_InputField inputUser;
    public TextMeshProUGUI txtMensaje;

    string user = "camward1";
    string clave = "titanup";

    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComprobarClaveIngresada()
    {
        if(inputClave.text == clave && inputUser.text == user)
        {
            txtMensaje.text = "Acceso concedido";
        }
        else
        {
            txtMensaje.text = "Acceso denegado";
            inputClave.text = "";
            inputUser.text = "";
        }
    }
}
