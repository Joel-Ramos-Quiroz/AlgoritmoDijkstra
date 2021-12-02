using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Threading;
using System.IO;

namespace AGENTE_UTILIDAD
{
    public partial class AGENTE : Form
    {
        
        #region Variables

        Conexion_Archivo oConexion_Archivo = new Conexion_Archivo();
        Reglas_RutaCorta oReglas_RutaCorta = new Reglas_RutaCorta();

        int PosicioA_X = 300-120;
        int PosicioA_Y = 162;

        int PosicioB_X = 470 - 120;
        int PosicioB_Y = 145;

        int PosicioC_X = 590 - 120;
        int PosicioC_Y = 85;

        int PosicioD_X = 280 - 120;
        int PosicioD_Y = 292;

        int PosicioE_X = 600 - 120;
        int PosicioE_Y = 356;

        int PosicioF_X = 710 - 120;
        int PosicioF_Y = 217;

        int PosicioG_X = 830 - 120;
        int PosicioG_Y = 181;

        int PosicioH_X = 950 - 120;
        int PosicioH_Y = 265;

        int PosicioI_X = 1070 - 120;
        int PosicioI_Y = 253;

        int Distancia;
        string Rutas;

        string Siguiente = "";

        #endregion

        #region Contructores

       

        public AGENTE()
        {
            InitializeComponent();

            oConexion_Archivo.Llenar_Archivo_Agente();
            oConexion_Archivo.Llenar_Archivo_Distancia();

            Asignar_Valores_De_Distancias();
        }
        
        public void Modificar_Imagen_a_Limpio(int i)
        {
      
            if ((i == 1))
            {
                imagen_A.Size =  new System.Drawing.Size(36, 36);
                imagen_A.Image = global::AGENTE_UTILIDAD.Properties.Resources.bote_limpio;
            }
            else if ((i == 2))
            {
                imagen_B.Size = new System.Drawing.Size(36, 36);
                imagen_B.Image = global::AGENTE_UTILIDAD.Properties.Resources.bote_limpio;
            }
            else if ((i == 3))
            {
                imagen_C.Size = new System.Drawing.Size(36, 36);
                imagen_C.Image = global::AGENTE_UTILIDAD.Properties.Resources.bote_limpio;
            }
            else if ((i == 4))
            {
                imagen_D.Size = new System.Drawing.Size(36, 36);
                imagen_D.Image = global::AGENTE_UTILIDAD.Properties.Resources.bote_limpio;
            }
            else if ((i == 5))
            {
                imagen_E.Size = new System.Drawing.Size(36, 36);
                imagen_E.Image = global::AGENTE_UTILIDAD.Properties.Resources.bote_limpio;
            }
            else if ((i == 6))
            {       
                imagen_F.Image = global::AGENTE_UTILIDAD.Properties.Resources.bote_limpio;
                imagen_F.Size = new System.Drawing.Size(36, 36);
            }
            else if ((i == 7))
            {
                imagen_G.Image = global::AGENTE_UTILIDAD.Properties.Resources.bote_limpio;
                imagen_G.Size = new System.Drawing.Size(36, 36);
            }
            else if ((i == 8))
            {             
                imagen_H.Image = global::AGENTE_UTILIDAD.Properties.Resources.bote_limpio;
                imagen_H.Size = new System.Drawing.Size(36, 36);
            }
            else if ((i == 9))
            {
                imagen_I.Image = global::AGENTE_UTILIDAD.Properties.Resources.bote_limpio;
                imagen_I.Size = new System.Drawing.Size(36, 36);
            }

        }
        System.Windows.Forms.PictureBox imagen_A = new System.Windows.Forms.PictureBox();
        System.Windows.Forms.PictureBox imagen_B = new System.Windows.Forms.PictureBox();
        System.Windows.Forms.PictureBox imagen_C = new System.Windows.Forms.PictureBox();
        System.Windows.Forms.PictureBox imagen_D = new System.Windows.Forms.PictureBox();
        System.Windows.Forms.PictureBox imagen_E = new System.Windows.Forms.PictureBox();
        System.Windows.Forms.PictureBox imagen_F = new System.Windows.Forms.PictureBox();
        System.Windows.Forms.PictureBox imagen_G = new System.Windows.Forms.PictureBox();
        System.Windows.Forms.PictureBox imagen_H = new System.Windows.Forms.PictureBox();
        System.Windows.Forms.PictureBox imagen_I = new System.Windows.Forms.PictureBox();

      

        public void PosicionarBasura()
        {
         
            FormatearImagen_Posicion(300 - 120, 162, 1);
            
            FormatearImagen_Posicion(470 - 120, 145, 2);
            
            FormatearImagen_Posicion(590 - 120, 85, 3);
            
            FormatearImagen_Posicion(280 - 120, 292, 4);
            
            FormatearImagen_Posicion(600 - 120, 356, 5);
      
            FormatearImagen_Posicion(710 - 120, 217, 6);
         
            FormatearImagen_Posicion(830 - 120, 181, 7);
    
            FormatearImagen_Posicion(950 - 120, 265, 8);
            
            FormatearImagen_Posicion(1070 - 120, 253, 9);
            
        }

