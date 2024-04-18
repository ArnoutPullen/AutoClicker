using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class AutoClickerForm : Form
    {
        private readonly Timer Timer;
        private readonly GlobalKeyListener globalKeyListener;
        private readonly GlobalMouseAPI globalMouseApi;

        private int ClickIntervalHours = 0;
        private int ClickIntervalMinutes = 0;
        private int ClickIntervalSeconds = 0;
        private int ClickIntervalMiliseconds = 0;
        private int RepeatTimes = 1;
        private bool IsPickingLocation = false;

        public AutoClickerForm()
        {
            InitializeComponent();

            globalKeyListener = new GlobalKeyListener();
            globalKeyListener.OnKeyPress += OnKeyPress;
            // Instantiate the GlobalMouseAPI class
            globalMouseApi = new GlobalMouseAPI();

            Timer = new Timer();
            Timer.Interval = 100;
            Timer.Tick += new EventHandler(TimerTickEvent);
            Stop.Enabled = false;
            ClickIntervalHoursTextBox.Text = Properties.Settings.Default.ClickIntervalHours.ToString();
            ClickIntervalMinutesTextBox.Text = Properties.Settings.Default.ClickIntervalMinutes.ToString();
            ClickIntervalSecondsTextBox.Text = Properties.Settings.Default.ClickIntervalSeconds.ToString();
            ClickIntervalMilisecondsTextBox.Text = Properties.Settings.Default.ClickIntervalMiliseconds.ToString();
            RandomOffsetCheckbox.Checked = Properties.Settings.Default.RandomOffset;
            RandomOffsetMilisecondsTextBox.Text = Properties.Settings.Default.RandomOffsetMiliseconds.ToString();
            MouseButtonComboBox.Items.Add("Left");
            MouseButtonComboBox.Items.Add("Middle");
            MouseButtonComboBox.Items.Add("Right");
            MouseButtonComboBox.SelectedIndex = Properties.Settings.Default.MouseButton;
            ClickTypeComboBox.Items.Add("Single");
            ClickTypeComboBox.Items.Add("Double");
            ClickTypeComboBox.SelectedIndex = Properties.Settings.Default.ClickType;
            ClickRepeatRadioButton.Checked = Properties.Settings.Default.ClickRepeat;
            ClickRepeatTextBox.Value = Properties.Settings.Default.ClickRepeatTimes;
            RepeatTimes = int.Parse(Properties.Settings.Default.ClickRepeatTimes.ToString());
            ClickRepeatUntilStoppedRadioButton.Checked = Properties.Settings.Default.ClickRepeatUntilStopped;
            CurrentLocationRadioButton.Checked = Properties.Settings.Default.CurrentLocation;
            PickLocationRadioButton.Checked = Properties.Settings.Default.PickLocation;
            PickLocationXTextBox.Text = Properties.Settings.Default.PickLocationX.ToString();
            PickLocationYTextBox.Text = Properties.Settings.Default.PickLocationY.ToString();
        }

        private void OnKeyPress(Keys key)
        {
            if (key == Keys.F6)
            {
                ToggleTimer();
            }
        }

        private void ToggleTimer()
        {
            if (Timer.Enabled)
            {
                StopTimer();
            }
            else
            {
                StartTimer();
            }
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StartTimer()
        {
            Console.WriteLine($"Starting {Timer.Enabled}");

            Start.Enabled = false;
            Stop.Enabled = true;

            // Stop the timer if it is already running
            if (Timer.Enabled) Timer.Stop();

            Timer.Start();
            Console.WriteLine($"Started {Timer.Enabled}");
        }

        private void StopButtonClick(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void StopTimer()
        {
            Console.WriteLine($"Stopping {Timer.Enabled}");

            Start.Enabled = true;
            Stop.Enabled = false;

            // Stop the timer
            Timer.Stop();

            Console.WriteLine($"Stopped {Timer.Enabled}");
        }

        private void TimerTickEvent(object sender, EventArgs e)
        {
            if (PickLocationRadioButton.Checked)
            {
                var x = PickLocationXTextBox.Text.Length > 0 ? int.Parse(PickLocationXTextBox.Text) : 0;
                var y = PickLocationYTextBox.Text.Length > 0 ? int.Parse(PickLocationYTextBox.Text) : 0;

                if (x == 0 || y == 0)
                {
                    MessageBox.Show("Please enter valid X and Y coordinates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Single click
                if (ClickTypeComboBox.SelectedIndex == 0)
                {
                    if (MouseButtonComboBox.SelectedIndex == 0)
                    {
                        // Left click
                        GlobalMouseAPI.LeftClick(x, y);
                    } else if (MouseButtonComboBox.SelectedIndex == 1)
                    {
                        // Middle click
                        GlobalMouseAPI.MiddleClick(x, y);
                    } else if (MouseButtonComboBox.SelectedIndex == 2)
                    {
                        // Right click
                        GlobalMouseAPI.RightClick(x, y);
                    } else
                    {
                        MessageBox.Show("Invalid mouse button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (ClickTypeComboBox.SelectedIndex == 1)
                {
                    // Double click
                    if (MouseButtonComboBox.SelectedIndex == 0)
                    {
                        // Left click
                        GlobalMouseAPI.LeftClick(x, y);
                        GlobalMouseAPI.LeftClick(x, y);
                    }
                    else if (MouseButtonComboBox.SelectedIndex == 1)
                    {
                        // Middle click
                        GlobalMouseAPI.MiddleClick(x, y);
                        GlobalMouseAPI.MiddleClick(x, y);
                    }
                    else if (MouseButtonComboBox.SelectedIndex == 2)
                    {
                        // Right click
                        GlobalMouseAPI.RightClick(x, y);
                        GlobalMouseAPI.RightClick(x, y);
                    }
                    else
                    {
                        MessageBox.Show("Invalid mouse button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid click type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else // if (CurrentLocationRadioButton.Checked)
            {
                if (ClickTypeComboBox.SelectedIndex == 0)
                {
                    if (MouseButtonComboBox.SelectedIndex == 0)
                    {
                        // Left click
                        GlobalMouseAPI.LeftClick();
                    }
                    else if (MouseButtonComboBox.SelectedIndex == 1)
                    {
                        // Middle click
                        GlobalMouseAPI.MiddleClick();
                    }
                    else if (MouseButtonComboBox.SelectedIndex == 2)
                    {
                        // Right click
                        GlobalMouseAPI.RightClick();
                    } else
                    {
                        MessageBox.Show("Invalid mouse button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (ClickTypeComboBox.SelectedIndex == 1)
                {
                    // Double click
                    if (MouseButtonComboBox.SelectedIndex == 0)
                    {
                        // Left click
                        GlobalMouseAPI.LeftClick();
                        GlobalMouseAPI.LeftClick();
                    }
                    else if (MouseButtonComboBox.SelectedIndex == 1)
                    {
                        // Middle click
                        GlobalMouseAPI.MiddleClick();
                        GlobalMouseAPI.MiddleClick();
                    }
                    else if (MouseButtonComboBox.SelectedIndex == 2)
                    {
                        // Right click
                        GlobalMouseAPI.RightClick();
                        GlobalMouseAPI.RightClick();
                    }
                    else
                    {
                        MessageBox.Show("Invalid mouse button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid click type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (ClickRepeatRadioButton.Checked)
            {
                if (RepeatTimes <= 0)
                {
                    StopTimer();
                    // Reset the repeat times
                    RepeatTimes = (int)ClickRepeatTextBox.Value;
                } else
                {
                    System.Console.WriteLine($"Repeat times: {RepeatTimes}");
                    // Decrement the repeat times
                    RepeatTimes--;
                }
            }

            if (ClickRepeatUntilStoppedRadioButton.Checked)
            {
                // Do nothing
            }

            // When random offset is enabled, calculate the new random interval for the next tick
            if (RandomOffsetCheckbox.Checked)
            {
                ReCalculateTimerInterval();
            }
        }

        private void ClickIntervalHoursChanged(object sender, EventArgs e)
        {
            ClickIntervalHours = ClickIntervalHoursTextBox.Text.Length > 0 ? int.Parse(ClickIntervalHoursTextBox.Text) : 0;
            ReCalculateTimerInterval();

            // Save the settings
            Properties.Settings.Default.ClickIntervalHours = ClickIntervalHours;
            Properties.Settings.Default.Save();
        }

        private void ClickIntervalMinutesChanged(object sender, EventArgs e)
        {
            ClickIntervalMinutes = ClickIntervalMinutesTextBox.Text.Length > 0 ? int.Parse(ClickIntervalMinutesTextBox.Text) : 0;
            ReCalculateTimerInterval();

            // Save the settings
            Properties.Settings.Default.ClickIntervalMinutes = ClickIntervalMinutes;
            Properties.Settings.Default.Save();
        }

        private void ClickIntervalSecondsChanged(object sender, EventArgs e)
        {
            ClickIntervalSeconds = ClickIntervalSecondsTextBox.Text.Length > 0 ? int.Parse(ClickIntervalSecondsTextBox.Text) : 0;
            ReCalculateTimerInterval();

            // Save the settings
            Properties.Settings.Default.ClickIntervalSeconds = ClickIntervalSeconds;
            Properties.Settings.Default.Save();
        }

        private void ClickIntervalMiliseconds_TextChanged(object sender, EventArgs e)
        {
            ClickIntervalMiliseconds = ClickIntervalMilisecondsTextBox.Text.Length > 0 ? int.Parse(ClickIntervalMilisecondsTextBox.Text) : 0;
            ReCalculateTimerInterval();

            // Save the settings
            Properties.Settings.Default.ClickIntervalMiliseconds = ClickIntervalMiliseconds;
            Properties.Settings.Default.Save();
        }

        private int CalculateTimerInterval()
        {
            int interval = ClickIntervalHours * 3600000 + ClickIntervalMinutes * 60000 + ClickIntervalSeconds * 1000 + ClickIntervalMiliseconds;

            if (RandomOffsetCheckbox.Checked)
            {
                var random = new Random();
                interval += random.Next(Properties.Settings.Default.RandomOffsetMiliseconds);
            }

            return interval;
        }

        private void ReCalculateTimerInterval()
        {
            int interval = CalculateTimerInterval();
            // Fall back to 100ms if the interval is less than or equal to 0
            if (interval <= 0) interval = 100;
            System.Console.WriteLine($"Interval: {interval}");
            Timer.Interval = interval;
        }

        private void RandomOffsetCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ReCalculateTimerInterval();

            if (RandomOffsetCheckbox.Checked)
            {
                RandomOffsetMilisecondsTextBox.Enabled = true;
            }
            else
            {
                RandomOffsetMilisecondsTextBox.Enabled = false;
            }

            Properties.Settings.Default.RandomOffset = RandomOffsetCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void RandomOffsetMilisecondsTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RandomOffsetMiliseconds = RandomOffsetMilisecondsTextBox.Text.Length > 0 ? int.Parse(RandomOffsetMilisecondsTextBox.Text) : 0;
            Properties.Settings.Default.Save();

            ReCalculateTimerInterval();
        }

        private void MouseButtonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MouseButton = MouseButtonComboBox.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void ClickTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClickType = ClickTypeComboBox.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void ClickRepeatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClickRepeat = ClickRepeatRadioButton.Checked;
            Properties.Settings.Default.Save();
        }

        private void ClickRepeatTextBox_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClickRepeatTimes = ClickRepeatTextBox.Value;
            Properties.Settings.Default.Save();
        }

        private void ClickRepeatUntilStoppedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClickRepeatUntilStopped = ClickRepeatUntilStoppedRadioButton.Checked;
            Properties.Settings.Default.Save();
        }

        private void CurrentLocationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentLocation = CurrentLocationRadioButton.Checked;
            Properties.Settings.Default.Save();
        }

        private void PickLocationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PickLocation = PickLocationRadioButton.Checked;
            Properties.Settings.Default.Save();
        }

        private async void PickLocationButton_Click(object sender, EventArgs e)
        {
            // Hide the form
            this.Hide();

            // TODO: Show tooltip at mouse with instructions and x/y coordinates

            IsPickingLocation = true;

            // Subscribe to the mouse event
            globalMouseApi.MouseAction += OnMouseAction;

            // Wait for the mouse event
            while (IsPickingLocation)
            {
                await Task.Delay(1000);
            }

            // Unsubscribe from the mouse event
            globalMouseApi.MouseAction -= OnMouseAction;

            IsPickingLocation = false;

            // Show the form
            this.Show();
        }

        private void OnMouseAction(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsPickingLocation = false;

                PickLocationXTextBox.Text = e.X.ToString();
                PickLocationYTextBox.Text = e.Y.ToString();

                // Store the x and y coordinates
                Properties.Settings.Default.PickLocationX = e.X;
                Properties.Settings.Default.PickLocationY = e.Y;
                Properties.Settings.Default.Save();
            }
        }

        private void PickLocationXTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PickLocationX = PickLocationXTextBox.Text.Length > 0 ? int.Parse(PickLocationXTextBox.Text) : 0;
            Properties.Settings.Default.Save();
        }

        private void PickLocationYTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PickLocationY = PickLocationYTextBox.Text.Length > 0 ? int.Parse(PickLocationYTextBox.Text) : 0;
            Properties.Settings.Default.Save();
        }
    }
}
