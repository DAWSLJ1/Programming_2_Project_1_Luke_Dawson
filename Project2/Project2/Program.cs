namespace Project2
{
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
            string selectedCategory;
            using(Category categoryForm = new Category())
            {
                if (categoryForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                selectedCategory = categoryForm.SelectedCategory;
            }
            Application.Run(new Form1(selectedCategory));
        }
    }
}