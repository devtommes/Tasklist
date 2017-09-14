using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasklist.DBModel;

namespace Tasklist.Controller
{
    class Tasklist : DbContext, ITasklist
    {


#region Initialization

        public Tasklist() : base("Tasklist")
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        #endregion

        #region "Enumerator"

        public object Current => throw new NotImplementedException();
        
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }
        #endregion

#region tasklist
        public Task Pull(int index)
        {
            throw new NotImplementedException();
        }

        public Task PullFirst()
        {
            throw new NotImplementedException();
        }

        public Task PullLast()
        {
            throw new NotImplementedException();
        }

        public void Put(Task t)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
#endregion
    }
}
