using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    // A class to represent a space ship
    class SpaceShip
    {
        // The current position of the space ship
        public Point Position { get; set; }

        // The speed of the space ship
        public int Speed { get; set; }

        // The transform of the space ship
        public Transform Transform { get; set; }

        // Move the space ship in a given direction
        public void Move(string direction)
        {
            // Update the space ship's position based on the direction
            if (direction == "up")
            {
                Position.Y -= Speed;
            }
            else if (direction == "down")
            {
                Position.Y += Speed;
            }
            else if (direction == "left")
            {
                Position.X -= Speed;
            }
            else if (direction == "right")
            {
                Position.X += Speed;
            }

            // Update the space ship's transform
            Transform.position = new Vector3(Position.X, Position.Y, 0);
        }
    }

    public class GameManager : MonoBehaviour
    {
        // The space ship
        SpaceShip ship;

        void Start()
        {
            // Create a new space ship at position (0, 0) with a speed of 1
            ship = new SpaceShip()
            {
                Position = new Point() { X = 0, Y = 0 },
                Speed = 1,
                Transform = transform
            };
        }

        void Update()
        {
            // Check if the left mouse button was clicked
            if (Input.GetMouseButtonDown(0))
            {
                // Get the screen point of the mouse click
                var screenPoint = Input.mousePosition;

                // Convert the screen point to a world point
                var worldPoint = Camera.main.ScreenToWorldPoint(screenPoint);

                // Calculate the direction to move the space ship in
                var direction = "up";
                if (worldPoint.y < 0)
                {
                    direction = "down";
                }
                if (worldPoint.x < 0)
                {
                    direction = "left";
                }
                if (worldPoint.x > 0)
                {
                    direction = "right";
                }

                // Move the space ship in the calculated direction
                ship.Move(direction);
            }
        }
    }
}