        System.Windows.Forms.Label lbl_etiqueta_A = new System.Windows.Forms.Label();
        System.Windows.Forms.Label lbl_etiqueta_B = new System.Windows.Forms.Label();
        System.Windows.Forms.Label lbl_etiqueta_C = new System.Windows.Forms.Label();
        System.Windows.Forms.Label lbl_etiqueta_D = new System.Windows.Forms.Label();
        System.Windows.Forms.Label lbl_etiqueta_E = new System.Windows.Forms.Label();
        System.Windows.Forms.Label lbl_etiqueta_F = new System.Windows.Forms.Label();
        System.Windows.Forms.Label lbl_etiqueta_G = new System.Windows.Forms.Label();
        System.Windows.Forms.Label lbl_etiqueta_H = new System.Windows.Forms.Label();
        System.Windows.Forms.Label lbl_etiqueta_I = new System.Windows.Forms.Label();
        public void FormatearImagen_Posicion(int posicion_x, int posicion_y,int i)
        {
          
                if ((i == 1))
                {

                lbl_etiqueta_A.AutoSize = true;

                lbl_etiqueta_A.Name = "Etiqueta_Basura_" + i.ToString();
                lbl_etiqueta_A.Size = new System.Drawing.Size(35, 13);
                lbl_etiqueta_A.TabIndex = 6;


                    imagen_A.BackColor = System.Drawing.Color.Transparent;
                    imagen_A.Image = global::AGENTE_UTILIDAD.Properties.Resources.basura;
                    imagen_A.Location = new System.Drawing.Point(posicion_x, posicion_y);
                lbl_etiqueta_A.Location = new System.Drawing.Point(posicion_x, posicion_y + 50);
                lbl_etiqueta_A.Text = "A";
                    imagen_A.Name = "Basura_A";
                    imagen_A.Size = new System.Drawing.Size(50, 41);
                    imagen_A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    imagen_A.TabIndex = 4;
                    imagen_A.TabStop = false;
                    this.Controls.Add(imagen_A);
                this.Controls.Add(lbl_etiqueta_A);
            }
                else if ((i == 2))
                {

                lbl_etiqueta_B.AutoSize = true;

                lbl_etiqueta_B.Name = "Etiqueta_Basura_" + i.ToString();
                lbl_etiqueta_B.Size = new System.Drawing.Size(35, 13);
                lbl_etiqueta_B.TabIndex = 6;


                imagen_B.BackColor = System.Drawing.Color.Transparent;
                    imagen_B.Image = global::AGENTE_UTILIDAD.Properties.Resources.basura;
                    imagen_B.Location = new System.Drawing.Point(posicion_x, posicion_y);
                lbl_etiqueta_B.Location = new System.Drawing.Point(posicion_x, posicion_y + 50);
                lbl_etiqueta_B.Text = "B";
                    imagen_B.Name = "Basura_B";
                    imagen_B.Size = new System.Drawing.Size(50, 41);
                    imagen_B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    imagen_B.TabIndex = 4;
                    imagen_B.TabStop = false;
                    this.Controls.Add(imagen_B);
                this.Controls.Add(lbl_etiqueta_B);
            }
                else if ((i == 3))
                {

                lbl_etiqueta_C.AutoSize = true;

                lbl_etiqueta_C.Name = "Etiqueta_Basura_" + i.ToString();
                lbl_etiqueta_C.Size = new System.Drawing.Size(35, 13);
                lbl_etiqueta_C.TabIndex = 6;

                imagen_C.BackColor = System.Drawing.Color.Transparent;
                    imagen_C.Image = global::AGENTE_UTILIDAD.Properties.Resources.basura;
                    imagen_C.Location = new System.Drawing.Point(posicion_x, posicion_y);
                lbl_etiqueta_C.Location = new System.Drawing.Point(posicion_x, posicion_y + 50);
                lbl_etiqueta_C.Text = "C";
                    imagen_C.Name = "Basura_C";
                    imagen_C.Size = new System.Drawing.Size(50, 41);
                    imagen_C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    imagen_C.TabIndex = 4;
                    imagen_C.TabStop = false;
                    this.Controls.Add(imagen_C);
                this.Controls.Add(lbl_etiqueta_C);
            }
                else if ((i == 4))
                {

                lbl_etiqueta_D.AutoSize = true;

                lbl_etiqueta_D.Name = "Etiqueta_Basura_" + i.ToString();
                lbl_etiqueta_D.Size = new System.Drawing.Size(35, 13);
                lbl_etiqueta_D.TabIndex = 6;

                imagen_D.BackColor = System.Drawing.Color.Transparent;
                    imagen_D.Image = global::AGENTE_UTILIDAD.Properties.Resources.basura;
                    imagen_D.Location = new System.Drawing.Point(posicion_x, posicion_y);
                lbl_etiqueta_D.Location = new System.Drawing.Point(posicion_x, posicion_y + 50);
                lbl_etiqueta_D.Text = "D";
                    imagen_D.Name = "Basura_D";
                    imagen_D.Size = new System.Drawing.Size(50, 41);
                    imagen_D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    imagen_D.TabIndex = 4;
                    imagen_D.TabStop = false;
                    this.Controls.Add(imagen_D);
                this.Controls.Add(lbl_etiqueta_D);
            }
                else if ((i == 5))
                {

                lbl_etiqueta_E.AutoSize = true;

                lbl_etiqueta_E.Name = "Etiqueta_Basura_" + i.ToString();
                lbl_etiqueta_E.Size = new System.Drawing.Size(35, 13);
                lbl_etiqueta_E.TabIndex = 6;

                imagen_E.BackColor = System.Drawing.Color.Transparent;
                    imagen_E.Image = global::AGENTE_UTILIDAD.Properties.Resources.basura;
                    imagen_E.Location = new System.Drawing.Point(posicion_x, posicion_y);
                lbl_etiqueta_E.Location = new System.Drawing.Point(posicion_x, posicion_y + 50);
                lbl_etiqueta_E.Text = "E";
                    imagen_E.Name = "Basura_E";
                    imagen_E.Size = new System.Drawing.Size(50, 41);
                    imagen_E.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    imagen_E.TabIndex = 4;
                    imagen_E.TabStop = false;
                    this.Controls.Add(imagen_E);
                this.Controls.Add(lbl_etiqueta_E);
            }
                else if ((i == 6))
                {

                lbl_etiqueta_F.AutoSize = true;

                lbl_etiqueta_F.Name = "Etiqueta_Basura_" + i.ToString();
                lbl_etiqueta_F.Size = new System.Drawing.Size(35, 13);
                lbl_etiqueta_F.TabIndex = 6;

                imagen_F.BackColor = System.Drawing.Color.Transparent;
                    imagen_F.Image = global::AGENTE_UTILIDAD.Properties.Resources.basura;
                    imagen_F.Location = new System.Drawing.Point(posicion_x, posicion_y);
                lbl_etiqueta_F.Location = new System.Drawing.Point(posicion_x, posicion_y + 50);
                lbl_etiqueta_F.Text = "F";
                    imagen_F.Name = "Basura_F";
                    imagen_F.Size = new System.Drawing.Size(50, 41);
                    imagen_F.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    imagen_F.TabIndex = 4;
                    imagen_F.TabStop = false;
                    this.Controls.Add(imagen_F);
                this.Controls.Add(lbl_etiqueta_F);
            }
                else if ((i == 7))
                {

                lbl_etiqueta_G.AutoSize = true;

                lbl_etiqueta_G.Name = "Etiqueta_Basura_" + i.ToString();
                lbl_etiqueta_G.Size = new System.Drawing.Size(35, 13);
                lbl_etiqueta_G.TabIndex = 6;

                imagen_G.BackColor = System.Drawing.Color.Transparent;
                    imagen_G.Image = global::AGENTE_UTILIDAD.Properties.Resources.basura;
                    imagen_G.Location = new System.Drawing.Point(posicion_x, posicion_y);
                lbl_etiqueta_G.Location = new System.Drawing.Point(posicion_x, posicion_y + 50);
                lbl_etiqueta_G.Text = "G";
                    imagen_G.Name = "Basura_G";
                    imagen_G.Size = new System.Drawing.Size(50, 41);
                    imagen_G.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    imagen_G.TabIndex = 4;
                    imagen_G.TabStop = false;
                    this.Controls.Add(imagen_G);
                this.Controls.Add(lbl_etiqueta_G);
            }
                else if ((i == 8))
                {

                lbl_etiqueta_H.AutoSize = true;

                lbl_etiqueta_H.Name = "Etiqueta_Basura_" + i.ToString();
                lbl_etiqueta_H.Size = new System.Drawing.Size(35, 13);
                lbl_etiqueta_H.TabIndex = 6;

                imagen_H.BackColor = System.Drawing.Color.Transparent;
                    imagen_H.Image = global::AGENTE_UTILIDAD.Properties.Resources.basura;
                    imagen_H.Location = new System.Drawing.Point(posicion_x, posicion_y);
                lbl_etiqueta_H.Location = new System.Drawing.Point(posicion_x, posicion_y + 50);
                lbl_etiqueta_H.Text = "H";
                    imagen_H.Name = "Basura_H";
                    imagen_H.Size = new System.Drawing.Size(50, 41);
                    imagen_H.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    imagen_H.TabIndex = 4;
                    imagen_H.TabStop = false;
                    this.Controls.Add(imagen_H);
                this.Controls.Add(lbl_etiqueta_H);
            }
                else if ((i == 9))
                {

                lbl_etiqueta_I.AutoSize = true;

                lbl_etiqueta_I.Name = "Etiqueta_Basura_" + i.ToString();
                lbl_etiqueta_I.Size = new System.Drawing.Size(35, 13);
                lbl_etiqueta_I.TabIndex = 6;

                imagen_I.BackColor = System.Drawing.Color.Transparent;
                    imagen_I.Image = global::AGENTE_UTILIDAD.Properties.Resources.basura;
                    imagen_I.Location = new System.Drawing.Point(posicion_x, posicion_y);

                lbl_etiqueta_I.Location = new System.Drawing.Point(posicion_x, posicion_y + 50);
                lbl_etiqueta_I.Text = "I";

                    imagen_I.Name = "Basura_I";
                    imagen_I.Size = new System.Drawing.Size(50, 41);
                    imagen_I.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    imagen_I.TabIndex = 4;
                    imagen_I.TabStop = false;
                    this.Controls.Add(imagen_I);
                this.Controls.Add(lbl_etiqueta_I);
            }
        }
        #endregion  

