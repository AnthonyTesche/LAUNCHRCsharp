using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace LAUNCHR
{
    public partial class FormPlanet : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public FormPlanet(ExoPlanet planet, object sender, EventArgs e)
        {
            InitializeComponent();
            flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowPanel.AutoScroll = true;
            pl_hostnameTitle.Text = planet.pl_hostname;
            try
            {
                int xPanel = 3;
                int yPanel = 3;
                var prop = planet.GetType().GetProperties();
                foreach (var props in prop)
                {
                    var variable = props.GetMethod;
                    object xx = variable.Invoke(planet, null);
                    if (xx == null)
                    {
                        continue;
                    }
                    if (!String.IsNullOrEmpty(variable.Invoke(planet, null).ToString()))
                    {
                        Panel p = new Panel();
                        p.Name = variable.Invoke(planet, null).ToString() + "Panel";
                        p.Location = new System.Drawing.Point(xPanel, yPanel);
                        p.Size = new System.Drawing.Size(141, 45);
                        p.BackColor = Color.FromArgb(0, 191, 255);
                        flowPanel.Controls.Add(p);
                        xPanel += 146;

                        Label labelVar = new Label();
                        labelVar.Text = props.Name;
                        labelVar.Name = props.Name + "Label";
                        labelVar.Location = new System.Drawing.Point(3, 0);
                        p.Controls.Add(labelVar);

                        Label quest = new Label();
                        quest.Text = "?";
                        quest.Font = new Font("Georgia", 10, FontStyle.Bold);
                        quest.Name = variable.Invoke(planet, null).ToString() + "_Quest";
                        quest.Click += new EventHandler((senderQuest, eQuest) => Quest_Click(sender, e, props.Name));
                        quest.Location = new System.Drawing.Point(109, 22);
                        p.Controls.Add(quest);

                        TextBox txtb = new TextBox();
                        txtb.Name = props.Name + "Box";
                        txtb.Location = new System.Drawing.Point(3, 20);
                        txtb.Size = new System.Drawing.Size(100, 20);
                        txtb.Text = variable.Invoke(planet, null).ToString();
                        txtb.TextAlign = HorizontalAlignment.Center;
                        txtb.Font = new Font("Georgia", 9);
                        p.Controls.Add(txtb);
                    }
                }
            } catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
        private void commentsButton_Click(object sender, EventArgs e)
        {
            try
            {
                CommentsForm comForm = new CommentsForm(pl_hostnameTitle.Text);
                comForm.ShowDialog();
            } catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
            
        }

        private void Quest_Click(object sender, EventArgs e, string questName)
        {
            if (questName == "pl_hostname")
            {
                MessageBox.Show("Host Star Name \n".Trim() + Environment.NewLine + "\nStellar name most commonly used in the literature. 	  	  	  	 ".Trim());
            }
            if (questName == "pl_letter")
            {
                MessageBox.Show("Planet Letter \n".Trim() + Environment.NewLine + "\nLetter assigned to the planetary component of a planetary system. 	  	  	  	 ".Trim());
            }
            if (questName == "pl_name")
            {
                MessageBox.Show("Planet Name \n".Trim() + Environment.NewLine + "\nPlanet name most commonly used in the literature. 	  	  	  	 ".Trim());
            }
            if (questName == "pl_discmethod")
            {
                MessageBox.Show("Discovery Method \n".Trim() + Environment.NewLine + "\nMethod by which the planet was first identified. 	  	  	  	 ".Trim());
            }
            if (questName == "pl_controvflag")
            {
                MessageBox.Show("Controversial Flag \n".Trim() + Environment.NewLine + "\nFlag indicating whether the confirmation status of a planet has been questioned in the published literature (1=yes, 0=no) 	  	  	  	 ".Trim());
            }
            if (questName == "pl_pnum")
            {
                MessageBox.Show("Number of Planets in System \n".Trim() + Environment.NewLine + "\nNumber of planets in the planetary system. 	  	  	  	 ".Trim());
            }
            if (questName == "pl_orbper")
            {
                MessageBox.Show("Orbital Period (days) \n".Trim() + Environment.NewLine + "\nTime the planet takes to make a complete orbit around the host star or system. 	".Trim());
            }
            if (questName == "pl_orbsmax")
            {
                MessageBox.Show("Orbit Semi-Major Axis (au) \n".Trim() + Environment.NewLine + "\nThe longest radius of an elliptic orbit, or, for exoplanets detected via gravitational microlensing or direct imaging, the projected separation in the plane of the sky. 	".Trim());
            }
            if (questName == "pl_orbeccen")
            {
                MessageBox.Show("Eccentricity \n".Trim() + Environment.NewLine + "\nAmount by which the orbit of the planet deviates from a perfect circle. 	".Trim());
            }
            if (questName == "pl_orbincl")
            {
                MessageBox.Show("Inclination (deg) \n".Trim() + Environment.NewLine + "\nAngle of the plane of the orbit relative to the plane perpendicular to the line-of-sight from Earth to the object. 	".Trim());
            }
            if (questName == "pl_bmassj")
            {
                MessageBox.Show("Planet Mass or M*sin(i) [Jupiter mass] \n".Trim() + Environment.NewLine + "\nBest planet mass estimate available, in order of preference: Mass, M*sin(i)/sin(i), or M*sin(i), depending on availability, and measured in Jupiter masses. See Planet Mass M*sin(i) Provenance (pl_bmassprov) to determine which measure applies. 	".Trim());
            }
            if (questName == "pl_bmassprov")
            {
                MessageBox.Show("Planet Mass or M*sin(i) Provenance \n".Trim() + Environment.NewLine + "\nProvenance of the measurement of the best mass. Options are: Mass, M*sin(i)/sin(i), and M*sini. 	".Trim());
            }
            if (questName == "pl_radj")
            {
                MessageBox.Show("Planet Radius (Jupiter radii) \n".Trim() + Environment.NewLine + "\nLength of a line segment from the center of the planet to its surface, measured in units of radius of Jupiter.".Trim());
            }
            if (questName == "pl_dens")
            {
                MessageBox.Show("Planet Density (g/cm**3) \n".Trim() + Environment.NewLine + "\nAmount of mass per unit of volume of the planet. 	".Trim());
            }
            if (questName == "pl_ttvflag")
            {
                MessageBox.Show("TTV Flag \n".Trim() + Environment.NewLine + "\nFlag indicating if the planet orbit exhibits transit timing variations from another planet in the system (1=yes, 0=no).".Trim() + Environment.NewLine + "\nNote: Non-transiting planets discovered via the transit timing variations of another planet in the system will not have their TTV flag set, since they do not themselves demonstrate TTVs. 	  	  	  	 ".Trim());
            }

            if (questName == "pl_kepflag")
            {
                MessageBox.Show("Kepler Field Flag \n".Trim() + Environment.NewLine + "\nFlag indicating if the planetary system signature is present in data taken with the Kepler mission (1=yes, 0=no).".Trim());
            }
            if (questName == "pl_k2flag")
            {
                MessageBox.Show("K2 Mission Flag \n".Trim() + Environment.NewLine + "\nFlag indicating if the planetary system signature is present in data taken with the K2 Mission (1=yes, 0=no).".Trim());
            }
            if (questName == "pl_nnotes")
            {
                MessageBox.Show("Number of Notes \n".Trim() + Environment.NewLine + "\nNumber of Notes associated with the planet. View all notes in the Confirmed Planet Overview page. 	  	  	  	 ".Trim());
            }
            if (questName == "ra_str")
            {
                MessageBox.Show("RA (sexagesimal) \n".Trim() + Environment.NewLine + "\nRight Ascension of the planetary system in sexagesimal format.".Trim());
            }
            if (questName == "dec_str")
            {
                MessageBox.Show("Dec (sexagesimal) \n".Trim() + Environment.NewLine + "\nDeclination of the planetary system in sexagesimal notation.".Trim());
            }
            if (questName == "ra")
            {
                MessageBox.Show("RA (decimal degrees) \n".Trim() + Environment.NewLine + "\nRight Ascension of the planetary system in decimal degrees.".Trim());
            }
            if (questName == "dec")
            {
                MessageBox.Show("Dec (decimal degrees) \n".Trim() + Environment.NewLine + "\nDeclination of the planetary system in decimal degrees.".Trim());
            }
            if (questName == "st_dist")
            {
                MessageBox.Show("Distance (pc) \n".Trim() + Environment.NewLine + "\nDistance to the planetary system in units of parsecs. 	".Trim());
            }
            if (questName == "gaia_dist")
            {
                MessageBox.Show("Gaia Distance [pc] \n".Trim() + Environment.NewLine + "\nDistance computed from Gaia parallax. 	".Trim());
            }
            if (questName == "st_optmag")
            {
                MessageBox.Show("Optical Magnitude [mag] \n".Trim() + Environment.NewLine + "\nBrightness of the host star as measured using the V (Johnson) or the Kepler-band in units of magnitudes. 	".Trim());
            }
            if (questName == "st_optband")
            {
                MessageBox.Show("Optical Magnitude Band \n".Trim() + Environment.NewLine + "\nBand corresponding to the Optical Magnitude. Options are: V (Johnson) or Kepler-band. 	".Trim());
            }
            if (questName == "gaia_gmag")
            {
                MessageBox.Show("G-band (Gaia) [mag] \n".Trim() + Environment.NewLine + "\nBrightness of the host star as measuring using the Gaia band in units of magnitudes. Objects matched to Gaia using the Hipparcos or 2MASS IDs provided in Gaia DR2. 	gaia_gmagerr 	gaia_gmagstr 	gaia_gmaglim 	 ".Trim());
            }
            if (questName == "st_teff")
            {
                MessageBox.Show("Effective Temperature (K) \n".Trim() + Environment.NewLine + "\nTemperature of the star as modeled by a black body emitting the same total amount of electromagnetic radiation.".Trim());
            }
            if (questName == "st_mass")
            {
                MessageBox.Show("Stellar Mass (solar mass) \n".Trim() + Environment.NewLine + "\nAmount of matter contained in the star, measured in units of masses of the Sun. 	".Trim());
            }
            if (questName == "st_rad")
            {
                MessageBox.Show("Stellar Radius (solar radii) \n".Trim() + Environment.NewLine + "\nLength of a line segment from the center of the star to its surface, measured in units of radius of the Sun.".Trim());
            }
            if (questName == "rowupdate")
            {
                MessageBox.Show("Date of Last Update \n".Trim() + Environment.NewLine + "\nDate of last update of the planet parameters. 	  	  	  	 ".Trim());
            }
            if (questName == "pl_facility")
            {
                MessageBox.Show("Discovery Facility \n".Trim() + Environment.NewLine + "\nName of facility of planet discovery observations 	  	  	  	 ".Trim());
            }
        }

        // Form Commands
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DragWindow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DragWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void DragWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
