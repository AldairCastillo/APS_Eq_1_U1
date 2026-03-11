namespace Clase_ICDIA_Unidad1.NumComplejos;

public class NumeroComplejo
{
 private double parte_real;
 private double parte_imaginaria;
 
 //Constructor completo (con parametros esenciales)
 //*El constructor se debe llamar exactamente igual que el 
 //nombre que tiene la clase
 public NumeroComplejo(double parte_real, double parte_imaginaria)
 {
  this.parte_real = parte_real;
  this.parte_imaginaria = parte_imaginaria;
 }

 public NumeroComplejo()
 {
  //Constructor vacio
 }

 public double ParteReal
 {
  get => parte_real; 
  set => parte_real = value;
 }

 public double ParteImaginaria
 {
  get => parte_imaginaria;
  set => parte_imaginaria = value;
 }

 public NumeroComplejo Suma(NumeroComplejo otro)
 {
  double rReal = this.ParteReal + otro.ParteReal;
  double rImaginaria = this.ParteImaginaria + otro.ParteImaginaria;
  
  NumeroComplejo temporal = new NumeroComplejo(rReal, rImaginaria);
  
  return temporal;
 }
 
 public NumeroComplejo Resta(NumeroComplejo otro)
 {
  double rReal = this.ParteReal - otro.ParteReal;
  double rImaginaria = this.ParteImaginaria - otro.ParteImaginaria;
  
  NumeroComplejo temporal = new NumeroComplejo(rReal, rImaginaria);
  
  return temporal;
 }

 public override string ToString()
 {
  if (parte_imaginaria >= 0)
  {
   return ParteReal + "+" + ParteImaginaria + "i"; 
  }
  else
  {
   ParteImaginaria = ParteImaginaria * -1; //convierte en positivo
   return ParteReal + "-" + ParteImaginaria + "i";
  }

  
 }

}