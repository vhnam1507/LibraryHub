using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryHub.Forms
{
    public partial class Form_entry : Form
    {
        public Form_entry()
        {
            InitializeComponent();
            SetWelcomeMessage();
        }

        private Random random = new Random();

        private string[] morningGreetings = { "Chào buổi sáng!", "Chúc một ngày tốt lành!", "Một quyển sách hay cho ngày mới!" };
        private string[] noonGreetings = { "Hi! đã trưa rồi đấy", "Tìm kiếm một quyển sách cho giờ trưa sao?!", "Đừng quên ăn trưa nhé!" };
        private string[] afternoonGreetings = { "Mặt trời sắp xuống núi rồi!", "Bạn nên đi ăn thay vì đọc sách vào lúc này!", "Kết thúc ngày làm việc rồi!" };
        private string[] eveningGreetings = { "Buổi tốt vui vẻ!", "Hãy chọn một quyển sách cho tối nay nào!", "Đọc một chút trước khi đi ngủ sao?!" };


        private string[] quotes = { "“All our dreams can come true, if we have the courage to pursue them.” \n—Walt Disney-",
                                    "“The secret of getting ahead is getting started.” \n—Mark Twain-",
                                    "“I’ve missed more than 9,000 shots in my career. I’ve lost almost 300 games. 26 times I’ve been trusted to take the game winning shot and missed. I’ve failed over and over and over again in my life, and that is why I succeed.” \n—Michael Jordan-" };
        private void SetWelcomeMessage()
        {
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            string[] greetings;
            string[] theQuotes = quotes;

            if (hour >= 4 && hour < 11)
            {
                greetings = morningGreetings;
            }
            else if (hour >= 11 && hour < 13)
            {
                greetings = noonGreetings;
            }
            else if (hour >= 13 && hour < 17)
            {
                greetings = afternoonGreetings;
            }
            else
            {
                greetings = eveningGreetings;
            }

            Random random = new Random();
            string selectedGreeting = GetRandom(greetings, random);
            lbl_welcome.Text = selectedGreeting;
            string selectedQuotes = GetRandom(theQuotes, random);
            lbl_quotes.Text = selectedQuotes;
        }

        private string GetRandom(string[] randText, Random random)
        {
            int index = random.Next(randText.Length);
            return randText[index];
        }

        private Form Current;

        private void openChildForms(Form childForm)
        {
            if (Current != null)
            {
                Current.Close();
            }
            Current = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_entry.Controls.Add(childForm);
            pnl_entry.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            Form_login form_login = new Form_login();
            openChildForms(form_login);            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
