using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexa_Enabled_IoT_Device_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_command_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                Trigger_Load(txt_command.Text);
            }
        }

        private void Trigger_Load(string cmd)
        {           
            string[] s = cmd.Split(' ');
            
            switch(s[0])
            {
                case "light":

                    if (s[1]=="on") pb_light.BackColor=Color.Green;
                    else pb_light.BackColor=Color.Gray;
                    break;
                ///////////////
                case "night":
                    if (s[1]=="lamp")
                    {
                        if (s[2]=="on")
                        {
                            pb_night_lamp.BackColor=Color.Green;
                        }
                        else
                        {
                            pb_night_lamp.BackColor=Color.Gray;
                        }
                    }                      
                    break;
                ////////////////////
                case "smart":
                    if (s[1]=="bulb")
                    {
                        if (s[2]=="on")
                        {
                            pb_smart_bulb.BackColor=Color.Green;
                        }
                        else
                        {
                            pb_smart_bulb.BackColor=Color.Gray;
                        }
                    }
                    break;
                ////////////////////
                case "fan":       
                    if (s[1]=="on")
                    {
                        txt_fan_status.Text="running..";  
                    }
                    else if ((s[1]=="off") ||(s[1]=="stop"))
                    {
                        txt_fan_status.Text="Stop";
                    }
                    else if (s[1]=="speed")
                    {
                        txt_fan_speed.Text=s[2]+"%";
                    }
                    break;
                ///////////////////////
                default:
                    break;
            }
             
        }








    }
}
