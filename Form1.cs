using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        //Files conataining players and guilds
        public static string PLAYERS_FILE = "players.txt";
        public static string GUILDS_FILE = "guilds.txt";
        //Create Dictionary for Guilds
        public static Dictionary<uint, Guild> dictGuilds = new Dictionary<uint, Guild>();
        //Create Dictionary for Players
        public static Dictionary<uint, Player> dictPlayers = new Dictionary<uint, Player>();
        //Max player level
        public static uint MAX_LEVEL = 60;
        //Races
        public enum Race { Orc, Troll, Tauren, Forsaken };
        //Classes
        public enum Class { Warrior, Mage, Druid, Priest, Warlock, Rogue, Paladin, Hunter, Shaman }
        //Roles
        public enum Roles { Tank, DPS, Healer }
        //Servers
        //servers are added when file is read
        public static List<string> listServers = new List<string>();
        //Player criteria, SortPlayerList() will display any player name that contains this
        public string playerCriteria = "";
        //Guild type
        //Need in array instead of enum because of 'Mythic+' special cahracter
        public static string[] arrayType = { "Casual", "Questing", "Mythic+", "Raiding", "PVP" };

        /* Form1
         *  Creates the form and reads in from player and guild files
         * */
        public Form1()
        {
            InitializeComponent();
            try
            {
                ReadPlayers(PLAYERS_FILE);
                ReadGuilds(GUILDS_FILE);
            }
            catch (ArgumentException readException)
            {
                TextBox_Output.AppendText("error:" + readException);
            }

            //Displays the player list with no criteria
            SortPlayerList();

            //Fill comboboxes with data
            ComboBox_Guild_Type.DataSource = arrayType;
            ComboBox_Guild_Server.DataSource = listServers;
            ComboBox_Player_Race.DataSource = Enum.GetValues(typeof(Race));
            ComboBox_Player_Class.DataSource = Enum.GetNames(typeof(Class));

            //Set start value of comboboxes to -1/nothing
            ComboBox_Guild_Server.SelectedIndex = -1;
            ComboBox_Guild_Type.SelectedIndex = -1;
            ComboBox_Player_Race.SelectedIndex = -1;
            ComboBox_Player_Class.SelectedIndex = -1;
        }

        //Create guild and player objects, read players and read guilds from file methods
        #region

        /*Guild Class
         * creates a guild object with an id and a name
         * */
        public class Guild : IComparable
        {
            //guild vars
            private uint id;
            private string name;
            private string server;
            private uint type;

            //public properties
            #region

            //Free R/W
            public uint Id
            {
                get { return id; }
                set { id = value; }
            }

            //Free R/W
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            //Free R/W
            public string Server
            {
                get { return server; }
                set { server = value; }
            }

            //Free R/W
            public uint Type
            {
                get { return type; }
                private set
                {
                    if (value >= 0 || value <= arrayType.Length - 1)
                        type = value;
                    else
                    {
                        throw new ArgumentException("Not a valid guild type");
                    }
                }
            }

            #endregion

            /*Default constructor 
             * no arguments
             * */
            public Guild() : this(0, "", "", 0)
            {

            }

            /*Default constructor 
             * arguments for id, name, server, and optional type for when file is read
             * */
            public Guild(uint iId, string iName, string iServer, uint iType = 0)
            {
                Id = iId;
                Name = iName;
                Server = iServer;
                Type = iType;
            }

            /* To string
             * Output the guild
             * */
            public override string ToString()
            {
                //Displays the guild id and name
                string output = String.Format("{0}-{1}", this.Name, this.Server);
                return output;
            }

            /*IComparable
            * overrides comparable
            * */
            public int CompareTo(object alpha)
            {
                //Check for null values
                if (alpha == null) return 1;

                //typecast
                Guild rightOp = alpha as Guild;

                //Items are compared by name
                if (rightOp != null)
                    return Name.CompareTo(rightOp.Name);
                else
                    throw new ArgumentException("Guild CompareTo argument is not an item");
            }
        }

        /* Read in Guilds
         * takes the file to get data from
         * put guilds from file into dictionary
         * */
        public static void ReadGuilds(string input)
        {
            //string to read lines into
            string tempLine;
            //try block to catch filenotfound
            try
            {
                using (StreamReader inFile = new StreamReader(input))
                {
                    //priming the read
                    tempLine = inFile.ReadLine();
                    //while there is still data in the file
                    while (tempLine != null)
                    {
                        //get each piece of the guild separated by tab into an array
                        string[] inGuilds = tempLine.Split('\t', '-');
                        //if the correct number of attributes are on the line, create a guild from line
                        if (inGuilds.Length <= 4)
                        {
                            //Create the guild from the array
                            Guild tempGuild = new Guild(Convert.ToUInt32(inGuilds[0]), inGuilds[1], inGuilds[2]);
                            //add to dictionary of items
                            dictGuilds.Add(tempGuild.Id, tempGuild);
                            //If a new server is input, add it to the list of servers
                            if (!listServers.Contains(inGuilds[2]))
                            {
                                listServers.Add(inGuilds[2]);
                            }
                        }//end of if length

                        //read next line
                        tempLine = inFile.ReadLine();
                    }//end of while
                }//end of using, items have been read in
            }//end of try
            catch (FileNotFoundException)
            {
                Console.WriteLine(input + "file does not exist");
            }
        }

        /* Players class
         * Player Object has an id, name, race, class, level, exp, guildID
         * */
        public class Player : IComparable
        {
            //attributes of player class
            private uint id;
            private string name;
            private Race playerRace;
            private Class playerClass;
            private uint level;
            private uint exp;
            private uint guildID;
            //public properties
            #region
            //R only
            public uint Id
            {
                get { return id; }
                private set { id = value; }
            }

            //R only
            public string Name
            {
                get { return name; }
                private set { name = value; }
            }

            //R only, 4 possible races
            public Race PlayerRace
            {
                get { return playerRace; }
                private set
                {
                    if (value >= (Race)0 || value <= (Race)3)
                        playerRace = value;
                    else
                    {
                        throw new ArgumentException(value + " is not a valid race id");
                    }
                }
            }

            //R only, 9 possible classes
            public Class PlayerClass
            {
                get { return playerClass; }
                private set
                {
                    if (value >= (Class)0 || value <= (Class)8)
                        playerClass = value;
                    else
                    {
                        throw new ArgumentException(value + " is not a valid class id");
                    }
                }
            }

            //Free R/W, [0, MAX_LEVEL]
            public uint Level
            {
                get { return level; }
                set
                {
                    if (value >= 0 || value <= MAX_LEVEL)
                        level = value;
                    else
                    {
                        throw new ArgumentException(value + " is not a valid level");
                    }
                }
            }

            //Normal R access, W acces increments exp and increases level appropriatly
            public uint Exp
            {
                get { return exp; }
                set
                {
                    exp = value;
                }
            }

            //R/W access
            public uint GuildID
            {
                get { return guildID; }
                set { guildID = value; }
            }

            #endregion

            /* Constructor
             * Arguments are id, name, race, class, level, exp, and guildID
             * */
            public Player(uint iID, string iName, Race iPlayerRace, Class iPlayerClass, uint iLevel, uint iExp, uint iGuildID = 0)
            {
                Id = iID;
                Name = iName;
                PlayerRace = iPlayerRace;
                PlayerClass = iPlayerClass;
                Level = iLevel;
                Exp = iExp;
                GuildID = iGuildID;
            }

            /* Default constructor
             * No arguments
             * */
            public Player() : this(0, "", 0, 0, 0, 0, 0)
            {

            }

            /*To String
             * outputs player name, race, class, level, and guild
             * */
            public override string ToString()
            {
                //Displays the player name, race, level, and guild
                string raceString = "" + (Race)this.PlayerRace;
                string levelString = "" + this.Level;
                //if the player is in a guild it will say which guild, if not then nothing
                string guildString = "";
                if (dictGuilds.ContainsKey(this.guildID))
                {
                    guildString = "Guild: " + dictGuilds[this.guildID];
                }

                string output = String.Format("{0}{1}{2}{3}", this.Name.PadRight(20), raceString.PadRight(10), levelString.PadRight(10), guildString);

                return output;
            }

            /*To String
             * outputs player name, race, class, level, and guild
             * */
            public string ToOutPutString()
            {
                //Displays the player name, race, level, and guild
                string raceString = "" + (Race)this.PlayerRace;
                string levelString = "" + this.Level;
                //if the player is in a guild it will say which guild, if not then nothing
                string guildString = "";
                if (dictGuilds.ContainsKey(this.guildID))
                {
                    guildString = "Guild: " + dictGuilds[this.guildID];
                }

                string output = String.Format("Name: {0}Race: {1} Level: {2}{3}", this.Name.PadRight(20), raceString.PadRight(10), levelString.PadRight(10), guildString);

                return output;
            }

            /*IComparable
             * overrides comparable
             * */
            public int CompareTo(object alpha)
            {
                //Check for null values
                if (alpha == null) return 1;

                //typecast
                Player rightOp = alpha as Player;

                //Players are compared by name
                if (rightOp != null)
                    return Name.CompareTo(rightOp.Name);
                else
                    throw new ArgumentException("Player CompareTo argument is not an Player");
            }
        }//end of player class

        /* Read in Players
        * takes the file the players are stored in
        * puts the items into the dictionary
        * */
        public static void ReadPlayers(string input)
        {
            //string to read lines into
            string tempLine;
            //try block to catch filenotfound
            try
            {
                using (StreamReader inFile = new StreamReader(input))
                {
                    //priming the read
                    tempLine = inFile.ReadLine();

                    //while there is still data in the file
                    while (tempLine != null)
                    {
                        //get each piece of the player separated by tab into an array
                        string[] inPlayers = tempLine.Split('\t');
                        //if the correct number of attributes are on the line, create a player from line
                        if (inPlayers.Length < 20)
                        {
                            //Create the player from the array, convert string to uints and other attributes when necessary
                            Player tempPlayer = new Player(Convert.ToUInt32(inPlayers[0]), inPlayers[1], (Race)Convert.ToUInt32(inPlayers[2]), (Class)Convert.ToUInt32(inPlayers[3]), Convert.ToUInt32(inPlayers[4]), Convert.ToUInt32(inPlayers[5]), Convert.ToUInt32(inPlayers[6]));

                            //add to dictionary of players
                            dictPlayers.Add(tempPlayer.Id, tempPlayer);
                        }//end of if length

                        //read next line
                        tempLine = inFile.ReadLine();
                    }//end of while
                }//end of using, items have been read in
            }//end of try
            catch (FileNotFoundException)
            {
                Console.WriteLine(input + "file does not exist");
            }
        }//readPlayers

        #endregion//end of Guild, ReadGuilds, Player, ReadPlayers

        /* SortPlayerList
         * Sorts the player list with the criteria for the player
         * */
        private void SortPlayerList()
        {
            //create sorted set of players to be put in listbox
            List<Player> playerSet = new List<Player>();

            //fill set with players
            foreach (Player p in dictPlayers.Values)
            {
                //If the name of the player contains the search criteria, put in list
                if (p.Name.ToLower().StartsWith(playerCriteria.ToLower()))
                {
                    playerSet.Add(p);
                }
            }

            //Sort set before outputting
            playerSet.Sort();
            //Puts set into Listbox
            ListBox_Players.DataSource = playerSet;
        }

        /*Click on Add Guild Button
         * if nothing is entered in the name field, informs user and does nothing
         * If name is entered creates a guild with a unique id and adds it to the guilds dictionary, informs user
         * */
        private void Button_Add_Guild_Click(object sender, EventArgs e)
        {
            //if there is somthing in the textbox
            if (Textbox_Guild_Name.Text.Length > 0)
            {
                //if server is selected
                if (ComboBox_Guild_Server.SelectedIndex > -1)
                {
                    //if type is selected
                    if (ComboBox_Guild_Type.SelectedIndex > -1)
                    {
                        //Create Ranodm number not in dictionary
                        Random rand = new Random();
                        uint uNum;
                        do
                        {
                            uNum = (uint)rand.Next(0, 999999);
                        } while (dictGuilds.ContainsKey(uNum));

                        //gets the type of guild that was chosen
                        uint guildType = Convert.ToUInt32(Array.IndexOf(arrayType, ComboBox_Guild_Type.Text));

                        //Create a temporary guild to add to the dictionary
                        Guild tempGuild = new Guild(uNum, Textbox_Guild_Name.Text, ComboBox_Guild_Server.Text, guildType);

                        //add guild to dictionary
                        dictGuilds.Add(uNum, tempGuild);

                        //Inform user of guild creation
                        TextBox_Output.Clear();
                        TextBox_Output.AppendText(Textbox_Guild_Name.Text + " has been added as a guild!\n");
                        Textbox_Guild_Name.Clear();
                        //reset inputs
                        ComboBox_Guild_Server.SelectedIndex = -1;
                        ComboBox_Guild_Type.SelectedIndex = -1;
                    }
                    else
                    //If they do not select a server
                    {
                        TextBox_Output.Clear();
                        TextBox_Output.AppendText("Please select a Guild Type");
                    }
                }
                else
                //If they do not select a server
                {
                    TextBox_Output.Clear();
                    TextBox_Output.AppendText("Please select a Server");
                }
            }
            else
            //If they do not enter a name inform user
            {
                TextBox_Output.Clear();
                TextBox_Output.AppendText("You need a Guild Name to create a guild!");
            }
        }

        /*Click on add player button
         * Checks name textbox, race, class, and role combobox. If all are filled out, create a playe rwith those values
         * */
        private void Button_Add_Player_Click(object sender, EventArgs e)
        {
            //If there is something in the textbox
            if (Textbox_Player_Name.Text.Length > 0)
            {
                //If selection in the race combobox
                if (ComboBox_Player_Race.SelectedIndex > -1)
                {
                    //If selection in the Class combobox
                    if (ComboBox_Player_Class.SelectedIndex > -1)
                    {
                        //If selection in the Role combobox
                        if (ComboBox_Player_Role.SelectedIndex > -1)
                        {
                            //If all boxes are filled and chosen,  create player

                            //Create random number that is not currently a key in the dictionary
                            Random rand = new Random();
                            uint uNum;
                            do
                            {
                                uNum = (uint)rand.Next(0, 99999999);
                            } while (dictPlayers.ContainsKey(uNum));

                            //get the largest key of the dictionary and add 1, will always be unique

                            //Create a temporary player to add to the dictionary
                            Player tempPlayer = new Player(uNum, Textbox_Player_Name.Text, (Race)ComboBox_Player_Race.SelectedIndex, (Class)ComboBox_Player_Class.SelectedIndex, 0, 0);
                            dictPlayers.Add(uNum, tempPlayer);

                            //Inform user of guild creation
                            TextBox_Output.Clear();
                            TextBox_Output.AppendText(Textbox_Player_Name.Text + " has been added as a player!\n");
                            Textbox_Player_Name.Clear();
                            //reset inputs
                            ComboBox_Player_Race.SelectedIndex = -1;
                            ComboBox_Player_Class.SelectedIndex = -1;
                            ComboBox_Player_Role.SelectedIndex = -1;

                            //Update list with new player
                            SortPlayerList();
                        }//end of role if
                        else
                        {
                            TextBox_Output.Clear();
                            TextBox_Output.AppendText("Please choose a Role for the Player");
                        }
                    }//End of class if
                    else
                    {
                        TextBox_Output.Clear();
                        TextBox_Output.AppendText("Please choose a Class for the Player");
                    }
                }//end of race if
                else
                {
                    TextBox_Output.Clear();
                    TextBox_Output.AppendText("Please choose a Race for the Player");
                }
            }//emd of Player name if
            else
            {
                TextBox_Output.Clear();
                TextBox_Output.AppendText("You need a Player Name to create a player!");
            }
        }

        /* Player Class ComboBox index change
         * When the user chooses a class, the roles available for that class become available to select
         * */
        private void ComboBox_Player_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When a class is selected, populate the role combobox with appropriate roles
            int roleNum = ComboBox_Player_Class.SelectedIndex;

            //Roles for classes
            switch (roleNum)
            {
                //DPS Only
                case 1://Mage
                case 4://Warlock
                case 5://Rogue
                case 7://Hunter
                    ComboBox_Player_Role.Items.Clear();
                    ComboBox_Player_Role.Items.Add((Roles)1);
                    ComboBox_Player_Role.SelectedIndex = 0;
                    break;
                //Healer or DPS
                case 3://Priest
                case 8://Shaman
                    ComboBox_Player_Role.Items.Clear();
                    ComboBox_Player_Role.Items.Add((Roles)1);
                    ComboBox_Player_Role.Items.Add((Roles)2);
                    break;
                //Tank or DPS
                case 0://Warrior
                    ComboBox_Player_Role.Items.Clear();
                    ComboBox_Player_Role.Items.Add((Roles)0);
                    ComboBox_Player_Role.Items.Add((Roles)1);
                    break;
                //Tank, DPS, Healer
                case 2://Druid
                case 6://Paladin
                    ComboBox_Player_Role.Items.Clear();
                    ComboBox_Player_Role.Items.Add((Roles)0);
                    ComboBox_Player_Role.Items.Add((Roles)1);
                    ComboBox_Player_Role.Items.Add((Roles)2);
                    break;
                //If No class, no options
                default:
                    ComboBox_Player_Role.Items.Clear();
                    break;
            }
        }

        /*Click on apply search button
         * Checks name textbox, race, class, and role combobox. If all are filled out, create a playe rwith those values
         * */
        private void Button_Apply_Search_Click(object sender, EventArgs e)
        {
            //create sorted set of guilds to be put in listbox
            List<Guild> guildSet = new List<Guild>();
            
            playerCriteria = Textbox_Search_Player.Text;
            SortPlayerList();

            //fill set with guilds
            foreach (Guild guild in dictGuilds.Values)
            {
                //If the name of the player contains the search criteria, put in list
                if (guild.Name.ToLower().StartsWith(Textbox_Search_Guild.Text.ToLower()))
                {
                    guildSet.Add(guild);
                }
            }

            //Sort set before outputting
            guildSet.Sort();

            //Puts set into Listbox
            ListBox_Guilds.DataSource = guildSet;
        }

        /*Click on print guild roster button
         * Checks guild listbox. If a guild is selected, print out the guild roster
         * */
        private void Button_Print_Guild_Roster_Click(object sender, EventArgs e)
        {
            //Declare and set objects
            KeyValuePair<uint, Guild> selectedGuild;
           
            //Test if a guild is selected
            if (ListBox_Guilds.SelectedIndex > -1)
            {
                selectedGuild = dictGuilds.ElementAt(ListBox_Guilds.SelectedIndex);         

                //Print the Guild Roster
                TextBox_Output.Clear(); //Clear the Output TextBox
                TextBox_Output.AppendText("Guild Listing for " + selectedGuild.Value.Name + " " + selectedGuild.Value.Server); //Print Output title
                TextBox_Output.AppendText("\n---------------------------------------------------------------------\n");

                //Print each player in the guild
                foreach (KeyValuePair<uint, Player> player in dictPlayers)
                {
                    //Test if the player is in the guild
                    if (selectedGuild.Value.Id == player.Value.GuildID)
                    {   //Print player information
                        TextBox_Output.AppendText(tempPlayer.ToOutPutString() + "\n");
                    }
                }
            }
            else //No guild is selected
            {
                TextBox_Output.AppendText("Please select a guild and try again.");
            }
        }

        /*Click on dispand guild button
        * Gets the selected guild and dispands it
        * */
        private void Button_Dispand_Guild_Click(object sender, EventArgs e)
        {
            //Declare and set objects
            KeyValuePair<uint, Guild> selectedGuild;

            //create sorted set of guilds to be put in listbox
            List<Guild> guildSet = new List<Guild>();

            //Test if a guild is selected
            if (ListBox_Guilds.SelectedIndex > -1)
            {   //Get selected guild
                selectedGuild = dictGuilds.ElementAt(ListBox_Guilds.SelectedIndex);

                //Remove players from guild
                foreach (KeyValuePair<uint, Player> player in dictPlayers)
                {   //Test if the player is in the guild
                    if (selectedGuild.Value.Id == player.Value.GuildID)
                    {   //Remove player from guild
                        player.Value.GuildID = 0;
                    }
                }
                
                //fill set with guilds
                foreach (Guild guild in dictGuilds.Values)
                {
                    //If the name of the player contains the search criteria, put in list
                    if (guild.Id != selectedGuild.Value.Id)
                    {
                        guildSet.Add(guild);
                    }
                }

                //Sort set before outputting
                guildSet.Sort();

                //Puts set into Listbox
                ListBox_Guilds.DataSource = guildSet;

                //Remove guild
                dictGuilds.Remove(selectedGuild.Key);

                //Print message
                TextBox_Output.Clear(); //Clear the Output TextBox
                TextBox_Output.AppendText("Guild " + selectedGuild.Value.Name + " has been dispanded.");
            }
            else //No guild is selected
            {
                TextBox_Output.AppendText("Error! No guild has been selected. Please select a guild from the guild list and try again.");
            }
        }

        /*Click on join guild button
        * Gets the selected guild, then selected player, then puts player into guild
        * */
        private void Button_Join_Guild_Click(object sender, EventArgs e)
        {
            //Declare and set objects
            KeyValuePair<uint, Guild> selectedGuild;
            KeyValuePair<uint, Player> selectedPlayer;
            
            //Test if a guild is selected
            if (ListBox_Guilds.SelectedIndex > -1)
            {   //Test if a player is selected
                if (ListBox_Players.SelectedIndex > -1)
                {   //Get the selected guild and player
                    selectedGuild = dictGuilds.ElementAt(ListBox_Guilds.SelectedIndex);
                    selectedPlayer = dictPlayers.ElementAt(ListBox_Players.SelectedIndex);

                    //Have player join guild
                    dictPlayers[selectedPlayer.Value.Id].GuildID = selectedGuild.Value.Id;

                    //Print message
                    TextBox_Output.Clear(); //Clear the Output TextBox
                    TextBox_Output.AppendText("Player " + selectedPlayer.Value.Name + " has joined guild " + selectedGuild.Value.Name);
                }
                else //No player is selected
                {   //Print Error Message
                    TextBox_Output.Clear(); //Clear the Output TextBox
                    TextBox_Output.AppendText("Error! No player has been selected. Please select a player from the player list and try again.");
                }
            }
            else //No guild is selected
            {   //Print Error Message
                TextBox_Output.Clear(); //Clear the Output TextBox
                TextBox_Output.AppendText("Error! No guild has been selected. Please select a guild from the guild list and try again.");
            }
        }

        /*Click on leave guild button
         * Gets the selected guild, then selected player, then removes player from guild
         * */
        private void Button_Leave_Guild_Click(object sender, EventArgs e)
        {
            //Declare and set objects
            KeyValuePair<uint, Guild> selectedGuild;
            KeyValuePair<uint, Player> selectedPlayer;

            //Test if a guild is selected
            if (ListBox_Guilds.SelectedIndex > -1)
            {   //Test if a player is selected
                if (ListBox_Players.SelectedIndex > -1)
                {   //Get the selected guild and player
                    selectedGuild = dictGuilds.ElementAt(ListBox_Guilds.SelectedIndex);
                    selectedPlayer = dictPlayers.ElementAt(ListBox_Players.SelectedIndex);

                    //Test if Player is in a guild
                    if (dictPlayers[selectedPlayer.Value.Id].GuildID != 0)
                    {
                        //Have player leave guild
                        dictPlayers[selectedPlayer.Value.Id].GuildID = 0;

                        //Print message
                        TextBox_Output.Clear(); //Clear the Output TextBox
                        TextBox_Output.AppendText("Player " + selectedPlayer.Value.Name + " has left guild " + selectedGuild.Value.Name);
                    }
                    else //Player is not in a guild
                    {   //Print message
                        TextBox_Output.Clear(); //Clear the Output TextBox
                        TextBox_Output.AppendText("Player " + selectedPlayer.Value.Name + " is not in a guild");
                    }
                }
                else //No player is selected
                {   //Print Error Message
                    TextBox_Output.Clear(); //Clear the Output TextBox
                    TextBox_Output.AppendText("Error! No player has been selected. Please select a player from the player list and try again.");
                }
            }
            else //No guild is selected
            {   //Print Error Message
                TextBox_Output.Clear(); //Clear the Output TextBox
                TextBox_Output.AppendText("Error! No guild has been selected. Please select a guild from the guild list and try again.");
            }
        }
    }//form1
}//namespace