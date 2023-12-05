using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_ornek_2_847
{
    public partial class Form1 : Form
    {
        List<string> kisiler = new List<string>();
        int İndexSira = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisiler.Add("hayrunnisa");
            kisiler.Add("kübra");
            kisiler.Add("sukeyna");
            kisiler.Add("rabia");
            kisiler.Add("deniz");

            listBox1.DataSource = kisiler.ToList();
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            kisiler.Add(txtKisiEkle.Text);

            listBox1.DataSource = kisiler.ToList(); //ListBox güncelle
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtKisiEkle.Text);
            if (durum)
            {
                MessageBox.Show("aradığınız kişi mevcut");
            }
            else
            {
                MessageBox.Show("aradığınız kişi mevcut değil");
            }
        }

        private void btnSira_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtKisiEkle.Text);
            if (sira > -1)
            {
                MessageBox.Show(txtKisiEkle.Text + " " + sira + ". sırasındadır.");
            }
            else
            {
                MessageBox.Show(txtKisiEkle.Text + " sıralamada yok ");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtKisiEkle.Text);
            if (sira > -1)
            {
                kisiler.RemoveAt(sira); //RemoveAt -> belirtilen index sırasındaki değeri siler.
            }

            listBox1.DataSource = kisiler.ToList(); //ListBox güncelle
        }

        private void btnRemoveİleSilme_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtKisiEkle.Text);
            if (durum)
            {
                kisiler.Remove(txtKisiEkle.Text); //kişi adı ile silme
            }

            listBox1.DataSource = kisiler.ToList(); //ListBox güncelle
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKisiEkle.Text = listBox1.SelectedValue.ToString();
            İndexSira = listBox1.SelectedIndex;
            //ListBox içindeki sırasını veriyor.
            //Aynı sıralama List(kisiler) içinde geçerli
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(İndexSira.ToString());
            kisiler[İndexSira] = txtKisiEkle.Text;

            listBox1.DataSource = kisiler.ToList(); //ListBox güncelle
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kisiler.Sort();

            listBox1.DataSource = kisiler.ToList(); //ListBox güncelle
        }

        private void btnAzalan_Click(object sender, EventArgs e)
        {
            kisiler.Sort();
            kisiler.Reverse();

            listBox1.DataSource = kisiler.ToList(); //ListBox güncelle

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Length == 5)
                {
                    sayac++;
                }
            }
            MessageBox.Show("5 karakterli :" + sayac + " tane öğrenci mevcut");
        }

        private void btnOgrenciler_Click(object sender, EventArgs e)
        {

            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i][0] == 'M' )
                {
                    sayac++;
                }
            }
            MessageBox.Show("m karakterli :" + sayac + " tane öğrenci mevcut");
        }

        private void btnBaslayan_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for(int i = 0; i < kisiler.Count; i++)
            {
                string kisi = kisiler[i];
                if (kisi[kisi.Length-1] == 'a')
                {
                    sayac++;
                }
            }
            MessageBox.Show("son harfi a karakterli :" + sayac + " tane öğrenci mevcut");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            kisiler.Clear();
            listBox1.DataSource = kisiler.ToList(); //ListBox güncelle
        }
    }
}    