using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ProbabilidadesTeg
{
    public partial class CalcuTeg : Form
    {// variables globales---------------
        int fichasDefensa; int fichasAtaque; // cantidad de fichas por bando
        int victAtq = 0; int victDef = 0; // cantidad de victorias ( se suman por cada simulacion)
        int cantDadosAtq = 0; int cantDadosDef = 0; // cantidad de dados que juegan atq vs def
        int simulaciones = 0; // cantidad de simulaciones (hasta 100 mil)
        int porcentaje; // porcentaje de exito del ataque en todas las simulaciones
        public CalcuTeg()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
           
            btnCalcular.Enabled = false; // bloque el boton mientras corre la simulacion
            victAtq = 0;
            victDef = 0;    

            for (simulaciones = 1; simulaciones < 100001; simulaciones++)
            {
                try // control de errores !!!!!
                {
                    fichasAtaque = Convert.ToInt16(txtbAtaque.Text);
                    fichasDefensa = Convert.ToInt16(txtbdefensa.Text);
                }
                catch 
                {
                    Console.Beep();
                    System.Windows.Forms.MessageBox.Show("revise sus datos ingresados", "Atención");
                    
                    btnCalcular.Enabled = true;
                    return; // fin control de errores  !!!!
                }
                do
                {
                    calcularCuantosDados();
                    jugarDados();
                }
                while (fichasDefensa > 0 && fichasAtaque > 1);
                
                if (fichasAtaque > 1)
                {
                    victAtq = victAtq + 1;
                }
                else
                    victDef = victDef + 1;
                
                
            }
            lbl_victoriaA.Text = victAtq.ToString(); lblVictoriaD.Text = victDef.ToString();
            porcentaje = victAtq * 100 / simulaciones;
            lblProbabilidad.Text = "La probabilidad de vencer es %" + porcentaje;
            btnCalcular.Enabled = true;
        }
        public void calcularCuantosDados() //calcula con cuantos dados tira ataque y defensa
        {
            switch (fichasAtaque)
            {
                case 3:
                    cantDadosAtq = 2;
                    break;
                case 2:
                    cantDadosAtq = 1;
                    break;
                default:
                    cantDadosAtq = 3;
                    break;
            }
            if (fichasDefensa > 3) cantDadosDef = 3;
            else cantDadosDef = fichasDefensa;
        }
        
        public void jugarDados()  // rutina del lanzamiento + aplicar las reglas de fichas
        {
            
            int dados_a_Comparar;
            int i; int pos; int dado;

            Random d = new  Random(); // creo instancia clase random para tirar los dados "d"
            int []atq = new int[3]; // defino vectores
            int []def = new int[3]; // defino vectores
            

            atq[0] = 0; atq[1] = 0; atq[2] = 0;
            def[0] = 0; def[1] = 0; def[2] = 0;
            
            if (cantDadosDef > cantDadosAtq) dados_a_Comparar = cantDadosAtq; // defino cuantos dados comparo
            else dados_a_Comparar = cantDadosDef;

            for  (i=0; i < cantDadosAtq; i++)  // lanzo los dados de ataque
            {
                pos = i - 1;
                dado = d.Next(1, 7);
                atq[i] = dado;
                
            }
            
            Array.Sort<int>(atq); Array.Reverse(atq); // ordena y deja en orden descendente
            
            for (i = 0; i < cantDadosDef; i++) // lanzo los dados de defensa
            {
                pos = i - 1;
                dado = d.Next(1, 7);
                def[i] = dado;              
            }
            Array.Sort<int>(def); Array.Reverse(def); // ordena y deja en orden descendente
            
            i = 1;
            do  // define y resta fichas al perdedor
            {
                if (atq[i - 1] > def[i - 1]) fichasDefensa = fichasDefensa - 1;
                else fichasAtaque = fichasAtaque - 1;
                i++;
            }   while (i < (dados_a_Comparar + 1));
            //
        }
    }
}
