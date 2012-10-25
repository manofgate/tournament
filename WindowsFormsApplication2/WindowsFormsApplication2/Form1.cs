using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    
	public partial class Form1 : Form
	{
        List<Person> people = new List<Person>();
        Person[] peepClone;
        BindingList<Person> pp = new BindingList<Person>();
		const int BRACKET_WIDTH = 50;

		public Form1()
		{
			InitializeComponent();

            
		}
		private void button2_Click(object sender, EventArgs e)
		{
            
            peepClone = people.ToArray();
            Form bracket = new Form();
			Label baseLabel = new Label();
			baseLabel.Text = "_________"; //sets the first dash line
			baseLabel.Width = BRACKET_WIDTH;
			baseLabel.Padding = Padding.Empty;
			int depth = (names_listbox.Rows.Count) / 2; 
			double power = Math.Pow(2, depth-1);
			baseLabel.Location = new Point(5, (int)((power + names_listbox.Rows.Count) * baseLabel.Height));
            bracket.Controls.Add(baseLabel);
            bracket.Controls.AddRange(generateBracket(baseLabel, names_listbox.Rows.Count - 1).ToArray());
			bracket.Show();
		}

        int i = 0;
		private List<Label> generateBracket(Label baseLabel, int size)
		{
			List<Label> labels = new List<Label>();
            
			int depth = (size + 1) / 2;
            
			if (size > 1)
			{
                if (size == 2)
                {
                    Label baseLabelName = new Label();
                    if (peepClone.Count() > 1)
                    {
                        baseLabelName.Text = peepClone[i].Name;
                    } //stuff i added
                    baseLabelName.Width = BRACKET_WIDTH;
                    baseLabelName.Padding = Padding.Empty;
                    baseLabelName.Location = new Point(baseLabel.Right, baseLabel.Top - depth * baseLabel.Height-7); 
                    baseLabelName.Parent = baseLabel;
                    labels.Add(baseLabelName);
                    i++;

                }
				Label top = new Label();
				top.Text = "________";
				top.Width = BRACKET_WIDTH;
				top.Location = new Point(baseLabel.Right, baseLabel.Top -  depth * baseLabel.Height); // puts it to the right of the previous point and bottom 
				top.Parent = baseLabel;
				top.Padding = Padding.Empty;
				labels.Add(top);
				labels.AddRange(generateBracket(top, (size + 1) / 2));

                if (size == 2)
                {
                    Label baseLabelNameb = new Label();
                    if (peepClone.Count() >= 1)
                    {
                        baseLabelNameb.Text = peepClone[i].Name;
                    }//stuff i added
                    baseLabelNameb.Width = BRACKET_WIDTH;
                    baseLabelNameb.Padding = Padding.Empty;
                    baseLabelNameb.Top = baseLabel.Top + baseLabel.Height * depth -7;
                    baseLabelNameb.Left = baseLabel.Right;
                    baseLabelNameb.Parent = baseLabel;
                    labels.Add(baseLabelNameb);
                    //.RemoveAt(0);
                    i++;
                }

				Label bottom = new Label();
				bottom.Text = "________";
				bottom.Width = BRACKET_WIDTH;
				bottom.Top = baseLabel.Top + baseLabel.Height * depth;
				bottom.Left = baseLabel.Right;
				bottom.Parent = baseLabel;
				bottom.Padding = Padding.Empty;
				labels.Add(bottom);
				labels.AddRange(generateBracket(bottom, size / 2));
			}

			return labels;
		}

        private void personBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            
        }

        private void names_listbox_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            names_listbox.EndEdit();
            string theName = names_listbox.Rows[e.RowIndex].Cells[0].Value.ToString();
            int agge = Convert.ToInt32(names_listbox.Rows[e.RowIndex].Cells[1].Value.ToString());
            int div = Convert.ToInt32(names_listbox.Rows[e.RowIndex].Cells[2].Value.ToString());
            string school = names_listbox.Rows[e.RowIndex].Cells[3].Value.ToString();
            //names_listbox.CurrentCell.Value.ToString();
            // string theName = names_listbox.;
            // string theName = "bob"; 
            Person p = new Person(theName, agge, div);
            people.Add(p);
            names_listbox.BeginEdit(false);
            i = 0;
        }


       


    



     

       

       

   


      


	}
}
