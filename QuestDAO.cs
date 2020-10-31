using System;
using System.Collections.Generic;
using System.Text;


// https://www.nuget.org/packages/System.Data.SQLite.Core/
// "updated 2 days ago"
// NuGet CLI:
// dotnet add package System.Data.SQLite.Core --version 1.0.113.5
using System.Data.SQLite;


namespace QuestKeep
{
    class QuestDAO
    {
        static bool TestConnect()
        {
            SQLiteConnection conn = new SQLiteConnection("QuestKeep001.bin");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CREATE TABLE TEST {INT ID};";
            cmd.ExecuteNonQuery();
            return true;
        }

        static void Main(String[] args)
        {
            QuestDAO.TestConnect();
        }
    }

}
