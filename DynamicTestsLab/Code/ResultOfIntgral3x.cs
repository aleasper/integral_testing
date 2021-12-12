using System.Diagnostics;

namespace DynamicTestsLab
{

    class ResultOfIntgral3x
    {
        static double resultOfCalculation = 0;
        static ProcessStartInfo cmdProp = new ProcessStartInfo
        {
            FileName = @"C:\Windows\System32\cmd.exe",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            RedirectStandardInput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        public static double ResultFromIntegral3x(TestCaseParameters testCase, Methods methodOfCalculation)
        {
            resultOfCalculation = 0;
            Process processCmd = new Process();

            string polynoms = string.Empty;
            for (int i = 0; i < testCase.Polynoms.Count - 1; i++)
                polynoms += testCase.Polynoms[i] + " ";
            polynoms += testCase.Polynoms[testCase.Polynoms.Count-1];

            processCmd.StartInfo = cmdProp;
            processCmd.OutputDataReceived += OutputDataRecieved;
            processCmd.EnableRaisingEvents = true;

            processCmd.Start();
            processCmd.BeginOutputReadLine();
            processCmd.BeginErrorReadLine();

            string inputOfConsole = $"Integral3x.exe {testCase.LeftBorder} {testCase.RightBorder} {testCase.Step} {(int)methodOfCalculation} {polynoms}";
            processCmd.StandardInput.WriteLine(inputOfConsole);
                    
            processCmd.StandardInput.WriteLine(" exit");
            processCmd.WaitForExit();
            return resultOfCalculation;
        }

        static void OutputDataRecieved(object sender, DataReceivedEventArgs eventArgs)
        {
            double num = 0;
            if (!string.IsNullOrEmpty(eventArgs.Data))
            {
                string data = eventArgs.Data.Replace("S", "").Replace("=", "").Replace(" ", "").Replace(".", ",");
                if (double.TryParse(data, out num))
                    resultOfCalculation = num;
            }
        }
    }
}
