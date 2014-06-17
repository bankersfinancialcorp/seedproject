namespace API.Models {
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBModels : DbContext {
        // Your context has been configured to use a 'DBModels' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'API.Models.DBModels' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBModels' 
        // connection string in the application configuration file.
        public DBModels()
            : base("name=DBModels") {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Messages> Messages { get; set; }
    }

    public class Messages
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}