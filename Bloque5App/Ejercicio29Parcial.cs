using System;

class Ejercicio29Parcial
{
    public static void Ejecutar()
    {
        char[,] tablero = new char[3,3];
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                tablero[i,j] = ' ';

        char jugador = 'X';
        int turnos = 0;
        bool ganador = false;

        while (!ganador && turnos < 9)
        {
    
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" " + tablero[i,0] + " | " + tablero[i,1] + " | " + tablero[i,2]);
                if (i < 2) Console.WriteLine("---+---+---");
            }

            Console.Write("Jugador " + jugador + ", fila (0-2): ");
            int fila = int.Parse(Console.ReadLine());
            Console.Write("Jugador " + jugador + ", columna (0-2): ");
            int col = int.Parse(Console.ReadLine());

            if (tablero[fila,col] == ' ')
            {
                tablero[fila,col] = jugador;
                turnos++;

                for (int i = 0; i < 3; i++)
                {
                    if (tablero[i,0]==jugador && tablero[i,1]==jugador && tablero[i,2]==jugador) ganador=true;
                    if (tablero[0,i]==jugador && tablero[1,i]==jugador && tablero[2,i]==jugador) ganador=true;
                }
                if (tablero[0,0]==jugador && tablero[1,1]==jugador && tablero[2,2]==jugador) ganador=true;
                if (tablero[0,2]==jugador && tablero[1,1]==jugador && tablero[2,0]==jugador) ganador=true;

                jugador = (jugador == 'X') ? 'O' : 'X';
            }
            else
            {
                Console.WriteLine("Casilla ocupada, intenta otra vez.");
            }
        }

        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(" " + tablero[i,0] + " | " + tablero[i,1] + " | " + tablero[i,2]);
            if (i < 2) Console.WriteLine("---+---+---");
        }

        if (ganador)
            Console.WriteLine("Ganó jugador " + ((jugador=='X') ? 'O' : 'X'));
        else
            Console.WriteLine("Empate!");
    }
}
