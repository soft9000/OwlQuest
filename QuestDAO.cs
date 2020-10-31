using System;
using System.Collections.Generic;
using System.Text;

// https://www.nuget.org/packages/System.Data.SQLite.Core/
// "updated 2 days ago"
// NuGet CLI:
// dotnet add package System.Data.SQLite.Core --version 1.0.113.5

using System.Data.SQLite;
using System.Diagnostics;

namespace QuestKeep
{
    class QuestDAO
    {

    }

    class QuestQuery
    {

    }

    class QuestDB
    {
        static String zdb = "QuestKeep001.bin";

        static SQLiteCommand GetCmd()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection($"Data Source={QuestDB.zdb}");
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                return cmd;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        static bool InsureSchema()
        {
            SQLiteCommand cmd = GetCmd();
            if (cmd == null)
            {
                return false;
            }
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Quests01 (" +
                "ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                "GID STRING," +
                "STATE INTEGER," +
                "QUESTION STRING," +
                "ANSWER STRING," +
                "HINT STRING," +
                "META STRING" +
                ");";
            cmd.ExecuteNonQuery();
            return true;
        }

        static bool DropSchema()
        {
            SQLiteCommand cmd = GetCmd();
            if (cmd == null)
            {
                return false;
            }
            cmd.CommandText = "DROP TABLE IF EXISTS Quests01";
            cmd.ExecuteNonQuery();
            return true;
        }

        static bool TestConnect()
        {
            SQLiteCommand cmd = GetCmd();
            if (cmd == null)
            {
                return false;
            }
            cmd.CommandText = "DROP TABLE IF EXISTS TEST;";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS TEST (INT ID);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DROP TABLE TEST;";
            cmd.ExecuteNonQuery();
            return true;
        }

        static void Main(String[] args)
        {
            Debug.Assert(QuestDB.TestConnect());
            Debug.Assert(QuestDB.InsureSchema());
            Debug.Assert(QuestDB.DropSchema());
            Console.WriteLine("Testing Success.");
        }
    }

}
