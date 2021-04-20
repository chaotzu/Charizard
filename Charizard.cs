using System;
//using System.Drawing;
using System.Collections.Generic;

namespace pokemones
{
    class Charizard
    {
        //int[] cColors = { 0x000000, 0x000080, 0x008000, 0x008080, 0x800000, 0x800080, 0x808000, 0xC0C0C0, 0x808080, 0x0000FF, 0x00FF00, 0x00FFFF, 0xFF0000, 0xFF00FF, 0xFFFF00, 0xFFFFFF }; 
        #region Atributos
        /// <summary>
        /// Altura de charizard.
        /// </summary>
        private double altura;
        /// <summary>
        /// Peso de charizard.
        /// </summary>
        private double peso;
        /// <summary>
        /// Sexo de charizard.
        /// </summary>
        private char sexo;
        /// <summary>
        /// Categoria de charizard.
        /// </summary>
        private String categoria;
        /// <summary>
        /// Habilidad especial de charizard.
        /// </summary>
        private String habilidad;
        /// <summary>
        /// Tipos de pokemon a los que pertenece de charizard.
        /// </summary>
        private List<String> tipo;
        /// <summary>
        /// Tipos contra los que es debil charizard.
        /// </summary>
        private List<String> debilidades;
        /// <summary>
        /// Ataques de charizard.
        /// </summary>
        private List<String> ataques;
        /// <summary>
        /// Nombre de charizard.
        /// </summary>
        private String nombre;   
        private int edad;    
        #endregion   

        #region Propiedades
        public String Altura{ get; private set;}
        public String Peso{ get; private set;}
        public char Sexo{ get; private set;}
        public String Categoria{ get; private set;}
        public String Habilidad{ get; private set;}
        public List<String> Tipo{ get; private set;}
        public List<String> Debilidades{ get; private set;}
        public List<String> Ataques{ get;  set;}
        public String Nombre{ get; set;}
        public int Edad{
             get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        #endregion 

        #region setters y getters
        public void setNombre(String nombre){
            this.nombre = nombre;
        }
        public String getNombre(){
            return nombre;
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una instancia de charizard
        /// </summary>
        public Charizard()
        {
            altura = 1.7;
            peso = 90.5;
            sexo = 'M';
            categoria = "llama";
            habilidad = "Mar de llamas";
            tipo = new List<string>(){
                "fuego",
                "viento"                                                                
            };
            debilidades = new List<string>(){
                "agua",
                "electricidad",
                "roca"                                                                
            };
            ataques = new List<string>(){
                "bola fuego"                                            
            };
            nombre = "Charizard";
            edad = 1;
        }

        /// <summary>
        /// Crea una instancia de charizard con valores arbitrarios.
        /// </summary>
        /// <param name="nombre">Nombre de charizard.</param>
        /// <param name="edad">Edad de charizard.</param>        
        public Charizard(string nombre, int edad)
        {
            altura = 1.7;
            peso = 90.5;
            sexo = 'M';
            categoria = "llama";
            habilidad = "Mar de llamas";
            tipo = new List<string>(){
                "fuego",
                "viento"                                                                
            };
            debilidades = new List<string>(){
                "agua",
                "electricidad",
                "roca"                                                                
            };
            ataques = new List<string>(){
                "bola fuego"                                            
            };                          
            this.nombre = nombre;
            this.edad = edad;            
        }
        #endregion

        

        #region Destructor
        /// <summary>
        /// Destructor de la instancia Charizard.
        /// </summary>
        ~Charizard(){
            Console.WriteLine("Charizard murió");
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Agrega un nuevo ataque a charizard
        /// </summary>
        /// <param name="ataque">Nombre del nuevo ataque.</param>        
        public void AprendeAtaque(String ataque)
        {
            ataques.Add(ataque);
        }

        /// <summary>
        /// Charizard ataca
        /// </summary>
        /// <param name="posicionAtaque">Posición del ataque.</param>
        /// <returns>Ataque.</returns>
        public String Ataca(int posicion)
        {            
            return ataques[posicion];
        }

        /// <summary>
        /// Charizard ataca
        /// </summary>
        /// <param name="nombreAtaque">nombre del ataque.</param>
        /// <returns>Ataque.</returns>
        public String Ataca(String ataque)
        {
            foreach (var item in ataques)
            {
                if(item == ataque)
                    return item;
            }
            return "El ataque no es conocido por Charizard";
        }

        /// <summary>
        /// Charizard ataca
        /// </summary>        
        /// <returns>Ataque.</returns>
        public String Ataca()
        {
            return ataques[new Random().Next(0, ataques.Count)];            
        }

        //public void Mostrar(){
        //    Bitmap bmpSrc = new Bitmap(@"006.png", true); ConsoleWriteImage(bmpSrc);
        //}

        //public void ConsoleWritePixel(Color cValue) { Color[] cTable = cColors.Select(x => Color.FromArgb(x)).ToArray(); char[] rList = new char[] { (char)9617, (char)9618, (char)9619, (char)9608 }; int[] bestHit = new int[] { 0, 0, 4, int.MaxValue }; for (int rChar = rList.Length; rChar > 0; rChar--) { for (int cFore = 0; cFore < cTable.Length; cFore++) { for (int cBack = 0; cBack < cTable.Length; cBack++) { int R = (cTable[cFore].R * rChar + cTable[cBack].R * (rList.Length - rChar)) / rList.Length; int G = (cTable[cFore].G * rChar + cTable[cBack].G * (rList.Length - rChar)) / rList.Length; int B = (cTable[cFore].B * rChar + cTable[cBack].B * (rList.Length - rChar)) / rList.Length; int iScore = (cValue.R - R) * (cValue.R - R) + (cValue.G - G) * (cValue.G - G) + (cValue.B - B) * (cValue.B - B); if (!(rChar > 1 && rChar < 4 && iScore > 50000))  { if (iScore < bestHit[3]) { bestHit[3] = iScore;  bestHit[0] = cFore;  bestHit[1] = cBack;  bestHit[2] = rChar;  } } } } } console.ForegroundColor = (ConsoleColor)bestHit[0]; Console.BackgroundColor = (ConsoleColor)bestHit[1]; Console.Write(rList[bestHit[2] - 1]); } 
        //public void ConsoleWriteImage(Bitmap source) { int sMax = 39; decimal percent = Math.Min(decimal.Divide(sMax, source.Width), decimal.Divide(sMax, source.Height)); Size dSize = new Size((int)(source.Width * percent), (int)(source.Height * percent)); Bitmap bmpMax = new Bitmap(source, dSize.Width * 2, dSize.Height); for (int i = 0; i < dSize.Height; i++) { for (int j = 0; j < dSize.Width; j++) { ConsoleWritePixel(bmpMax.GetPixel(j * 2, i)); ConsoleWritePixel(bmpMax.GetPixel(j * 2 + 1, i)); } System.Console.WriteLine(); } Console.ResetColor(); }
        #endregion



    }
}
