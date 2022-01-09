using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BookKeeper.Model.Items;
using BookKeeper.Presenters;
using BookKeeper.View;

namespace BookKeeper
{

    public partial class MainForm : Form
    {
        //public List<ListButton> userButtons = new List<ListButton>();
        public MainForm()
        {
            InitializeComponent();
            this.Icon = Resources.ImageService.MainIcon;
        }
        public UserPresenter Presenter {
            private get;
            set;
        }
    }
}
