﻿using Dapper;
using DBWizard.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace DBWizard
{
    class SqliteDataAccess
    {
        #region student
        // ***************** Create *****************

        /* Inserts a new student to the SQL database.
         * INPUT: student
         * OUTPUT: new row to SQL database, null to program.
         */
        internal void InsertNewStudent(Student stu)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "INSERT INTO STUDENTS (student_id, parent_id, FirstName, LastName, DOB, gender, address, program_id, school_id, GradeLevel, photo)" +
                    "VALUES (@student_id, @parent_id, @FirstName, @LastName, @DOB, @gender, @address, @program_id, @school_id, @GradeLevel, @photo)";
                cnn.Execute(strQuery, stu);
            }
        }

        // ***************** Read *****************

        /* Gets a list of all students with the provided last name as equality.
         * INPUT: String last name
         * OUTPUT List<Student>
         */
        public List<Student> FindStudentByLastname(string last_name)
        {
            //A using statement protects us as a failsafe: it guarantees the connection to the
            //database will be closed, even in event of an application or computer crash.
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT * FROM students WHERE LastName=@LastName";

                var output = cnn.Query<Student>(strQuery, new { LastName = last_name });
                return output.ToList();
            }
        }

        /* Gets a single student from the db given the db id field.
         * This function is also usedl used in delete functionality of Form1.cs
         * INPUT: integer database id
         * OUTPUT: student
         */
        public Student GetStudentByDbID(int dbid_in)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT * FROM students WHERE id=@id";
                var stu_out = cnn.Query<Student>(strQuery, new { id = dbid_in }).Single();

                return stu_out;
            }
        }

        //Can also be used for search function, but currently unused.
        //TODO: cleanup if we decide not to use this.
        public List<Student> FindStudentByStudentId(string studentid_in)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT * FROM students WHERE student_id=@studentid";

                var output = cnn.Query<Student>(strQuery, new { studentid = studentid_in });
                return output.ToList();
            }
        }

        // ***************** Update *****************

        /* Updates an individual student in the DB.
         * Needs to do field mapping in the Execute call because
         * the photo field can be null or not null, and 
         * the conditional operator can be used to change the query on the fly.
         * 
         * INPUT: Student
         * OUTPUT: Data to SQL Database, void to program
         */
        internal void UpdateStudent(Student stu)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "UPDATE Students SET student_id = @student_id, FirstName = @First_Name, LastName = @Last_Name," +
                "DOB = @_dob, Gender = @_gender, Address = @_address, GradeLevel = @Grade_Level, Photo = @_photo" +
                "WHERE id = @_id;";

                cnn.Execute(strQuery, new
                {
                    _id = stu.id,
                    student_id = stu.student_id,
                    First_Name = stu.FirstName,
                    Last_Name = stu.LastName,
                    _dob = stu.DOB,
                    _gender = stu.gender,
                    _address = stu.address,
                    Grade_Level = stu.GradeLevel,
                    _photo = stu.photo ?? null
                });
            }
        }

        // ***************** Delete *****************

        /* Deletes a student record from the database.
         * INPUT: student
         * OUTPUT: void
         */
        internal void DeleteStudent(Student stu_in)
        {
            //protect query from 0 or negative indexes.
            if (stu_in.id <= 0)
                return;

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "DELETE FROM STUDENTS WHERE id=@id;";
                cnn.Execute(strQuery, stu_in);
            }
        }

        #endregion

        #region parent
        // ***************** Create *****************

        /* Inserts a new parent.
         * returns parent id as the new row # it just inserted.
         * INPUT: parent
         * OUTPUT: int <new parent db id>
         */
        internal int InsertNewParent(Parent par)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "INSERT INTO PARENTS (FirstName,LastName,PhoneNumber,EmailAddress)" +
                    "VALUES (@FirstName,@LastName,@PhoneNumber,@EmailAddress);" +
                    "SELECT MAX(parent_id) as parent_id from parents;";
                int parent_id_out = cnn.Query<int>(strQuery, par).Single();
                return parent_id_out;
            }
        }

        // ***************** Read *****************

        /* Gets a single Parent from the db given the parent_id db field.
         * INPUT: int parent_id
         * OUTPUT: Parent
         */
        public Parent GetParentByID(int parent_id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT * FROM parents WHERE parent_id=@id;";

                var output = cnn.Query<Parent>(strQuery, new { id = parent_id });

                var parList = output.ToList();
                Parent parent = parList[0];
                return parent;
            }
        }

        // ***************** Update *****************

        /* Update a parent to the SQL database.
         * Needs to do the mapping as parent_id is not stored on the parent object of the form.
         * but it is stored in the student object if the student is found.
         * 
         * INPUT: Parent, int parent_id
         * OUTPUT: Data to SQL database, void to program.
         */
        internal void UpdateParent(Parent par, int parent_id_in)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "UPDATE Parents SET FirstName = @First_Name, LastName = @Last_Name," +
                    "PhoneNumber = @Phone_Number, EmailAddress = @Email_Address" +
                    "WHERE parent_id = @_id;";

                cnn.Execute(strQuery, new
                {
                    _id = parent_id_in,
                    First_Name = par.FirstName,
                    Last_Name = par.LastName,
                    Phone_Number = par.PhoneNumber,
                    Email_Address = par.EmailAddress
                });
            }
        }

        // ***************** Delete *****************

        /* Deletes a parent record from the database.
         * INPUT: Parent
         * OUTPUT: void
         */
        internal void DeleteParent(Parent par_in)
        {
            //protect query from 0 or negative indexes.
            if (par_in.parent_id <= 0)
                return;

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "DELETE FROM Parents WHERE parent_id=@parent_id;";
                cnn.Execute(strQuery, par_in);
            }
        }

        #endregion

        #region Misc
        /* Returns the list of available programs from the DB to fill the Programs drop-down.
         * INPUT: no args
         * OUTPUT: List<Program>
         */
        internal List<Program> GetPrograms()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT name FROM programs;";

                var output = cnn.Query<Program>(strQuery, new DynamicParameters());
                return output.ToList();
            }
        }

        /* Returns the list of available schools from the DB to fill the Schools drop-down.
         * INPUT: no args
         * OUTPUT: List<School>
         */
        internal List<School> GetSchools()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT name FROM schools;";

                var output = cnn.Query<School>(strQuery, new DynamicParameters());
                return output.ToList();
            }
        }
        #endregion

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    } //class SqliteDataAccess
}
