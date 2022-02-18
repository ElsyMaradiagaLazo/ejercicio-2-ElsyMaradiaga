namespace Ejercicio2ElsyMaradiaga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Ejercicio#2 Elsy Yohana Maradiaga lazo
        // cuenta:20191002864

        private void registrobutton1_Click(object sender, EventArgs e)
        {
            // Procedimiento 

            String[] ArregloNombre = new String[1];//Arreglo para poder guardar el nombre de cada estudiante
            int[] ArregloEdad = new int[1];//Arreglo para números que guardará la edad de cada estudiante

            int Edad = Convert.ToInt32(EdadtextBox2.Text);//convertiremos el int para poderlo usar dentro del arreglo
            for (int i = 0; i < ArregloNombre.Length; i++) //utilizaremos el for para poder llenar la listboxt

            {
                ArregloNombre[i] = Nombretextbox1.Text;//se llenará de acuerdo de los nombres que se ingrese con el i
                ArregloEdad[i] = Edad;//se registrará la edad
                //aquí ya se podrá llenar la listbox en uno solo
                listBox1.Items.Add(ArregloNombre[i] +"-"+ ArregloEdad[i]);
            }

        }
    }
}