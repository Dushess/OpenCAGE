﻿/*
 * 
 * Created by Matt Filer
 * www.mattfiler.co.uk
 * 
 */

using Alien_Isolation_Mod_Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackagingTool
{
    public partial class Landing : Form
    {
        string behaviourDirectory = Directory.GetCurrentDirectory() + @"\Behaviour Tree Directory\"; //Our working dir for BehaviourPacker
        string attributeDirectory = Directory.GetCurrentDirectory() + @"\Attribute Editor Directory\"; //Our working dir for CharEd
        string gameDirectory = ""; //Our game's dir, set on form load

        public Landing()
        {
            InitializeComponent();
        }

        //On Load
        private void Landing_Load(object sender, EventArgs e)
        {
            /* CREATE REQUIRED FOLDERS */
            Directory.CreateDirectory(behaviourDirectory);
            Directory.CreateDirectory(attributeDirectory);

            /* CREATE SETTINGS FILE */
            if (!File.Exists(Directory.GetCurrentDirectory() + @"\modtools_settings.ayz"))
            {
                File.WriteAllText(Directory.GetCurrentDirectory() + @"\modtools_settings.ayz", "1\n0\n1"); //Write default settings
            }

            /* SET GAME FOLDER */
            bool hasThrownError = false;
            if (!File.Exists(Directory.GetCurrentDirectory() + @"\modtools_locales.ayz"))
            {
                //Check if user has followed tutorial
                if (File.Exists(Directory.GetCurrentDirectory() + @"\AI.exe"))
                {
                    File.WriteAllText(Directory.GetCurrentDirectory() + @"\modtools_locales.ayz", Directory.GetCurrentDirectory()); //Write new file
                }
                else
                {
                    MessageBox.Show("Please locate your Alien: Isolation executable (AI.exe).");
                    OpenFileDialog selectGameFile = new OpenFileDialog();
                    if (selectGameFile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(Directory.GetCurrentDirectory() + @"\modtools_locales.ayz", Path.GetDirectoryName(selectGameFile.FileName)); //Write new file
                    }
                    else
                    {
                        hasThrownError = true;
                    }
                }
            }
            gameDirectory = File.ReadAllText(Directory.GetCurrentDirectory() + @"\modtools_locales.ayz"); //Set our game's dir

            /* VALIDATE GAME DIRECTORY */
            if (!File.Exists(gameDirectory + @"\DATA\BINARY_BEHAVIOR\_DIRECTORY_CONTENTS.BML") || hasThrownError)
            {
                MessageBox.Show("Please ensure you have selected the correct game install location. Missing files!");
                File.Delete(Directory.GetCurrentDirectory() + @"\modtools_locales.ayz");
                openBehaviourTreePackager.Enabled = false;
                openCharEd.Enabled = false;
            }

            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        //Open BehaviourPacker
        private void openBehaviourTreePackager_Click(object sender, EventArgs e)
        {
            BehaviourPacker packerForm = new BehaviourPacker();
            packerForm.Show();
        }

        //Open CharEd
        private void button2_Click(object sender, EventArgs e)
        {
            CharEd attributeForm = new CharEd();
            attributeForm.Show();
        }

        //Open AlienConfigEditor
        private void openAlienConfig_Click(object sender, EventArgs e)
        {
            AlienConfigEditor alienConfigForm = new AlienConfigEditor();
            alienConfigForm.Show();
        }

        //Open DifficultyEditor
        private void openDifficultyEditor_Click(object sender, EventArgs e)
        {
            DifficultyEditor diffEditorForm = new DifficultyEditor();
            diffEditorForm.Show();
        }

        //Open ViewconeEditor (global)
        private void openViewconeEditor_Click(object sender, EventArgs e)
        {
            ViewconeEditor viewconeSetEditor = new ViewconeEditor();
            viewconeSetEditor.Show();
        }

        //Open ViewconeEditor (character)
        private void openCharViewconeEditor_Click(object sender, EventArgs e)
        {
            CharViewconeEditor viewconeCharSetEditor = new CharViewconeEditor();
            viewconeCharSetEditor.Show();
        }

        //Open WeaponEditor
        private void openWeaponEditor_Click(object sender, EventArgs e)
        {
            WeaponEditor weaponEditorForm = new WeaponEditor();
            weaponEditorForm.Show();
        }

        //Open radiosity editor
        private void openRadiosityEditor_Click(object sender, EventArgs e)
        {
            RadiosityEditor radEdFormc = new RadiosityEditor();
            radEdFormc.Show();
        }

        //open ammo settings
        private void button7_Click(object sender, EventArgs e)
        {

        }

        //open weapon inventory settings
        private void weaponInvSettings_Click(object sender, EventArgs e)
        {

        }

        //open loot inventory settings
        private void openLootInvSettings_Click(object sender, EventArgs e)
        {

        }

        //open loadscreen movie playlist editor
        private void button4_Click(object sender, EventArgs e)
        {
            LoadMovieEditor openLoadscreenEditor = new LoadMovieEditor();
            openLoadscreenEditor.Show();
        }

        //open blueprint editor
        private void openBlueprintEditor_Click(object sender, EventArgs e)
        {
            BlueprintEditor openBPEditor = new BlueprintEditor();
            openBPEditor.Show();
        }

        //open hack tool editor
        private void openHackEditor_Click(object sender, EventArgs e)
        {
            HackingEditor openHackEditor = new HackingEditor();
            openHackEditor.Show();
        }

        //open game
        private void startGame_Click(object sender, EventArgs e)
        {
            //Process.Start(gameDirectory + @"\AI.exe");
            Process.Start("steam://rungameid/214490");
        }

        private void doBenchmark_Click(object sender, EventArgs e)
        {
            //unused
        }
    }
}
