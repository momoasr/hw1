using System.IO;
using System;

namespace UserApp
{
    public class LoginHelper
    {
        const string USERNAME = "admin";
        const string PASSWORD = "admin";

        public bool ValidateCredentials(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            return username.Equals(USERNAME, System.StringComparison.InvariantCultureIgnoreCase)
                && password == PASSWORD;
        }

        public void LogAttemptToFile(string username, bool success)
        {
            try
            {
                var name = string.IsNullOrEmpty(username) ? "Anonymous" : username;
                var status = success ? "Success" : "Failed";
                var logText = $"{name} - {DateTime.Now} - login status: {status}";
                var filePath = "C:\\dev\\Monia\\dotnet\\hw1\\UserApp\\UserApp\\log.txt";
                StreamWriter sw = new StreamWriter(filePath, append: true);
                sw.WriteLine(logText);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
