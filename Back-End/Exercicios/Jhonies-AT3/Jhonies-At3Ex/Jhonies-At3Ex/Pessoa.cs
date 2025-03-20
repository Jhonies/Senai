using System;

namespace Jhonies_At3Ex;

public class Pessoa
{
    private string nome; //nome privado

    //Atributo publico para acessar o nome
    public string Nome
    {
        get { return nome; } //Retorna o valor do campo privado
        set { nome = value; } //Define um novo valor
    }
}