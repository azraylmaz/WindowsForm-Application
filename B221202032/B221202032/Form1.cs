//*****************************************************************************************************
//*******                                                                                       *******
//*******              STUDENT NAME            : AZRA YILMAZ                                    *******
//*******              STUDENT NUMBER          : B221202032                                     *******
//*****************************************************************************************************


using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace B221202032
{
    public partial class Form1 : Form
    {
        private Polygon polygon;
        private static readonly Random random = new Random();
       
        List<Coordinates> coorList = new List<Coordinates>(); 

        public Form1()
        {
            InitializeComponent();
            InitializePolygon();

            // default values appear when we start the project
            txtCenterX.Text = "0";
            txtCenterY.Text = "0";
            txtLength.Text = "4";
            txtNumberOfEdge.Text = "5";
            txtRotationAngle.Text = "30";
        }

        private void InitializePolygon()
        {
            // create a polygon object with random values
            polygon = new Polygon();
        }

        private void WritetoListBox()
        {

            // clear the listBox
            listBox1.Items.Clear();

           
            coorList = polygon.calculateEdgeCoordinates();  //calculate the edge coordinates
           
            foreach (var coor in coorList)
            {
                listBox1.Items.Add(coor.vertex);  //add edge coordinates to the ListBox
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSetRandomValues_Click(object sender, EventArgs e)
        {


            // declare random values
            Point2D center = new Point2D();
            int length = random.Next(3, 10); // range for length: 3 to 9
            int numberOfEdges = random.Next(3, 11); //  range for number of edges: 3 to 10
            int rotationAngle = random.Next(0, 360); // range for rotation angle : 0 to 359

            // create a polygon object with the random values
            polygon = new Polygon(center, length);
            polygon._numberOfEdges = numberOfEdges;
            polygon._rotationAngle = rotationAngle;

            // assign values that declared randomly 
            txtCenterX.Text = polygon._center._x.ToString();
            txtCenterY.Text = polygon._center._y.ToString();
            txtLength.Text = polygon._length.ToString();
            txtNumberOfEdge.Text = polygon._numberOfEdges.ToString();
            txtRotationAngle.Text = polygon._rotationAngle.ToString();

            // clear the ListBox
            listBox1.Items.Clear();
            // clear the coordinates list
            coorList.Clear();
            // nullify the pictureBox1 to redraw with an empty polygon
            pictureBox1.Invalidate();


        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // we can assign values and draw the polygon according to our values
            polygon._center._x = int.Parse(txtCenterX.Text);
            polygon._center._y = int.Parse(txtCenterY.Text);
            polygon._length = int.Parse(txtLength.Text);
            polygon._numberOfEdges = int.Parse(txtNumberOfEdge.Text);

            
            pictureBox1.Invalidate();   // nullify the pictureBox1 to redraw with an empty polygon
            WritetoListBox();  // write vertexes to listBox when Draw button is clicked

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // draw the coordinate plane in black
            Pen blackPen = new Pen(Color.Black);
            int halfWidth = pictureBox1.Width / 2;
            int halfHeight = pictureBox1.Height / 2;
            e.Graphics.DrawLine(blackPen, halfWidth, 0, halfWidth, pictureBox1.Height); // Vertical line of the plane
            e.Graphics.DrawLine(blackPen, 0, halfHeight, pictureBox1.Width, halfHeight); // Horizontal line of the plane

            // draw the polygon in red
            if (coorList.Count > 2)  // if number of edge is smaller than 2, it draws nothing
            {
                Pen redPen = new Pen(Color.Red);
                for (int i = 1; i < coorList.Count; i++)
                {
                    Point startP = new Point(halfWidth + (int)(coorList[i - 1].x * 10), halfHeight - (int)(coorList[i - 1].y * 10));  // I multiplied by 10 in order to enlarge the polygon...
                    Point finishP = new Point(halfWidth + (int)(coorList[i].x * 10), halfHeight - (int)(coorList[i].y * 10));
                    e.Graphics.DrawLine(redPen, startP, finishP);
                }

                // draw the last point to the first point to close the polygon
                Point lastP = new Point(halfWidth + (int)(coorList.Last().x * 10), halfHeight - (int)(coorList.Last().y * 10));
                Point firstP = new Point(halfWidth + (int)(coorList.First().x * 10), halfHeight - (int)(coorList.First().y * 10));
                e.Graphics.DrawLine(redPen, lastP, firstP);
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            // clear the listBox
            listBox1.Items.Clear();

            // update the rotation angle from the textbox
            polygon._rotationAngle = int.Parse(txtRotationAngle.Text);

            // rotate the polygon and get the updated coordinates
            coorList = polygon.rotatePolygon();

            // populate the listBox with the new vertex coordinates
            foreach (var coor in coorList)
            {
                listBox1.Items.Add(coor.vertex);
            }
       
            pictureBox1.Invalidate();  // nullify the pictureBox1 to redraw with an empty polygon
            WritetoListBox();  // write vertexes to the listBox when Draw button is clicked

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
