using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace DynamicTestsLab
{
    public enum Methods
    {
        Parabola = 1,
        Trapezoid,
        MonteCarlo
    }
    public enum TestCaseType
    {
        Positive = 1,
        Negative
    }
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        TestCaseParameters testCase;
        List<double> oracleResult = new List<double>();
        List<double> integral3xResult = new List<double>();
        Methods currentMethod;
        TestCaseType testCaseType;

        List<TimeSpan> oracleTimer = new List<TimeSpan>();
        List<TimeSpan> integral3xTimer = new List<TimeSpan>();
        List<double> parabolEsps = new List<double>();
        List<double> MonteEsps = new List<double>();
        List<double> trapecEsps = new List<double>();

        private void StartButton_Click(object sender, EventArgs e)
        {
            oracleResult.Clear();
            integral3xResult.Clear();
            oracleTimer.Clear();
            integral3xTimer.Clear();
            parabolEsps.Clear();
            MonteEsps.Clear();
            trapecEsps.Clear();
            StartTests();
        }

        void StartTests()
        {

            try {
                ResultTextBox.Text = "";
                ResultTextBox.Text = "Началось тестирование с выбранными параметрами...\n";
                for (int i = 0; i != 3; ++i)
                {
                    oracleResult.Clear();
                    integral3xResult.Clear();
                    currentMethod = ReturnMethod(i);
                    testCaseType = ReturnCaseType();
                    testCase = new TestCaseParameters();
                    decimal leftBorder, rightBorder;
                    Decimal.TryParse(LeftBorderTextbox.Text, out leftBorder);
                    Decimal.TryParse(RightBorderTextbox.Text, out rightBorder);
                    testCase.Step = StepNumeric.Value;
                    testCase.LeftBorder = leftBorder;
                    testCase.RightBorder = rightBorder;
                    PolynomsTest(testCase, currentMethod, testCaseType);
                }
                ResultTextBox.Text += $"\nТесты завершены, результаты в таблице";
                ResultTextBox.SelectionStart = ResultTextBox.TextLength;
                ResultTextBox.ScrollToCaret();
            }
            catch
            {
                ResultTextBox.Text += "Произошла ошибка. Проверьте корректность введенных параметров\n";
            }
           
           
        }

        void PolynomsTest(TestCaseParameters testCase, Methods method, TestCaseType testCaseType)
        {
            double epsT = (double)this.epsTInput.Value;

                for (int i = 1; i <= 20; i++)
                {
                    testCase.Polynoms.Clear();
                    for (int j = 1; j <= i; j++)
                        testCase.Polynoms.Add(j);

                    oracleResult.Add(Oracle.OracleResult(testCase));
                    ResultTextBox.Text += "Результат вычислений с помощью 'Оракула': " + Math.Round(oracleResult[i-1], 5) + Environment.NewLine;

                    integral3xResult.Add(ResultOfIntgral3x.ResultFromIntegral3x(testCase, method));
                    ResultTextBox.Text += "Результат вычислений с помощью 'Integral3x': " + integral3xResult[i - 1] + Environment.NewLine;
                    
                    switch(method)
                    {
                        case Methods.Parabola:
                            {
                                parabolEsps.Add(Math.Round(Math.Abs(oracleResult[i - 1] - integral3xResult[i - 1]), 4));
                                break;
                            }
                        case Methods.Trapezoid:
                            {
                                trapecEsps.Add(Math.Round(Math.Abs(oracleResult[i - 1] - integral3xResult[i - 1]), 4));
                                break;
                            }
                        case Methods.MonteCarlo:
                            {
                                MonteEsps.Add(Math.Round(Math.Abs(oracleResult[i - 1] - integral3xResult[i - 1]), 4));
                                break;
                            }
                        default:
                            break;
                    }
                    
                    ResultTextBox.SelectionStart = ResultTextBox.TextLength;
                    ResultTextBox.ScrollToCaret();

                }

                ResultTextBox.Text += $"\nТест для метода " + method + " проведен успешно.\n\n";
                ResultTextBox.SelectionStart = ResultTextBox.TextLength;
                ResultTextBox.ScrollToCaret();

            BuildTableButton.Enabled = true;

        }

        Methods ReturnMethod(int methodNum)
        {
            if (methodNum == 0)
                return Methods.MonteCarlo;
            if (methodNum == 1)
                return Methods.Trapezoid;
            if (methodNum == 2)
                return Methods.Parabola;
            return Methods.MonteCarlo;
        }
        
        TestCaseType ReturnCaseType()
        {
                return TestCaseType.Positive;
        }

        private void BuildTableButton_Click(object sender, EventArgs e)
        {
            TableForm form = new TableForm(this.parabolEsps, this.trapecEsps, this.MonteEsps, (double)this.epsTInput.Value);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
