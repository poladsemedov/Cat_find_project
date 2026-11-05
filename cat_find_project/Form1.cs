using System.Media;

namespace Pisik_bomba_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Cixish edilsin mi?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        int bomba;
        int count = 0;
        bool bitdi = false;
        bool p1 = false, p2 = false, p3 = false, p4 = false, p5 = false, p6 = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            bomba = r.Next(1, 7);
        }

        private void new_game_btn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            bomba = r.Next(1, 7);
            count = 0;
            count_lbl.Text = count.ToString();
            bitdi = false;
            p1 = false;
            p2 = false;
            p3 = false;
            p4 = false;
            p5 = false;
            p6 = false;

            q_img_1.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\question.png";
            q_img_2.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\question.png";
            q_img_3.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\question.png";
            q_img_4.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\question.png";
            q_img_5.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\question.png";
            q_img_6.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\question.png";
        }

        private void q_img_1_Click(object sender, EventArgs e)
        {
            if (bitdi == false && p1 == false)
            {
                p1 = true;
                if (bomba == 1)
                {
                    q_img_1.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\bomba.png";
                    SoundPlayer s = new SoundPlayer("C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\explosion.wav");
                    s.Play();
                    bitdi = true;
                    MessageBox.Show("Oyun bitdi");
                }
                else
                {
                    q_img_1.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\cat.png";
                    count++;
                    count_lbl.Text = count.ToString();
                    if (count == 5)
                    {
                        MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                        new_game_btn_Click(sender, e);
                    }
                }
            }
        }

        private void q_img_2_Click(object sender, EventArgs e)
        {
            if (bitdi == false && p2 == false)
            {
                p2 = true;
                if (bomba == 2)
                {
                    q_img_2.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\bomba.png";
                    SoundPlayer s = new SoundPlayer("C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\explosion.wav");
                    s.Play();
                    bitdi = true;
                    MessageBox.Show("Oyun bitdi");
                }
                else
                {
                    q_img_2.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\cat.png";
                    count++;
                    count_lbl.Text = count.ToString();
                    if (count == 5)
                    {
                        MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                        new_game_btn_Click(sender, e);
                    }
                }
            }
        }

        private void q_img_3_Click(object sender, EventArgs e)
        {
            if (bitdi == false && p3 == false)
            {
                p3 = true;
                if (bomba == 3)
                {
                    q_img_3.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\bomba.png";
                    SoundPlayer s = new SoundPlayer("C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\explosion.wav");
                    s.Play();
                    bitdi = true;
                    MessageBox.Show("Oyun bitdi");
                }
                else
                {
                    q_img_3.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\cat.png";
                    count++;
                    count_lbl.Text = count.ToString();
                    if (count == 5)
                    {
                        MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                        new_game_btn_Click(sender, e);
                    }
                }
            }
        }

        private void q_img_4_Click(object sender, EventArgs e)
        {
            if (bitdi == false && p4 == false)
            {
                p4 = true;
                if (bomba == 4)
                {
                    q_img_4.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\bomba.png";
                    SoundPlayer s = new SoundPlayer("C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\explosion.wav");
                    s.Play();
                    bitdi = true;
                    MessageBox.Show("Oyun bitdi");
                }
                else
                {
                    q_img_4.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\cat.png";
                    count++;
                    count_lbl.Text = count.ToString();
                    if (count == 5)
                    {
                        MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                        new_game_btn_Click(sender, e);
                    }
                }
            }
        }

        private void q_img_5_Click(object sender, EventArgs e)
        {
            if (bitdi == false && p5 == false)
            {
                p5 = true;
                if (bomba == 5)
                {
                    q_img_5.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\bomba.png";
                    SoundPlayer s = new SoundPlayer("C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\explosion.wav");
                    s.Play();
                    bitdi = true;
                    MessageBox.Show("Oyun bitdi");
                }
                else
                {
                    q_img_5.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\cat.png";
                    count++;
                    count_lbl.Text = count.ToString();
                    if (count == 5)
                    {
                        MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                        new_game_btn_Click(sender, e);
                    }
                }
            }
        }

        private void q_img_6_Click(object sender, EventArgs e)
        {
            if (bitdi == false && p6 == false)
            {
                p6 = true;
                if (bomba == 6)
                {
                    q_img_6.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\bomba.png";
                    SoundPlayer s = new SoundPlayer("C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\explosion.wav");
                    s.Play();
                    bitdi = true;
                    MessageBox.Show("Oyun bitdi");
                }
                else
                {
                    q_img_6.ImageLocation = "C:\\Users\\Evez\\Desktop\\VS 2026\\Pisik_bomba_oyunu\\Pisik_bomba_oyunu\\image\\cat.png";
                    count++;
                    count_lbl.Text = count.ToString();
                    if (count == 5)
                    {
                        MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                        new_game_btn_Click(sender, e);
                    }
                }
            }
        }
    }
}
