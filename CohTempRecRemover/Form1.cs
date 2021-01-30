using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace CohTempRecRemover
{
    public partial class Form1 : Form
    {
        private string BtnRunAndStop_OriginalText = "";
        private string BtnRunAndStop_TextWhenRunning = "";
        private string TempRecDir = "";
        private string TempRecFullPath = "";
        private string QuestionMessage_Start = "";
        private string QuestionTitle = "";
        private string ErrorMessage_DirectoryNotFound = "";
        private string ErrorMessage_DeleteFailed = "";

        public Form1()
        {
            InitializeComponent();

            TempRecDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Company of Heroes Relaunch\\playback";
            TempRecFullPath = TempRecDir + "\\temp.rec";

            if (CultureInfo.CurrentCulture.Name == "de-DE") { InitTextes_German(); } else { InitTextes_English(); }

            LblMessage_Line1.Text = LblMessage_Line2.Text = "";
            LblVersion.Text = BuildVersionString_ForVersionLabel();
        }

        private void BtnRunAndStop_Click(object sender, EventArgs e)
        {
            LblMessage_Line1.Text = LblMessage_Line2.Text = "";
            if (!TimerRemoveTempRec.Enabled)
            {
                if (MessageBox.Show(QuestionMessage_Start, QuestionTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (Directory.Exists(TempRecDir))
                    {
                        TimerRemoveTempRec.Start();
                        BtnRunAndStop.BackColor = Color.Red;
                        BtnRunAndStop.ForeColor = Color.White;
                        BtnRunAndStop.Text = BtnRunAndStop_TextWhenRunning;
                    }
                    else { LblMessage_Line1.Text = ErrorMessage_DirectoryNotFound; }
                }
            } else
            {
                TimerRemoveTempRec.Stop();
                BtnRunAndStop.BackColor = Color.Lime;
                BtnRunAndStop.ForeColor = Color.Black;
                BtnRunAndStop.Text = BtnRunAndStop_OriginalText;          
            }
        }

        private void TimerRemoveTempRec_Tick(object sender, EventArgs e)
        {
            if (File.Exists(TempRecFullPath))
            {
                try { File.Delete(TempRecFullPath); } catch (Exception exc)
                {
                    LblMessage_Line1.Text = ErrorMessage_DeleteFailed;
                    LblMessage_Line2.Text = exc.Message;
                }
            }
        }

        private string BuildVersionString_ForVersionLabel()
        {
            string[] currentVersionNumbers = Application.ProductVersion.Split('.');
            string versionMajor = currentVersionNumbers.Length >= 1 ? currentVersionNumbers[0] : "?";
            string versionMinor = currentVersionNumbers.Length >= 2 ? currentVersionNumbers[1] : "?";
            string versionRevision = currentVersionNumbers.Length >= 3 ? currentVersionNumbers[2] : "?";
            return "Version " + versionMajor + "." + versionMinor + "." + versionRevision;
        }

        private void InitTextes_German()
        {
            this.Text = "automatischer \"temp.rec\"-Entferner für \"Company of Heroes\"";
            LblTitle_Line1.Text = "Dieses Programm entfernt automatisch die \"temp.rec\" von \"Company of Heroes\", um Spielabstürze vorzubeugen.";
            LblTitle_Line2.Text = "Diese befindet sich im jeweiligen Benutzer-Ordner unter \"Documents\\My Games\\Company of Heroes Relaunch\\playback\".";
            LblHowTo_Line1.Text = "Klicken Sie einfach auf den Knopf unten, um diese oben beschriebene Automatik zu aktivieren.";
            LblHowTo_Line2.Text = "Klicken Sie erneut auf diesen Knopf um diese Automatik wieder zu deaktivieren.";
            BtnRunAndStop_OriginalText = "automatisches Entfernen der \"temp.rec\" aktivieren";
            BtnRunAndStop_TextWhenRunning = BtnRunAndStop_OriginalText.Replace("aktivieren", "deaktivieren");
            QuestionMessage_Start = "Sind Sie sicher, dass sie das automatische Entfernen der \"temp.rec\" auf \"" + TempRecDir + "\" aktivieren möchten?";
            QuestionTitle = "Sind Sie sicher?";
            ErrorMessage_DirectoryNotFound = "Das Verzeichnis der \"temp.rec\" von \"Company of Heroes\" scheint nicht zu existieren.";
            ErrorMessage_DeleteFailed = "Bei dem Versuch, eine Vorhandene \"temp.rec\" zu entfernen ist ein Fehler aufgetreten:";
        }

        private void InitTextes_English()
        {
            this.Text = "automatic \"temp.rec\"-remover for \"Company of Heroes\"";
            LblTitle_Line1.Text = "This program automatically removes the \"temp.rec\" of \"Company of Heroes\" to prevent game crashes.";
            LblTitle_Line2.Text = "It should exist in the User-Directory in \"Documents\\My Games\\Company of Heroes Relaunch\\playback\".";
            LblHowTo_Line1.Text = "Just click on this Button below to activate this automatic.";
            LblHowTo_Line2.Text = "Click on this button again to deactivate it.";
            BtnRunAndStop_OriginalText = "enable automatic removal of \"temp.rec\"";
            BtnRunAndStop_TextWhenRunning = BtnRunAndStop_OriginalText.Replace("enable", "disable");
            QuestionMessage_Start = "Are you sure that you want to enable the automatic removal of the \"temp.rec\" from \"" + TempRecDir + "\"?";
            QuestionTitle = "Are you sure?";
            ErrorMessage_DirectoryNotFound = "The Directory of the \"temp.rec\" of \"Company of Heroes\" doesn't seem to exist.";
            ErrorMessage_DeleteFailed = "An attempt to remove an existing \"temp.rec\" failed:";
        }
    }
}
