using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player();

            _player.CurrentHitPoints = 10;

            _player.MaximunHitPoints = 10;

            _player.Gold = 20;

            _player.ExperiencePoints = 0;

            _player.Level = 1;

            LblHitPoints.Text = _player.CurrentHitPoints.ToString();
            LblGold.Text = _player.Gold.ToString();
            LblExperience.Text = _player.ExperiencePoints.ToString();
            LblLevel.Text = _player.Level.ToString();
        }
    }
} 