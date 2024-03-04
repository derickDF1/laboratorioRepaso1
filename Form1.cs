using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorioRepaso1
{
    public partial class Form1 : Form
    {
        List<Empleado> empleados = new List<Empleado>();    //Cargar empleados
        List<AsistenciaEmpleado> asistencias = new List<AsistenciaEmpleado>();    //Cargar asistencias
        List<Reporte> reportes = new List<Reporte>(); //Cargar reportes de sueldo acumulado de los empleados
        public Form1()
        {
            InitializeComponent();
        }

        public void MostrarEmpleados()
        {
            //Mostrar la lista de empleados en el GridView
            dataGridViewEmpleado.DataSource = null;
            dataGridViewEmpleado.DataSource = empleados;
            dataGridViewEmpleado.Refresh();
        }

        public void MostrarAsistencias()
        {
            //Mostrar la lista de asistencias en el GridView
            dataGridViewAsistencia.DataSource = null;
            dataGridViewAsistencia.DataSource = asistencias;
            dataGridViewAsistencia.Refresh();
        }

        public void cargarAsistencia()
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "AsistenciaEmpleado.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //Leer los datos de un empleado
                AsistenciaEmpleado asistencia = new AsistenciaEmpleado();
                asistencia.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                asistencia.HorasMes = Convert.ToInt16(reader.ReadLine());
                asistencia.Mes = Convert.ToInt16(reader.ReadLine());
                asistencias.Add(asistencia);    //Guardar el empleado a la lista de asistencias
            }
            reader.Close();
            MostrarAsistencias();       //Mostrar la lista de asistencias en el GridView
        }

        public void cargarEmpleados()
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "Empleados.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //Leer los datos de un empleado
                Empleado empleado = new Empleado();
                empleado.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                empleado.NombreEmpleado = reader.ReadLine();
                empleado.SueldoHora = Convert.ToDecimal(reader.ReadLine());
                empleados.Add(empleado);    //Guardar el empleado a la lista de empleados
            }
            reader.Close();
            MostrarEmpleados();     //Mostrar la lista de empleados en el GridView
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            cargarEmpleados();      //Leer archivo Empleados.txt y mostrarlo en el GridView
            cargarAsistencia();     //Leer archivo AsistenciaEmpleados.txt y mostrarlo en el GridView
        }

        private void buttonCalcularSueldos_Click(object sender, EventArgs e)
        {
            foreach (Empleado empleado in empleados)
            {
                foreach (AsistenciaEmpleado asistencia in asistencias)
                {
                    if (empleado.NoEmpleado == asistencia.NoEmpleado)
                    {
                        Reporte reporte = new Reporte();
                        reporte.NombreEmpleado = empleado.NombreEmpleado;
                        reporte.Mes = asistencia.Mes;
                        reporte.SueldoMensual = empleado.SueldoHora * asistencia.HorasMes;
                        reportes.Add(reporte);
                    }
                }
            }
            //Cargar los datos en el datagridview
            dataGridViewReporteSueldos.DataSource = null;
            dataGridViewReporteSueldos.DataSource = reportes;
            dataGridViewReporteSueldos.Refresh();
        }
    }
}
