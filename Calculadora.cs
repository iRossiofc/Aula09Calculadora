namespace Aula09Calculadora
{
    public class Calculadora
    {
        //primeiro numero na entrada
        public float num1 { get; set; }
        //segundo numero na entrada
        public float num2 { get; set; }
        //resultado da operação
        public float resultado { get; set; }
        //é um protected ou seja não aparece nas classes filhas
        //é o perador para a soma, subtração, divisão ou multiplicação
        protected string operador { get; set; }

        /// <summary>
        /// metodo para realizar a soma, ele da como resultado a soma do "num1" com o "num2", como é um void ele não tem retorno
        /// </summary>
        public void Somar(){
            resultado = 0;
            resultado = num1 + num2;
        }
        /// <summary>
        //metodo para realizar a subtração, ele da como resultado a subtração do "num1" com o "num2", como é um void ele não tem retorno
        /// </summary>
        public void Subtrair(){
            resultado = 0;
            resultado = num1 - num2;
        }

        /// <summary>
        /// metodo para realizar a multiplicação, ele da como resultado a multiplacação do "num1" com o "num2", como é um void ele não tem retorno
        /// </summary>
        public void Multiplicar(){
            resultado = 0;
            resultado = num1 * num2;
        }

        /// <summary>
        //metodo para realizar a divisão, ele da como resultado a divisão do "num1" com o "num2", como é um void ele não tem retorno
        /// </summary>
        public void Dividir(){
            resultado = 0;
            resultado = num1 / num2;
        }
    }
}