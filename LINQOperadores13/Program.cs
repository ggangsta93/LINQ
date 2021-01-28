using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOperadores13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hay tres categorias para los operadores de query
            //Secuencia a secuencia (secuencia de entrada, secuencia de salida)
            //Secuencia de entrada, elemento sencillo o escalar
            //Nada de entrada, secuencia de salida

            //Secuencia a secuencia
            //Filtro: Where, Take, TakeWhile, Skip, SkipWhile, Distinct
            //Proyeccion: Select, SelectMany
            //Union: Join, GroupJoin, Zip
            //Ordenamiento: OrderBy, ThenBy, Reverse
            //Agrupamiento: GroupBy
            //Operadores de conjuntos: Concat, Union, Intersect, Except
            //Conversion import: OfType, Cast
            //Conversion export: ToArray, ToDictionary, ToLookup, AsEnumerable, AsQueryble

            //Secuencia a elemento o escalar
            //Operadores de elemento: First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault, ElementAt, ElementOrDefault, DefaultEmpty
            //Agregacion: Aggregate, Average, Count, LongCount, Sum, Max, Min
            //Cuantificador: All, Any, Contains, SequenceEqual

            //nada de entrada, secuencia de salida
            //Generacion: Empty, Range, Repeat

            ////////////////////////////////////////////////////////////////////////////////////////////

            //Filtro
            //Where regresa un subconjunto de elementos que satisfacen una condicion
            //Take regresa el primer elemento n e ignora el resto
            //Skip ignora los primeros n elementos y regresa el resto
            //TakeWhile emite elementos de la sucuencia de entrada hasta que el predicado es falso
            //SkipWhile ignora los elementos de la secuencia de entrada hasta que el predicado es falso, luego emite el resto
            //Distinct regresa una secuencia que excluye a los depulicados

            //Where
            //Aparte de los que hemos visto, where permite un segundo argumento de tipo int que simboliza el 
            //Esto se conoce como filtro por indice

            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema", "pay de pera y manzana" };
            Console.WriteLine("----Where ---");

            IEnumerable<string> r1 = postres.Where((n, i) => i % 2 == 0);//n es el string y i es el indice
            //Mostramos los resultados
            foreach (string postre in r1)
                Console.WriteLine(postre);


            Console.WriteLine("----StartsWith ---");

            //IEnumerable<string> r2 = postres.Where(i=> i.StartsWith("pay"));  Otra opción

            IEnumerable<string> r2 = from p in postres
                                     where p.StartsWith("pay")
                                     select p;
            //Mostramos los resultados
            foreach (string postre in r2)
                Console.WriteLine(postre);


            Console.WriteLine("-------");
            IEnumerable<string> r3 = from p in postres
                                     where p.EndsWith("manzana")
                                     select p;
            //Mostramos los resultados
            foreach (string postre in r2)
                Console.WriteLine(postre);


            Console.WriteLine("\n----TakeWhile ---");
            //TakeWhile enumera la secuencia y emite cada elemento hasta que el predicado es falso
            //ignora el resto

            //Creamos un arreglo sobre el cual trabajar
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8, 11, 2, 4 };
            var r4 = numeros.TakeWhile(n => n < 8);//Se romperá en 9 por tanto devuele {1,5,7,3,5}

            //Mostramos los resultados
            foreach (int numero in r4)
                Console.WriteLine(numero);


            Console.WriteLine("\n----SkipWhile---");
            //SkipWale enumera la secuencia ignora los elementos hasta que el predicado es falso, y emite el resto
            var r5 = numeros.SkipWhile(n => n < 8);//Se romperá en 9 por tanto devulve {9,8,11,2,4}

            //Mostramos los resultados
            foreach (int numero in r5)
                Console.WriteLine(numero);

            ////////////////////////////////////////////////////////////////////////////////////////////
            //Proyección
            //Select transforma el elemento de entrada con la expresion lambda
            //SelecMany transforma el elemento lo aplana y concatena con las subsecuencias resultantes

            //Hemos usado Select con tipos anonimos o para tomar el elemento completamente

            //Proyeccion indexada
            Console.WriteLine("\n----Proyeccion indexada---");
            IEnumerable<string> r6 = postres.Select((p, i) => "Indice " + i + " para el postre " + p);

            //Mostramos los resultados
            foreach (string postre in r6)
                Console.WriteLine(postre);


            //SelectMany
            //En Select cada elemento de entrada produce un elemento de salida
            //SelectMany produce 0.. n elementos.
            Console.WriteLine("\n----SelectMany---");
            IEnumerable<string> r7 = postres.SelectMany(p => p.Split());

            //Mostramos los resultados
            foreach (string postre in r7)
                Console.WriteLine(postre);


            //Comparamos con Select
            Console.WriteLine("----Comparamos con Select");

            //Regresa un arreglo de cadenas no esta "aplanado", lo está dando de forma jerarquica
            IEnumerable<string[]> r8 = postres.Select(p => p.Split());

            foreach (string[] n in r8)
            {
                Console.WriteLine("-");
                foreach (string m in n)
                    Console.WriteLine(m);
            }

            //Select con mutiples variables de rango
            Console.WriteLine("----Select con mutiples variables");

            IEnumerable<string> r9 = from p in postres/*esta forma del from se evalua de adentro hacia afuera, ej desde p1 a p*/
                                     from p1 in p.Split()
                                     select p1 + " ===>" + p;

            //Mostramos los resultados
            foreach (string postre in r9)
                Console.WriteLine(postre);


            Console.WriteLine("-------");

            IEnumerable<string> r10 = from p in postres
                                      from p1 in postres
                                      select "Yo quiero: " + p1 + " y tu quieres " + p;

            //Mostramos los resultados
            foreach (string postre in r10)
                Console.WriteLine(postre);

            ///////////////////////////////////////////////////////////////////////////////

            //Union-Joing
            //Join une los elementos de dos colecciones en un solo conjunto
            //GroupJoin es como Join pero da un resultado jerarquico
            //Zip Enumera dos secuencias y aplica una funcion a cada par|

            Console.WriteLine("\n----Join---");

            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Ana",100),
                new CEstudiante("Mario",150),
                new CEstudiante("Susana",180),
            };

            List<CCurso> cursos = new List<CCurso>
            {
                new CCurso("Programacion",100),
                new CCurso("Orientado objetos",150),
                new CCurso("Programacion",150),
                new CCurso("Programacion",180),
                new CCurso("UML",100),
                new CCurso("Orientado objetos",100),
                new CCurso("UML",180)
            };

            //var listado = from e in estudiantes
            //              from c in cursos
            //              where c.Id == e.Id
            //              select e.Nombre + " esta en el curso " + c.Curso;

            var listado = from e in estudiantes
                          join c in cursos
                          on e.Id equals c.Id
                          select e.Nombre + " esta en el curso " + c.Curso;

            //Mostramos los resultados
            foreach (string n in listado)
                Console.WriteLine(n);

            Console.WriteLine("\n----GroupJoin---");

            //Los resultados se obtienen en forma jerarquica
            //La sintaxis es la misma pero utilizamos into

            var listado2 = from e in estudiantes
                           join c in cursos
                           on e.Id equals c.Id
                           into tempListado
                           select new { estudiante = e.Nombre, tempListado };//Select está creando un tipo anonimo

            //Mostramos los resultados
            foreach (var lst in listado2)
            {
                Console.WriteLine(lst.estudiante);
                foreach (var lst2 in lst.tempListado)
                    Console.WriteLine(lst2);
            }



            Console.WriteLine("\n----ZIP---");
            //ZIP
            //Regresa una secuencia que aplica una funcion a cada par

            string[] helados = { "chocolate", "vainilla", "fresa", "limon" };

            IEnumerable<string> r12 = postres.Zip(helados, (p, h) => p + " con helado de " + h);

            //Mostramos los resultados
            foreach (string n in r12)
                Console.WriteLine(n);

            ///////////////////////////////////////////////////////////////////////////////
            //Ordenamiento
            //OrderBy, ThenBy, Ordena en orden ascendente
            //OrderByDescending, ThenByDescending Ordena en orden descendente
            //Reverse Regresas en el orden inverso

            Console.WriteLine("\n----Ordenamiento---");

            IEnumerable<int> numOrden = numeros.OrderBy(n => n);
            IEnumerable<int> numDes = numeros.OrderByDescending(n => n);

            //Mostramos los resultados
            foreach (int n in numOrden)
                Console.WriteLine(n);
            Console.WriteLine("-------");
            //Mostramos los resultados
            foreach (int n in numDes)
                Console.WriteLine(n);

            Console.WriteLine("-------");
            string[] palabras = { "hola", "piedra", "pato", "pastel", "carros", "auto" };

            IEnumerable<string> palabrasOrd = palabras.OrderBy(p => p.Length).ThenBy(p => p);//Primero por longitud luego por alfabeto
            //Mostramos los resultados
            foreach (string p in palabrasOrd)
                Console.WriteLine(p);

            ///////////////////////////////////////////////////////////////////////////////
            //Agrupamiento
            //GroupBy Agrupa una secuencia en subsecuencias

            Console.WriteLine("\n----Agrupamiento---");

            string[] archivos = System.IO.Directory.GetFiles("C:\\Windows\\System32");
            Console.WriteLine("Archivos obtenidos por GetFiles");

            //Mostramos los resultados
            //foreach (string n in archivos)
            //    Console.WriteLine(n);
            //Agrupamos basados en la extension
            //Adentro de () colocamos el criterio de agrupamiento

            var archivoAg = archivos.GroupBy(a => System.IO.Path.GetExtension(a));
            Console.WriteLine("Resultados agrupados");

            foreach (IGrouping<string, string> g in archivoAg)
            {
                //Console.WriteLine("Archivos de extension {0}",g.Key);//Aqui usamos la llave de agrupamiento
                //foreach (string a in g)
                //     Console.WriteLine("\t {0}", a);
            }

            ///////////////////////////////////////////////////////////////////////////////
            ///Conjuntos
            ///Cancat, Union, Intersect, Except
            ///////////////////////////////////////////////////////////////////////////////

            //Conversion
            //OfType Convierte de IEnumerable a IEnumerable<T>, desecha los elementos erroneos
            //Cast Convierte de IEnumerable a IEnumerable<T>, lanza excepcion con los elementos erroneos
            //ToArray Convierte de IEnumerable<T> a T[]
            //ToList Convierte de IEnumerable<T> a List<T>
            //ToDictionary Convierte de IEnumerable<T> a Dictionary<TKey, TValue>
            //ToLookup Convierte de IEnumerable<T> a ILookup<TKey, TElement>
            //AsEnumerable Hace downcast a IEnumerable<T>
            //AsQueryable Hace cast o convierte a IQueryable<T>

            ///////////////////////////////////////////////////////////////////////////////
            //De elemento
            //First, FirstOrDefault         Regresa primer elemento de la secuencia
            //Last, LastOrDefault           Regresa el ultimo elemento de la secuencia
            //Single, SingleOrDefault       Equivalente a First, FirstOrDefault pero lanza una excepcion si hay de 
            //ElementAt, ElementAtDefault   Regresa el elemento de determinada posicion
            //DefaultOfEmpty                Regresa al elemento de default is la secuencia no tiene elementos

            Console.WriteLine("\n----De elemento---");

            //Obtenemos el primero
            int primero = numeros.First();
            Console.WriteLine("Primero: " + primero);

            //Primero que cumpla cierta condicion
            int primeroc = numeros.First(n => n % 2 == 0);
            Console.WriteLine("Primero que cumpla la condición: " + primeroc);

            //Primero que cumpla o default
            int primerod = numeros.FirstOrDefault(n => n % 57 == 0);
            Console.WriteLine("Primero que cumpla o default: " + primerod);

            ///////////////////////////////////////////////////////////////////////////////
            //Agregacion
            //Count,LongCount, Regresa la cantidad de elementos en la secuencia int o int64
            //Min Regresa el elemento menor de la secuencia
            //Max regresa el elemento mayor de la secuencia
            //Sum Regresa la sumatoria de los elementos
            //Average Regresa el promedio de los elementos
            //Aggregate Hace un agregacion usando nuestro algoritmo

            Console.WriteLine("\n----De agregacion---");
            int sumatoria = numeros.Sum();
            Console.WriteLine("Sumatoria: " + sumatoria);

            int[] numeros2 = { 1, 2, 3, 4, 5 };//Si no se especifica una semilla por default toma el primer valor

            //En este caso la semilla es cero, si no se pone la semilla, toma el primer valor
            int agregado = numeros2.Aggregate(0, (t, n) => t + (n * 2));//El 0 se conoce como parametro semilla
            Console.WriteLine("Agregado: " + agregado);

            ///////////////////////////////////////////////////////////
            //Cuantificadores
            //Contains       Regresa true si la secuencia contiene al elemento
            //Any            Regresa true si un elemento satisface al predicado
            //All            Regresa true si todos los elementos satisfacen al predicado
            //SequenceEqual  Regresa true si la segunda secuencia tiene elementos identicos a la entrada

            Console.WriteLine("\n--- Cuantificadores ---");

            bool todos = numeros2.All(n => n < 10);//Expresion lambda o predicado
            Console.WriteLine(todos);

            bool iguales = numeros2.SequenceEqual(numeros2);//
            Console.Write(iguales);

            ///////////////////////////////////////////////////////////
            //Generacion

            //Empty     Crea una secuencia vacia
            //Repeat    Crea una secuencia de elementos que se repiten
            //Range     Crea una secuencia de enteros

            Console.WriteLine("\n---Generacion ---");

            var vacia = Enumerable.Empty<int>();

            foreach (int n in vacia)
                Console.WriteLine(n);

            Console.WriteLine("-------");

            var repetir = Enumerable.Repeat("hola", 5);
            foreach (string n in repetir)
                Console.WriteLine(n);

            Console.WriteLine("-------");

            var rango = Enumerable.Range(5, 15); //Inicio, elementos ->Imprime desde el 5 hasta el 19
            foreach (int n in rango)
                Console.WriteLine(n);

        }
    }

    class CCurso
    {
        private string curso;
        private int id;

        public CCurso(string pCurso, int pID)
        {
            curso = pCurso;
            id = pID;
        }

        public string Curso { get => curso; set => curso = value; }
        public int Id { get => id; set =>  id=value; }

        public override string ToString()
        {
            return string.Format("Curso => {0}",curso);
        }



    }
}
