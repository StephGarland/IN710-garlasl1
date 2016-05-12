using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_11._1_Assignment_Manager
{
    class CreateAssignmentDatabase
    {
        public CreateAssignmentDatabase()
        {
            string createTutorTable = @"CREATE TABLE tblTutor
                                        (
                                            tutorID int NOT NULL AUTO_INCREMENT,
                                            lastName varchar(20) NOT NULL,
                                            firstName varchar(20) NOT NULL,
                                            email varchar(100),
                                            PRIMARY KEY(tutorID)
                                        );";

            string insertQuery = @"INSERT INTO tblTutor (lastName,firstName,email)
                                    VALUES('Lockhart', 'Gilderoy', 'lockhart.gilderoy@hw.ac.nz');";

            string createPaperTable = @"CREATE TABLE tblPaper
                                        (
                                            paperID int NOT NULL AUTO_INCREMENT,
                                            name varchar(50) NOT NULL,
                                            tutorID int,
                                            PRIMARY KEY(paperID),
                                            FOREIGN KEY(tutorID) REFERENCES tblTutor(tutorID)
                                        );";

            string createAssignmentTable = @"CREATE TABLE tblAssignment
                                            (
                                                assignmentID int NOT NULL AUTO_INCREMENT,
                                                name varchar(50) NOT NULL,
                                                name varchar(50) NOT NULL,
                                                dueDate datetime,
                                                grade int NOT NULL,
                                                paperID int,
                                                PRIMARY KEY(assignmentID),
                                                FOREIGN KEY(paperID) REFERENCES tblPaper(paperID)
                                            );";
        }
    }
}
