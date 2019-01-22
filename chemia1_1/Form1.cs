using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace chemia1_1
{
    public partial class Form1 : Form
    {

        Dictionary<string, Produkty> dict;
        public Form1()
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
                txtNazwa.AutoCompleteCustomSource.AddRange(dict.Keys.ToArray());


                string[] strKod = new string[dict.Count];
                int i = 0;

                foreach (KeyValuePair<string, Produkty> rekord in dict)
                {
                    strKod[i] = rekord.Value.kod;
                    i++;
                    // int key = pair.Key;

                }
                txtKod.AutoCompleteCustomSource.AddRange(strKod);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            fs.Close();
            

        }
     

        private Produkty FindRekordKey(string key)
        {
            Produkty p = new Produkty();
            p = dict[key];
            return p;

        }

        private void txtNazwa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Produkty p = new Produkty();
                p = FindRekordKey(txtNazwa.Text);
                txtOpis.Text = p.opis;
                txtDzialanie.Text = p.dzialanie;
                txtZastosowanie.Text = p.zastosowanie;
                txtKod.Text = p.kod;
            }
            catch
            {
                txtOpis.Text = null;
                txtDzialanie.Text = null;
                txtZastosowanie.Text = null;
                txtKod.Text = null;
            }

        }

        private void btnEdytor_Click(object sender, EventArgs e)
        {
            Edytor dlg = new Edytor();

            dlg.ShowDialog();
        }

        private Produkty FindRekord(string key)
        {
            Produkty p = new Produkty();
            p = dict[key];
            return p;

        }

        //znajdowanie klucza do rekordu
        private string FindKeyforRecord(string kod)
        {
            string klucz = "";

            foreach (KeyValuePair<string, Produkty> rekord in dict)
            {
                if (rekord.Value.kod == kod)
                {
                    klucz = rekord.Key;
                    break;
                }
            }
            return klucz;

        }

        private void txtKod_TextChanged(object sender, EventArgs e)
        {
            string key;
            try
            {
                key = FindKeyforRecord(txtKod.Text);

                txtNazwa.Text = key;
                Produkty p = new Produkty();
                p = FindRekord(key);

                txtOpis.Text = p.opis;
                txtDzialanie.Text = p.dzialanie;
                txtZastosowanie.Text = p.zastosowanie;
                txtKod.Text = p.kod;
              //  txtRyzyko.Text = p.ryzyko;
            }
            catch
            {
              //  txtOpis.Text = null;
              //  txtDzialanie.Text = null;
              //  txtZastosowanie.Text = null;
              //  txtKod.Text = null;
             //   txtRyzykoEdytor.Text = null;
            }
        }
    }
}
