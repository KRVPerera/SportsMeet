using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SportsMeet.Models;

namespace SportsMeet
{
    public partial class AddMultipleEventsToPlayer : Form
    {
        public Player CurrentPlayer { get; }

        public AddMultipleEventsToPlayer(Player existingPlayer)
        {
            InitializeComponent();
            CurrentPlayer = existingPlayer;

            labelAddEventsPlayerNumber.Text = existingPlayer.Number;
            labelAddEventsPlayerAge.Text = existingPlayer.Age.ToString();
            labelAddEventsPlayerFullName.Text = existingPlayer.FullName();
            labelAddEventsPlayerGender.Text = Util.SexEnumToSex((Util.SexEnum)existingPlayer.Sex);
        }
    }
}