        #region Funciones Generales

        private void Asignar_Valores_De_Distancias()
        {
            oReglas_RutaCorta.cargar("ABCDEFGHI");

            oReglas_RutaCorta.agregarRuta('A', 'B', oConexion_Archivo.ObtenerDistancia("AB", "Distancias"));
            oReglas_RutaCorta.agregarRuta('A', 'D', oConexion_Archivo.ObtenerDistancia("AD", "Distancias"));

            oReglas_RutaCorta.agregarRuta('B', 'C', oConexion_Archivo.ObtenerDistancia("BC", "Distancias"));
            oReglas_RutaCorta.agregarRuta('B', 'F', oConexion_Archivo.ObtenerDistancia("BF", "Distancias"));

            oReglas_RutaCorta.agregarRuta('C', 'G', oConexion_Archivo.ObtenerDistancia("CG", "Distancias"));

            oReglas_RutaCorta.agregarRuta('D', 'E', oConexion_Archivo.ObtenerDistancia("DE", "Distancias"));

            oReglas_RutaCorta.agregarRuta('E', 'F', oConexion_Archivo.ObtenerDistancia("EF", "Distancias"));

            oReglas_RutaCorta.agregarRuta('F', 'H', oConexion_Archivo.ObtenerDistancia("FH", "Distancias"));

            oReglas_RutaCorta.agregarRuta('G', 'I', oConexion_Archivo.ObtenerDistancia("GI", "Distancias"));

            oReglas_RutaCorta.agregarRuta('H', 'I', oConexion_Archivo.ObtenerDistancia("HI", "Distancias"));


            Distancia = oReglas_RutaCorta.VerResultadoValor();
            Rutas = oReglas_RutaCorta.VerResultadoRuta();
        }
        
        #region Posiciones

        private void PosicionDeRobot_A()
        {
            PictRobot.Left = PosicioA_X;
            PictRobot.Top = PosicioA_Y;
        }

        private void PosicionDeRobot_B()
        {
            PictRobot.Left = PosicioB_X;
            PictRobot.Top = PosicioB_Y;
        }

        private void PosicionDeRobot_C()
        {
            PictRobot.Left = PosicioC_X;
            PictRobot.Top = PosicioC_Y;
        }

        private void PosicionDeRobot_D()
        {
            PictRobot.Left = PosicioD_X;
            PictRobot.Top = PosicioD_Y;
        }

        private void PosicionDeRobot_E()
        {
            PictRobot.Left = PosicioE_X;
            PictRobot.Top = PosicioE_Y;
        }

        private void PosicionDeRobot_F()
        {
            PictRobot.Left = PosicioF_X;
            PictRobot.Top = PosicioF_Y;
        }

        private void PosicionDeRobot_G()
        {
            PictRobot.Left = PosicioG_X;
            PictRobot.Top = PosicioG_Y;
        }

        private void PosicionDeRobot_H()
        {
            PictRobot.Left = PosicioH_X;
            PictRobot.Top = PosicioH_Y;
        }

        private void PosicionDeRobot_I()
        {
            PictRobot.Left = PosicioI_X;
            PictRobot.Top = PosicioI_Y;
        }

