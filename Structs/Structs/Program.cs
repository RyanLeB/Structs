using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        // Unity example
        struct Vector3
        {
            public float x;
            public float y;
            public float z;
        }
        
        struct Vector4
        {
            public float w;
            public float x;
            public float y;
            public float z;
        }

        struct Point2D
        {
            public int x;
            public int y;
        }
        
        static void Main(string[] args)
        {

            Vector3 position;
            position.x = 0.0f;
            position.y = 0.0f;
            position.z = 0.0f;
            
            Console.WriteLine("Structs");
            Console.WriteLine();



            // player
            // int score = 0;
            // int health = 100;
            // int shield = 100;
            // int playerX = 10;
            // int playerY = 10;


            // 1000 enemies
            // int numEnemies = 1000;
            // int[] enemyX = new int[numEnemies];
            // int[] enemyY = new int[numEnemies];


            // player
            int score = 0;
            int health = 100;
            int shield = 100;
            //  int playerX = 10;
            //  int playerY = 10;
            Point2D playerPosition;
            playerPosition.x = 10;
            playerPosition.y = 10;


            // 1000 enemies
            int numEnemies = 1000;
            Point2D[] enemyPosition = new Point2D[numEnemies];
            // loop
            for (int i = 0; i < numEnemies; i++)
            {
                enemyPosition[i].x = 10;
                enemyPosition[i].y = 10;    
            }






            // no structs
            // no classes (objects)



            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
