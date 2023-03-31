using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMasterclass;

public class Noh
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Sexo { get; set; }
    public Noh Proximo { get; set; }

    public Noh(int id, string nome, int sexo, Noh proximo)
    {
        Id = id;
        Nome = nome;
        Sexo = sexo;
        Proximo = proximo;
    }
}