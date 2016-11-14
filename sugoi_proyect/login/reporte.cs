using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class reporte : Form
    {
        public reporte()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 5;
            progressBar1.Step = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"C:\Users\g_ric\Desktop\"+nombre_pdf.Text+".pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Reporte de Empleados");
            doc.AddCreator("SUGOI-EASYSOFT COMPANY");

            // Abrimos el archivo
            doc.Open();
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Reporte de Empleados"));
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(7);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell cltel = new PdfPCell(new Phrase("Telefono", _standardFont));
            cltel.BorderWidth = 0;
            cltel.BorderWidthBottom = 0.75f;

            PdfPCell cldir = new PdfPCell(new Phrase("Direccion", _standardFont));
            cldir.BorderWidth = 0;
            cldir.BorderWidthBottom = 0.75f;

            PdfPCell clemail = new PdfPCell(new Phrase("Email", _standardFont));
            clemail.BorderWidth = 0;
            clemail.BorderWidthBottom = 0.75f;

            PdfPCell clhrs = new PdfPCell(new Phrase("Horas de Trabajo", _standardFont));
            clhrs.BorderWidth = 0;
            clhrs.BorderWidthBottom = 0.75f;

            PdfPCell clturno = new PdfPCell(new Phrase("Turno", _standardFont));
            clturno.BorderWidth = 0;
            clturno.BorderWidthBottom = 0.75f;

            PdfPCell clantig = new PdfPCell(new Phrase("Antiguedad", _standardFont));
            clantig.BorderWidth = 0;
            clantig.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(cltel);
            tblPrueba.AddCell(cldir);
            tblPrueba.AddCell(clemail);
            tblPrueba.AddCell(clhrs);
            tblPrueba.AddCell(clturno);
            tblPrueba.AddCell(clantig);
            progressBar1.PerformStep();
            // Llenamos la tabla con información

            try
            {
                MySqlCommand sql = null;
                sql = new MySqlCommand();

                //Indicamos el Query a ejecutar por el commando;
                sql.CommandText = "sp_get_report();";
                sql.Connection = Bd.ObtenerConexion();


                MySqlDataReader consulta;

                //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader
                consulta = sql.ExecuteReader();

                while (consulta.Read())
                {
                    clNombre = new PdfPCell(new Phrase(consulta.GetString(0), _standardFont));
                    clNombre.BorderWidth = 0;
                  
                    cltel = new PdfPCell(new Phrase(consulta.GetString(1), _standardFont));
                    cltel.BorderWidth = 0;

                    cldir = new PdfPCell(new Phrase(consulta.GetString(2), _standardFont));
                    cldir.BorderWidth = 0;
                   
                    clemail = new PdfPCell(new Phrase(consulta.GetString(3), _standardFont));
                    clemail.BorderWidth = 0;
                  
                    clhrs = new PdfPCell(new Phrase(consulta.GetString(4), _standardFont));
                    clhrs.BorderWidth = 0;              

                    clturno = new PdfPCell(new Phrase(consulta.GetString(5), _standardFont));
                    clturno.BorderWidth = 0;
                    
                    clantig = new PdfPCell(new Phrase(consulta.GetString(6), _standardFont));
                    clantig.BorderWidth = 0;
                       // Añadimos las celdas a la tabla
                    tblPrueba.AddCell(clNombre);
                    tblPrueba.AddCell(cltel);
                    tblPrueba.AddCell(cldir);
                    tblPrueba.AddCell(clemail);
                    tblPrueba.AddCell(clhrs);
                    tblPrueba.AddCell(clturno);
                    tblPrueba.AddCell(clantig);
                }
                progressBar1.PerformStep();

            }
            catch(Exception ex) { MessageBox.Show("Error: " + ex.ToString()); }

            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);
            progressBar1.PerformStep();
            doc.Close();
            writer.Close();
            progressBar1.PerformStep();
            MessageBox.Show("PDF generado con exito, se guadro en la ruta C:/Users/g_ric/Desktop/"+nombre_pdf.Text+".pdf");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_admon admon = new main_admon();
            this.Hide();
            admon.Show();

        }
    }
}
