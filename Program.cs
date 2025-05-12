using System.Runtime.InteropServices;
using System.Security.Cryptography;

Console.Clear(); // Comando para limpar todo o terminal antes de iniciar o programa.

int naipe = RandomNumberGenerator // Gerador de número aleatório.
    .GetInt32(1,5); // Vai gerar um número de 1 a 5.
string nomeNaipe = "";

// Método mais simplificado abaixo: 

// string nomeNaipe = naipe switch{
//     1 => "Paus",
//     2 => "Espada",
//     3 => "Copas",
//     4 => "Ouros"
// };

// => (igual e seta significa, Arrow function).

switch (naipe)
{
    case 1:
        nomeNaipe = "Paus";
        break;
    case 2:
        nomeNaipe = "Espada";
        break;
    case 3:
        nomeNaipe = "Copas";
        break;
    case 4:
        nomeNaipe = "Ouros";
        break;
}

Console.WriteLine(nomeNaipe); // Retorna um valor aleatório para o usuário.