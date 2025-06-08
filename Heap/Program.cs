using System;

class Program
{
    static void Main()
    {
        var people = new People();
        people.Name = "Maria";
        people.Age = 30;

        Console.WriteLine($"Name: {people.Name}, Age: {people.Age}");
    }
}

public class People
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

// Comportamentos:
// 1. new People() -> cria um objeto na memória heap.
// 2. a var people -> cria um ponteiro(referência) na memória stack, apontando para a posição com os dados na memória heap.
// 3. people.Name = "Maria" e people.Age = 30 atribuem valores aos campos do objeto na heap.
// 4. Console.WriteLine(...) acessa os valores através da referência people, buscando os dados na heap.
// 3. Após o fim do escopo (Main), o ponteiro people é removida da Stack
// 4. O objeto na Heap se torna elegível para coleta pelo Garbage Collector

// +--------------------------------+
// |            Stack               |
// +--------------------------------+
// | people --> (referência) ---+   |
// |                            |   |
// +----------------------------|---+
//                              |
//                              v
//                  +-----------------------+
//                  |        Heap           |
//                  +-----------------------+
//                  | Objeto People         |
//                  | Nome = "Maria"        |
//                  | Idade = 30            |
//                  +-----------------------+
