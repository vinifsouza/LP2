using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;


namespace P30481923025 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e) {
            double[,] vendas = new double[5, 4];
            string totalSemana = "";
            double numSemana = 0;
            double somaGeral = 0;
            bool validar = true;
            int sair = 0;
            
            for(var i = 0; i < 5; i++) {
                double soma = 0;
                validar = true;
                sair = 0;

                for (var j = 0; j < 4; j++) {

                    do {
                        totalSemana = Interaction.InputBox("Digite o total da semana: " + (j + 1) +
                            " Mês " + (i + 1));

                        if(totalSemana == "") {
                            MessageBox.Show("Entrada vazia!");
                            sair = 1;
                            break;
                        }else if (!double.TryParse(totalSemana, out numSemana)) {
                            MessageBox.Show("Digite um valor válido!");
                            validar = false;
                        } else{
                            validar = true;
                        }
                    } while (validar == false);

                    if (sair == 1) {
                        break;
                    } else { 
                    listBox.Items.Add("Total do mês: " + (i + 1) + " Semana: " + (j + 1) + " R$ " +
                                numSemana.ToString("N2"));
                    soma += numSemana;
                    }
                }

                if(sair == 1) {
                    break;
                } else { 
                somaGeral += soma;
                listBox.Items.Add(">> Total Mês: R$ " + soma.ToString("N2"));
                listBox.Items.Add("__________");
                }
            }
            listBox.Items.Add(">>Total Geral: R$ " + somaGeral.ToString("N2"));
        }
    }
}
