using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using TournamentTrackerOne.BAL;

namespace TournamentTrackerOne.DAL
{
    class DatabaseQueries
    {

        // Creating Conenction //
        public static SqlConnection GetConnection()
        {
            string conString = "Data Source = DESKTOP-5BHA0DA; Initial Catalog = TournamentTracker; Integrated Security = true;";

            SqlConnection connection = new SqlConnection(conString);

            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection Un-Successful!!", "Error");
            }

            return connection;
        }

        // Tournament Owner Sign Up //
        public static void TOwnerSignUp(TournamentOwner obj)
        {
            string query = "INSERT INTO TournamentOwner VALUES (@TournamentOwner_ID, @FirstName, @LastName, @Email, @Address_, @ContactNo, @UserName, @Password_);";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TournamentOwner_ID", obj.tournamentID);
            command.Parameters.AddWithValue("@FirstName", obj.firstName);
            command.Parameters.AddWithValue("@LastName", obj.lastName);
            command.Parameters.AddWithValue("@Email", obj.email);
            command.Parameters.AddWithValue("@Address_", obj.address);
            command.Parameters.AddWithValue("@ContactNo", obj.contactNo);
            command.Parameters.AddWithValue("@UserName", obj.username);
            command.Parameters.AddWithValue("@Password_", obj.password);


            command.ExecuteNonQuery();
        }

        // Tournament Owner Log in //
        public static bool TOwnerLogin(string username, string password)
        {
            string query = "SELECT UserName, Password_ FROM TournamentOwner WHERE UserName = '" + username + "' AND Password_ = '" + password + "';";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adpt.Fill(dataTable);

            bool check = false;
            if(dataTable.Rows.Count == 1)
            {
                check = true;
            }
            else
            {
                check = false;
            }

            return check;
        }


        // Add Captain Record //
        public static void AddCaptainRecord(Captain obj)
        {
            //string query = $"INSERT INTO Captain VALUES ('{obj.captainID}', '{obj.firstName}', '{obj.lastName}', '{obj.email}', '{obj.address}, '{obj.contactNo}');";

            string query = "INSERT INTO Captain VALUES (@Captain_ID, @FirstName, @LastName, @Email, @Address_, @ContactNo);";
            
            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Captain_ID", obj.captainID);
            command.Parameters.AddWithValue("@FirstName", obj.firstName);
            command.Parameters.AddWithValue("@LastName", obj.lastName);
            command.Parameters.AddWithValue("@Email", obj.email);
            command.Parameters.AddWithValue("@Address_", obj.address);
            command.Parameters.AddWithValue("@ContactNo", obj.contactNo);

            command.ExecuteNonQuery();
        }


        // Delete Captain Record //
        public static SqlDataReader GetCaptainIDs()
        {
            string query = "SELECT Captain_ID FROM Captain;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            return dataReader;
        }

        public static void DeleteCaptainRecord(string capID)
        {

            string query = "DELETE FROM Captain WHERE Captain_ID = @Captain_ID;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Captain_ID", capID);

