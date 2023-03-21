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
using System.IO.Compression;


namespace CompressionDemo
{
    public partial class Form1 : Form
    {
        public const string ZipExtension = ".zip";
        public const string RarExtension = ".rar";

        private ICompressionStrategy _compressionStrategy = null;

        public Form1()
        {
            InitializeComponent();

            // By default, use the built-in ZIP compression strategy
            _compressionStrategy = new ZipCompressionStrategy();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompress_Click_1(object sender, EventArgs e)
        {
            string sourceDirectory = txtSourceDirectory.Text.Trim();
            string destinationPath = Path.Combine(
                Path.GetDirectoryName(sourceDirectory),
                Path.GetFileNameWithoutExtension(sourceDirectory) + _compressionStrategy.FileExtension);

            try
            {
                _compressionStrategy.Compress(sourceDirectory, destinationPath);
                MessageBox.Show("Compression complete.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        

        private void checkZip_CheckedChanged(object sender, EventArgs e)
        {
            if (checkZip.Checked)
            {
                _compressionStrategy = new ZipCompressionStrategy();
            }
            else
            {
                _compressionStrategy = null;
            }
        }

        private void checkRar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRar.Checked)
            {
                _compressionStrategy = new RarCompressionStrategy();
            }
            else
            {
                _compressionStrategy = null;
            }
        }

    }

    public interface ICompressionStrategy
    {
        string FileExtension { get; }
        void Compress(string sourceDirectory, string destinationPath);
    }

    public class ZipCompressionStrategy : ICompressionStrategy
    {
        public string FileExtension => Form1.ZipExtension;

        public void Compress(string sourceDirectory, string destinationPath)
        {
            ZipFile.CreateFromDirectory(sourceDirectory, destinationPath);
        }
    }

    public class RarCompressionStrategy : ICompressionStrategy
    {
        public string FileExtension => Form1.RarExtension;

        public void Compress(string sourceDirectory, string destinationPath)
        {
            // TODO: Implement RAR compression
            throw new NotImplementedException("RAR compression not implemented.");
        }
    }
}
