using System.Data;

namespace DrawPoint {
    internal class Program {
        static void Main(string[] args) {
            //Create new instance of the Point class
            //Point[] points = new Point[20];

            //Point point1 = new(1, 1);
            //Point point2 = new(4, 4);

            //Line line = new Line(10, 10, 0, 0);

            //line = line.Perturb(2, 10, 30, 50);

            //line.Draw();

            //Point topLeft = new(2, 2);
            //Point topRight = new(9, 2);
            //Point btmLeft = new(2, 6);
            //Point btmRight = new(9, 6 );

            //Rectangle testangle = new Rectangle(topLeft, topRight, btmLeft, btmRight);

            //testangle.Draw();
            ////
            //testangle.Move(10,10);
            ////
            //testangle.Draw();
            ////

            //Polygon triangle = new Polygon(new(0, 0), new(17, 23), new(40, 12));

            string xEntry;
            string yEntry;
            string console;
            int tempX;
            int tempY;
            Point tempPoint = new(0,0);
            bool parser;
            bool closed;
            bool complete = false;

            LinkedList polygonList = new LinkedList();

            Console.WriteLine("Polygons!");

            for (int entry = 0; complete == false; entry++) {

                do {  //USER ENTERS EACH X 
                    xEntry = Input($"\nPoint #{entry + 1} X: ");
                    parser = int.TryParse(xEntry, out tempX);
                } while (parser == false);

                do {  //USER ENTERS EACH Y
                    yEntry = Input($"Point #{entry + 1} Y: ");
                    parser = int.TryParse(yEntry, out tempY);
                } while (parser == false);

                //STORE TO TEMPORARY POINT
                tempPoint = new(tempX, tempY);

                //ADD POINT TO LIST
                polygonList.Add(tempPoint);

                do {  //DECIDE TO ADD ANOTHER POINT
                    console = Input("\nEnter another point? (y/n) ");
                } while ((console.ToLower() != "y") && (console.ToLower() != "n"));

                if (console == "n") {
                    do {
                        console = Input("Close this polygon?");
                    } while (console.ToLower() != "n" && console.ToLower() != "y");
                    
                    if (console.ToLower() == "y") {
                        closed = true;
                    }
                    break;
                }
                Console.WriteLine();
            }

            Console.Clear();
            Polygon poly = new Polygon(polygonList);

            //poly.ToString();

                Console.ReadKey();

            //CREATE RANDOM POINTS AND STORE THEM TO THE ARRAY
            //for (int storeIndex = 0; storeIndex < points.Length; storeIndex++) {
            //    Point currentPoint = new Point(rand.Next(0, 16), rand.Next(0, 16));
            //    currentPoint.SetColor(255, 128, 000);
            //
            //    currentPoint.Color = new Hue(0, 0, 0);
            //
            //    points[storeIndex] = currentPoint;
            //}//end for


            //DRAW RANDOM POINTS IN THE ARRAY
            //for (int drawIndex = 0; drawIndex < points.Length; drawIndex++) {
            //    Point currentPoint = points[drawIndex];
            //    currentPoint.DrawPoint();
            //}//end for

        }//end main

        static string Input(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }//end class
}// end namespace