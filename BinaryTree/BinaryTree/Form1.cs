using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declare myTree object
        Tree myTree;
        public string rst = null;

        /*Create binary tree, display raw data and sorted data*/
        private void button1_Click(object sender, EventArgs e)
        {
            //add root value
            Random rnd = new Random();
            int num;
            num = rnd.Next(0, 10000);
            myTree = new Tree(num); 

            //convert input
            int n = Convert.ToInt32(txtbox1.Text);

            //add to display at listBox1
            List<int> _items = new List<int>(); 
             _items.Add(num);

            //add vertices into binary tree
            for (int i = 1; i < n; i++)
            {
                num = rnd.Next(0, 10000);
                myTree.AddRc(num);

                //add to display
                _items.Add(num);
            }

            //display raw data at listBox1
            listBox1.DataSource = _items;
            
            //display sorted data at listBox2
            string treestring = "";
            myTree.Print(null, ref treestring);
            listBox2.DataSource = myTree.sortedList;

        }

        /*Search and display result*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            rst = null;
            myTree.track.Clear();
            int n = Convert.ToInt32(txtBox2.Text);

            //call Search
            myTree.Search(null, n, ref rst);

            if (!string.IsNullOrEmpty(rst))
            {
                lblSearch.Text = rst;
            }
            else
            {
                lblSearch.Text = "NOT FOUND " + n;
            }

            listBox3.DataSource = null;
            listBox3.DataSource = myTree.track;
        }
    }
}
