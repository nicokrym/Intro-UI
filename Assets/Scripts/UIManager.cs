using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtSaludo;
    public TMP_InputField inputNombre;
    string nombreUsuario;
    string saludo;

    // Start is called before the first frame update
    void Start()
    {
        txtSaludo.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saludar()
    {
        nombreUsuario = inputNombre.text;
        saludo = "Hola " + nombreUsuario + "!";
        txtSaludo.text = saludo;
    }
}
