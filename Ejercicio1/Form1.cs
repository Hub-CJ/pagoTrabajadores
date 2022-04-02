using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class HubCJ : Form
    {
        CEmpleado objempleado = null;
        public HubCJ()
        {
            InitializeComponent();
            llenarComboCategorias();
            configurarListaEmpleados();
        }
        void llenarComboCategorias()
        {
            //comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList; //para que no se pueda modificar el combobox, tambien se puede desde propiedades
            comboCategoria.Items.Add("A");
            comboCategoria.Items.Add("B");
            comboCategoria.Items.Add("C");
            comboCategoria.Items.Add("D");
        }
        void configurarListaEmpleados()
        {
            listView1.View = View.Details; //para que aparezaca un empleado por linea 
            listView1.GridLines = true; //para que se vean las lineas
            listView1.Columns.Add("Empleado", 200); //añadimos a titulos de la tabla de nuestro listviw
            listView1.Columns.Add("Categoria", 70);
            listView1.Columns.Add("Minutos tardanza", 100);
            listView1.Columns.Add("Llamadas atencio", 100);
            listView1.Columns.Add("Pago"); //si no le pongo tamaño, sera automatico
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if(textNombre.Text !="" && textTardanza.Text!="" &&
                textAtencion.Text != "" && comboCategoria.SelectedIndex != -1)
            {
                objempleado= new CEmpleado();
                objempleado.Nombres = textNombre.Text;
                objempleado.Tardanza = Convert.ToInt32(textTardanza.Text);
                objempleado.Categoria = comboCategoria.Text;
                objempleado.Atencion = Convert.ToInt32(textAtencion.Text);

                ListViewItem fila = new ListViewItem(objempleado.Nombres); //creamos un objeto fila que permitira agregar filas al listviw
                fila.SubItems.Add(objempleado.Categoria);
                fila.SubItems.Add(objempleado.Tardanza.ToString());
                fila.SubItems.Add(objempleado.Atencion.ToString());
                fila.SubItems.Add(objempleado.calcularPago().ToString());//añadimos datos a nuestro objeto fila
                listView1.Items.Add(fila); //escribimos en el listviw
                labelNumEmpleados.Text = listView1.Items.Count.ToString(); //cueta cuantas filas tenemos en nuestro listviw
                textAtencion.Clear();
                textTardanza.Clear();
                textNombre.Clear();
                comboCategoria.SelectedIndex = -1; //para que el combobox se borre
                textNombre.Focus();//para que el cursos vuelva al textbox nombre
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textAtencion.Clear();
            textTardanza.Clear();
            textNombre.Clear();
            comboCategoria.SelectedIndex = -1; //para que el combobox se borre
            textNombre.Focus();//para que el cursos vuelva al textbox nombre
        }

        private void textAtencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) //solo si es diferente a dijistos y controles 
                e.Handled = true; //activare Handeled que impedira ingresar datos
            //OTRA FORMA DE HACER
            //if (Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            //    e.Handled = false;
            //else
            //    e.Handled = true;
        }

        private void textTardanza_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textTardanza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
