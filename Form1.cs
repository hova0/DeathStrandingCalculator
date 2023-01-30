using System.Text;

namespace DeathStrandingCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.roadbuilder_metaltotal.KeyDown += SuppressEnterKeyDown;
            this.roadbuilder_ceramictotal.KeyDown += SuppressEnterKeyDown;
            this.roadbuilder_ceramicinitial.KeyDown += SuppressEnterKeyDown;
            this.roadbuilder_metalinitial.KeyDown += SuppressEnterKeyDown;
            this.adhoc_amount.KeyDown += SuppressEnterKeyDown;
            this.roadrepair_percentageleft.KeyDown += Roadrepair_percentageleft_KeyDown;

        }


        private void SuppressEnterKeyDown(object? sender, KeyEventArgs y)
        {
            if (y.KeyData == Keys.Enter)
            {
                //y.Handled = true;
                y.SuppressKeyPress = true;
            }
            return;
        }


        #region Road Repair
        List<int> RoadRepair_Percentages = new List<int>();
        private void roadrepair_addClick(object? sender, EventArgs e)
        {
            if (roadrepair_percentageleft.Value > 0)
            {
                RoadRepair_Percentages.Add((int)roadrepair_percentageleft.Value);
                UpdateRoadRepairOutput();
            }
        }
        private void Roadrepair_percentageleft_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                roadrepair_addClick(sender, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void roadrepair_clear_Click(object sender, EventArgs e)
        {
            RoadRepair_Percentages.Clear();
            roadrepair_output.Text = "";
        }

        public void UpdateRoadRepairOutput()
        {
            roadrepair_output.Text = "Metals used for repair\r\n";
            List<int> amounts_needed = new List<int>();
            bool useceramic = roadrepair_useceramic.Checked;
            foreach(int roadpercent in RoadRepair_Percentages)
            {
                int repairamount = GetRepairRoadAmount(roadpercent);

                List<int> metalchunks;
                if(useceramic)
                    metalchunks = MetalsConverter.CeramicChunks(repairamount);
                else
                    metalchunks = MetalsConverter.MetalChunks(repairamount);
                amounts_needed.AddRange(metalchunks);
            }
            roadrepair_output.Text += MetalsConverter.PrintAggregateList(amounts_needed);

        }
        public static int GetRepairRoadAmount(int percentleft)
        {
            const int durability_max = 360000;
            double remaining = (100.0 - percentleft) / 100.0;
            return (int)Math.Round((durability_max * remaining) / 240);
        }
        private void roadrepair_useceramic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRoadRepairOutput();
        }

        #endregion

        #region Road Building
        private void roadbuilder_metalinitial_ValueChanged(object sender, EventArgs e)
        {
            UpdateRoadBuilderOutput();
        }

        private void roadbuilder_metaltotal_ValueChanged(object sender, EventArgs e)
        {
            UpdateRoadBuilderOutput();
        }

        private void roadbuilder_ceramicinitial_ValueChanged(object sender, EventArgs e)
        {
            UpdateRoadBuilderOutput();
        }

        private void roadbuilder_ceramictotal_ValueChanged(object sender, EventArgs e)
        {
            UpdateRoadBuilderOutput();
        }

        public void UpdateRoadBuilderOutput()
        {
                roadbuilder_output.Text = "";
            if (roadbuilder_ceramictotal.Value == 0 || roadbuilder_metaltotal.Value == 0)
                return;

            int metalamount = (int)Math.Round(roadbuilder_metaltotal.Value - roadbuilder_metalinitial.Value);
            int ceramicamount = (int)Math.Round(roadbuilder_ceramictotal.Value - roadbuilder_ceramicinitial.Value);

            if (metalamount < 0 || ceramicamount < 0)
                return;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(MetalsConverter.PrintChunksAggregate(metalamount, ResourceType.Metal));
            sb.AppendLine(MetalsConverter.PrintChunksAggregate(ceramicamount, ResourceType.Ceramic));

            roadbuilder_output.Text = sb.ToString();
        }
        #endregion
        #region AdHoc
        private void adhoc_amount_ValueChanged(object sender, EventArgs e)
        {
            UpdateAdHocOutput();
        }

        private void adhoc_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sender != null && sender is ComboBox)
            {
                ComboBox source = sender as ComboBox;
                if (!string.IsNullOrEmpty(source.Text))
                    UpdateAdHocOutput();
            }
        }

        private void UpdateAdHocOutput()
        {
            int amount = (int)Math.Round(adhoc_amount.Value);
            ResourceType type;
            if (Enum.TryParse<ResourceType>(adhoc_type.Text, out type) == false)
                return;
            adhoc_output.Text = MetalsConverter.PrintChunks(amount, type);
        }


        #endregion

    }
}