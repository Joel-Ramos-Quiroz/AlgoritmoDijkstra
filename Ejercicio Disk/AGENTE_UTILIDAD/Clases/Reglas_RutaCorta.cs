using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AGENTE_UTILIDAD
{
    class Reglas_RutaCorta
    {

        #region Variables

        int[,] grafo;
        char[] nodos;
        int[] distancia = new int[45];

        int contador = 0;
        int contador2 = 0;

        int i_resultado = 0;

        int ResultadoValor = 0;
        char[] Ruta = new char[45];
        char[,] ResultadoRuta;

        #endregion

        public void LimpiarArreglo()
        {
            for (int i = 0; i < nodos.Length; i++)
            {
                for (int j = 0; j < nodos.Length; j++)
                {                    
                    ResultadoRuta[i, j]=Convert.ToChar("0");
                }
            }
        }

        public void Inicializar()
        {
            contador=0;
            contador2 = 0;
            i_resultado = 0;
        }
        //cargamos los datos
        public void cargar(String serieNodos)
        {
            contador = 0;
            contador2 = 0;
            nodos = serieNodos.ToCharArray();
            grafo = new int[nodos.Length, nodos.Length];
            ResultadoRuta = new char[nodos.Length, nodos.Length];
        }

        // asigna el tamaño de la arista entre dos nodos
        public void agregarRuta(char origen, char destino, int distancia)
        {
            int n1 = posicionNodo(origen);
            int n2 = posicionNodo(destino);

            grafo[n1, n2] = distancia;
            grafo[n2, n1] = distancia;

        }

        // retorna la posición en el arreglo de un nodo específico
        private int posicionNodo(char nodo)
        {
            for (int i = 0; i < nodos.Length; i++)
            {
                if (nodos[i] == nodo) return i;
            }
            return -1;
        }


        // encuentra la ruta mínima entre dos nodos del grafo
        public void encontrarRutaMinimaFuerzaBruta(char inicio, char fin)
        {
            int p1 = posicionNodo(inicio);
            int p2 = posicionNodo(fin);
            // cola para almacenar cada ruta que está siendo evaluada
            Stack<Int32> resultado = new Stack<Int32>();
            resultado.Push(p1);
            recorrerRutas(p1, p2, resultado);


        }


        // recorre recursivamente las rutas entre un nodo inicial y un nodo final
        // almacenando en una cola cada nodo visitado     



        private void recorrerRutas(int nodoI, int nodoF, Stack<Int32> resultado)
        {
            // si el nodo inicial es igual al final se muestra y evalúa la ruta en revisión
            
            if (nodoI == nodoF)
            {
                string rutas = "";
                string valor = "";
                string cad = "";
                int contador2 = 0;

                foreach (char x in resultado)
                {
                    rutas = nodos[x].ToString() + rutas;
                    valor = evaluar(resultado).ToString();
                    cad = rutas + " " + ": " + valor;

                    
                    
                        distancia[contador] = Convert.ToChar(evaluar(resultado));

                        ResultadoRuta[contador, contador2] = nodos[x];


                        contador2 = contador2 + 1;
                   
                }
                

                //MessageBox.Show(evaluar(resultado).ToString() + "CON = " + contador2.ToString());
                contador = contador + 1;
                
                return;



            }
            // Si el nodoInicial no es igual al final se crea una lista con todos los nodos
            // adyacentes al nodo inicial que no estén en la ruta en evaluación

            List<Int32> lista = new List<Int32>();

            for (int i = 0; i < (grafo.Length); i++)
            {

                if (i <= 8)
                {
                    if (grafo[nodoI, i] != 0 && !resultado.Contains(i)) lista.Add(i);
                }
            }
            // se recorren todas las rutas formadas con los nodos adyacentes al inicial
            foreach (int nodo in lista)
            {
                resultado.Push(nodo);
                recorrerRutas(nodo, nodoF, resultado);
                resultado.Pop();
            }
        }

        // evaluar la longitud de una ruta
        public int evaluar(Stack<Int32> resultado)
        {
            int resp = 0;
            int[] r = new int[resultado.Count];
            int i = 0;
            foreach (int x in resultado) r[i++] = x;
            for (i = 1; i < r.Length; i++) resp += grafo[r[i], r[i - 1]];
            return resp;
        }


        public int VerResultadoValor()
        {
            ResultadoValor = distancia[0];
            
            for (int i = 1; i < contador; i++)
            {
               
                if (ResultadoValor > (distancia[i]))
                {
                    ResultadoValor = distancia[i];

                    i_resultado = i;

                }

            }
            
            return ResultadoValor;
        }


        public string VerResultadoRuta()
        {
            string Resultado = "";
            
            for (int k = 0; k < nodos.Length; k++)
            {

                if ((ResultadoRuta[i_resultado, k] != 0) && ((ResultadoRuta[i_resultado, k].ToString()) != "0"))
                {
                    //MessageBox.Show(i_resultado.ToString());
                    Resultado = ResultadoRuta[i_resultado, k].ToString() + Resultado;
                   
                }
            }
                        
            LimpiarArreglo();
            //Inicializar();
            return Resultado;
        }

    }
}