            command.ExecuteNonQuery();
        }


        // Add Coach Record //
        public static void AddCoachRecord(Coach obj)
        {
            //string query = $"INSERT INTO Captain VALUES ('{obj.captainID}', '{obj.firstName}', '{obj.lastName}', '{obj.email}', '{obj.address}, '{obj.contactNo}');";

            string query = "INSERT INTO Coach VALUES (@Coach_ID, @FirstName, @LastName, @Email, @Address_, @ContactNo);";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Coach_ID", obj.coachID);
            command.Parameters.AddWithValue("@FirstName", obj.firstName);
            command.Parameters.AddWithValue("@LastName", obj.lastName);
            command.Parameters.AddWithValue("@Email", obj.email);
            command.Parameters.AddWithValue("@Address_", obj.address);
            command.Parameters.AddWithValue("@ContactNo", obj.contactNo);

            command.ExecuteNonQuery();
        }


        // Delete Coach Record //
        public static SqlDataReader GetCoachIDs()
        {
            string query = "SELECT Coach_ID FROM Coach;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            return dataReader;
        }

        public static void DeleteCoachRecord(string cchID)
        {
            string query = "DELETE FROM Coach WHERE Coach_ID = @Coach_ID;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Coach_ID", cchID);

            command.ExecuteNonQuery();
        }



        // Add Team Record //
        public static void AddTeamRecord(Team obj)
        {
            string query = "INSERT INTO Team VALUES (@Team_ID, @TeamName, @Captain_ID, @Coach_ID);";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Team_ID", obj.teamID);
            command.Parameters.AddWithValue("@TeamName", obj.teamName);
            command.Parameters.AddWithValue("@Captain_ID", obj.CaptainID);
            command.Parameters.AddWithValue("@Coach_ID", obj.CoachID);

            command.ExecuteNonQuery();
        }


        // Delete Team Record //

        public static SqlDataReader GetTeamIDs()
        {
            string query = "SELECT Team_ID FROM Team;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            return dataReader;
        }

        public static void DeleteTeamRecord(string tID)
        {
            string query = "DELETE FROM Team WHERE Team_ID = @Team_ID;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Team_ID", tID);

            command.ExecuteNonQuery();
        }



        // Add Tournament Record //
        public static void addTournamentRecord(Tournaments obj)
        {
            string query = "INSERT INTO Tournaments VALUES(@TournamentOwner_ID, @Tournament_ID, @TournamentTitle, @StartDate, @EndDate, @Location);";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TournamentOwner_ID", obj.tournamentOwnerID);
            command.Parameters.AddWithValue("@Tournament_ID", obj.tournamentID);
            command.Parameters.AddWithValue("@TournamentTitle", obj.tournamentTitle);
            command.Parameters.AddWithValue("@StartDate", obj.startDate);
            command.Parameters.AddWithValue("@EndDate", obj.endDate);
            command.Parameters.AddWithValue("@Location", obj.location);

            command.ExecuteNonQuery();
        }

        // Get Tournament Owner IDs //
        public static string GetTournamentOwnerID(string username)
        {
            string query = "SELECT TournamentOwner_ID FROM TournamentOwner WHERE UserName = @UserName;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", username);

            SqlDataAdapter adpt = new SqlDataAdapter(command);

            DataTable set = new DataTable();
            adpt.Fill(set);


            string id = null;
            foreach(DataRow ds in set.Rows)
            {
                id = Convert.ToString(ds["TournamentOwner_ID"]);
            }

            return id;
        }
        
        // Get Tournament IDs from Tournament //
        public static SqlDataReader GetTournamentIDs()
        {
            string query = "SELECT Tournament_ID FROM Tournaments;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            return dataReader;
        }
        // Get Tournament IDs from Tournament //
        public static SqlDataReader GetTournamentIDMM()
        {
            string query = "SELECT Tournament_ID FROM MatchMaking;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            return dataReader;
        }




        // Add Player Record //
        public static void AddPlayerRecord(Player obj)
        {
            string query = "INSERT INTO Player VALUES (@Player_ID, @FirstName, @LastName, @Email, @Address_, @ContactNo, @PlayerExperience, @PlayerScore, @PlayerDescription, @PlayerStatus, @Team_ID);";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Player_ID", obj.playerID);
            command.Parameters.AddWithValue("@FirstName", obj.firstName);
            command.Parameters.AddWithValue("@LastName", obj.lastName);
            command.Parameters.AddWithValue("@Email", obj.email);
            command.Parameters.AddWithValue("@Address_", obj.address);
            command.Parameters.AddWithValue("@ContactNo", obj.contactNo);
            command.Parameters.AddWithValue("@PlayerExperience", obj.playerExp);
            command.Parameters.AddWithValue("@PlayerScore", obj.playerScore);
            command.Parameters.AddWithValue("@PlayerDescription", obj.playerDescription);
            command.Parameters.AddWithValue("@PlayerStatus", obj.playerStatus);
            command.Parameters.AddWithValue("@Team_ID", obj.playerTeamID);


            command.ExecuteNonQuery();
        }


        // Delete Player Record //
        public static SqlDataReader GetPlayerIDs() 
        {
            string query = "SELECT Player_ID FROM Player;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            return dataReader;
            
        }

        public static void DeletePlayerRecord(string pID)
        {
            string query = "DELETE FROM Player WHERE Player_ID = @Player_ID;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Player_ID", pID);

            command.ExecuteNonQuery();
        }


        // Add Record in Price Table  //
        public static void AddPriceRecord(string id, string winner, string runner)
        {
            string query = "INSERT INTO Price VALUES(@Tournament_ID, @WinnerAmount, @RunnerUpAmount);";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Tournament_ID", id);
            command.Parameters.AddWithValue("@WinnerAmount", winner);
            command.Parameters.AddWithValue("@RunnerUpAmount", runner);

            command.ExecuteNonQuery();
        }

        // Show Price Table Records //
        public static DataSet ShowPriceRecord()
        {
            string query = "SELECT Tournament_ID AS [Tournament ID], WinnerAmount AS [Winner Amount], RunnerUpAmount AS [Runner-Up Amount] FROM Price";

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adpt = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            adpt.Fill(ds, "priceTable");

            return ds;
        }


        // Add Viewer Record //
        public static void AddViewerRecord(Viewer x)
        {
            string str = "insert into Viewer values(@ViewerID,@FirstName,@LastName,@Email,@Address_,@ContactNo,@Username,@Password_)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(str, connection);

            command.Parameters.AddWithValue("@ViewerID", x.ViewerID);
            command.Parameters.AddWithValue("@FirstName", x.firstName);
            command.Parameters.AddWithValue("@LastName", x.lastName);
            command.Parameters.AddWithValue("@Email", x.email);
            command.Parameters.AddWithValue("@Address_", x.address);
            command.Parameters.AddWithValue("@ContactNo", x.contactNo);
            command.Parameters.AddWithValue("@UserName", x.username);
            command.Parameters.AddWithValue("@Password_", x.password);
          
            command.ExecuteNonQuery();
        }


        // Get Rounds From Tournament //
        public static SqlDataReader GetRoundsFromTournament(string a)
        {
            string query = "SELECT RoundNo FROM MatchMaking Where Tournament_ID = @Tournament_ID;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Tournament_ID", a);

            SqlDataReader dataReader = command.ExecuteReader();

            return dataReader;
        }


        // Get Matchs From Rounds //
        public static SqlDataReader GetMatchesFromRounds(string a)
        {
            string query = "SELECT MatchNo FROM MatchMaking Where RoundNo = @RoundNo;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RoundNo", a);

            SqlDataReader dataReader = command.ExecuteReader();

            return dataReader;
        }

        // Get Score From Matches //
        public static SqlDataReader GetScoreFromMatches(string a)
        {
            string query = "SELECT TeamWinnerID, WinnerPrice FROM Winner WHERE MatchNo = @MatchNo;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MatchNo", a);

            return command.ExecuteReader();

        }


        // Show Tournament IDs Against Tournament Owner ID in Match Making //
        // Get Tournament IDs //
        public static string GetTournamentIDsMM(string tOID)
        {
            string query = "SELECT Tournament_ID FROM Tournaments WHERE TournamentOwner_ID = @TournamentOwner_ID";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TournamentOwner_ID", tOID);

            SqlDataAdapter dataAdpt = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            dataAdpt.Fill(dt);

            string x = null;
            foreach(DataRow row in dt.Rows)
            {
                x = Convert.ToString(row["Tournament_ID"]);
            }

            return x;
        }


        // Match Making Add Record //
        public static void AddMatchMakingRecord(MatchMaking obj)
        {
            string query = "INSERT INTO MatchMaking VALUES(@Tournament_ID, @RoundNo, @MatchNo, @TeamA, @TeamB, @ScoreA, @ScoreB);";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Tournament_ID", obj.Tournament_ID);
            command.Parameters.AddWithValue("@RoundNo", obj.RoundNo);
            command.Parameters.AddWithValue("@MatchNo", obj.MatchNo);
            command.Parameters.AddWithValue("@TeamA", obj.TeamA);
            command.Parameters.AddWithValue("@TeamB", obj.TeamB);
            command.Parameters.AddWithValue("@ScoreA", obj.ScoreA);
            command.Parameters.AddWithValue("@ScoreB", obj.ScoreB);
    

            command.ExecuteNonQuery();
        }

        // Enter teams in TeamsInTournament //
        public static void addRdTiT(string teamID, string Tid)
        {
            string query = "INSERT INTO TeamsInTournament VALUES(@Team_ID, @Tournament_ID)";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Team_ID", teamID);
            command.Parameters.AddWithValue("@Tournament_ID", Tid);

            command.ExecuteNonQuery();

        }

        // Get Team IDs from TIT //
        public static SqlDataReader GetTeamIDsTIT()
        {
            string query = "SELECT Team_ID FROM TeamsInTournament;";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            return dataReader;
        }


        // Add Value in Winner //
        public static void AddInWinner(string matchNo, string teamID, string winPrice)
        {
            string query = "INSERT INTO Winner VALUES(@MatchNo, @TeamWinnerID, @WinnerPrice);";
            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MatchNo", matchNo);
            command.Parameters.AddWithValue("@TeamWinnerID", teamID);
            command.Parameters.AddWithValue("@WinnerPrice", winPrice);

            command.ExecuteNonQuery();
        }

        // Add Value in RunnerUp //
        public static void AddInRunnerup(string matchNo, string teamRID, string runnerPrice)
        {
            string query = "INSERT INTO RunnerUp VALUES(@MatchNo, @TeamRunnerupID, @RunneruprPrice);";
            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MatchNo", matchNo);
            command.Parameters.AddWithValue("@TeamRunnerupID", teamRID);
            command.Parameters.AddWithValue("@RunneruprPrice", runnerPrice);

            command.ExecuteNonQuery();
        }

        // Getting WinnerPrice & RunnerUp Price //
        public static string GetWinnerPrice(string tID)
        {
            string query = "SELECT WinnerAmount FROM Price WHERE Tournament_ID = @Tournament_ID";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Tournament_ID", tID);

            SqlDataAdapter dataAdpt = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            dataAdpt.Fill(dt);

            string x = null;
            foreach (DataRow row in dt.Rows)
            {
                x = Convert.ToString(row["WinnerAmount"]);
            }

            return x;
        }

        public static string GetRunnerupPrice(string tID)
        {
            string query = "SELECT RunnerUpAmount FROM Price WHERE Tournament_ID = @Tournament_ID";

            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Tournament_ID", tID);

            SqlDataAdapter dataAdpt = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            dataAdpt.Fill(dt);

            string x = null;
            foreach (DataRow row in dt.Rows)
            {
                x = Convert.ToString(row["RunnerUpAmount"]);
            }

            return x;
        }
        public static SqlDataReader GetTeamIDTournamentTracker()
        {
            string query = "SELECT Tournament_ID FROM TeamsinTournament";



            SqlConnection connection = GetConnection();



            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();



            return dataReader;
        }
        public static SqlDataReader GetTeamIDTournamentTracker1(string a)
        {
            string query = "SELECT Team_ID FROM TeamsinTournament where Tournament_ID = @Tournament_ID";



            SqlConnection connection = GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Tournament_ID", a);
            SqlDataReader dataReader = command.ExecuteReader();



            return dataReader;
        }
        public static DataSet GetDataThroughDataAdaptor1(string a)
        {
            string qry = "select Team_ID,TeamName,Captain_ID,Coach_ID from Team where Team_ID =@Team_ID";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Team_ID", a);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"Team");
            return ds;
        }
        public static SqlDataReader GetTeamIDTracker()
        {
            string query = "SELECT Team_ID FROM Team;";



            SqlConnection connection = GetConnection();



            SqlCommand command = new SqlCommand(query, connection);



            SqlDataReader dataReader = command.ExecuteReader();



            return dataReader;
        }
  
public static DataSet GetDataThroughDataAdaptor(string a)
        {
            string qry = "select * from Player where Team_ID =@Team_ID";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Team_ID", a);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ProjectTestFour");
            return ds;
        }


    }
}
