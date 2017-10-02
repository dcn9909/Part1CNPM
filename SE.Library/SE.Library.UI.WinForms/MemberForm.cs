using SE.Library.Model;
using SE.Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE.Library.UI.WinForms
{
    public partial class MemberForm : Form
    {
        private LibraryService libService = new LibraryService();
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            DisplayMember();
            
        }

        private void DisplayMember()
        {
            lvwMember.Items.Clear();

            foreach (Member item in libService.GetAllMembers())
            {
                ListViewItem member = new ListViewItem(item.FirstName);
                member.SubItems.Add(item.LastName);
                lvwMember.Items.Add(member);
            }

            //auto resize content
            lvwMember.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            //auto resize header
            lvwMember.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.LastName = txbLastName.Text;
            member.FirstName = txbFirstName.Text;

            ListViewItem item = new ListViewItem(member.FirstName);
            item.SubItems.Add(member.LastName);

            lvwMember.Items.Add(item);


        }
    }
}
