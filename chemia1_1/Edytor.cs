using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace chemia1_1
{
    public partial class Edytor : Form
    {
        
         Dictionary<string, Produkty> dict;
        public Edytor()
        {
            InitializeComponent();
            dict = new Dictionary<string, Produkty>();
            LoadBaza();
        }

        private void LoadBaza()
        {
            dict.Clear();
            FileStream fs = new FileStream("Produkty.dat", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                dict = (Dictionary<string, Produkty>)bf.Deserialize(fs);
                txtNazwaEdytor.AutoCompleteCustomSource.AddRange(dict.Keys.ToArray());
                lstNazwa.Items.AddRange(dict.Keys.ToArray());


             //   string[] strKod = new string[dict.Count];
             //   int i = 0;

             //   foreach (KeyValuePair<string, Produkty> rekord in dict)
             //   {
              //      strKod[i] = rekord.Value.kod;
             //       i++;

                   

                    // int key = pair.Key;

            //    }
            //    txtKodEdytor.AutoCompleteCustomSource.AddRange(strKod);
          //  lstNazwa.Items.AddRange(strKod);


            }
            catch(Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
            fs.Close();


        }


        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("Produkty.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, dict);
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void WyczyscPola()
        {
            txtNazwaEdytor.Text = null;
            txtOpisEdytor.Text = null;
            txtDzialanieEdytor.Text = null;
            txtZastosowanieEdytor.Text = null;
            txtKodEdytor.Text = null;
            txtRyzykoEdytor.Text = null;

        }

        private void btnDodajDoBazy_Click(object sender, EventArgs e)
        {
            Produkty pr = new Produkty();
            if (dict.TryGetValue(txtNazwaEdytor.Text, out pr) == false)
            {
                Produkty p = new Produkty();

                p.opis = txtOpisEdytor.Text;
                p.dzialanie = txtDzialanieEdytor.Text;
                p.zastosowanie = txtZastosowanieEdytor.Text;
                p.kod = txtKodEdytor.Text;
                p.ryzyko = txtRyzykoEdytor.Text;
                dict.Add(txtNazwaEdytor.Text, p);
            }
           else
            {
                DialogResult dlg;
                dlg=MessageBox.Show("Taki rekord istnieje. Czy chcesz go zaktualizować?","info",MessageBoxButtons.YesNo);
                //aktualizacja
                if (dlg == DialogResult.Yes)
                {
                    dict.Remove(txtNazwaEdytor.Text);
                    Produkty p = new Produkty();

                    p.opis = txtOpisEdytor.Text;
                    p.dzialanie = txtDzialanieEdytor.Text;
                    p.zastosowanie = txtZastosowanieEdytor.Text;
                    p.kod = txtKodEdytor.Text;
                    p.ryzyko = txtRyzykoEdytor.Text;
                    dict.Add(txtNazwaEdytor.Text, p);
                    WyczyscPola();
                }
            }
        }



        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                dict.Remove(txtNazwaEdytor.Text);
                txtNazwaEdytor.AutoCompleteCustomSource.AddRange(dict.Keys.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadBaza_Click(object sender, EventArgs e)
        {

        }

        private Produkty FindRekord(string key)
        {
            Produkty p = new Produkty();
            p = dict[key];
            return p;

        }

        private void txtNazwaEdytor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Produkty p = new Produkty();
                p = FindRekord(txtNazwaEdytor.Text);
                txtOpisEdytor.Text = p.opis;
                txtDzialanieEdytor.Text = p.dzialanie;
                txtZastosowanieEdytor.Text = p.zastosowanie;
                txtKodEdytor.Text = p.kod;
                txtRyzykoEdytor.Text=p.ryzyko;
            }
            catch
            {
                txtOpisEdytor.Text = null;
                txtDzialanieEdytor.Text = null;
                txtZastosowanieEdytor.Text = null;
                txtKodEdytor.Text = null;
                txtRyzykoEdytor.Text=null;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        //znajdowanie klucza do rekordu
        private string FindKeyforRecord(string kod)
        {
            string klucz="";
            
            foreach (KeyValuePair<string, Produkty> rekord in dict)
            {
                if(rekord.Value.kod==kod)
                {
                    klucz = rekord.Key;
                    break;
                }
            }
                return klucz;

        }

        private void txtKodEdytor_TextChanged(object sender, EventArgs e)
        {
           /* string key;
            try
            {
                key = FindKeyforRecord(txtKodEdytor.Text);

                txtNazwaEdytor.Text = key;
                Produkty p = new Produkty();
                p = FindRekord(key);

                txtOpisEdytor.Text = p.opis;
                txtDzialanieEdytor.Text = p.dzialanie;
                txtZastosowanieEdytor.Text = p.zastosowanie;
                txtKodEdytor.Text = p.kod;
                txtRyzykoEdytor.Text = p.ryzyko;
            }
            catch
            {
                txtOpisEdytor.Text = null;
                txtDzialanieEdytor.Text = null;
                txtZastosowanieEdytor.Text = null;
                txtKodEdytor.Text = null;
                txtRyzykoEdytor.Text = null;
            }*/

        }

        private void lstNazwa_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(lstNazwa.SelectedItem.ToString());
            try
            {
                Produkty p = new Produkty();
                txtNazwaEdytor.Text = lstNazwa.SelectedItem.ToString();
                p = FindRekord(lstNazwa.SelectedItem.ToString());
                txtOpisEdytor.Text = p.opis;
                txtDzialanieEdytor.Text = p.dzialanie;
                txtZastosowanieEdytor.Text = p.zastosowanie;
                txtKodEdytor.Text = p.kod;
                txtRyzykoEdytor.Text = p.ryzyko;
            }
            catch
            {
                txtOpisEdytor.Text = null;
                txtDzialanieEdytor.Text = null;
                txtZastosowanieEdytor.Text = null;
                txtKodEdytor.Text = null;
                txtRyzykoEdytor.Text = null;
            }

        }

        private void txtRyzykoEdytor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
