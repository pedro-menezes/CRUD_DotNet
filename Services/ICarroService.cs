using PrimeiraAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraAPI.Services
{
    public interface ICarroService
    {
        bool AdicionarCarro(Carro carro);
        List<Carro> RetornarListCarro();
        Carro RetornarCarroPorId(int id);
        bool AtualizarCarro(Carro carro);
        bool DeletarCarro(int id);
    }
}