        private void HubicarRobot()
        {
            if (cmbInicio.Text == "A")
            {
                PosicionDeRobot_A();
                Modificar_Imagen_a_Limpio(1);
                Siguiente = "A";
            }
            else if (cmbInicio.Text == "B")
            {
                PosicionDeRobot_B();
                Modificar_Imagen_a_Limpio(2);
                Siguiente = "B";
            }
            else if (cmbInicio.Text == "C")
            {
                PosicionDeRobot_C();
                Modificar_Imagen_a_Limpio(3);
                Siguiente = "C";
            }
            else if (cmbInicio.Text == "D")
            {
                PosicionDeRobot_D();
                Modificar_Imagen_a_Limpio(4);
                Siguiente = "D";
            }
            else if (cmbInicio.Text == "E")
            {
                PosicionDeRobot_E();
                Modificar_Imagen_a_Limpio(5);
                Siguiente = "E";
            }
            else if (cmbInicio.Text == "F")
            {
                PosicionDeRobot_F();
                Modificar_Imagen_a_Limpio(6);
                Siguiente = "F";
            }
            else if (cmbInicio.Text == "G")
            {
                PosicionDeRobot_G();
                Modificar_Imagen_a_Limpio(7);
                Siguiente = "G";
            }
            else if (cmbInicio.Text == "H")
            {
                PosicionDeRobot_H();
                Modificar_Imagen_a_Limpio(8);
                Siguiente = "H";
            }
            else if (cmbInicio.Text == "I")
            {
                PosicionDeRobot_I();
                Modificar_Imagen_a_Limpio(9);
                Siguiente = "I";
            }
        }

        #endregion

        #region Este

        private void Func_Este(int Posicio_X, int Posicio_Y, int Incremento)
        {
            if ((PictRobot.Left < Posicio_X) && (PictRobot.Top > Posicio_Y))
            {
            PictRobot.Left = PictRobot.Left + 10;
            PictRobot.Top = PictRobot.Top - Incremento;
            }
            else
            {
                
                
            }
        }

        //***************(    ---AB---   )********************
        private void Func_AB()
        {
            if (oConexion_Archivo.ObtenerAccion("AB", "AGENTE") == "IR AL Este")
            {
                Func_Este(PosicioB_X, PosicioB_Y, 1);
              
                
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
               
                MessageBox.Show("Error no se puede encontrar la accion AB (IR AL Este) o a sido modificada");
            }
        }

        #endregion

        #region Oeste

        private void Func_Oeste(int Posicio_X, int Posicio_Y, int Incremento)
        {
            if ((PictRobot.Left > Posicio_X) && (PictRobot.Top < Posicio_Y))
            {
                PictRobot.Left = PictRobot.Left - 10;
                PictRobot.Top = PictRobot.Top + Incremento;
            }
            else
            {
                
            }
            
        }

        //***************(    ---BA---   )********************
        private void Func_BA()
        {
            if (oConexion_Archivo.ObtenerAccion("BA", "AGENTE") == "IR AL Oeste")
            {
                Func_Oeste(PosicioA_X, PosicioA_Y, 1);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion BA (IR AL Oeste) o a sido modificada");
            }
            
        }

        #endregion

        #region Nordeste

        private void Func_Nordeste(int Posicio_X, int Posicio_Y, int Incremento)
        {
            if ((PictRobot.Left < Posicio_X) && (PictRobot.Top > Posicio_Y))
            {
                PictRobot.Left = PictRobot.Left + 10;
                PictRobot.Top = PictRobot.Top - Incremento;
            }
            else
            {
               

            }

        }

        //***************(    ---BC---   )********************
        private void Func_BC()
        {
            if (oConexion_Archivo.ObtenerAccion("BC", "AGENTE") == "IR AL Nordeste")
            {
                Func_Nordeste(PosicioC_X, PosicioC_Y, 5);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  BC (IR AL Nordeste) o a sido modificada");
            }
            
        }

        //***************(    ---HI---   )********************
        private void Func_HI()
        {
            if (oConexion_Archivo.ObtenerAccion("HI", "AGENTE") == "IR AL Nordeste")
            {
                Func_Nordeste(PosicioI_X, PosicioI_Y, 1);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  HI (IR AL Nordeste) o a sido modificada");
            }
           
        }        

        #endregion

        #region SudOeste

        private void Func_SudOeste(int Posicio_X, int Posicio_Y, int Incremento)
        {
            if ((PictRobot.Left > Posicio_X) && (PictRobot.Top < Posicio_Y))
            {
                PictRobot.Left = PictRobot.Left - 10;
                PictRobot.Top = PictRobot.Top + Incremento;
            }
            else
            {
                

            }

        }

        //***************(    ---CB---   )********************
        private void Func_CB()
        {
            if (oConexion_Archivo.ObtenerAccion("CB", "AGENTE") == "IR AL SudOeste")
            {
                Func_SudOeste(PosicioB_X, PosicioB_Y, 5);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  CB (IR AL SudOeste) o a sido modificada");
            }
            
        }

        //***************(    ---IH---   )********************
        private void Func_IH()
        {
            if (oConexion_Archivo.ObtenerAccion("IH", "AGENTE") == "IR AL SudOeste")
            {
                Func_SudOeste(PosicioH_X, PosicioH_Y, 1);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  IH (IR AL SudOeste) o a sido modificada");
            }
            
        }

        #endregion

        #region SurEste

        private void Func_SurEste(int Posicio_X,int Posicio_Y,int Incremento)
        {
            if ((PictRobot.Left < Posicio_X) && (PictRobot.Top < Posicio_Y))
            {
                PictRobot.Left = PictRobot.Left + 10;
                PictRobot.Top = PictRobot.Top + Incremento;
            }
            else
            {

                label1.Text = PictRobot.Left.ToString();
                label2.Text = PictRobot.Top.ToString();
            }

        }

        //***************(    ---CG---   )********************
        private void Func_CG()
        {
            if (oConexion_Archivo.ObtenerAccion("CG", "AGENTE") == "IR AL SurEste")
            {
                Func_SurEste(PosicioG_X, PosicioG_Y, 4);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  CG (IR AL SurEste) o a sido modificada");
            }
            
           
        }

        //***************(    ---GI---   )********************
        private void Func_GI()
        {
            if (oConexion_Archivo.ObtenerAccion("GI", "AGENTE") == "IR AL SurEste")
            {
                Func_SurEste(PosicioI_X, PosicioI_Y, 3);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  GI (IR AL SurEste) o a sido modificada");
            }
            
            
        }

        //***************(    ---BF---   )********************
        private void Func_BF()
        {
            if (oConexion_Archivo.ObtenerAccion("BF", "AGENTE") == "IR AL SurEste")
            {
                Func_SurEste(PosicioF_X, PosicioF_Y, 3);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  BF (IR AL SurEste) o a sido modificada");
            }
            

        }
    
