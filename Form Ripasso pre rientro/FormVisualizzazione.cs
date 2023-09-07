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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_Ripasso_pre_rientro
{
    public partial class FormVisualizzazione : Form
    {
		public string path, pathTEMP;
		Funzioni f;
		public FormVisualizzazione()
		{
			InitializeComponent();
			path = @"rota.csv";
			f = new Funzioni();
		}
		#region Funzioni evento
		private void FormVisualizzazione_Load(object sender, EventArgs e)
		{
			if (f.ContaCampi(path) == 9)
				checkBoxMioValore.Visible = false;
			else
				checkBoxMioValore.Visible = true;
		}
		private void checkBoxMunicipio_Click(object sender, EventArgs e)
		{
			int n = NumeroCheckedBox();
			if (n > 3)
			{
				MessageBox.Show("Puoi selezionare al massimo 3 campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				checkBoxMunicipio.Checked = false;
			}
			else if (n > 0)
			{
				Visualizza(path);
			}
			else
				listViewVisualizza.Clear();
		}
		private void checkBoxZoneUrbane_Click(object sender, EventArgs e)
		{
			int n = NumeroCheckedBox();
			if (n > 3)
			{
				MessageBox.Show("Puoi selezionare al massimo 3 campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				checkBoxZoneUrbane.Checked = false;
			}
			else if (n > 0)
			{
				Visualizza(path);
			}
			else
				listViewVisualizza.Clear();
		}
		private void checkBoxRione_Click(object sender, EventArgs e)
		{
			int n = NumeroCheckedBox();
			if (n > 3)
			{
				MessageBox.Show("Puoi selezionare al massimo 3 campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				checkBoxRione.Checked = false;
			}
			else if (n > 0)
			{
				Visualizza(path);
			}
			else
				listViewVisualizza.Clear();
		}
		private void checkBoxQuartiere_Click(object sender, EventArgs e)
		{
			int n = NumeroCheckedBox();
			if (n > 3)
			{
				MessageBox.Show("Puoi selezionare al massimo 3 campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				checkBoxQuartiere.Checked = false;
			}
			else if (n > 0)
			{
				Visualizza(path);
			}
			else
				listViewVisualizza.Clear();
		}
		private void checkBoxSubUrbio_Click(object sender, EventArgs e)
		{
			int n = NumeroCheckedBox();
			if (n > 3)
			{
				MessageBox.Show("Puoi selezionare al massimo 3 campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				checkBoxSubUrbio.Checked = false;
			}
			else if (n > 0)
			{
				Visualizza(path);
			}
			else
				listViewVisualizza.Clear();
		}
		private void checkBoxZoneAgro_Click(object sender, EventArgs e)
		{
			int n = NumeroCheckedBox();
			if (n > 3)
			{
				MessageBox.Show("Puoi selezionare al massimo 3 campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				checkBoxZoneAgro.Checked = false;
			}
			else if (n > 0)
			{
				Visualizza(path);
			}
			else
				listViewVisualizza.Clear();
		}
		private void checkBoxBorgate_Click(object sender, EventArgs e)
		{
			int n = NumeroCheckedBox();
			if (n > 3)
			{
				MessageBox.Show("Puoi selezionare al massimo 3 campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				checkBoxBorgate.Checked = false;
			}
			else if (n > 0)
			{
				Visualizza(path);
			}
			else
				listViewVisualizza.Clear();
		}
		private void checkBoxExMunicipi_Click(object sender, EventArgs e)
		{
			int n = NumeroCheckedBox();
			if (n > 3)
			{
				MessageBox.Show("Puoi selezionare al massimo 3 campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				checkBoxExMunicipi.Checked = false;
			}
			else if (n > 0)
			{
				Visualizza(path);
			}
			else
				listViewVisualizza.Clear();
		}
		private void checkBoxEtichetta_Click(object sender, EventArgs e)
		{
			int n = NumeroCheckedBox();
			if (n > 3)
			{
				MessageBox.Show("Puoi selezionare al massimo 3 campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				checkBoxEtichetta.Checked = false;
			}
			else if (n > 0)
			{
				Visualizza(path);
			}
			else
				listViewVisualizza.Clear();
		}
		private void checkBoxMioValore_Click(object sender, EventArgs e)
		{
			int n = NumeroCheckedBox();
			if (n > 3)
			{
				MessageBox.Show("Puoi selezionare al massimo 3 campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				checkBoxMioValore.Checked = false;
			}
			else if (n > 0)
			{
				Visualizza(path);
			}
			else
				listViewVisualizza.Clear();
		}
		#endregion
		#region Funzioni Servizio
		private int NumeroCheckedBox()
		{
			int n = 0;
			if (checkBoxMunicipio.Checked == true)
				n++;
		    if (checkBoxZoneUrbane.Checked == true)
				n++;
			if (checkBoxRione.Checked == true)
				n++;
			if (checkBoxQuartiere.Checked == true)
				n++;
			if (checkBoxSubUrbio.Checked == true)
				n++;
			if (checkBoxZoneAgro.Checked == true)
				n++;
			if (checkBoxBorgate.Checked == true)
				n++;
			if (checkBoxExMunicipi.Checked == true)
				n++;
			if (checkBoxEtichetta.Checked == true)
				n++;
			if (checkBoxMioValore.Checked == true)
				n++;
			return n;
		}
		private void Visualizza(string path)
		{
			listViewVisualizza.Clear();
			int nCampi = f.ContaCampi(path);
			int[] check = new int[nCampi];
			for (int i = 0; i < nCampi; i++)
				check[i] = 0;
			if (checkBoxMunicipio.Checked == true)
				check[0] = 1;
			if (checkBoxZoneUrbane.Checked == true)
				check[1] = 1;
			if (checkBoxRione.Checked == true)
				check[2] = 1;
			if (checkBoxQuartiere.Checked == true)
				check[3] = 1;
			if (checkBoxSubUrbio.Checked == true)
				check[4] = 1;
			if (checkBoxZoneAgro.Checked == true)
				check[5] = 1;
			if (checkBoxBorgate.Checked == true)
				check[6] = 1;
			if (checkBoxExMunicipi.Checked == true)
				check[7] = 1;
			if (checkBoxEtichetta.Checked == true)
				check[8] = 1;
			if (nCampi > 9)
				if (checkBoxMioValore.Checked == true)
					check[9] = 1;
			string[] items = f.NomeCampi(path);
			listViewVisualizza.View = View.Details;
			listViewVisualizza.GridLines = true;
			using (StreamReader sr = File.OpenText(path))
			{
				string line;

				for (int i = 0; i < nCampi; i++)
				{
					if (check[i] == 1)
						listViewVisualizza.Columns.Add(items[i], listViewVisualizza.Width / NumeroCheckedBox(), HorizontalAlignment.Center);
				}
				line = sr.ReadLine();
				while ((line = sr.ReadLine()) != null)
				{
					string[] fields = line.Split(';');
					if (nCampi == 11)
					{
						if (fields[10] == "0")
						{
							ListViewItem newItem = new ListViewItem();
							bool first = false;
							for (int i = 0; i < nCampi; i++)
							{
								if (check[i] == 1 && !first)
								{
									newItem.Text = fields[i];
									first = true;
								}
								else if (check[i] == 1)
									newItem.SubItems.Add(fields[i]);
							}
							listViewVisualizza.Items.Add(newItem);
						}
					}
					else
					{
						ListViewItem newItem = new ListViewItem();
						bool first = false;
						for (int i = 0; i < nCampi; i++)
						{
							if (check[i] == 1 && !first)
							{
								newItem.Text = fields[i];
								first = true;
							}
							else if (check[i] == 1)
								newItem.SubItems.Add(fields[i]);
						}
						listViewVisualizza.Items.Add(newItem);
					}
				}
				sr.Close();
			}
		}
	}
		#endregion
}
