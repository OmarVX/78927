using System;
using immensajes;

namespace imensajes{
    public interface iMensajes{
        string saludar(string nombre){
            return "hola"+nombre;
        }
        string mostrar(string nombre){
            return "x";
        }
    }
}