﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void kapcsolatLetrehozas()
        {
            //Kapcsolat létrehozása
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "cs_harcosok";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            conn.Open();
            sql = conn.CreateCommand();
        }
        private void kapcsolatBontas()
        {
            conn.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                kapcsolatLetrehozas();
                
                sql.CommandText = @"CREATE TABLE IF NOT EXISTS `harcosok` ( 
                                    `id` INT NOT NULL AUTO_INCREMENT , 
                                    `nev` VARCHAR(128) NOT NULL , 
                                    `letrehozas` DATETIME NOT NULL ,
                                    PRIMARY KEY (`id`), 
                                    UNIQUE (`nev`)) ENGINE = InnoDB;";
                sql.ExecuteNonQuery();
                sql.CommandText = @"CREATE TABLE IF NOT EXISTS `kepessegek` ( 
                                    `id` INT NOT NULL AUTO_INCREMENT , 
                                    `nev` VARCHAR(128) NOT NULL , 
                                    `leiras` VARCHAR(500) NOT NULL , 
                                    `harcos_id` INT NOT NULL , 
                                    PRIMARY KEY (`id`),
                                    FOREIGN KEY (`harcos_id`) REFERENCES harcosok(`id`))
                                    ENGINE = InnoDB;";
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Adatkapcsolati hiba");
                return;
            }
            hasznaloComboFeltolt();
            kapcsolatBontas();
        }

        private void hasznaloComboFeltolt()
        {
            hasznaloComboBox.Items.Clear();
            sql.CommandText = "SELECT nev FROM harcosok;";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    hasznaloComboBox.Items.Add(dr.GetString("nev"));
                }
            }
        }

        private void btnHarcosLetrehozas_Click(object sender, EventArgs e)
        {
            kapcsolatLetrehozas();
            string nev = harcosNeveTextBox.Text.Trim();
            if (nev == "")
            {
                MessageBox.Show("Adja meg a harcos nevét!");
                harcosNeveTextBox.Focus();
                return;
            }
            string query = "SELECT * FROM harcosok WHERE nev = '" + nev+"'";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                MySqlDataReader reader = command.ExecuteReader();
                
                if (!reader.HasRows)
                {
                    var datum = DateTime.Now.ToString("yyyy-MM-dd ");
                    
                    reader.Close();
                    sql.CommandText = "INSERT INTO harcosok (`nev`, `letrehozas`) VALUES ('" + nev + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                    sql.ExecuteNonQuery();
                    harcosNeveTextBox.Clear();
                    MessageBox.Show("Sikeres harcos felvétel!");
                    harcosNeveTextBox.Focus();
                    hasznaloComboFeltolt();
                }
                else
                {
                    MessageBox.Show("Ilyen nevű harcos már létezik!");
                    harcosNeveTextBox.Focus();
                }
                
            }
                        
                    kapcsolatBontas();
             
                        


        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {

        }
    }
}
