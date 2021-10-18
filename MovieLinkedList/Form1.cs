using MovieLinkedList.Classes;
using MovieLinkedList.LinkedLists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLinkedList
{
    public partial class Form1 : Form
    {

        SLinkdList SlinkdList = new SLinkdList();
        DLinkdList DlinkdList = new DLinkdList();
        int countNodes = 0;
        List<string> nodeValues;
        List<string> dLinkdListPrevious;

        public Form1()
        {
            InitializeComponent();

            //LinkdList linkdList = new LinkdList();


            SlinkdList.append("Fast and Furious 1");
            SlinkdList.append("Fast and Furious 3");
            SlinkdList.append("Fast and Furious 5");
            SlinkdList.append("Fast and Furious 7");

            countNodes = SlinkdList.count();


            DlinkdList.append("Fast and Furious 1");
            DlinkdList.append("Fast and Furious 3");
            DlinkdList.append("Fast and Furious 5");
            DlinkdList.append("Fast and Furious 7");
            DlinkdList.insertAfter(2, "Movie between Fast 1 and 3");

            //txbOutput.Clear();

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {

            SlinkdList.append(txbName.Text);
            DlinkdList.append(txbName.Text);

            txbName.Clear();

            countNodes++;
      
        }



        private void btnCount_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Node Count : " + countNodes);

        }

        private void btnViewMovies_Click(object sender, EventArgs e)
        {
            nodeValues = SlinkdList.showNext();

            foreach (var item in nodeValues)
            {
                MessageBox.Show("Movie Name : " + item.ToString());
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            dLinkdListPrevious = DlinkdList.showPrevious();

            foreach (var item in dLinkdListPrevious)
            {
                MessageBox.Show("Movie Name : " + item.ToString());
            }

        }
    }
}