        //***************(    ---FH---   )********************
        private void Func_FH()
        {
            if (oConexion_Archivo.ObtenerAccion("FH", "AGENTE") == "IR AL SurEste")
            {
                Func_SurEste(PosicioH_X, PosicioH_Y, 2);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  FH (IR AL SurEste) o a sido modificada");
            }
           

        }
        //***************(    ---DE---   )********************
        private void Func_DE()
        {
            if (oConexion_Archivo.ObtenerAccion("DE", "AGENTE") == "IR AL SurEste")
            {
                Func_SurEste(PosicioE_X, PosicioE_Y, 2);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  DE (IR AL SurEste) o a sido modificada");
            }
            

        }

        #endregion

        #region  NorOeste

        private void Func_NorOeste(int Posicio_X, int Posicio_Y, int Incremento)
        {
            if ((PictRobot.Left > Posicio_X) && (PictRobot.Top > Posicio_Y))
            {
                PictRobot.Left = PictRobot.Left - 10;
                PictRobot.Top = PictRobot.Top - Incremento;
            }
            else
            {
                label1.Text = PictRobot.Left.ToString();
                label2.Text = PictRobot.Top.ToString(); 

            }

        }

        //***************(    ---GC---   )********************
        private void Func_GC()
        {
            if (oConexion_Archivo.ObtenerAccion("GC", "AGENTE") == "IR AL NorOeste")
            {
                Func_NorOeste(PosicioC_X, PosicioC_Y, 4);            
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  GC (IR AL NorOeste) o a sido modificada");
            }
            
            
        }

        //***************(    ---IG---   )********************
        private void Func_IG()
        {
            if (oConexion_Archivo.ObtenerAccion("IG", "AGENTE") == "IR AL NorOeste")
            {
                Func_NorOeste(PosicioG_X, PosicioG_Y, 3);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  IG (IR AL NorOeste) o a sido modificada");
            }
            
        }

        //***************(    ---FB---   )********************           
        private void Func_FB()
        {
            if (oConexion_Archivo.ObtenerAccion("FB", "AGENTE") == "IR AL NorOeste")
            {
                Func_NorOeste(PosicioB_X, PosicioB_Y, 3);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  FB (IR AL NorOeste) o a sido modificada");
            }
            
        }

        //***************(    ---HF---   )********************       
        private void Func_HF()
        {
            if (oConexion_Archivo.ObtenerAccion("HF", "AGENTE") == "IR AL NorOeste")
            {
                Func_NorOeste(PosicioF_X, PosicioF_Y, 2);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  HF (IR AL NorOeste) o a sido modificada");
            }
            
        }

        //***************(    ---ED---   )********************       
        private void Func_ED()
        {
            if (oConexion_Archivo.ObtenerAccion("ED", "AGENTE") == "IR AL NorOeste")
            {
                Func_NorOeste(PosicioD_X, PosicioD_Y, 2);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  ED (IR AL NorOeste) o a sido modificada");
            }
            

        }
      

        #endregion

        #region Sur

        private void Func_Sur(int Posicio_X, int Posicio_Y, int Incremento)
        {
            if ((PictRobot.Left > Posicio_X) && (PictRobot.Top < Posicio_Y))
            {
                PictRobot.Left = PictRobot.Left - Incremento;
                PictRobot.Top = PictRobot.Top + 10 ;
            }
            else
            {
                label1.Text = PictRobot.Left.ToString();
                label2.Text = PictRobot.Top.ToString();
                //PosicionDeRobot_D();
            }

        }

        //***************(    ---AD---   )********************
        private void Func_AD()
        {
            if (oConexion_Archivo.ObtenerAccion("AD", "AGENTE") == "IR AL Sur")
            {
                Func_Sur(PosicioD_X, PosicioD_Y, 1);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  AD (IR AL Sur) o a sido modificada");
            }
            

        }

        //***************(    ---FE---   )********************
        private void Func_FE()
        {
            if (oConexion_Archivo.ObtenerAccion("FE", "AGENTE") == "IR AL Sur")
            {
                Func_Sur(PosicioE_X, PosicioE_Y, 8);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  FE (IR AL Sur) o a sido modificada");
            }
            
        }

        #endregion

        #region Norte

        private void Func_Norte(int Posicio_X, int Posicio_Y, int Incremento)
        {
            if ((PictRobot.Left < Posicio_X) && (PictRobot.Top > Posicio_Y))
            {
                PictRobot.Left = PictRobot.Left + Incremento;
                PictRobot.Top = PictRobot.Top - 10;
            }
            else
            {
                label1.Text = PictRobot.Left.ToString();
                label2.Text = PictRobot.Top.ToString();
            }

        }

        //***************(    ---DA---   )********************
        private void Func_DA()
        {
            if (oConexion_Archivo.ObtenerAccion("DA", "AGENTE") == "IR AL Norte")
            {
                Func_Norte(PosicioA_X, PosicioA_Y, 1);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  DA (IR AL Norte) o a sido modificada");
            }
            
        }

        //***************(    ---EF---   )********************
        private void Func_EF()
        {
            if (oConexion_Archivo.ObtenerAccion("EF", "AGENTE") == "IR AL Norte")
            {
                Func_Norte(PosicioF_X, PosicioF_Y, 8);
            }
            else
            {
                MOVER_ROBOT.Enabled = false;
                MessageBox.Show("Error no se puede encontrar la accion  EF (IR AL Norte) o a sido modificada");
            }
            
        }

        #endregion
       #endregion

        #region Eventos

        private void AGENTE_Load(object sender, EventArgs e)
        {
            PosicionDeRobot_A();
            PosicionarBasura();

            LlenarCombo();
            cmbInicio.SelectedIndex = 0;
            cmbFin.SelectedIndex = 0;
        }
        int iii = 0;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
        
              
           

            if (iii==0)
                {
                    cmbInicio.Text = "A";
                    cmbFin.Text = "B";
                }
                if (iii == 1)
                {
                    cmbInicio.Text = "B";
                    cmbFin.Text = "C";
                }
                if (iii == 2)
                {
                    cmbInicio.Text = "C";
                    cmbFin.Text = "D";
                }
                if (iii == 3)
                {
                    cmbInicio.Text = "D";
                    cmbFin.Text = "E";
                }
                if (iii == 4)
                {
                    cmbInicio.Text = "E";
                    cmbFin.Text = "F";
                }
                if (iii == 5)
                {
                    cmbInicio.Text = "F";
                    cmbFin.Text = "G";
                }
                if (iii == 6)
                {
                    cmbInicio.Text = "G";
                    cmbFin.Text = "H";
                }
                if (iii == 7)
                {
                    cmbInicio.Text = "H";
                    cmbFin.Text = "I";
                }
            iii = iii + 1;
            if (iii==8)
            {
                iii = 0;
                return;

            
            }

