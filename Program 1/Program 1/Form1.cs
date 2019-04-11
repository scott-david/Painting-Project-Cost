// Grading ID: C1891
// Program 1
// Due Date: 2/14/17
// CIS 199-75
// This program is intended to let the user enter the total wall space, coats desired,
// and the price of the paint. When the user clicks the calculate button, they will see the 
// total cost of the painting project, along with labor and several other variables. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        // I accidentally double clicked this label
        private void outputCostOfPaintLabel_Click(object sender, EventArgs e)
        {

        }
        // this will allow the user to press the exit button if they will to close the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        //this will allow the user to clear all labels and textboxes in case they want to change their numbers
        private void clearButton_Click(object sender, EventArgs e)
        {
            outputCostOfLaborLabel.Text = "$0.00";
            outputCostOfPaintLabel.Text = "$0.00";
            outputGallonsRequiredLabel.Text = "0";
            outputHoursOfLaborLabel.Text = "0";
            outputTotalToBePaintedLabel.Text = "0";
            wallSpaceTextBox.Text = "";
            coatsOfPaintTextBox.Text = "";
            priceOfPaintTextBox.Text = "";
            outputTotalCostLabel.Text = "$0.00";
        }
        // this will allow the user to see the total cost of their painting project
        private void button1_Click(object sender, EventArgs e)
        {
            const decimal payPerHour = 10.50m; // this is a constant value for how much the company charges per hour for labor
            const int sqFtPerGallon = 330; // this is the constant for how much square footage can be covered by each gallon of paint
            const int hrsLaborPerGallon = 6; // this is a constant for how long it takes 330 sq ft to be covered

            float wallSpace; // this is the square feet of wall space to be painted, which the user inputs
            int coatsDesired; // this is how many coats the user wants, as an int
            float totalWallPainted; // this is so we can reference it to the outputTotalToBePaintedLabel

            wallSpace = float.Parse(wallSpaceTextBox.Text);
            coatsDesired = int.Parse(coatsOfPaintTextBox.Text);
            totalWallPainted = wallSpace * coatsDesired;
            outputTotalToBePaintedLabel.Text = totalWallPainted.ToString("n1");
            

            decimal gallonsRequired; // placeholder so I can Parse the outputTotalToBePaintedLabel 
            decimal totalGallonsNeeded; // this is the total amount of paint that is needed for the project (gallons)

            gallonsRequired = decimal.Parse(outputTotalToBePaintedLabel.Text);
            totalGallonsNeeded = Math.Ceiling(gallonsRequired / sqFtPerGallon);
            outputGallonsRequiredLabel.Text = totalGallonsNeeded.ToString();

            
            float totalHours; // this is the total hours that it will take to complete the painting project
            float gallonsToHours; // depending on the gallons used, gives us the total labor output

            gallonsToHours = float.Parse(outputGallonsRequiredLabel.Text);
            totalHours = float.Parse(outputHoursOfLaborLabel.Text);
            totalHours = gallonsToHours * hrsLaborPerGallon;

            outputHoursOfLaborLabel.Text = totalHours.ToString();

            decimal paintCost; // this is how much the paint costs per gallon
            decimal totalPaintCost; // this is the total cost of the paint

            paintCost = decimal.Parse(priceOfPaintTextBox.Text);
            totalPaintCost = paintCost * totalGallonsNeeded;

            outputCostOfPaintLabel.Text = (totalPaintCost.ToString("c"));
            
            decimal laborCost; // this is how much labor costs per hour
            decimal totalLaborCost; // this is the total cost of labor for the project

            laborCost = decimal.Parse(outputHoursOfLaborLabel.Text);
            totalLaborCost = laborCost * payPerHour;

            outputCostOfLaborLabel.Text = (totalLaborCost.ToString("c"));

            decimal totalCost; // this is the total cost for the whole project, labor and paint included

            totalCost = totalLaborCost + totalPaintCost;
            outputTotalCostLabel.Text = (totalCost.ToString("C"));




        }
    }
}
