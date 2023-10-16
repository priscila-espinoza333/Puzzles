//1.- Crear matriz vacía con 10 números aleatorios.
int [] randomNum = RandomArray();

Console.WriteLine("array de números aleatorios");
// iteracion
    foreach (int numero in randomNum){
        Console.WriteLine("número " + numero);
    }
    
// Funcioón que recorre el array y asigna valor aleatorio entre 5 y 25
static int[] RandomArray(){
    int[] result = new int[10]; //creo el array
    Random rand = new Random(); // creo la clase rand para generar los numeros aleatorios
    for (int i = 0; i < result.Length; i++){ //recorro cada elemento del array
        result[i] = rand.Next(5,25);  //genera el valor aleatorio
    }
    return result;
}

// declaro las variables para min max y suma 
    int vMin = VMin (randomNum);
    int vMax = VMax(randomNum);
    int sum = Sum(randomNum);

    // imprimo los valores min, max y suma 
    Console.WriteLine("\nValor minimo: " + vMin);
    Console.WriteLine("\nValor máximo: " + vMax);
    Console.WriteLine("\nTotal suma valores: " + sum);


// devuelve el valor minimo del array
static int VMin(int[] array){
    int min = array[0];
    foreach (int numero in array){
        if (numero < min){
            min = numero;
    }
}
    return min;
}
// devuelve el  valor maximo del array
static int VMax(int[] array){
    int max = array[0];
    foreach (int numero in array){
        if (numero > max){
            max = numero;
        }
    } 
    return max;
}  
// realiza la suma de los valores del array
static int Sum(int[] array){
    int sum = 0;
    foreach(int numero in array){
        sum += numero;
    }
    return sum;
}
Console.WriteLine("----------------------------");
// Lanzamiento de Moneda 

string moneda = TossCoin();
Console.WriteLine("Tirando la Moneda!");


static string TossCoin(){

    Random randomGenerator = new Random();
    int resultado = randomGenerator.Next(2);
    if(resultado == 0){
        return "Cara";
    }
    else{
        return"Cruz";
        }
}
Console.WriteLine("Resultado: " + moneda);

Console.WriteLine("----------------------------");

//opcional dobo arreglar no esta funcionando correctamente!

int num = 5;
double relacion = TossMultipleCoins(num);
Console.WriteLine("Relación de lanzamientos de cara: " + relacion);

static double TossMultipleCoins(int num){
    int contadorcaras = 0;
    for(int c = 0; c < num; c++){
        if(TossCoin() == "cara"){
            contadorcaras++;
        }
    }
    return (double)contadorcaras / num;
}   

Console.WriteLine("----------------------------");

// Nombres

// creo la lista con los nombres
List<string> nombres = new List<string>();
nombres.Add("Todd");
nombres.Add("Tiffany");
nombres.Add("Charlie");
nombres.Add("Ginebra");
nombres.Add("Sydney");

//creo la nueva lista y asigno el resultado de la función 
List<string> filtroNombres = FiltrarNombres(nombres);

        Console.WriteLine("Nombres con más de 5 caracteres:");
        //iteración
        foreach (string nombre in filtroNombres)
        {
            Console.WriteLine(nombre);
        }
// creo la función 
 static List<string> FiltrarNombres(List<string> nombres)
    {
        //creo la lista que almacena los nombres con mas de 5 caracteres
        List<string> filtroNombres = new List<string>();
    //iteración
        foreach (string nombre in nombres)
        {
            if (nombre.Length > 5)
            {
                filtroNombres.Add(nombre);
            }
        }

        return filtroNombres;
    }

    //opcional 




    
    
    
    








