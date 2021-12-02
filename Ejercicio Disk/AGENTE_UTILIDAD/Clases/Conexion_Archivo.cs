using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Text;
using System.Security;
using System.Security.Permissions;

namespace AGENTE_UTILIDAD
{
    class Conexion_Archivo
    {
        int LineasTotal = 0;

        private void Archivo()
        {
            StringBuilder resultText = new StringBuilder();
            FileIOPermission permFileIO = new FileIOPermission(FileIOPermissionAccess.AllAccess, "C:\\");

            try
            {
                permFileIO.Demand();
            }
            catch (SecurityException se)
            {
                resultText.Append(se.Message);
            }

            //directori Agente
            DirectoryInfo DIR = new DirectoryInfo("C:/AGENTE");

            if (!DIR.Exists)
            {
                DIR.Create();
            }
        }

        public void Llenar_Archivo_Agente()
        {
            try
            {
                Archivo();

                string fileName = @"C:\Agente\AGENTE.txt";

                // Compruebe si el archivo ya existe. Si es así, elimínelo.
                if (File.Exists(fileName))
                {
                    //DialogResult myDialogResult;
                    //myDialogResult = MessageBox.Show("El archivo AGENTE.txt ya existe desea crear el archivo desde el Inicio", "Crear Archivo Agente", MessageBoxButtons.YesNo);
                    //if (myDialogResult == DialogResult.Yes)
                    //{
                        File.Delete(fileName);
                    //}

                    //if (myDialogResult == DialogResult.No)
                    //{
                    //    return;
                    //}
                    
                    
                }

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    #region Agregar Texto
                    
                    // Agrego texto a mi Archivo.txt
                    sw.WriteLine("-------------------------");
                    sw.WriteLine("RUTA (AB)|IR AL Este");
                    sw.WriteLine("RUTA (AD)|IR AL Sur");
                    sw.WriteLine("-------------------------");
                    sw.WriteLine("RUTA (BA)|IR AL Oeste");
                    sw.WriteLine("RUTA (BC)|IR AL Nordeste");
                    sw.WriteLine("RUTA (BF)|IR AL SurEste");
                    sw.WriteLine("-------------------------");
                    sw.WriteLine("RUTA (CB)|IR AL SudOeste");
                    sw.WriteLine("RUTA (CG)|IR AL SurEste");
                    sw.WriteLine("-------------------------");
                    sw.WriteLine("RUTA (DA)|IR AL Norte");
                    sw.WriteLine("RUTA (DE)|IR AL SurEste");
                    sw.WriteLine("-------------------------");
                    sw.WriteLine("RUTA (ED)|IR AL NorOeste");
                    sw.WriteLine("RUTA (EF)|IR AL Norte");
                    sw.WriteLine("-------------------------");
                    sw.WriteLine("RUTA (FB)|IR AL NorOeste");
                    sw.WriteLine("RUTA (FE)|IR AL Sur");
                    sw.WriteLine("RUTA (FH)|IR AL SurEste");
                    sw.WriteLine("-------------------------");
                    sw.WriteLine("RUTA (GC)|IR AL NorOeste");
                    sw.WriteLine("RUTA (GI)|IR AL SurEste");
                    sw.WriteLine("-------------------------");
                    sw.WriteLine("RUTA (HF)|IR AL NorOeste");
                    sw.WriteLine("RUTA (HI)|IR AL Nordeste");
                    sw.WriteLine("-------------------------");
                    sw.WriteLine("RUTA (IG)|IR AL NorOeste");
                    sw.WriteLine("RUTA (IH)|IR AL SudOeste");
                    sw.WriteLine("-------------------------");

                    #endregion
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
            
        }

        public void Llenar_Archivo_Distancia()
        {
            try
            {
                Archivo();

                string fileName = @"C:\Agente\Distancias.txt";

                // Compruebe si el archivo ya existe. Si es así, elimínelo.
                if (File.Exists(fileName))
                {
                    //DialogResult myDialogResult;
                    //myDialogResult = MessageBox.Show("El archivo Distancia.txt ya existe desea crear el archivo desde el Inicio", "Crear Archivo Distancia", MessageBoxButtons.YesNo);
                    //if (myDialogResult == DialogResult.Yes)
                    //{
                        File.Delete(fileName);
                    //}

                    //if (myDialogResult == DialogResult.No)
                    //{
                    //    return;
                    //}


                }

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    #region Agregar Texto
                    
                    // Agrego texto a mi Archivo.txt
                    sw.WriteLine("RUTA (AB)|900");
                    sw.WriteLine("RUTA (AD)|100");
                    sw.WriteLine("RUTA (BC)|100");
                    sw.WriteLine("RUTA (BF)|100");
                    sw.WriteLine("RUTA (CG)|105");
                    sw.WriteLine("RUTA (DE)|150");
                    sw.WriteLine("RUTA (EF)|280");
                    sw.WriteLine("RUTA (FH)|320");
                    sw.WriteLine("RUTA (GI)|330");
                    sw.WriteLine("RUTA (HI)|123");    

                    #endregion
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

        }

        private string[] Obtener_lineas(int Posicion, string NomArchivo, string NuevoTexto)
        {
            string distancia_txt = "";
            string[] distancias = new string[45];
            try
            {
                string strLine = "";
                
                int dis = 0;
                int contador = 0;
                string filename = @"C:\AGENTE\" + NomArchivo + ".txt";
                StreamReader objStreamReader = new StreamReader(filename); ;
                                
                strLine = objStreamReader.ReadLine();

                do
                {
                    dis = strLine.Length;
                    if (Posicion == contador)
                    {
                        //MessageBox.Show(NuevoTexto);
                        distancias[contador] = NuevoTexto;
                    }
                    else
                    {
                        distancia_txt = strLine.Substring(10, dis - 10);
                        //lleno el arreglo para despues poder modificar
                        distancias[contador] = distancia_txt;
                    }

                    

                    
                    
                    strLine = objStreamReader.ReadLine();
                    contador = contador + 1;
                    LineasTotal = contador;
                    
                } while (strLine != null);

                objStreamReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return distancias;
            
        }

        public void Modificar(int Posicion, string NomArchivo, string[] ruta, string NuevoTexto)
        {
            try
            {
                Archivo();
                string[] distancias = new string[45];
                string fileName = @"C:\AGENTE\" + NomArchivo + ".txt";
                string Distancias="";
                string Rutas = "";
                distancias = Obtener_lineas(Posicion, NomArchivo, NuevoTexto);

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    #region Agregar Texto

                    // Agrego texto a mi Archivo.txt
                    for (int i = 0; i < LineasTotal; i++)
                    {
                        Distancias=distancias[i];
                        Rutas = ruta[i];
                        sw.WriteLine(Rutas+"|"+Distancias);
                       
                    }

                    #endregion
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

        }

        public string ObtenerAccion(string Ruta, string NomArchivo)
        {
            string Accion = "";
            try
            {
                string strLine = "";

                string ruta_txt;
                StreamReader objStreamReader;             

                objStreamReader = new StreamReader(@"C:\AGENTE\"+NomArchivo+".txt");

                strLine = objStreamReader.ReadLine();

                do
                {
                    ruta_txt = strLine.Substring(6, 2);

                    if (ruta_txt == Ruta)
                    {                        
                        Accion = (strLine.Substring(10, strLine.Length-10)).Trim();

                    }
                    strLine = objStreamReader.ReadLine();
                } while (strLine != null);

                objStreamReader.Close();
                return Accion;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return Accion;

            }

           
        }

        public int ObtenerDistancia(string Ruta, string NomArchivo)
        {
            int  distancia = 0;
            try
            {
                string strLine = "";

                string ruta_txt;
                StreamReader objStreamReader;

                objStreamReader = new StreamReader(@"C:\AGENTE\" + NomArchivo + ".txt");

                strLine = objStreamReader.ReadLine();

                do
                {
                    ruta_txt = strLine.Substring(6, 2);

                    if (ruta_txt == Ruta)
                    {
                        distancia = Convert.ToInt32((strLine.Substring(10, strLine.Length - 10)).Trim());

                    }
                    strLine = objStreamReader.ReadLine();
                } while (strLine != null);

                objStreamReader.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            return distancia;
        }

        public string VerDistancia(int posicion)
        {
            string distancia_txt = "";
            try
            {
                string strLine = "";

                int dis = 0;
                int contador = 0;
                StreamReader objStreamReader;
                objStreamReader = new StreamReader(@"C:\AGENTE\Distancias.txt");
                strLine = objStreamReader.ReadLine();
                do
                {
                    dis = strLine.Length;
                    if (posicion == contador)
                    {
                        distancia_txt = strLine.Substring(10, dis - 10);
                    }

                    strLine = objStreamReader.ReadLine();
                    contador = contador + 1;
                } while (contador <= posicion);

                objStreamReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return distancia_txt;
        }

    }


    

}
