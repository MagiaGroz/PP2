﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3

{

    public abstract class GameObject

    {

        public List<Point> body = new List<Point>();

        public char sign;



        public GameObject()

        {



        }

        public GameObject(char sign)

        {

            this.sign = sign;

        }



        public void Draw()

        {

            foreach (Point p in body)

            {

                Console.SetCursorPosition(p.X, p.Y);

                Console.Write(sign);

            }

        }

        public void Clear()

        {

            foreach (Point p in body)

            {

                Console.SetCursorPosition(p.X, p.Y);

                Console.Write(' ');

            }

        }

    }

}