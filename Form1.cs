
namespace ola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncrearfichero_Click(object sender, EventArgs e)
        {
            StreamWriter fichero;
            fichero = File.CreateText("C:\\Users\\Usuario\\Documents\\fichero.txt");
            fichero.WriteLine("Hola, picate la cola");
            fichero.Write("negro");
            fichero.Write("\r\n");
            fichero.WriteLine("fin");
            fichero.Close();
        }

        private void btnformados_Click(object sender, EventArgs e)
        {
            using (StreamWriter fichero = new StreamWriter("fichero1.txt"))
            {
                fichero.WriteLine("Este codigo es mas compacto");
                fichero.WriteLine("Pancho");
                fichero.WriteLine("villa");
            }
        }

        private void btnleerarchivo_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("fichero.txt");
            linea = fichero.ReadLine();
            Console.WriteLine(linea);
            Console.WriteLine(fichero.ReadLine());
            Console.WriteLine(fichero.ReadLine());
            fichero.Close();
        }

        private void btnleerarchivo4_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            fichero = File.OpenText("fichero.txt");
            while (!fichero.EndOfStream)
            {
                Console.WriteLine(fichero.ReadLine());
                fichero.Close();
            }
        }
    }
}
