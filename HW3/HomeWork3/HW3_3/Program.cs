namespace HW3_3
{

    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithFile workingWithFile = new WorkingWithFile();
            workingWithFile.ReadingEmailFromFile();
            workingWithFile.WriteEmailInTxtFile("email");
        }

        
    }
}
