using Microsoft.AspNetCore.SignalR.Client;
using static System.Net.Mime.MediaTypeNames;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        HubConnection hub;
        string NewMeesage = string.Empty;

        public Form1()
        {
            InitializeComponent();

            hub = new HubConnectionBuilder()
                .WithUrl("https://localhost:7085/ChatHub")
                .Build();
            hub.Closed += Hub_Closed;
        }

        private async Task Hub_Closed(Exception? arg)
        {
            //await Task.Delay(new Random().Next(0, 5) * 1000);
            await hub.StartAsync();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            hub.On<string, string>("ReceiveMessage", (user, message) =>
            {
                NewMeesage = $"{user} : {message}";
                if (!string.IsNullOrEmpty(message))
                {
                    if (lb.InvokeRequired)
                    {
                        lb.Invoke(new Action(Chat));
                        return;
                    }
                    //lb.Items.Add(NewMeesage.ToString());
                }
            });

            try
            {
                await hub.StartAsync();
                lb.Items.Add("Connection Started.");
            }
            catch (Exception ex)
            {
                lb.Items.Add(ex.Message.ToString());
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(KirimPesan);
            t.Start();
        }

        async void KirimPesan()
        {
            try
            {
                await hub.InvokeAsync("SendMessage", txtUser.Text, txtPesan.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kirim pesan gagal : \n" + ex.Message.ToString());
            }
        }

        void Chat()
        {
            try
            {
                lb.Items.Add(NewMeesage.ToString());
            } catch (Exception ex)
            {
                MessageBox.Show("Terima pesan gagal : \n" + ex.Message.ToString());
            }
        }
    }
}