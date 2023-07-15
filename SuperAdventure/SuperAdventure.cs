using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1);

            Location test1 = new Location(1, "Your House", "This is your house");
            Location test2 = new Location(1, "Your House", "This is your house", null, null, null);


            LblHitPoints.Text = _player.CurrentHitPoints.ToString();
            LblGold.Text = _player.Gold.ToString();
            LblExperience.Text = _player.ExperiencePoints.ToString();
            LblLevel.Text = _player.Level.ToString();
        }

        private void BtnNorth_Click(object sender, EventArgs e)
        {

        }

        private void BtnWest_Click(object sender, EventArgs e)
        {

        }

        private void BtnSouth_Click(object sender, EventArgs e)
        {

        }

        private void BtnEast_Click(object sender, EventArgs e)
        {

        }

        private void BtnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void BtnUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}