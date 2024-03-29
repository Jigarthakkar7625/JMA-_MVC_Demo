﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstMVCMAJA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MyDBJMAAEntities2 : DbContext
    {
        public MyDBJMAAEntities2()
            : base("name=MyDBJMAAEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<MyFirstView> MyFirstViews { get; set; }
    
        [DbFunction("MyDBJMAAEntities2", "MyTableValuedFunction")]
        public virtual IQueryable<MyTableValuedFunction_Result> MyTableValuedFunction(Nullable<int> a)
        {
            var aParameter = a.HasValue ?
                new ObjectParameter("a", a) :
                new ObjectParameter("a", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<MyTableValuedFunction_Result>("[MyDBJMAAEntities2].[MyTableValuedFunction](@a)", aParameter);
        }
    
        [DbFunction("MyDBJMAAEntities2", "MyTableValuedFunction1")]
        public virtual IQueryable<MyTableValuedFunction1_Result> MyTableValuedFunction1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<MyTableValuedFunction1_Result>("[MyDBJMAAEntities2].[MyTableValuedFunction1]()");
        }
    
        public virtual ObjectResult<GetMultipleData_Result> GetMultipleData(Nullable<int> studentId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMultipleData_Result>("GetMultipleData", studentIdParameter);
        }
    
        public virtual ObjectResult<MyFirstSP_Result> MyFirstSP(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MyFirstSP_Result>("MyFirstSP", userIdParameter);
        }
    
        public virtual int SP_GetData(string studentName, Nullable<int> courseId, string address)
        {
            var studentNameParameter = studentName != null ?
                new ObjectParameter("studentName", studentName) :
                new ObjectParameter("studentName", typeof(string));
    
            var courseIdParameter = courseId.HasValue ?
                new ObjectParameter("courseId", courseId) :
                new ObjectParameter("courseId", typeof(int));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_GetData", studentNameParameter, courseIdParameter, addressParameter);
        }
    }
}
