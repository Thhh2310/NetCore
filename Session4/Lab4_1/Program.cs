namespace Lab4_1
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Khởi tạo lớp window
            Window win = new Window(1, 2);

            //Khởi tạo listbox
            ListBox lb = new ListBox(3, 4, "Stand alone list box");

            //Khởi tạo lớp button
            Button b = new Button(5, 6);
            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();

            //Khởi tạo bằng Window
            Window[] winArray = new Window[3];
            winArray[0] = new Window(1, 2);
            winArray[1] = new ListBox(3, 4, "List box array");
            winArray[2] = new Button(5, 6);
            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }
        }
    }
}