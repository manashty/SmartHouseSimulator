using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ARM_Mobile_Multimedia_CMS
{
    public partial class FileSelector : UserControl
    {
        public enum FileSelectorType
        {
            Image,
            Sound,
            Video
        }

        public FileSelector()
        {
            InitializeComponent();
        }

        private void FileSelector_Load(object sender, EventArgs e)
        {

        }
        private string i;

        public string ButtonText
        {
            get
            {
                return btn_Browse.Text;
            }
            set
            {
                btn_Browse.Text = value;
            }
        }

        public string PreviewTitle
        {
            get
            {
                return lbl_Preview.Text;
            }
            set
            {
                lbl_Preview.Text = value;
            }
        }

        public string Title
        {
            get
            {
                return lbl_Title.Text;
            }
            set
            {
                lbl_Title.Text = value;
            }
        }

        public string FileName
        {
            get
            {
                return txt_FileName.Text;
            }
            set
            {
                txt_FileName.Text = value;
            }
        }
        /// <summary>
        /// The destination file path that the fileselector FileName will be used to replace that file.
        /// Example: /Images/Logo.png
        /// </summary>
        public string JarFilePath
        {
            get
            {
                return jarFilePath;
            }
            set
            {
                jarFilePath = value;
            }
        }
        FileSelectorType fileType = FileSelectorType.Image;
        Size imageSize = new Size();
        /// <summary>
        /// Image size of the selected file, if the type is Image
        /// </summary>
        public Size ImageSize
        {
            get { return imageSize; }
            set { imageSize = value; }
        }

        public FileSelectorType FileType
        {
            get { return fileType; }
            set
            {
                fileType = value;
                switch (fileType)
                {
                    case FileSelectorType.Image:
                        openFileDialog1.Filter = "All Image Types|*.jpg;*.png;*.bmp;*.gif";
                        break;
                    case FileSelectorType.Sound:
                        openFileDialog1.Filter = "All Sound Types|*.wav;*.mp3;*.mid;*.amr";
                        break;
                    case FileSelectorType.Video:
                        openFileDialog1.Filter = "All Video Types|.3gp;*.wmv;*.mpg";
                        break;
                    default:
                        break;
                }
            }
        }
        string jarFilePath = "";
        bool previewEnabled = true;
        public bool PreviewEnabled { get { return previewEnabled; } set { previewEnabled = value; } }
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_FileName.Text = openFileDialog1.FileName;
                if (previewEnabled)
                {
                    pic_Preview.ImageLocation = txt_FileName.Text;
                }
            }
        }

        private void txt_FileName_TextChanged(object sender, EventArgs e)
        {
            if (previewEnabled)
                pic_Preview.ImageLocation = txt_FileName.Text;
        }

        private void pic_Preview_MouseClick(object sender, MouseEventArgs e)
        {
            if (FileName != "")
            {
                if (fileType == FileSelectorType.Image)
                {
                    Form previewForm = new Form();
                    previewForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    PictureBox pbox = new PictureBox();
                    pbox.Image = Image.FromFile(FileName);
                    pbox.SizeMode = PictureBoxSizeMode.AutoSize;
                    previewForm.Controls.Add(pbox);
                    previewForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    previewForm.AutoSize = true;
                    previewForm.Size = pbox.Size;
                    previewForm.StartPosition = FormStartPosition.CenterScreen;
                    previewForm.MaximumSize = new Size(800, 650);
                    previewForm.AutoScroll = true;

                    pbox.Parent = previewForm;
                    pbox.Click += new EventHandler(pbox_Click);
                    previewForm.ShowDialog();
                }
                else
                    ;//ARMLib.ARMFileManager.ShellExecute(FileName, true, null);
            }
            else
                MessageBox.Show("Select a File First!");
        }

        void pbox_Click(object sender, EventArgs e)
        {
            ((Form)((PictureBox)sender).Parent).Close();
        }

        static List<FileSelectorData> fileSelectorData;
        public static List<FileSelectorData> GetAllControlsFileSelectorsData(Control parent)
        {
            fileSelectorData = new List<FileSelectorData>();
            GetControlFileSelectors(parent);
            return fileSelectorData;
        }

        public static void GetControlFileSelectors(Control c)
        {
            //MessageBox.Show(c.GetType().ToString());
            if (c.GetType() == Type.GetType("ARM_Mobile_Multimedia_CMS.FileSelector"))
            {
                fileSelectorData.Add(new FileSelectorData((FileSelector)c));
            }
            if (c.HasChildren)
                for (int i = 0; i < c.Controls.Count; i++)
                {
                    GetControlFileSelectors(c.Controls[i]);
                }
        }

        public struct FileSelectorData
        {
            public Object data;
            public FileSelector.FileSelectorType fileType;
            public String fileName;
            public String destinationFile;

            public FileSelectorData(FileSelectorType FileType, String FileName, String DestinationFile, Object Data)
            {
                data = Data;
                fileType = FileType;
                fileName = FileName;
                destinationFile = DestinationFile;
            }

            public bool IsValid(FileSelectorType fst)
            {
                if (destinationFile != null)
                    if (destinationFile != "")
                        if (fileName != null)
                            if (fileName != "")
                                if (fst == fileType)
                                    return true;
                return false;
            }
            public FileSelectorData(FileSelector fs)
            {
                data = null;
                fileType = fs.FileType;
                fileName = fs.FileName;
                destinationFile = fs.JarFilePath;
            }
        }
    }
}
