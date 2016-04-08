using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8._2_Petrol_Bots
{
    public class Ship
    {
        const int FUEL_CAPACITY = 10;
        const int WIDTH = 20;
        const int HEIGHT = 20;
        Brush shipColour;

        Point currentPosition;
        Point destination;

        Random random;
        int Fuel { get; set; }

        public Ship()
        {
            random = new Random();
            shipColour = Brushes.CadetBlue;
            Fuel = FUEL_CAPACITY;
        }

        public void Update()
        {
            Move();
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(shipColour, currentPosition.X, currentPosition.Y, WIDTH, HEIGHT);
        }

        public void Move()
        {
            //if the ship has reached its destination, obtain a new destination.
            if (currentPosition.X == destination.X && currentPosition.Y == destination.Y)
            {
                NewDestination();
            }
            else
            {
                //if the ship has not reached its x destination, navigate one closer
                if (currentPosition.X != destination.X)
                {
                    if (currentPosition.X < destination.X)
                    {
                        currentPosition.X++;
                    }
                    else { currentPosition.X--; }
                }

                //if the ship has not reached its y destination, navigate one closer
                if (currentPosition.Y != destination.Y)
                {
                    if (currentPosition.Y < destination.Y)
                    {
                        currentPosition.Y++;
                    }
                    else { currentPosition.Y--; }
                }

                //the ship has moved x, y, or both: decrement fuel.
                Fuel--;
            }          
        }

        public void NewDestination()
        {          
            destination.X = random.Next(0, 200);
            destination.Y = random.Next(0, 200);
        }
    }
}
