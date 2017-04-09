using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTree
{
    class Tree
    {
        public Node top;
        public List<int> sortedList = new List<int>();
        public List<int> track = new List<int>();

        public Tree()
        {
            top = null;
        }

        public Tree(int initial)
        {
            top = new Node(initial);
        }


        //Add node non-recursive add
        public void Add(int value)
        {
            bool added = false;
            
            if (top == null)
            {
                //Add top
                Node NewNode = new Node(value);
                top = NewNode;
                return;
            }

            Node currentnode = top;

            //traverse the tree
            while (added == false)
            {
                try
                {
                    //Go left
                    if (value < currentnode.value)
                    {
                        if (currentnode.left == null)
                        {
                            Node NewNode = new Node(value);
                            currentnode.left = NewNode;
                            added = true;
                        }
                        else
                        {
                            currentnode = currentnode.left;
                        }
                    }

                    //Go right
                    if (value > currentnode.value)
                    {
                        if (currentnode.right == null)
                        {
                            Node NewNode = new Node(value);
                            currentnode.right = NewNode;
                            added = true;
                        }
                        else
                        {
                            currentnode = currentnode.right;
                        }
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e);
                }

            }
        }

        //recursive add
        public void AddRc(int value)
        {
            AddR(ref top, value);
        }

        //recursive add
        private void AddR(ref Node N, int value)
        {
            //add root
            if (N == null)
            {
                Node NewNode = new Node(value);
                N = NewNode;
                return;//end function
            }

            //Go left
            if(value < N.value)
            {
                AddR(ref N.left, value);
                return;//end function
            }

            //Go right
            if(value > N.value)
            {
                AddR(ref N.right, value);
                return;//end function
            }
        }

        /*search and return string rst (result)*/
        public void Search(Node N, int value, ref string rst)
        {
            //get top value
            if(N == null)
            {
                N = top;
            }

            //found if end function
            if(N.value == value)
            {
                track.Add(N.value);
                rst = "Found " + N.value;
                return;
            }

            //search left
            else if(value < N.value && N.left != null)
            {
                track.Add(N.value);
                Search(N.left, value, ref rst);
            }

            //search right
            else if(value > N.value && N.right != null)
            {
                track.Add(N.value);
                Search(N.right, value, ref rst);
            }
        }

        public void Print(Node N, ref string s)
        {
            if (N == null)
            {
                N = top;
            }

            //add left to sortedList 
            if(N.left != null)
            {
                Print(N.left, ref s);
                s = s + N.value.ToString().PadLeft(3);
                sortedList.Add(N.value);
            }

            //add node
            else
            {
                s = s + N.value.ToString().PadLeft(3);
                sortedList.Add(N.value);
            }

            //add right
            if(N.right != null){
                Print(N.right, ref s);
            }
        }
    }
}
