using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace application_calculator
{
    public partial class MainWindow : Window
    {
        double result = 0;
        double number_first, number_second;
        string operation = ""; //string.Empty

        bool isRadianMode = true;
        private double memoryValue = 0;
        private bool memoryHasValue = false;
        private bool altFunctionsEnabled = false;
        private int bracketLevel = 0;


        public MainWindow()
        {
            InitializeComponent();

            Width = 900;
            Height = 565;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            display_result.Text = "0";
            display_operation.Clear();
        }

        private void negate_Click(object sender, RoutedEventArgs e)
        {
            double number = double.Parse(display_result.Text);
            display_result.Text = Convert.ToString(-1 * number);
        }

        private void percent_Click(object sender, RoutedEventArgs e)
        {
            number_first = double.Parse(display_result.Text);
            display_result.Text = "";
            result = number_first / 100;
            display_result.Text = result.ToString();
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            number_first = double.Parse(display_result.Text);
            display_result.Text = "";
            operation = "/";

            display_operation.Text = $"{number_first} ÷ ";
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            number_first = double.Parse(display_result.Text);
            display_result.Text = "";
            operation = "*";

            display_operation.Text = $"{number_first} × ";
        }

        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            number_first = double.Parse(display_result.Text);
            display_result.Text = "";
            operation = "-";

            display_operation.Text = $"{number_first} - ";
        }

        private void addition_Click(object sender, RoutedEventArgs e)
        {
            number_first = double.Parse(display_result.Text);
            display_result.Text = "";
            operation = "+";

            display_operation.Text = $"{number_first} + ";
        }

        private void decimal_Click(object sender, RoutedEventArgs e)
        {
            // if there is a decimal point in the display box, then DO NOT add another one
            if (!display_result.Text.Contains("."))
            {
                string str = display_result.Text += ".";
                result = double.Parse(str);
            }
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            number_second = double.Parse(display_result.Text);

            switch (operation)
            {
                case "+":
                    result = number_first + number_second;
                    display_operation.Text = $"{number_first} + {number_second} =";
                    break;
                case "-":
                    result = number_first - number_second;
                    display_operation.Text = $"{number_first} - {number_second} =";
                    break;
                case "*":
                    result = number_first * number_second;
                    display_operation.Text = $"{number_first} × {number_second} =";
                    break;
                case "/":
                    if (number_second != 0)
                    {
                        result = number_first / number_second;
                        display_operation.Text = $"{number_first} ÷ {number_second} =";
                    }
                    else
                    {
                        display_operation.Text = $"{number_first} ÷ {number_second} =";
                        // TODO
                    }
                    break;
            }

            display_result.Text = result.ToString();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (display_result.Text == "0")
            {
                display_result.Clear();
            }

            Button button = (Button)sender;
            display_result.Text += 0.ToString();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (display_result.Text == "0")
            {
                display_result.Clear();
            }

            Button button = (Button)sender;
            display_result.Text += 1.ToString();
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (display_result.Text == "0")
            {
                display_result.Clear();
            }

            Button button = (Button)sender;
            display_result.Text += 2.ToString();
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (display_result.Text == "0")
            {
                display_result.Clear();
            }

            Button btn_one = (Button)sender;
            display_result.Text += 3.ToString();
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (display_result.Text == "0")
            {
                display_result.Clear();
            }

            Button btn_one = (Button)sender;
            display_result.Text += 4.ToString();
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (display_result.Text == "0")
            {
                display_result.Clear();
            }

            Button btn_one = (Button)sender;
            display_result.Text += 5.ToString();
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (display_result.Text == "0")
            {
                display_result.Clear();
            }

            Button btn_one = (Button)sender;
            display_result.Text += 6.ToString();
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (display_result.Text == "0")
            {
                display_result.Clear();
            }

            Button btn_one = (Button)sender;
            display_result.Text += 7.ToString();
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (display_result.Text == "0") display_result.Clear();

            Button btn_one = (Button)sender;
            display_result.Text += 8.ToString();
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (display_result.Text == "0")
            {
                display_result.Clear();
            }

            Button btn_one = (Button)sender;
            display_result.Text += 9.ToString();
        }

        private void random_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            double number_first = r.NextDouble();
            double number_second = r.NextDouble();

            display_result.Text = number_first.ToString();
            display_operation.Text = $"";

            display_result.Text = number_second.ToString();
            display_operation.Text = number_second.ToString();
        }

        private void pi_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "") display_result.Text = Math.PI.ToString();
            else
            {
                number_second = Math.PI;
                display_result.Text = Math.PI.ToString();
            }
        }

        private void radian_Click(object sender, RoutedEventArgs e)
        {
            isRadianMode = !isRadianMode;
            radian.Content = isRadianMode ? "RAD" : "DEG";
        }

        private void hyperbolic_sine_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double value))
            {
                result = Math.Sinh(value);
                display_operation.Text = $"sinh({value})";
                display_result.Text = result.ToString();
            }
        }

        private void hyperbolic_cosine_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double value))
            {
                result = Math.Cosh(value);
                display_operation.Text = $"cosh({value})";
                display_result.Text = result.ToString();
            }
            else display_result.Text = "Error";
        }

        private void hyperbolic_tangent_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double value))
            {
                result = Math.Tanh(value);
                display_operation.Text = $"tanh({value})";
                display_result.Text = result.ToString();
            }
            else display_result.Text = "Error";

        }

        private void factorial_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double value))
            {
                if (value >= 0 && value == Math.Floor(value))
                {
                    try
                    {
                        result = CalculateFactorial((int)value);
                        display_operation.Text = $"fact({value})";
                        display_result.Text = result.ToString();
                    }
                    catch (OverflowException)
                    {
                        display_result.Text = "Overflow";
                        display_operation.Text = $"fact({value})";
                    }
                }
                else
                {
                    display_result.Text = "Invalid Input";
                    display_operation.Text = "Factorial must be non-negative integer";
                }
            }
            else
            {
                display_result.Text = "Error";
            }
        }

        private double CalculateFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Negative factorial not defined");

            if (n == 0 || n == 1)
                return 1;

            double result = 1;
            checked // This will throw OverflowException if result is too large
            {
                for (int i = 2; i <= n; i++) result *= i;
            }
            return result;
        }

        private void sine_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(display_result.Text);
            result = isRadianMode ? Math.Sin(value) : Math.Sin(value * Math.PI / 180);
            display_result.Text = result.ToString();
            display_operation.Text = $"sin({value})";
        }

        private void cosine_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(display_result.Text);
            result = isRadianMode ? Math.Cos(value) : Math.Cos(value * Math.PI / 180);
            display_result.Text = result.ToString();
            display_operation.Text = $"cos({value})";
        }

        private void tangent_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double value))
            {
                if (isRadianMode) result = Math.Tan(value);

                else result = Math.Tan(value * Math.PI / 180);

                if (double.IsInfinity(result))
                {
                    display_result.Text = "Undefined";
                    display_operation.Text = $"tan({value})";
                }
                else
                {
                    display_result.Text = result.ToString();
                    display_operation.Text = $"tan({value})";
                }
            }
            else display_result.Text = "Error";
        }

        private void euler_number_Click(object sender, RoutedEventArgs e)
        {
            result = Math.E;
            display_operation.Text = "e";
            display_result.Text = result.ToString("0.###############");
        }

        private void exponential_notation_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double value))
            {
                display_result.Text = value.ToString("0.############E+0"); // Scientific notation
                display_operation.Text = $"{value} → Scientific";
            }
            else display_result.Text = "Error";
        }

        private void inverse_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double value))
            {
                if (value != 0)
                {
                    result = 1 / value;
                    display_operation.Text = $"1/({value})";
                    display_result.Text = result.ToString();
                }
                else
                {
                    display_result.Text = "Cannot divide by zero";
                    display_operation.Text = "1/(0)";
                }
            }
            else display_result.Text = "Error";
        }

        private void square_root_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double value))
            {
                if (value >= 0)
                {
                    result = Math.Sqrt(value);
                    display_operation.Text = $"√({value})";
                    display_result.Text = result.ToString();
                }
                else
                {
                    display_result.Text = "Invalid Input";
                    display_operation.Text = "√(x) requires x ≥ 0";
                }
            }
            else display_result.Text = "Error";
        }

        private void cube_root_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double value))
            {
                result = Math.Pow(value, 1.0 / 3); // Cbrt available in .NET Core 3.0+
                display_operation.Text = $"³√({value})";
                display_result.Text = result.ToString();
            }
            else display_result.Text = "Error";
        }

        private void nth_root_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number_first = double.Parse(display_result.Text);
                display_result.Text = "";
                operation = "root";
                display_operation.Text = $"{number_first}√(";
            }
            else if (operation == "root")
            {
                double degree = number_first;
                double radicand = double.Parse(display_result.Text);

                if (degree % 2 == 0 && radicand < 0)
                {
                    display_result.Text = "Invalid Input";
                    display_operation.Text = "Even root of negative";
                }
                else if (degree == 0)
                {
                    display_result.Text = "Undefined";
                    display_operation.Text = "0th root";
                }
                else
                {
                    result = Math.Pow(radicand, 1.0 / degree);
                    display_operation.Text = $"{degree}√({radicand})";
                    display_result.Text = result.ToString();
                }

                operation = "";
            }
        }

        private void natural_logarithm_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double value))
            {
                if (value > 0)
                {
                    result = Math.Log(value); // Natural logarithm (base e)
                    display_operation.Text = $"ln({value})";
                    display_result.Text = result.ToString("0.###############");
                }
                else
                {
                    display_result.Text = "Must be positive";
                    display_operation.Text = $"ln({value})";
                }
            }
            else display_result.Text = "Error";
        }

        private void logarithm_ten_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double value))
            {
                if (value > 0)
                {
                    result = Math.Log10(value); // Base-10 logarithm
                    display_operation.Text = $"log({value})";
                    display_result.Text = result.ToString("0.###############");
                }
                else
                {
                    display_result.Text = "Must be positive";
                    display_operation.Text = $"log({value})";
                }
            }
            else display_result.Text = "Error";
        }

        private void y_power_x_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number_first = double.Parse(display_result.Text);
                display_result.Text = "";
                operation = "y^x";
                display_operation.Text = $"{number_first}^(";
            }
            else if (operation == "y^x")
            {
                number_second = double.Parse(display_result.Text);

                // Handle special cases
                if (number_first == 0 && number_second <= 0)
                {
                    display_result.Text = "Undefined";
                    display_operation.Text = $"{number_first}^{number_second}";
                }
                else
                {
                    result = Math.Pow(number_first, number_second);
                    display_operation.Text = $"{number_first}^{number_second}";
                    display_result.Text = result.ToString();
                }

                operation = "";
            }
        }

        private void two_power_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double exponent))
            {
                result = Math.Pow(2, exponent);
                display_operation.Text = $"2^({exponent})";
                display_result.Text = result.ToString();
            }
            else display_result.Text = "Error";
        }

        private void alt_functions_Click(object sender, RoutedEventArgs e)
        {
            altFunctionsEnabled = !altFunctionsEnabled;
            alt_functions.Background = altFunctionsEnabled ? Brushes.LightBlue : Brushes.Transparent;
        }

        private void square_power_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double x))
            {
                result = x * x;
                display_operation.Text = $"({x})²";
                display_result.Text = result.ToString("0.###############");
            }
            else
            {
                display_result.Text = "Error";
            }
        }

        private void cube_power_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double x))
            {
                result = x * x * x;
                display_operation.Text = $"({x})³";
                display_result.Text = result.ToString("0.###############");
            }
            else
            {
                display_result.Text = "Error";
            }
        }

        private void x_power_y_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                // First operand (x)
                number_first = double.Parse(display_result.Text);
                operation = "x^y";
                display_operation.Text = $"{number_first}^";
                display_result.Text = "";
            }
            else if (operation == "x^y")
            {
                // Second operand (y)
                double y = double.Parse(display_result.Text);

                // Special cases
                if (number_first == 0 && y <= 0)
                {
                    display_result.Text = "Undefined";
                }
                else if (number_first < 0 && Math.Floor(y) != y)
                {
                    display_result.Text = "Complex";
                }
                else
                {
                    result = Math.Pow(number_first, y);
                    display_operation.Text = $"{number_first}^{y} =";
                    display_result.Text = result.ToString("0.###############");
                }
                operation = "";
            }
        }

        private void euler_number_power_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double exponent))
            {
                try
                {
                    result = Math.Exp(exponent);
                    display_operation.Text = $"e^({exponent})";

                    // Format output for very large/small numbers
                    if (Math.Abs(result) > 1e10 || Math.Abs(result) < 1e-10)
                        display_result.Text = result.ToString("0.###############E+0");
                    else
                        display_result.Text = result.ToString("0.###############");
                }
                catch (OverflowException)
                {
                    display_result.Text = "Overflow";
                    display_operation.Text = $"e^({exponent})";
                }
            }
            else
            {
                display_result.Text = "Error";
            }
        }

        private void ten_power_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double exponent))
            {
                try
                {
                    result = Math.Pow(10, exponent);
                    display_operation.Text = $"10^({exponent})";

                    // Scientific notation for large/small results
                    display_result.Text = result.ToString("0.###############E+0");
                }
                catch (OverflowException)
                {
                    display_result.Text = exponent > 0 ? "∞" : "0";
                    display_operation.Text = $"10^({exponent})";
                }
            }
            else
            {
                display_result.Text = "Error";
            }
        }

        private void left_bracket_Click(object sender, RoutedEventArgs e)
        {
            // If current display is "0" or an operator was just pressed
            if (display_result.Text == "0" || operation != "")
            {
                display_operation.Text += "(";
                display_result.Text = "0"; // Reset for new input inside brackets
            }
            else
            {
                // If we're in the middle of a number, add multiplication
                if (display_result.Text != "0")
                {
                    display_operation.Text += display_result.Text + "×(";
                    display_result.Text = "0";
                }
                else
                {
                    display_operation.Text += "(";
                }
            }
            bracketLevel++; // Track nesting level
        }

        private void right_bracket_Click(object sender, RoutedEventArgs e)
        {
            if (bracketLevel > 0)
            {
                // Add current number to the operation before closing bracket
                display_operation.Text += display_result.Text + ")";

                // Evaluate the expression inside the brackets
                try
                {
                    string expression = display_operation.Text;
                    result = EvaluateExpression(expression);
                    display_result.Text = result.ToString();
                }
                catch
                {
                    display_result.Text = "Error";
                }

                bracketLevel--;
            }
            else
            {
                display_result.Text = "Mismatched )";
            }
        }

        private double EvaluateExpression(string expression)
        {
            // Simple expression evaluator - consider using DataTable.Compute or a proper parser
            return Convert.ToDouble(new System.Data.DataTable().Compute(expression, null));
        }

        private void memory_clear_Click(object sender, RoutedEventArgs e)
        {
            memoryValue = 0;
            memoryHasValue = false;

            // Visual feedback
            memory_clear.Background = Brushes.Transparent;
            memory_add.Background = Brushes.Transparent;
            memory_subtract.Background = Brushes.Transparent;

            // Optional: Update status display
            UpdateMemoryStatus();
        }

        private void memory_add_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double currentValue))
            {
                memoryValue += currentValue;
                memoryHasValue = true;

                // Visual feedback
                memory_add.Background = Brushes.LightGreen;

                // Optional: Show brief confirmation
                display_operation.Text = "M+ " + currentValue.ToString();
                UpdateMemoryStatus();
            }
        }

        private void memory_subtract_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(display_result.Text, out double currentValue))
            {
                memoryValue -= currentValue;
                memoryHasValue = true;

                // Visual feedback
                memory_subtract.Background = Brushes.LightPink;

                // Optional: Show brief confirmation
                display_operation.Text = "M- " + currentValue.ToString();
                UpdateMemoryStatus();
            }
        }

        private void UpdateMemoryStatus()
        {
            // change button appearance
            memory_clear.IsEnabled = memoryHasValue;
        }
    }
}