using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaJuwebs.Models
{
  public class ContaCorrente
  {
    private string? Cpf;
    public string? CPF
    {
      get { return Cpf; }
      set { Cpf = value; }
    }
    protected string? Tipo;
    public string? TIPO
    {
      get { return Tipo; }
      set { Tipo = value; }
    }
    private string? Nome;
    public string? NOME
    {
      get { return Nome; }
      set { Nome = value; }
    }
    private double Saldo;
    public double SALDO
    {
      get { return Saldo; }
      set { Saldo = value; }
    }
    private bool Status = false;
    public bool STATUS
    {
      get { return Status; }
      set { Status = value; }
    }
    public void MenuMetodo()
    {
      Console.WriteLine($@"
        Nome: {NOME}
        CPF: {CPF}
        Tipo: {TIPO}
        Saldo: {SALDO}
        Status: {STATUS}");
    }
    public ContaCorrente()
    {
      this.STATUS = false;
      this.SALDO = 0;
    }
    public void AbrirConta()
    {
      this.STATUS = true;
      if (this.TIPO == "CC")
      {
        this.SALDO = 1050;
      }
      else if (this.TIPO == "CP")
      {
        this.SALDO = 1500;
      }
      else
      {
        this.STATUS = false;
      }
    }
    public void FecharConta()
    {
      if (this.SALDO > 0)
      {
        Console.WriteLine("Conta em debito");
      }
      else if (this.SALDO < 0)
      {
        Console.WriteLine("Retire seu dinheiro");
      }
      else
      {
        this.STATUS = false;
        Console.WriteLine("Conta fechada com sucesso");
      }
    }
    public void Depositar(double valor)
    {
      if (this.STATUS == true)
      {
        this.SALDO += valor;
        Console.WriteLine("Deposito realizado com sucesso");
      }
      else
      {
        Console.WriteLine("Impossivel depositar");
      }
    }
    public void Sacar(double valor)
    {
      if (this.STATUS == true)
      {
        if (this.SALDO >= valor)
        {
          this.SALDO -= valor;
          Console.WriteLine("Saque realizado com sucesso");
        }
        else
        {
          Console.WriteLine("Saldo insuficiente");
        }
      }
      else
      {
        Console.WriteLine("Impossivel sacar");
      }
    }
    public void PagarMensal(double vM)
    {
      vM = 0;
      DateTime hora = DateTime.Now;
      if (this.TIPO == "CC")
      {
        vM = 12;
      }
      else if (this.TIPO == "CP")
      {
        vM = 20;
      }
      if (this.STATUS == true)
      {
        if (this.SALDO > vM)
        {
          this.SALDO -= vM;
          Console.WriteLine($"Sua mensalidade de {vM} foi paga com sucesso");
          Console.WriteLine($"Sua conta foi paga em {hora}");
          Console.WriteLine($"Seu saldo atual é de {this.SALDO}");
        }
        else
        {
          Console.WriteLine("Impossivel pagar");
        }
      }
    }

  }
}
