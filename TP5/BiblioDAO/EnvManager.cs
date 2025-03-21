using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using MySql.Data.MySqlClient;
using Npgsql;

namespace BiblioDAO
{
    public class EnvManager
    {
        public string driver;
        public string db_name;
        public string host;
        public string port;
        public string username;
        public string password;


        public EnvManager() {

            string projectPath = GetProjectPath();

            string envFilePath = Path.Combine(projectPath, ".env");

            if (File.Exists(envFilePath))
                Env.Load(envFilePath);
            else
                throw new FileNotFoundException("Le fichier .env n'a pas été trouvé à l'emplacement spécifié.");


            driver = Environment.GetEnvironmentVariable("DB_DRIVER") ?? "postgresql";
            db_name = Environment.GetEnvironmentVariable("DB_NAME") ?? throw new InvalidOperationException("DB_NAME is required");
            host = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
            port = Environment.GetEnvironmentVariable("DB_PORT") ?? "5432";
            username = Environment.GetEnvironmentVariable("DB_USER") ?? "postgres";
            password = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? throw new InvalidOperationException("DB_PASSWORD is required");
        
        }

        public IDbConnection InitiliseDbConnection()
        {
            IDbConnection cnx;
            string chaine_cnx = $"Host={host};Port={port};Username={username};Password={password};Database={db_name};";

            switch (driver.ToLower())
            {
                case "mysql":
                    cnx = new MySqlConnection(chaine_cnx);
                    break;
                case "sqlserver":
                    cnx = new SqlConnection(chaine_cnx);
                    break;
                case "postgresql":
                default:
                    cnx = new NpgsqlConnection(chaine_cnx);
                    break;

            }

            return cnx;
        }

        public IDataReader getDataReader(IDataReader initialReader)
        {
            IDataReader reader;

            switch (driver.ToLower())
            {
                case "mysql":
                    reader = (MySqlDataReader)initialReader;
                    break;
                case "sqlserver":
                    reader = (SqlDataReader)initialReader;
                    break;
                case "postgresql":
                default:
                    reader = (NpgsqlDataReader)initialReader;
                    break;

            }

            return reader;
        }




        private string GetProjectPath()
        {
            // Récupérer le répertoire d'exécution de l'application
            string currentDirectory = Directory.GetCurrentDirectory();

            // Remonter les répertoires jusqu'à ce qu'on trouve un dossier contenant le fichier .env
            while (true)
            {
                // Vérifiez si le fichier .env existe dans le répertoire actuel
                string envFilePath = Path.Combine(currentDirectory, ".env");

                if (File.Exists(envFilePath))
                {
                    // Si le fichier .env est trouvé, retournez le chemin du projet de test
                    return currentDirectory;
                }

                // Si nous avons atteint la racine (pas de répertoire parent), arrêtez la recherche
                string parentDirectory = Directory.GetParent(currentDirectory)?.FullName;

                if (parentDirectory == null || parentDirectory == currentDirectory)
                {
                    throw new DirectoryNotFoundException("Le fichier .env n'a pas été trouvé dans les répertoires parents.");
                }

                // Sinon, remontez dans l'arborescence des répertoires
                currentDirectory = parentDirectory;
            }
        }
    }
}
