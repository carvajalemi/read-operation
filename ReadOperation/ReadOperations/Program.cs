using System;

class Program {
  public static void Main (string[] args)
  {
     //Leer dos numeros
    int a = Leer ("Ingrese valor 1: ");
    int b = Leer ("Ingrese valor 2: ");
    LeerOperacion("Ingrese operacion: ", a, b); 

    
  }
  //Funcion Leer dos numeros
  public static int Leer(string mensaje)
  {
    int intentos = 0;
    while (intentos < 3)
    {
      Console.WriteLine(mensaje);
      string numeroComoString = Console.ReadLine();
      int valorReal=0;
     if(!int.TryParse(numeroComoString, out valorReal))
      {
        Console.WriteLine("valor ingresado invalido, intente de nuevo ...");
        intentos++; // intentos = intentos +1
      }
      else
      {
          valorReal=Int32.Parse(numeroComoString);
          return valorReal;
      }
    }
     throw new Exception("No se pude leer nada");
  }

  //Funcion LeerOperacion
  public static void LeerOperacion(string mensaje, int a, int b)
  {
    int intentos = 0;
   // while (intentos < 3)
    for (intentos=0; intentos < 3; intentos++)
    {
      Console.WriteLine(mensaje);
      string operadorComoString = Console.ReadLine();
      decimal resultado=0;
      if((operadorComoString== "+")||(operadorComoString== "-")||(operadorComoString== "*")||(operadorComoString== "/"))
      {
        if(operadorComoString== "+")
           {
              resultado = (a+b);
              Console.WriteLine ("El valor de la suma de a+b es:" +resultado);
              return;
           }
        else if (operadorComoString== "-")
          {
              resultado = (a-b);
              Console.WriteLine ("El valor de la resta de a-b es:" +resultado);
              return;
           }
        else if (operadorComoString== "*")
          {
              resultado = (a*b);
              Console.WriteLine ("El valor de la multiplicacion de a*b es:" +resultado);
              return;
          }
        else if (operadorComoString== "/")
        {
              resultado = (Convert.ToDecimal (a)/Convert.ToDecimal (b));
              Console.WriteLine ("El valor de la division de a/b es:" +resultado);
              return;
        }
      }
      else
      {
         Console.WriteLine("Operacion ingresada invalida, intente de nuevo");
        //  intentos++; // intentos = intentos +1
      }
    }
     throw new Exception("No se pude leer nada");
  }
}