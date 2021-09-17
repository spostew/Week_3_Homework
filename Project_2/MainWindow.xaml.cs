/*
 * Project_2: This program will calculate how much change is returned from a vending machine after a dollar has been entered.
 * Name: Spencer Unitt
 * Module: Homework 3, Project 2
 * Problem Statement: Return the remainder of change in each coin after an item has been bought from a vending machine
 * 
 * Algorithm: 
 *  1. Create a text box that prompts the user for the cost of the item they wish to pay for.
 *  2. When a button below the textbox is clicked, do the following
 *      2a. Create a variable that takes in the number from the textBox
 *      2b. Create variables for each coin with the appropriate value. And variables named (the coin)_amount. These will hold the remainder.
 *      2c. Subtract 100 (a dollar) from the cost of the item
 *      2d. Use the following two equations for each coin
 *          coin_amount = change / coin_value
 *          change = change - (coin_value * coin_amount)
 *      2e. In a seperate textBlock return the amount each coin will be given based on the value the user enters.
 *  3. Have a spot for the text to display when the user clicks the approprate button. 
 *  4. Create an exit button that when clicked will close the program for the user. *   
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

namespace Project_2
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

        private void recieve_Change_Click(object sender, RoutedEventArgs e)
        {
            // Variables used throughout 
            int change = int.Parse(change_insert.Text);
            // Holds the value of each coin
            int quarter = 25, nickle = 5, dime = 10;
            // Holds the remainder and total intial cost
            int quarter_amount, dime_amount, nickle_amount, penny_amount, total_cost = change;

            // Calculates the starting balance
            change = 100 - change;
            // Determines the remainder
            quarter_amount = change / 25;
            // Updates the current balance and repeats until it reaches 0
            change -= quarter * quarter_amount;
            dime_amount = change / 10;
            change -= dime * dime_amount;
            nickle_amount = change / 5;
            change -= nickle * nickle_amount;
            penny_amount = change;

            // Returns the values of everything and displays to user in a TextBlock
            return_Change.Text = "The item cost " + total_cost + " cents.\n"
                            + "After inserting a dollar you will recieve the following change.\n\n"
                            + "Quarters: " + quarter_amount.ToString() + "\n" 
                            + "Dimes: " + dime_amount.ToString() + "\n" 
                            + "Nickles: " + nickle_amount.ToString() + "\n"
                            + "Pennies: " + penny_amount.ToString();
                   
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Closes the program if user clicks this button
            this.Close();
        }
    }
}
