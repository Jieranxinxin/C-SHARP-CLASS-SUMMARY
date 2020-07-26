using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化根节点
            TreeNode tn = new TreeNode("根节点");
            treeView1.Nodes.Add(tn);
        }

        //事件 在MouseEventArgs e去捕捉鼠标、键盘上的操作
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //this当前右键菜单
                //new Point(e.X, e.Y)，捕捉当前右键菜单显示位置
                //加右，减左
                contextMenuStrip1.Show(this,new Point(e.X+20, e.Y+10));
            }
        }

        //尽量不要中英文混搭，将name值更改即可
        private void AddNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddChildNode();

        }
        private void 增加兄弟节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBrothersNode();
        }
        private void 删除节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNode();
        }







        //增加节点
        private void AddChildNode()
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Please choose node");
                return;
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("节点名称不能为空！");
                    return;
                }
                else
                {
                    //要先对其实例化
                    TreeNode tn = new TreeNode(textBox1.Text);
                    treeView1.SelectedNode.Nodes.Add(tn);
                    //让你选中的那个节点等于你增加的那个节点
                    treeView1.SelectedNode = tn;
                    //保持被展开状态
                    treeView1.ExpandAll();
                }
            }
        }

        private void AddBrothersNode()
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Please choose node");
                return;
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("节点名称不能为空！");
                    return;
                }
                else
                {
                    TreeNode tn = new TreeNode(textBox1.Text);
                    //加兄弟节点，要先退回去，找到父节点Parent
                    treeView1.SelectedNode.Parent.Nodes.Add(tn);
                    treeView1.SelectedNode = tn;
                    treeView1.ExpandAll();
                }
            }
        }
        //删除操作，先判断子节点是否为0，为0可删
        private void DeleteNode()
        {
            if (treeView1.SelectedNode.Nodes.Count == 0)
            {
                treeView1.SelectedNode.Remove();
            }
            else
            {
                DialogResult dr= MessageBox.Show("当前节点有子节点,是否删除？","信息提示",MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //i的范围一般都是常量，要不然，i在变，范围也在变，容易出错
                    //for(int i = 0; i < treeView1.SelectedNode.Nodes.Count; i++)
                    //反过来想
                    for (int i = treeView1.SelectedNode.Nodes.Count - 1; i >= 0; i--)
                    {
                        treeView1.SelectedNode.Nodes.RemoveAt(i);
                    }
                    //加上下面这一行代码，可以把这一支都删掉
                    treeView1.SelectedNode.Remove();
                }
                else
                {
                    return;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //找到当前节点展开就OK
            treeView1.SelectedNode.Expand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //先去找根节点，让当前选中的节点等于根节点
            //treeView1.SelectedNode = treeView1.Nodes[0];
            //treeView1.SelectedNode.ExpandAll();
            treeView1.ExpandAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
    }
}
