using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace HailToTheNoxus_
{
    public partial class Form1 : Form
    {

        private static class Champions
        {
            public static Dictionary<string, int> Champs = new Dictionary<string, int>()
            {
                {"Amumu", 450},
                {"Annie", 450},
                {"Ashe", 450},
                {"Brand", 450},
                {"Caitlyn", 450},
                {"Darius", 450},
                {"Diana", 450},
                {"Dr. Mundo", 450},
                {"Garen", 450},
                {"Leona", 450},
                {"Lux", 450},
                {"Malphite", 450},
                {"Master Yi", 450},
                {"Miss Fortune", 450},
                {"Nunu & Willump", 450},
                {"Poppy", 450},
                {"Sejuani", 450},
                {"Sivir", 450},
                {"Sona", 450},
                {"Soraka", 450},
                {"Teemo", 450},
                {"Warwick", 450},
                {"Yuumi", 450},
                {"Alistar", 1350},
                {"Blitzcrank", 1350},
                {"Cho'Gath", 1350},
                {"Evelynn", 1350},
                {"Ezreal", 1350},
                {"Fiddlesticks", 1350},
                {"Fizz", 1350},
                {"Janna", 1350},
                {"Jax", 1350},
                {"Kai'Sa", 1350},
                {"Lee Sin", 1350},
                {"Lucian", 1350},
                {"Mordekaiser", 1350},
                {"Morgana", 1350},
                {"Nasus", 1350},
                {"Pantheon", 1350},
                {"Rammus", 1350},
                {"Sett", 1350},
                {"Sion", 1350},
                {"Taric", 1350},
                {"Tristana", 1350},
                {"Tryndamere", 1350},
                {"Udyr", 1350},
                {"Veigar", 1350},
                {"Vi", 1350},
                {"Volibear", 1350},
                {"Xerath", 1350},
                {"Xin Zhao", 1350},
                {"Yasuo", 1350},
                {"Zed", 1350},
                {"Zilean", 1350},
                {"Ahri", 3150},
                {"Akali", 3150},
                {"Anivia", 3150},
                {"Braum", 3150},
                {"Corki", 3150},
                {"Ekko", 3150},
                {"Galio", 3150},
                {"Gangplank", 3150},
                {"Gragas", 3150},
                {"Heimerdinger", 3150},
                {"Illaoi", 3150},
                {"Irelia", 3150},
                {"Jarvan IV", 3150},
                {"Jinx", 3150},
                {"Karma", 3150},
                {"Karthus", 3150},
                {"Kassadin", 3150},
                {"Katarina", 3150},
                {"Kayn", 3150},
                {"LeBlanc", 3150},
                {"Nami", 3150},
                {"Nidalee", 3150},
                {"Nocturne", 3150},
                {"Olaf", 3150},
                {"Pyke", 3150},
                {"Samira", 3150},
                {"Senna", 3150},
                {"Seraphine", 3150},
                {"Shaco", 3150},
                {"Shen", 3150},
                {"Shyvana", 3150},
                {"Swain", 3150},
                {"Sylas", 3150},
                {"Syndra", 3150},
                {"Talon", 3150},
                {"Thresh", 3150},
                {"Trundle", 3150},
                {"Twitch", 3150},
                {"Urgot", 3150},
                {"Vayne", 3150},
                {"Vex", 3150},
                {"Viktor", 3150},
                {"Vladimir", 3150},
                {"Wukong", 3150},
                {"Yone", 3150},
                {"Yorick", 3150},
                {"Zyra", 3150},
                {"Jhin", 4444},
                {"Aatrox", 4800},
                {"Akshan", 4800},
                {"Aphelios", 4800},
                {"Aurelion Sol", 4800},
                {"Azir", 4800},
                {"Bard", 4800},
                {"Camille", 4800},
                {"Cassiopeia", 4800},
                {"Draven", 4800},
                {"Elise", 4800},
                {"Fiora", 4800},
                {"Gnar", 4800},
                {"Graves", 4800},
                {"Gwen", 4800},
                {"Hecarim", 4800},
                {"Ivern", 4800},
                {"Jayce", 4800},
                {"Kalista", 4800},
                {"Kayle", 4800},
                {"Kennen", 4800},
                {"Kha'Zix", 4800},
                {"Kindred", 4800},
                {"Kled", 4800},
                {"Kog'Maw", 4800},
                {"Lillia", 4800},
                {"Lissandra", 4800},
                {"Lulu", 4800},
                {"Malzahar", 4800},
                {"Maokai", 4800},
                {"Nautilus", 4800},
                {"Neeko", 4800},
                {"Orianna", 4800},
                {"Ornn", 4800},
                {"Qiyana", 4800},
                {"Quinn", 4800},
                {"Rakan", 4800},
                {"Rek'Sai", 4800},
                {"Rell", 4800},
                {"Renekton", 4800},
                {"Rengar", 4800},
                {"Riven", 4800},
                {"Rumble", 4800},
                {"Ryze", 4800},
                {"Singed", 4800},
                {"Skarner", 4800},
                {"Tahm Kench", 4800},
                {"Taliyah", 4800},
                {"Twisted Fate", 4800},
                {"Varus", 4800},
                {"Vel'Koz", 4800},
                {"Viego", 4800},
                {"Xayah", 4800},
                {"Zac", 4800},
                {"Ziggs", 4800},
                {"Zoe", 4800},
                {"Bel'Veth", 6300},
                {"K'Sante", 6300},
                {"Nilah", 6300},
                {"Renata Glasc", 6300},
                {"Zeri", 6300}
            };
        }

        private Dictionary<string, champObj> champList = new Dictionary<string, champObj>();
        private int currentBE = 0;

        private class champObj
        {
            public string champName;
            public int champPriceNew;
            public int champPriceOld;
            public int champCount;
            public string champLootId;
            public int champSelectedCount = 0;
            public NumericUpDown champNumeric;
        }

        public class JSON_DE
        {
            public string lootId;
            public int value;
            public string tilePath;
            public int count;
            public string itemDesc;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private static HttpClient handler()
        {
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };
            var request = new HttpClient(handler);
            return request;
        }

        private static class Test // to do
        {
            private static List<string> found = find();
            public static string port = found[0];
            public static string token = found[1];

            private static List<string> find()
            {
                var cmd = new ProcessStartInfo("cmd.exe");
                cmd.Arguments = "/c wmic PROCESS WHERE name='LeagueClientUx.exe' GET commandline";
                cmd.RedirectStandardOutput = true;
                cmd.UseShellExecute = false;
                var cmd_exec = Process.Start(cmd);
                var output = cmd_exec.StandardOutput.ReadToEnd();

                cmd_exec.WaitForExit();

                string app_port = "--app-port=([0-9]*)";
                string remoting_auth_token = "--remoting-auth-token=([\\w-]*)";

                Regex regPort = new Regex(app_port, RegexOptions.IgnoreCase);
                Regex regToken = new Regex(remoting_auth_token, RegexOptions.IgnoreCase);

                string beforePort = regPort.Match(output).ToString();
                string beforeToken = regToken.Match(output).ToString();

                List<string> lines = new List<string>();

                lines.Add(beforePort.Substring(beforePort.IndexOf("=") + 1));

                string token = beforeToken.Substring(beforeToken.IndexOf("=") + 1);

                lines.Add(token);

                return lines;
            }
        }

        private async Task<string> LCU_Request(string url, string method = "get", string body = "")
        {
            HttpMethod httpMethod = HttpMethod.Get;
            if (method.ToLower() == "post")
            {
                httpMethod = HttpMethod.Post;
            }
            var request = handler();
            string port = Test.port;
            string token = Test.token;
            var bytes = Encoding.ASCII.GetBytes($"riot:{token}");

            var lcuReq = new HttpRequestMessage(httpMethod, $"https://127.0.0.1:{port}{url}");
            lcuReq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(bytes));
            lcuReq.Content = body == "" ? null : new StringContent($"[\"{body}\"]", Encoding.UTF8, "application/json");
            var res = await request.SendAsync(lcuReq);
            var content = await res.Content.ReadAsStringAsync();
            return content;
        }


        private async Task<Bitmap> LCU_RequestIMG(string url)
        {
            var request = handler();
            string port = Test.port;
            string token = Test.token;
            var bytes = Encoding.ASCII.GetBytes($"riot:{token}");


            MemoryStream mStream = new MemoryStream();
            var lcuReq = new HttpRequestMessage(HttpMethod.Get, $"https://127.0.0.1:{port}{url}");
            lcuReq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(bytes));
            var res = await request.SendAsync(lcuReq);
            var content = await res.Content.ReadAsByteArrayAsync();
            mStream.Write(content, 0, Convert.ToInt32(content.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            lcuReq.Dispose();
            return bm;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string s = await LCU_Request("/lol-loot/v1/player-loot");

            JObject nick = JObject.Parse(await LCU_Request("/lol-summoner/v1/current-summoner"));
            lblNick.Text = $"{nick["displayName"]}";
            var champPool = JsonConvert.DeserializeObject<List<JSON_DE>>(s);
            champPool = champPool.OrderBy(o =>o.itemDesc).ToList();
            champPool.RemoveAll(x => !x.lootId.StartsWith("CHAMPION_RENTAL") && x.lootId != "CURRENCY_champion");
            

            int pos = 0;
            
            
            foreach (var champ in champPool)
            {
                if (champ.lootId == "CURRENCY_champion") { currentBE = champ.count; lblBlue.Text = "Blue Essence: " + currentBE; }
                else
                {
                    champObj champobj = new champObj();
                    champobj.champPriceOld = (int)champ.value;
                    champobj.champName = (string)champ.itemDesc;
                    champobj.champPriceNew = Champions.Champs[champobj.champName];
                    champobj.champCount = (int)champ.count;
                    champobj.champLootId = (string)champ.lootId;
                    champobj.champNumeric = new NumericUpDown();
                    champobj.champNumeric.Location = new Point(100, pos + 38);
                    champobj.champNumeric.Margin = new Padding(0, 0, 0, 0);
                    champobj.champNumeric.Maximum = champobj.champCount;
                    champPanel.Controls.Add(champobj.champNumeric);

                    //Bitmap s2 = await LCU_RequestIMG((string)champ.tilePath);
                    PictureBox pic = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(0, pos),
                        Width = 96,
                        Height = 96,
                        //Image = s2,
                        Margin = new Padding(0, 0, 0, 0),
                        BorderStyle = BorderStyle.FixedSingle,
                        Padding = new Padding(5),
                        BackColor = champobj.champPriceNew > champobj.champPriceOld ? Color.Green : Color.Red,
                    };
                    champPanel.Controls.Add(pic);



                    Label lbl = new Label();
                    lbl.Text = $"{champobj.champName}\nOld price: {champobj.champPriceOld} (Disenchant: {champobj.champPriceOld * 0.2}) New price: {champobj.champPriceNew} ({champobj.champPriceNew * 0.2})\nProfit after patch:{champobj.champPriceNew * 0.2 - champobj.champPriceOld * 0.2}";
                    lbl.Location = new Point(100, pos);
                    lbl.Width = 300;
                    lbl.Height = 40;
                    champPanel.Controls.Add(lbl);

                    champList.Add(champobj.champName, champobj);

                    //Second value is margin
                    pos += 96 + 15;
                }

            }

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double bonus = 0;
            foreach (var champ in champList)
            {
                if (champ.Value.champNumeric.Value == 0)
                {
                    continue;
                }
                else
                {
                    bonus += champ.Value.champPriceOld * 0.2 * (int)champ.Value.champNumeric.Value;
                }
            }
            lblBlueAfter.Text = "Blue Essence After " + (int)(bonus + currentBE);
            
        }

        private async void btnDisenchant_Click(object sender, EventArgs e)
        {
            string ChampDis = string.Empty;
            foreach (var champ in champList)
            {
                if (champ.Value.champNumeric.Value == 0)
                {
                    continue;
                }
                else
                {
                    champ.Value.champSelectedCount = (int)champ.Value.champNumeric.Value;
                    ChampDis += $"\n{champ.Value.champSelectedCount}x {champ.Value.champName}";
                }
            }
            if (ChampDis == string.Empty) { MessageBox.Show("Nothing to disenchant..."); return; }
            DialogResult result = MessageBox.Show($"Champions to disenchant: {ChampDis}", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (var champ in champList)
                {
                    if (champ.Value.champSelectedCount > 0)
                    {
                        var content = await LCU_Request($"/lol-loot/v1/recipes/CHAMPION_RENTAL_disenchant/craft?repeat={champ.Value.champSelectedCount}", "post", champ.Value.champLootId);

                    }
                }
                MessageBox.Show("Disenchanted!\n\nRestart to refresh inventory!");
            }
        }

        private void linkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ko-fi.com/acemi");
        }
    }
}
