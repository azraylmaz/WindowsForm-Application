//*****************************************************************************************************
//*******                                                                                       *******
//*******              STUDENT NAME            : AZRA YILMAZ                                    *******
//*******              STUDENT NUMBER          : B221202032                                     *******
//*****************************************************************************************************


using System.Windows.Forms;

namespace B221202032
{
    class Point2D
    {
        public int _x;
        public int _y;
        public double _r;
        public double _theta;
      
        private static readonly Random random = new Random();
        

        // default constructor with no parameters
        public Point2D()
        {
            _x = random.Next(4); //  range: 0 to 3 for x
            _y = random.Next(4); //  range: 0 to 3 for y
        }

        // constructor setting initial 2D coordinates with random x and y values
        public Point2D(int x, int y)
        {
            _x = x;
            _y = y;
        }

        // print coordinates method
        public void printCoordinates()
        {
            Console.WriteLine("(" + _x + "," + _y + ")");
        }

        // calculate polar coordinates method
        public void calculatePolarCoordinates()
        {
            _r = Math.Sqrt(_x * _x + _y * _y);
            _theta = Math.Atan2(_y, _x);

        }

        // calculate cartesian coordinates method
        public void calculateCartesianCoordinates()
        {
            _x = (int)(_r * Math.Cos(_theta));
            _y = (int)(_r * Math.Sin(_theta));
        }

        // print polar coordinates method
        public void printPolarCoordinates()
        {
            Console.WriteLine("(" + _r + ", " + _theta + ")");
        }

    }

    class Polygon
    {
        public Point2D _center;
        public int _length;
        public int _numberOfEdges;
        public double startAngle = 0;
        public int _rotationAngle;
        private static readonly Random random = new Random();
        
        // fields
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public int NumberOfEdges
        {
            get { return _numberOfEdges; }
            set { _numberOfEdges = value; }
        }

        // default constructor with no parameters
        public Polygon()
        {
            _center = new Point2D();
            _length = random.Next(3, 10); // Example range for length: 3 to 9
            _numberOfEdges = random.Next(3, 11); // Example range for number of edges: 3 to 10
            _rotationAngle = random.Next(0, 360); // Example range for rotation angle : 0 to 359
        }

        // constructor with initial center and radius as parameters
        public Polygon(Point2D center, int length)
        {
            _center = center;
            _length = length;
            _numberOfEdges = random.Next(3, 11); //  range for number of edges: 3 to 10
            _rotationAngle = random.Next(0, 360); //  range for rotation angle : 0 to 359
        }

        // generic list for calculating edge coordinates
        public List<Coordinates> calculateEdgeCoordinates()
        {
            
            // calculate the angle increment between each vertex
            double angleIncrement = 2 * Math.PI / _numberOfEdges;

            // calculate the distance from the center to each vertex
            double distance = _length / (2 * Math.Sin(Math.PI / _numberOfEdges));
            
            var coorList = new List<Coordinates>();            

            // Calculate the coordinates of each vertex
            for (int i = 0; i < _numberOfEdges; i++)
            {
                // Calculate the angle of the current vertex
                double angle = startAngle + i * angleIncrement;  

                // Calculate the x and y coordinates using polar coordinates
                double x = _center._x + distance * Math.Cos(angle);
                double y = _center._y + distance * Math.Sin(angle);

                coorList.Add(new Coordinates { x = x, y = y, vertex= $"Vertex {i + 1}: ({x}, {y})" });
            }

            return coorList;
        }

        // generic list for rotating polygon
        public List<Coordinates> rotatePolygon()
        {
            // calculate the rotation angle in radians
            double rotationAngleRad = _rotationAngle * Math.PI / 180;

            // calculate the angle increment between each vertex
            double angleIncrement = 2 * Math.PI / _numberOfEdges;

            // reset the start angle before each rotation
            startAngle -= rotationAngleRad;

            var coorList = new List<Coordinates>();

            // calculate and print the coordinates of the vertexes after rotation
            for (int i = 0; i < _numberOfEdges; i++)
            {
                // Calculate the angle of the current vertex
                double angle = startAngle + i * angleIncrement;

                // Calculate the x and y coordinates using polar coordinates
                double x = _center._x + _length * Math.Cos(angle);
                double y = _center._y + _length * Math.Sin(angle);

                // Rotate the coordinates around the center using rotation matrix
                double newX = _center._x + ((x - _center._x) * Math.Cos(rotationAngleRad) - (y - _center._y) * Math.Sin(rotationAngleRad));
                double newY = _center._y + ((x - _center._x) * Math.Sin(rotationAngleRad) + (y - _center._y) * Math.Cos(rotationAngleRad));

                coorList.Add(new Coordinates { x = newX, y = newY, vertex = $"Vertex {i + 1}: ({newX}, {newY})" });
            }
            return coorList;
        }


    }

    // a public class to keep coordinates
    public class Coordinates
    {
        // properties
        public double x { get; set; }
        public double y { get; set; }

        public string vertex { get; set; }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}