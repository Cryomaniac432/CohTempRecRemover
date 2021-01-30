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

namespace CohTempRecRemover
{
    public partial class Form1 : Form
    {
        private string BtnRunAndStop_OriginalText = "";
        private string BtnRunAndStop_TextWhenRunning = "";
        private string TempRecDir = "";
        private string TempRecFullPath = "";
        private string ErrorMEssage_DirectoryNotFound = "";
        private string ErrorMessage_DeleteFailed = "";

        public Form1()
        {
            InitializeComponent();

            //Class Attributes
            BtnRunAndStop_OriginalText = BtnRunAndStop.Text;
            BtnRunAndStop_TextWhenRunning = BtnRunAndStop_OriginalText.Replace("aktivieren", "stoppen");
            TempRecDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Company of Heroes Relaunch\\playback";
            TempRecFullPath = TempRecDir + "\\temp.rec";
            ErrorMEssage_DirectoryNotFound = "Das Verzeichnis der \"temp.rec\" von \"Company of Heroes\" scheint nicht zu existieren.";
            ErrorMessage_DeleteFailed = "Bei dem Versuch, eine Vorhandene \"temp.rec\" zu entfernen ist ein Fehler aufgetreten:";

            //Labels
            LblMessage_Line1.Text = LblMessage_Line2.Text = "";
            LblVersion.Text = BuildVersionString_ForVersionLabel();
        }

        private void BtnRunAndStop_Click(object sender, EventArgs e)
        {
            LblMessage_Line1.Text = LblMessage_Line2.Text = "";
            if (!TimerRemoveTempRec.Enabled)
            {
                if (Directory.Exists(TempRecDir))
                {
                    TimerRemoveTempRec.Start();
                    BtnRunAndStop.BackColor = Color.Red;
                    BtnRunAndStop.ForeColor = Color.White;
                    BtnRunAndStop.Text = BtnRunAndStop_TextWhenRunning;
                } else { LblMessage_Line1.Text = ErrorMEssage_DirectoryNotFound; }
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
    }
}
