using PrimeiraAPI.Entities;
using PrimeiraAPI.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PrimeiraAPI.Services
{
  public class CarroService : ICarroService
  {
    private readonly LocalDbContext _local;
    public CarroService(LocalDbContext local){
      _local = local;
    }

    public bool AdicionarCarro(Carro carro)
    {
      _local.carro.Add(carro);
      _local.SaveChanges();
      return true;
    }

    public bool AtualizarCarro(Carro carro)
    {
        _local.carro.Attach(carro);
        _local.Entry(carro).State = EntityState.Modified;
        _local.SaveChanges();
        return true;
    }

    public bool DeletarCarro(int id)
    {
        var objApagar =_local.carro.Where(d => d.id == id).FirstOrDefault();
        _local.carro.Remove(objApagar);
        _local.SaveChanges();
        return true;
    }

    public Carro RetornarCarroPorId(int id)
    {
        return _local.carro.Where(d => d.id == id).FirstOrDefault();
    }

    public List<Carro> RetornarListCarro()
    {
      return _local.carro.ToList();
    }
  }
}