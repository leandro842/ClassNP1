using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_NP1
{
    class Classes
    {

        public class Corretor : Cotacao
        {
            private int cod { get; set; } //seters inúteis só para dizer que tem.
            private int fone;
            public int Fone
            {
                set
                {
                    this.fone = value;
                }
            }

            private static int check_length(int fone) // Checa se o telefone é válido.
            {
                return fone.ToString().Length;
            }
            public Corretor(int cod, int fone, int cod_cot, double valor) // Construtor recebe parametros.
            {
                values(cod_cot, valor);
                this.cod = cod;
                int length = check_length(fone);

                if (length != 11)
                {
                    MessageBox.Show("Número de telefone inválido seu corno do caralho!"); //Preciso lembrar de tirar esse "corno do caralho" 
                }
                else
                {
                    this.fone = fone;
                }
            }

        }

        public class Cotacao
        {
            private int cod_cot { get; set; } //get set totalmente inútil só pra dizer que tem.
            protected double valor;

            public void values(int cod, double valor)
            {
                this.cod_cot = cod;
                this.valor = check_value(valor);
            }
            private double check_value(double valor)
            {
                if (valor.GetType().Equals(typeof(double)))
                {
                    return valor;
                }
                else
                {
                    MessageBox.Show("Are you crazy? WTF are you try to set a different type o data in a double's field?");
                    return 0;
                }
            }
            public Cotacao()
            {

            }
        }
    }
}
