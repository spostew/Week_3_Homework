/*
 * Project_1: This program will have the user enter in a monthly payment and total loan price. It will return the cost that will cost to 
 *            interest and the amount that will go to the principal.
 * Name: Spencer Unitt
 * Module: Homework_3, Project 1
 * Problem Statement: Create a program that will display a monthly morgtage payment after recieving the payment and total loan amount
 * 
 * Algorithm
 *  1. Create a const varible that holds the interest amount in decimal format. Store the interest rate inside
 *  2. Create two variables that will parse the data from the textBoxes in the GUI. One should hold the payment value, the other
 *     should hold the total loan amount
 *  3. Use the following equation to determine the interest amount
 *     monthly_interest = loan * (1 + interest_rate * 1). subtract this total by the loan amount
 *  4. Subtract the payment by the monthly interest and store in a variable for the principal amount
 *  5. Display the amount that will go to the interest rate and the amount that goes to the pricipal
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generate_amount_left_Click(object sender, RoutedEventArgs e)
        {
            // Creates a variable that can't be changed set to the interest rate converted to deciaml format
            const double interest_rate = 6.39 / 100;

            // Gets the values in the textBoxes
            double payment = Double.Parse(monthly_Payment.Text);
            double debt = Double.Parse(amount_Owed.Text);
            
            // Calculates the monthly interest
            double monthly_interest = debt * (1 + interest_rate * 1);
            monthly_interest -= debt;

            // Calculates the amount that goes to principal
            double monthly_principal = payment - monthly_interest;

            // Displays the results
            amount_To_Interest.Text = "$" + monthly_interest.ToString();
            amount_To_Principal.Text = "$" + monthly_principal.ToString();

        }

        
    }
}
