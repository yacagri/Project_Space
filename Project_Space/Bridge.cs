using Project_Space.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Space
{
    internal class Bridge : Form
    {
        
        private System.Windows.Forms.Button schlaufraum;

        private void InitializeComponent()
        {
            this.schlaufraum = new System.Windows.Forms.Button();
            this.lb_floor = new System.Windows.Forms.Label();
            this.labor = new System.Windows.Forms.Button();
            this.kommandozentrale = new System.Windows.Forms.Button();
            this.kuche = new System.Windows.Forms.Button();
            this.lager = new System.Windows.Forms.Button();
            this.wohnbereich = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pnl_schlafraum = new System.Windows.Forms.Panel();
            this.btn_sclafraum_back = new System.Windows.Forms.Button();
            this.pnl_schlafraum.SuspendLayout();
            this.SuspendLayout();
            // 
            // schlaufraum
            // 
            this.schlaufraum.BackColor = System.Drawing.Color.Transparent;
            this.schlaufraum.BackgroundImage = global::Project_Space.Properties.Resources.Blue_Button_Transparent;
            this.schlaufraum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.schlaufraum.FlatAppearance.BorderSize = 0;
            this.schlaufraum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.schlaufraum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.schlaufraum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schlaufraum.Font = new System.Drawing.Font("Berlin Sans FB", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schlaufraum.ForeColor = System.Drawing.Color.Black;
            this.schlaufraum.Location = new System.Drawing.Point(147, 71);
            this.schlaufraum.Name = "schlaufraum";
            this.schlaufraum.Size = new System.Drawing.Size(161, 43);
            this.schlaufraum.TabIndex = 0;
            this.schlaufraum.TabStop = false;
            this.schlaufraum.Text = "Schlaufraum";
            this.schlaufraum.UseVisualStyleBackColor = false;
            this.schlaufraum.Click += new System.EventHandler(this.raum1_Click);
            this.schlaufraum.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.schlaufraum.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // lb_floor
            // 
            this.lb_floor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_floor.Location = new System.Drawing.Point(90, 30);
            this.lb_floor.Name = "lb_floor";
            this.lb_floor.Size = new System.Drawing.Size(744, 543);
            this.lb_floor.TabIndex = 1;
            // 
            // labor
            // 
            this.labor.BackColor = System.Drawing.Color.Transparent;
            this.labor.BackgroundImage = global::Project_Space.Properties.Resources.Blue_Button_Transparent;
            this.labor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.labor.FlatAppearance.BorderSize = 0;
            this.labor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.labor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.labor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labor.Font = new System.Drawing.Font("Berlin Sans FB", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labor.Location = new System.Drawing.Point(367, 167);
            this.labor.Name = "labor";
            this.labor.Size = new System.Drawing.Size(161, 43);
            this.labor.TabIndex = 2;
            this.labor.TabStop = false;
            this.labor.Text = "Labor";
            this.labor.UseVisualStyleBackColor = false;
            this.labor.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.labor.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // kommandozentrale
            // 
            this.kommandozentrale.BackColor = System.Drawing.Color.Transparent;
            this.kommandozentrale.BackgroundImage = global::Project_Space.Properties.Resources.Blue_Button_Transparent;
            this.kommandozentrale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kommandozentrale.FlatAppearance.BorderSize = 0;
            this.kommandozentrale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.kommandozentrale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.kommandozentrale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kommandozentrale.Font = new System.Drawing.Font("Berlin Sans FB", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kommandozentrale.Location = new System.Drawing.Point(367, 71);
            this.kommandozentrale.Name = "kommandozentrale";
            this.kommandozentrale.Size = new System.Drawing.Size(161, 43);
            this.kommandozentrale.TabIndex = 3;
            this.kommandozentrale.TabStop = false;
            this.kommandozentrale.Text = "Kommandozentrale";
            this.kommandozentrale.UseVisualStyleBackColor = false;
            this.kommandozentrale.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.kommandozentrale.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // kuche
            // 
            this.kuche.BackColor = System.Drawing.Color.Transparent;
            this.kuche.BackgroundImage = global::Project_Space.Properties.Resources.Blue_Button_Transparent;
            this.kuche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kuche.FlatAppearance.BorderSize = 0;
            this.kuche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.kuche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.kuche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kuche.Font = new System.Drawing.Font("Berlin Sans FB", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuche.Location = new System.Drawing.Point(147, 167);
            this.kuche.Name = "kuche";
            this.kuche.Size = new System.Drawing.Size(161, 43);
            this.kuche.TabIndex = 4;
            this.kuche.TabStop = false;
            this.kuche.Text = "Küche";
            this.kuche.UseVisualStyleBackColor = false;
            this.kuche.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.kuche.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // lager
            // 
            this.lager.BackColor = System.Drawing.Color.Transparent;
            this.lager.BackgroundImage = global::Project_Space.Properties.Resources.Blue_Button_Transparent;
            this.lager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lager.FlatAppearance.BorderSize = 0;
            this.lager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lager.Font = new System.Drawing.Font("Berlin Sans FB", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lager.Location = new System.Drawing.Point(367, 268);
            this.lager.Name = "lager";
            this.lager.Size = new System.Drawing.Size(161, 43);
            this.lager.TabIndex = 5;
            this.lager.TabStop = false;
            this.lager.Text = "Lager";
            this.lager.UseVisualStyleBackColor = false;
            this.lager.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.lager.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // wohnbereich
            // 
            this.wohnbereich.BackColor = System.Drawing.Color.Transparent;
            this.wohnbereich.BackgroundImage = global::Project_Space.Properties.Resources.Blue_Button_Transparent;
            this.wohnbereich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wohnbereich.FlatAppearance.BorderSize = 0;
            this.wohnbereich.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wohnbereich.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wohnbereich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wohnbereich.Font = new System.Drawing.Font("Berlin Sans FB", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wohnbereich.Location = new System.Drawing.Point(147, 268);
            this.wohnbereich.Name = "wohnbereich";
            this.wohnbereich.Size = new System.Drawing.Size(161, 43);
            this.wohnbereich.TabIndex = 6;
            this.wohnbereich.TabStop = false;
            this.wohnbereich.Text = "Wohnbereich";
            this.wohnbereich.UseVisualStyleBackColor = false;
            this.wohnbereich.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.wohnbereich.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::Project_Space.Properties.Resources.Blue_Button_Transparent;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Berlin Sans FB", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(247, 379);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(161, 43);
            this.Exit.TabIndex = 7;
            this.Exit.TabStop = false;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // pnl_schlafraum
            // 
            this.pnl_schlafraum.BackgroundImage = global::Project_Space.Properties.Resources.Blonde_Schlafraum;
            this.pnl_schlafraum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_schlafraum.Controls.Add(this.btn_sclafraum_back);
            this.pnl_schlafraum.Location = new System.Drawing.Point(38, 30);
            this.pnl_schlafraum.Name = "pnl_schlafraum";
            this.pnl_schlafraum.Size = new System.Drawing.Size(920, 678);
            this.pnl_schlafraum.TabIndex = 8;
            this.pnl_schlafraum.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_schlafraum_Paint);
            // 
            // btn_sclafraum_back
            // 
            this.btn_sclafraum_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_sclafraum_back.BackgroundImage = global::Project_Space.Properties.Resources.Blue_Button_Transparent;
            this.btn_sclafraum_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sclafraum_back.FlatAppearance.BorderSize = 0;
            this.btn_sclafraum_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sclafraum_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_sclafraum_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sclafraum_back.Font = new System.Drawing.Font("Berlin Sans FB", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sclafraum_back.Location = new System.Drawing.Point(139, 50);
            this.btn_sclafraum_back.Name = "btn_sclafraum_back";
            this.btn_sclafraum_back.Size = new System.Drawing.Size(161, 43);
            this.btn_sclafraum_back.TabIndex = 0;
            this.btn_sclafraum_back.Text = "Zurück";
            this.btn_sclafraum_back.UseVisualStyleBackColor = false;
            this.btn_sclafraum_back.Click += new System.EventHandler(this.btn_sclafraum_back_Click);
            this.btn_sclafraum_back.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btn_sclafraum_back.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // Bridge
            // 
            this.BackgroundImage = global::Project_Space.Properties.Resources.Floor_Finish;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 482);
            this.Controls.Add(this.pnl_schlafraum);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.wohnbereich);
            this.Controls.Add(this.lager);
            this.Controls.Add(this.kuche);
            this.Controls.Add(this.kommandozentrale);
            this.Controls.Add(this.labor);
            this.Controls.Add(this.schlaufraum);
            this.Controls.Add(this.lb_floor);
            this.Name = "Bridge";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.pnl_schlafraum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Label lb_floor;
        private Button labor;
        private Button kommandozentrale;
        private Button kuche;
        private Button lager;
        private Button wohnbereich;
        private Button Exit;
        private Panel pnl_schlafraum;
        private Button btn_sclafraum_back;
        List<Panel> panelList = new List<Panel>();

      

        public Bridge()
        {
            InitializeComponent();
             WindowState = FormWindowState.Maximized;
            schlaufraum.BringToFront();
            Exit.BringToFront();
            labor.BringToFront();
            lager.BringToFront();
            wohnbereich.BringToFront();
            kommandozentrale.BringToFront();
            kuche.BringToFront();

            btn_sclafraum_back.BringToFront();
            lb_floor.Controls.Add(schlaufraum);
            lb_floor.Controls.Add(Exit);
            lb_floor.Controls.Add(labor);
            lb_floor.Controls.Add(lager);
            lb_floor.Controls.Add(wohnbereich);
            lb_floor.Controls.Add(kuche);
            lb_floor.Controls.Add(kommandozentrale);
            pnl_schlafraum.Controls.Add(btn_sclafraum_back);
            


            Image image = global::Project_Space.Properties.Resources.Raum_Menü_Background;
            


            lb_floor.Image = new Bitmap(image, lb_floor.Size);
            lb_floor.Location = new System.Drawing.Point();
            lb_floor.BackColor = System.Drawing.Color.Transparent;

            pnl_schlafraum.Visible = false;


        }

        private void Bridge_Load(object sender, EventArgs e)
        {
            //ResourceManager rm = Resources.ResourceManager;
            //Bitmap myImage = (Bitmap)rm.GetObject("Raum_Menü_Background");
            

        }

        private void raum1_Click(object sender, EventArgs e)
        {
            pnl_schlafraum.Size = new System.Drawing.Size(990, 770);
            pnl_schlafraum.Visible = true;
            
            
            Exit.Visible = false;
            wohnbereich.Visible = false;   
            kuche.Visible = false;  
            kommandozentrale.Visible = false;   
            lager.Visible = false;  
            labor.Visible = false;
            schlaufraum.Visible = false;
            lb_floor.Visible = false;


        }


        Boolean say = true;
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
          
            int larger = 10;
            int width = btn.Size.Width + larger;
            int height = btn.Size.Height + larger;

            if (say == true)
            {
                btn.Size = new System.Drawing.Size(width, height);
             
                say = false;
            }

        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
           
            int smaller = 10;

            int width = btn.Size.Width - smaller;
            int height = btn.Size.Height - smaller;

            if (say == false)
            {
                btn.Size = new System.Drawing.Size(width, height);
                say=true;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pnl_schlafraum_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_sclafraum_back_Click(object sender, EventArgs e)
        {
            
            pnl_schlafraum.Visible = false;


            Exit.Visible = true;
            wohnbereich.Visible = true;
            kuche.Visible = true;
            kommandozentrale.Visible = true;
            lager.Visible = true;
            labor.Visible = true;
            schlaufraum.Visible = true;
            lb_floor.Visible = true;
        }
    }
}