            Asignar_Valores_De_Distancias();
            
            
            char inicio = Convert.ToChar(cmbInicio.Text);
            char fin = Convert.ToChar(cmbFin.Text);

            MOVER_ROBOT.Enabled = false;

            oReglas_RutaCorta.Inicializar();

            HubicarRobot();
            
            oReglas_RutaCorta.encontrarRutaMinimaFuerzaBruta(inicio, fin);

            Distancia = oReglas_RutaCorta.VerResultadoValor();
            Rutas = oReglas_RutaCorta.VerResultadoRuta();

            //MessageBox.Show("Ruta: |" + Rutas + "| Distancia: |" + Distancia + "|peso");
            hablar("DESDE " + cmbInicio.Text+ "       HASTA  " + cmbFin.Text + "   TIENE UNA DISTANCIA DE " + Distancia + "|peso");
         
            MOVER_ROBOT.Enabled = true;
            
            oReglas_RutaCorta.Inicializar();
            }
        

        private void cmbInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            MOVER_ROBOT.Enabled = false;
            HubicarRobot();

            if (cmbInicio.SelectedIndex == 0)
            {
              

                

                

               

               

               

               

                

               
            }
            if (cmbInicio.SelectedIndex == 0)
            {
                FormatearImagen_Posicion(300 - 120, 162, 1);
            }
            else if (cmbInicio.SelectedIndex ==1)
            {
                FormatearImagen_Posicion(470 - 120, 145, 2);
            }
            else if (cmbInicio.SelectedIndex == 2)
            {
                FormatearImagen_Posicion(590 - 120, 85, 3);
            }
            else if (cmbInicio.SelectedIndex == 3)
            {
                FormatearImagen_Posicion(280 - 120, 292, 4);
            }
            else if (cmbInicio.SelectedIndex == 4)
            {
                FormatearImagen_Posicion(600 - 120, 356, 5);
            }
            else if (cmbInicio.SelectedIndex == 5)
            {
                FormatearImagen_Posicion(710 - 120, 217, 6);
            }
            else if (cmbInicio.SelectedIndex == 6)
            {
                FormatearImagen_Posicion(830 - 120, 181, 7);
            }
            else if (cmbInicio.SelectedIndex == 7)
            {
                FormatearImagen_Posicion(950 - 120, 265, 8);
            }
            else if (cmbInicio.SelectedIndex == 8)
            {
                FormatearImagen_Posicion(1070 - 120, 253, 9);
            }
          
        }
        
        private void MOVER_Robot_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < Rutas.Length-1; i++)
            {
                //************************************* DELANTE **********************************************

                if ((Rutas.Substring(i, 1) == "A") && (Rutas.Substring(i + 1, 1) == "B") && (Siguiente == "A"))
                {
                    Func_AB();
                    if ((PictRobot.Left == PosicioB_X) && (PictRobot.Top == PosicioB_Y))
                    {
                        Siguiente = "B";
                        Modificar_Imagen_a_Limpio(2);
                        PosicionDeRobot_B();
                    }
                    
                }

                else if ((Rutas.Substring(i, 1) == "B") && (Rutas.Substring(i + 1, 1) == "F") && (Siguiente == "B"))
                {
                    Func_BF();

                    if ((PictRobot.Left == PosicioF_X) && (PictRobot.Top == PosicioF_Y))
                    {
                        Siguiente = "F";
                        Modificar_Imagen_a_Limpio(6);
                        PosicionDeRobot_F();
                    }
                }

                else if ((Rutas.Substring(i, 1) == "B") && (Rutas.Substring(i + 1, 1) == "C") && (Siguiente == "B"))
                {
                    Func_BC();
                    
                    if ((PictRobot.Left == PosicioC_X) && (PictRobot.Top == PosicioC_Y))
                    {
                        Siguiente = "C";
                        Modificar_Imagen_a_Limpio(3);
                        PosicionDeRobot_C();
                    }
                }

                else if ((Rutas.Substring(i, 1) == "F") && (Rutas.Substring(i + 1, 1) == "H") && (Siguiente == "F"))
                {
                    Func_FH();

                    if ((PictRobot.Left == PosicioH_X) && (PictRobot.Top == PosicioH_Y))
                    {
                        Siguiente = "H";
                        Modificar_Imagen_a_Limpio(8);
                        PosicionDeRobot_H();
                    }

                }
                else if ((Rutas.Substring(i, 1) == "H") && (Rutas.Substring(i + 1, 1) == "I") && (Siguiente == "H"))
                {
                    Func_HI();

                    if ((PictRobot.Left == PosicioI_X) && (PictRobot.Top == PosicioI_Y))
                    {
                        Siguiente = "I";
                        Modificar_Imagen_a_Limpio(9);
                        PosicionDeRobot_I();
                    }
                }

                else if ((Rutas.Substring(i, 1) == "C") && (Rutas.Substring(i + 1, 1) == "G") && (Siguiente == "C"))
                {
                    Func_CG();

                    if ((PictRobot.Left == PosicioG_X) && (PictRobot.Top == PosicioG_Y))
                    {
                        Siguiente = "G";
                        Modificar_Imagen_a_Limpio(7);
                        PosicionDeRobot_G();
                    }
                }

                else if ((Rutas.Substring(i, 1) == "G") && (Rutas.Substring(i + 1, 1) == "I") && (Siguiente == "G"))
                {
                    Func_GI();

                    if ((PictRobot.Left == PosicioI_X) && (PictRobot.Top == PosicioI_Y))
                    {
                        Siguiente = "I";
                        Modificar_Imagen_a_Limpio(9);
                        PosicionDeRobot_I();
                    }
                }

                else if ((Rutas.Substring(i, 1) == "A") && (Rutas.Substring(i + 1, 1) == "D") && (Siguiente == "A"))
                {
                    Func_AD();

                    if ((PictRobot.Left == PosicioD_X+7) && (PictRobot.Top == PosicioD_Y))
                    {
                        PosicionDeRobot_D();
                        Modificar_Imagen_a_Limpio(4);
                        Siguiente = "D";
                    }
                }

                else if ((Rutas.Substring(i, 1) == "D") && (Rutas.Substring(i + 1, 1) == "E") && (Siguiente == "D"))
                {
                    Func_DE();

                    if ((PictRobot.Left == PosicioE_X) && (PictRobot.Top == PosicioE_Y))
                    {
                        PosicionDeRobot_E();
                        Modificar_Imagen_a_Limpio(5);
                        Siguiente = "E";
                       
                    }
                }

                else if ((Rutas.Substring(i, 1) == "E") && (Rutas.Substring(i + 1, 1) == "F") && (Siguiente == "E"))
                {
                    Func_EF();

                    if ((PictRobot.Left == PosicioF_X+2) && (PictRobot.Top == PosicioF_Y-1))
                    {
                        
                        PosicionDeRobot_F();
                        Modificar_Imagen_a_Limpio(6);
                        Siguiente = "F";

                    }
                }

                //************************************* ATRAS **********************************************
                else if ((Rutas.Substring(i, 1) == "B") && (Rutas.Substring(i + 1, 1) == "A") && (Siguiente == "B"))
                {
                    Func_BA();

                    if ((PictRobot.Left == PosicioA_X) && (PictRobot.Top == PosicioA_Y))
                    {

                        PosicionDeRobot_A();
                        Modificar_Imagen_a_Limpio(1);
                        Siguiente = "A";

                    }
                }

                else if ((Rutas.Substring(i, 1) == "C") && (Rutas.Substring(i + 1, 1) == "B") && (Siguiente == "C"))
                {
                    Func_CB();

                    if ((PictRobot.Left == PosicioB_X) && (PictRobot.Top == PosicioB_Y))
                    {

                        PosicionDeRobot_B();
                        Modificar_Imagen_a_Limpio(2);
                        Siguiente = "B";

                    }
                }

                else if ((Rutas.Substring(i, 1) == "G") && (Rutas.Substring(i + 1, 1) == "C") && (Siguiente == "G"))
                {
                    Func_GC();

                    if ((PictRobot.Left == PosicioC_X) && (PictRobot.Top == PosicioC_Y))
                    {

                        PosicionDeRobot_C();
                        Modificar_Imagen_a_Limpio(3);
                        Siguiente = "C";

                    }
                }

                else if ((Rutas.Substring(i, 1) == "I") && (Rutas.Substring(i + 1, 1) == "G") && (Siguiente == "I"))
                {
                    Func_IG();

                    if ((PictRobot.Left == PosicioG_X) && (PictRobot.Top == PosicioG_Y))
                    {

                        PosicionDeRobot_G();
                        Modificar_Imagen_a_Limpio(7);
                        Siguiente = "G";

                    }
                }

                else if ((Rutas.Substring(i, 1) == "I") && (Rutas.Substring(i + 1, 1) == "H") && (Siguiente == "I"))
                {
                    Func_IH();

                    if ((PictRobot.Left == PosicioH_X) && (PictRobot.Top == PosicioH_Y))
                    {

                        PosicionDeRobot_H();
                        Modificar_Imagen_a_Limpio(8);
                        Siguiente = "H";

                    }
                }

                else if ((Rutas.Substring(i, 1) == "H") && (Rutas.Substring(i + 1, 1) == "F") && (Siguiente == "H"))
                {
                    Func_HF();

                    if ((PictRobot.Left == PosicioF_X) && (PictRobot.Top == PosicioF_Y))
                    {

                        PosicionDeRobot_F();
                        Modificar_Imagen_a_Limpio(6);
                        Siguiente = "F";

                    }
                }

                else if ((Rutas.Substring(i, 1) == "F") && (Rutas.Substring(i + 1, 1) == "B") && (Siguiente == "F"))
                {
                    Func_FB();

                    if ((PictRobot.Left == PosicioB_X) && (PictRobot.Top == PosicioB_Y))
                    {

                        PosicionDeRobot_B();
                        Modificar_Imagen_a_Limpio(1);
                        Siguiente = "B";

                    }
                }
                else if ((Rutas.Substring(i, 1) == "F") && (Rutas.Substring(i + 1, 1) == "E") && (Siguiente == "F"))
                {
                    Func_FE();

                    if ((PictRobot.Left == PosicioE_X-2) && (PictRobot.Top == PosicioE_Y+1))
                    {                        
                        PosicionDeRobot_E();
                        Modificar_Imagen_a_Limpio(5);
                        Siguiente = "E";

                    }
                }

                else if ((Rutas.Substring(i, 1) == "F") && (Rutas.Substring(i + 1, 1) == "E") && (Siguiente == "F"))
                {
                    Func_FE();

                    if ((PictRobot.Left == PosicioE_X - 2) && (PictRobot.Top == PosicioE_Y + 1))
                    {
                        PosicionDeRobot_E();
                        Modificar_Imagen_a_Limpio(5);
                        Siguiente = "E";

                    }
                }

                else if ((Rutas.Substring(i, 1) == "E") && (Rutas.Substring(i + 1, 1) == "D") && (Siguiente == "E"))
                {
                    Func_ED();

                    if ((PictRobot.Left == PosicioD_X) && (PictRobot.Top == PosicioD_Y))
                    {  
                        PosicionDeRobot_D();
                        Modificar_Imagen_a_Limpio(4);
                        Siguiente = "D";

                    }
                }

                else if ((Rutas.Substring(i, 1) == "D") && (Rutas.Substring(i + 1, 1) == "A") && (Siguiente == "D"))
                {
                    Func_DA();

                    if ((PictRobot.Left == PosicioA_X - 7) && (PictRobot.Top == PosicioA_Y))
                    {
                        PosicionDeRobot_A();
                        Modificar_Imagen_a_Limpio(1);
                        Siguiente = "A";

                    }
                }

                if (Siguiente==cmbFin.Text)
                {
                    MOVER_ROBOT.Enabled = false;
                    //MessageBox.Show("A LLEGADO A SU DESTINO ---INICIO: ("+cmbInicio.Text+")"+" FIN: ("+cmbFin.Text+")--- CON UNA DISTANCIA DE "+Distancia.ToString()+"peso");
                    hablar("A LLEGADO A SU DESTINO ---INICIO: .(" + cmbInicio.Text + ")" + " FIN: .(" + cmbFin.Text + ")--- CON UNA DISTANCIA DE " + Distancia.ToString() + "peso");

                  
                        if (i != 8)
                        {
                            //i += 1;
                            btnIniciar.PerformClick();
                        }
                  
                }
            }
        
        }

        private void cmbFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            MOVER_ROBOT.Enabled = false;
            HubicarRobot();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Func_ED();
        }

       

        #endregion
        
        public void hablar(string texto)
        {
           // MessageBox.Show(texto);
            //Thread tarea = new Thread(new ParameterizedThreadStart(texto_a_voz));
            //tarea.Start(texto);
        }

        public void texto_a_voz(object texto)
        {
            SpeechSynthesizer voz = new SpeechSynthesizer();
            voz.SetOutputToDefaultAudioDevice();
            voz.Rate =-2;
            voz.Speak(texto.ToString());
            
        }
        

















        System.Data.DataTable dt_tmp = new System.Data.DataTable();
        string[] rutas;

        int Fila = 0;


        private void FormatearTabla()
        {
            dt_tmp = new DataTable("tmp");
            dt_tmp.Columns.Add("vértice");
            dt_tmp.Columns.Add("peso");
        }
        private void LlenarCombo()
        {
            try
            {
                FormatearTabla();
                string strLine = "";
                string ruta_txt;
                string distancia_txt;
                StreamReader objStreamReader;
                objStreamReader = new StreamReader(@"C:\AGENTE\Distancias.txt");
                strLine = objStreamReader.ReadLine();
                do
                {
                    ruta_txt = strLine.Substring(0, 9);
                    distancia_txt = strLine.Substring(10, 3);
                    //ruta_txt = strLine.Substring(0, 9);
                    if (ruta_txt != "---------")
                    {
                        DataRow r = dt_tmp.NewRow();
                        r["vértice"] = ruta_txt;
                        r["peso"] = distancia_txt;
                        //r["filtro"] = "";
                        dt_tmp.Rows.Add(r);
                    }
                    strLine = objStreamReader.ReadLine();

                } while (strLine != null);
                dtglistado.DataSource = dt_tmp;
                objStreamReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            rutas = new string[10];
            for (var i = 0; i < dtglistado.RowCount ; i++)
            {

                rutas[i] = dtglistado.Rows[i].Cells["vértice"].Value.ToString();
                //oConexion_Archivo.Modificar(i, "Distancias", rutas, numAleatorio.Next(100, 900).ToString());
            }
            for (var i = 0; i < dtglistado.RowCount; i++)
            {
                if (i >5)
                {
                    oConexion_Archivo.Modificar(i, "Distancias", rutas, (numAleatorio.Next(100, 105)).ToString());
                }
                else
                {
                    oConexion_Archivo.Modificar(i, "Distancias", rutas, (numAleatorio.Next(500, 900)).ToString());
                }
              
            }
            LlenarCombo();
            

          
            //    Random numAleatorio2 = new Random();
            //    Random numAleatorio3 = new Random();
            //    char[] letras = {'A','B','C'};
            //char[] letras2 = { 'A', 'B' };
            //int o = 0;
            //for (var i = 0; i < dtglistado.RowCount; i++)
            //{
            //    o = numAleatorio3.Next(106, 120);
            //    //if (dtglistado.Rows[i].Cells[1].Value.ToString()>=o.ToString())
            //    //{
            //    //    dtglistado.Rows[i].Cells[1].Value= "234234234";
            //    //}
            //   ;
            //    //oConexion_Archivo.Modificar(i, "Distancias", rutas, numAleatorio.Next(100, 900).ToString());
            //}



            //string v1 = (letras[numAleatorio3.Next(0, 3)] + ", ").ToString().Substring(0, 1);
            //for (var i = 0; i <= 2; i++)
            //{
            //    lbl_etiqueta_A.Text = v1 + "   -   " + dtglistado.Rows[i].Cells["peso"].Value.ToString();
            //    lbl_etiqueta_B.Text = v1 + "   -   " + dtglistado.Rows[i].Cells["peso"].Value.ToString();
            //    lbl_etiqueta_C.Text = v1 + "   -   " + dtglistado.Rows[i].Cells["peso"].Value.ToString();
            //}

            //string v2 = (letras2[numAleatorio3.Next(0, 10)] + ", ").ToString().Substring(0, 1);

            //for (var i = 3; i <= 5; i++)
            //{
            //    lbl_etiqueta_D.Text = v2 + "   -   " + dtglistado.Rows[i].Cells["peso"].Value.ToString();
            //    lbl_etiqueta_E.Text = v2 + "   -   " + dtglistado.Rows[i].Cells["peso"].Value.ToString();
            //    lbl_etiqueta_F.Text = v2 + "   -   " + dtglistado.Rows[i].Cells["peso"].Value.ToString();
            //}

            //string v3 = (letras[numAleatorio3.Next(0, 10)] + ", ").ToString().Substring(0, 1);
            //for (var i = 6; i <= 8; i++)
            //{
            //    lbl_etiqueta_G.Text = "C" + "   -   " + dtglistado.Rows[i].Cells["peso"].Value.ToString();
            //    lbl_etiqueta_H.Text = "C" + "   -   " + dtglistado.Rows[i].Cells["peso"].Value.ToString();
            //    lbl_etiqueta_I.Text = "C" + "   -   " + dtglistado.Rows[i].Cells["peso"].Value.ToString();
            //}

            dtglistado.Sort(dtglistado.Columns["peso"], ListSortDirection.Ascending);
            Random numAleatorio4 = new Random();
            //lbl_etiqueta_G.Text = (letras[numAleatorio3.Next(0, 3)] + ", ").ToString().Substring(0, 1) + "   -   " + dtglistado.Rows[numAleatorio3.Next(0, 10)].Cells["peso"].Value.ToString();
            //lbl_etiqueta_H.Text = (letras[numAleatorio3.Next(0, 3)] + ", ").ToString().Substring(0, 1) + "   -   " + dtglistado.Rows[numAleatorio3.Next(0, 10)].Cells["peso"].Value.ToString();
            //lbl_etiqueta_I.Text = (letras[numAleatorio3.Next(0, 3)] + ", ").ToString().Substring(0, 1) + "   -   " + dtglistado.Rows[numAleatorio3.Next(0, 10)].Cells["peso"].Value.ToString();


            //rutas[i] = dtglistado.Rows[i].Cells["ruta"].Value.ToString();
            //oConexion_Archivo.Modificar(i, "Distancias", rutas, numAleatorio.Next(100, 900).ToString());

        }

       
    }
}
