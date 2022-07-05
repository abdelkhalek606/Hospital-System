using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }
        public int gitDocPassword(string userName)
        {
            string query = "SELECT password FROM Doctor WHERE username = '" + userName + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return 0;
            }
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int updatepatientSSN(string user, int p)
        {
            string query = "update patient set SSN= " + p +

                " WHERE" +
                            " username ='" + user + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updatedocusernamepass2(string username, int password)
        {
            string query = "update doctor set password = '" + password +

                "' WHERE" +
                            " username ='" + username + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AskQuestion(int SSN, int DOCid, string q)
        {
            string query = "INSERT INTO Question (sender_ssn, doctor_id, question) " +
                "Values (" + SSN + "," + DOCid + ", '" + q + "') ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getQuestion(int pssn)
        {
            string query = "SELECT question, response FROM  Question WHERE sender_ssn = " + pssn + ";";
            return dbMan.ExecuteReader(query);
        }
        public int updaterecepusernamepass2(string username, int password)
        {
            string query = "update receptionist set password = '" + password +

                "' WHERE" +
                            " username ='" + username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getPatientOut()
        {
            string sql = " select distinct p.username from patient p, patient_visitlog v    where ((v.date_out is not null) and v.ssn=p.SSN )or( p.SSN not in (select r.ssn from patient_visitlog r))";
            return dbMan.ExecuteReader(sql);
        }
        public string gitDocName(string userName)
        {
            string query = "SELECT name FROM Doctor WHERE username = '" + userName + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return "null";
            }
            return (string)(dbMan.ExecuteScalar(query));
        }
        public int gitDocDNO(string userName)
        {
            string query = "SELECT DNO FROM Doctor WHERE username = '" + userName + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return 0;
            }
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int gitDocID(string userName)
        {
            string query = "SELECT id FROM Doctor WHERE username = '" + userName + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return 0;
            }
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int gitPatientPassword(string userName)
        {
            string query = "SELECT password FROM patient WHERE username = '" + userName + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return 0;
            }
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int gitAdminPassword(string userName)
        {
            string query = "SELECT password FROM administrator WHERE username = '" + userName + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return 0;
            }
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int gitRepPassword(string userName)
        {
            string query = "SELECT password FROM receptionist WHERE username = '" + userName + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return 0;
            }

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public string gitRecpName(string userName)
        {
            string query = "SELECT name FROM receptionist WHERE username = '" + userName + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return "null";
            }
            return (string)(dbMan.ExecuteScalar(query));
        }
        public int gitPatientSSN(string user)
        {
            string query = "SELECT SSN FROM patient WHERE username = '" + user + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return 0;
            }

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int gitPatientPhone(string user)
        {
            string query = "SELECT password FROM patient WHERE username = '" + user + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return 0;
            }

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public string gitPatientName(string userName)
        {
            string query = "SELECT fname FROM patient WHERE username = '" + userName + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return "null";
            }
            return (string)(dbMan.ExecuteScalar(query));
        }
        public string gitPatientGender(string userName)
        {
            string query = "SELECT gender FROM patient WHERE username = '" + userName + "';";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return "null";
            }
            return (string)(dbMan.ExecuteScalar(query));
        }
        public DataTable gitPatientIn()
        {
           string sql = " SELECT username FROM patient as p , patient_visitlog as v WHERE p.SSN=v.ssn AND  date_out IS NULL;";
            return dbMan.ExecuteReader(sql);
         }

        public int addPatientVisit( string user, string d){

            int SSN = gitPatientSSN(user);

            string query = "INSERT INTO patient_visitlog (SSN, date_in) " + "Values ( " + SSN + ",'" + d + "');";
            return dbMan.ExecuteNonQuery(query);    

         }

        public int addPatientOut(string user, string d) {
            int SSN = gitPatientSSN(user);
            string query = "UPDATE patient_visitlog SET  date_out =  '" + d + "' WHERE ssn = " + SSN + ";";
            return dbMan.ExecuteNonQuery(query);    
        }
       
        public DataTable gitRequestedRooms()
        {
            string query = "SELECT * FROM requsted_rooms ;";
            return dbMan.ExecuteReader(query) ;
        }
        public DataTable gitPatientWhoRequestedRoom(int id)
        {
            string query = "SELECT patient_requst FROM requsted_rooms WHERE room_id = " + id + " ;";
            
            return dbMan.ExecuteReader(query);
        }
        public int joinRoom(int id, int ssn)
        {
            // first we need to delete the record from requ. list
            string query= "DELETE requsted_rooms WHERE room_id=  " +id+ "AND patient_requst = " +ssn + ";"; 
            dbMan.ExecuteNonQuery(query);
            string query2 = "UPDATE rooms SET patient_ssn =" + ssn + "WHERE Id = " + id + ";";
            return dbMan.ExecuteNonQuery(query2);
        }
        public DataTable gitAmbulanceOut()
        {
            string query = "SELECT *  FROM ambulance WHERE avaliable = 'False' ;";
            return dbMan.ExecuteReader(query);
        }
        public int EditAmbulance(int id)
        {
            string query = "UPDATE ambulance SET  avaliable = 'True' WHERE Id= " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectFamilyMember(string user)
        {
            string query = "SELECT Name, Sex , Relationship , Birthdate, phonenumber, relative_ssn FROM relatives r, patient p WHERE r.patient_SSN = p.SSN AND p.username =  '" +user + "' ;";    
            return dbMan.ExecuteReader(query);
        }


        //////// ADD

        public int AddRelative(string name, string g, string R, int phone, int RSSN, int PSSN, String d)
        {
            string query = "INSERT INTO relatives (Name, Sex,Relationship,phonenumber,relative_ssn,patient_SSN,Birthdate)" +
                "Values ('" + name + "', '" + g + "' , '" + R + "'," + phone + "," + RSSN + "," + PSSN + ",'" + d + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        /// <summary>

        public int Insertpatient(string fname, string mint, string Lname, int ssn, DateTime Bdata, string gender, int phonenumber, string username, string password)
        {
            string query = "INSERT INTO patient (fname, mint, lname, SSN,DOB,phone_number,gender,username,password) " +
                            "Values ('" + fname + "','" + mint + "','" + Lname + "','" + ssn + "','" + Bdata + "','" + phonenumber + "','" + gender + "','" + username + "','" + password + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        

       public DataTable getUserNameAndPassOfPat(int SSN)
       {
           string query = "SELECT username, password FROM patient where SSN =  " +SSN+ ";" ;
            return dbMan.ExecuteReader(query);  
       }
       
        public DataTable getUserNameAndPassOfDoc(int id)
        {
            string query = "SELECT username , password FROM Doctor WHERE id = " +id+ ";" ;  
            return dbMan.ExecuteReader(query);
        }
        public DataTable getUserNameAndPassOfRecep(int id)
        {
            string query = "SELECT username , password FROM receptionist WHERE id = " + id + ";";
            return dbMan.ExecuteReader(query);
        }


        public DataTable getUserNameAndPassOfAdmin(int id)
        {
            string query = "SELECT username , password FROM administrator WHERE id = " + id + ";";
            return dbMan.ExecuteReader(query);
        }
        /// <summary>
        ///  ZIAD
        /// </summary>
        /// Select
        /// 
        public DataTable SelectAlladmin()
        {
            string query = "SELECT * FROM administrator;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllrecep()
        {
            string query = "SELECT * FROM receptionist;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllrelatives()
        {
            string query = "SELECT * FROM relatives;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllpatients()
        {
            string query = "SELECT * FROM patient;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAlldoctors()
        {
            string query = "SELECT * FROM doctor;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllambulances()
        {
            string query = "SELECT * FROM ambulance;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAlldeps()
        {
            string query = "SELECT * FROM department;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllnurses()
        {
            string query = "SELECT * FROM nurses;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllrooms()
        {
            string query = "SELECT * FROM rooms;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDepnum()
        {
            string query = "SELECT Dnumber FROM Department;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectclinicid()
        {
            string query = "SELECT id FROM clinic;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectdocid()
        {
            string query = "SELECT id FROM doctor;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectpatid()
        {
            string query = "SELECT SSN FROM patient;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectnursesid()
        {
            string query = "SELECT id FROM nurses;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectambid()
        {
            string query = "SELECT id FROM ambulance;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectrecepid()
        {
            string query = "SELECT id FROM receptionist;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectadminid()
        {
            string query = "SELECT id FROM administrator;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectroomid()
        {
            string query = "SELECT id FROM rooms;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectrelativeid()
        {
            string query = "SELECT relative_ssn FROM relatives;";
            return dbMan.ExecuteReader(query);
        }
        /////////////////////


        public int Insertdep(string dname, int dnumber)
        {
            string query = "INSERT INTO Department (Dnumber, Dname, Mng_id) Values ('" + dnumber + "','" + dname + "', null);";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Insertclinc(int id, int doctor_id)
        {
            string query = "INSERT INTO clinic (id, doctor_id)" +
                            "Values (" + id + "," + doctor_id + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Insertambulance(int id)
        {
            string query = "INSERT INTO ambulance (id, avaliable)" +
                            "Values (" + id + ", 'false');";
            return dbMan.ExecuteNonQuery(query);///////////////////////////////////////////////
        }

        public int Insertnurse(string name, int id)
        {
            string query = "INSERT INTO nurses (name, id)" +
                            "Values ('" + name + "'," + id + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Insertroom(int id)
        {
            string query = "INSERT INTO rooms (Id)" +
                            "Values (" + id + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Insertdoctor(int id, int dno, string name, string username, int password)
        {
            string query = "INSERT INTO doctor (id, DNO, name, username, password) " +
                            "Values (" + id + "," + dno + ",'" + name + "','" + username + "','" + password + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Insertadmin(string name, int id, string username, int password)
        {
            string query = "INSERT INTO administrator (name, id, username, password)" +
                            "Values ('" + name + "'," + id + ",'" + username + "','" + password + "');";
            return dbMan.ExecuteNonQuery(query);
        }


        public int Insertrecep(string name, int id, string username, int password)
        {
            string query = "INSERT INTO receptionist (Id, name, username, password)" +
                            "Values (" + id + ",'" + name + "','" + username + "','" + password + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertpatientA(string gender, string fname, string mname, string lname, string username, int password, int ssn, int phone, DateTime bday)
        {
            string query = "INSERT INTO patient (username, password, SSN, Fname, mint, lname, DoB, phone_number, gender)" +
                            "Values ('" + username + "','" + password + "','" + ssn + "','" + fname + "','" + mname
                            + "','" + lname + "','" + bday + "','" + phone + "','" + gender + "');";
            return dbMan.ExecuteNonQuery(query); //////////////check order and complete
        }



        public int Insertrelative(string name, int patssn, string relationship, int relssn, DateTime bday, string sex, int phone)
        {
            string query = "INSERT INTO relatives (Name, Sex, Relationship, Birthdate, patient_SSN, relative_ssn, phonenumber)" +
                            "Values ('" + name + "','" + sex + "','" + relationship + "','" + bday + "','" + patssn + "','" + relssn + "','" + phone + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        //// neeeds work above check order names and complete

        public int updatepatusernamepass(int id, string username, int password)
        {
            string query = "update patient set username = '" + username + "', password = " + password +

                "WHERE" +
                            " SSN =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updatedocusernamepass(int id, string username, int password)
        {
            string query = "update doctor set username = '" + username + "', password = " + password +

                "WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateadminusernamepass(int id, string username, int password)
        {
            string query = "update administrator set username = '" + username + "', password = " + password +

                "WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updaterecepusernamepass(int id, string username, int password)
        {
            string query = "update receptionist set username = '" + username + "', password = " + password +

                "WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        //////////////

        public int updaterecepname(int id, string name)
        {
            string query = "update receptionist set name = '" + name +

                "' WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateadminname(int id, string name)
        {
            string query = "update administrator set name = '" + name +

                "' WHERE" +
                            " id = " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updatedepsupervisor(int docid, int dno)
        {
            string query = "update department set Mng_id = " + docid +

                " WHERE" +
                            " Dnumber =" + dno + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updatenursename(int id, string name)
        {
            string query = "update nurses set name = '" + name +

                "' WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updatenurseroom(int id, int roomid)
        {
            string query = "update nurses Set room_id = " + roomid + /////////////////room_id?

                " WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateambulancedriver(int id, string drivername)
        {
            string query = "update ambulance set driver = '" + drivername +  //////////driver?

                "' WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updatedocname(int id, string docname)
        {
            string query = "update doctor set name = '" + docname +

                "' WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updatedocclinc(int id, int clinic)
        {
            string query = "update clinic set doctor_id = '" + id +  //////////clinic_id?/////////////////////

                "' WHERE" +
                            " id =" + clinic + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updatedocdep(int id, int dep)
        {
            string query = "update doctor set Dno = '" + dep +  //////////Dno?

                "' WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updaterelaname(int id, string name)
        {
            string query = "update relatives set name = '" + name +

                "' WHERE" +
                            " relative_ssn =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updaterelaphone(int id, int p)
        {
            string query = "update relatives set phonenumber = '" + p +

                "' WHERE" +
                            " relative_ssn =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updaterelasex(int id, string s)
        {
            string query = "update relatives set sex = '" + s +

                "' WHERE" +
                            " relative_ssn =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updaterelabirth(int id, DateTime date)
        {
            string query = "update relatives set Birthdate = '" + date +

                "' WHERE" +
                            " relative_ssn =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updatePatbirth(int id, DateTime date)
        {
            string query = "update patient set DOB = '" + date +

                "' WHERE" +
                            " SSN =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updatepatientphone(int id, int p)
        {
            string query = "update patient set phone_number = '" + p +

                "' WHERE" +
                            " SSN ='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updatepatientsex(int id, string p)
        {
            string query = "update patient Set gender  = '" + p +

                "' WHERE" +
                            " SSN =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updatepatientname(int id, string f, string m, string l)
        {
            string query = "update patient set fname='" + f + "', mint='" + m + "', lname ='" + l +

                "' WHERE" +
                            " SSN =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int deleteareceptionist(int id)
        {
            string query = "DELETE FROM receptionist WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        //////////////// update pat and relative needed

        public int deleteroom(int id)
        {
            string query = "DELETE FROM rooms WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deletenurse(int id)
        {
            string query = "DELETE FROM nurses WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteclinic(int id)
        {
            string query = "DELETE FROM clinic WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deletedoctor(int id)
        {
            string query = "DELETE FROM doctor WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deletepatient(int id)
        {
            string query = "DELETE FROM patient WHERE" +
                            " SSN =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteambulance(int id)
        {
            string query = "DELETE FROM ambulance WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteadmin(int id)
        {
            string query = "DELETE FROM administrator WHERE" +
                            " id =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        
        public int deletedep(int dno)
        {
            string query = "DELETE FROM department WHERE" +
                            " Dnumber =" + dno + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleterelative(int ssn)
        {
            string query = "DELETE FROM relatives WHERE" +
                            " relative_ssn =" + ssn + ";";
            return dbMan.ExecuteNonQuery(query);
        }
    

        /// <summary>
        /// ////////

        /// </summary>
        public DataTable Selectschadul(string name)
        {
            string query = "SELECT starttime,endtime,day FROM doctor d,schedule s where s.doctor_id=d.id and d.name='" + name + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectappointment(string name)
        {
            string query = "SELECT a.starttime,a.endtime,a.day FROM doctor d,clinic c, appointment a where c.doctor_id=d.id and a.clinic_id=c.id and d.name='" + name + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectdocname(string d)
        {
            string query = "SELECT name FROM doctor, DeparTment where DNO=Dnumber and Dname= '" + d + "';";
            return dbMan.ExecuteReader(query);
        }
        public int Insertcare(int docid, int passn)
        {
            string query = "INSERT INTO care(Doctor_id,patient_ssn) values ('" + docid + "','" + passn + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        
        public int Selectdocid(string name, int pssn)
        {
            string query = "SELECT d.id  FROM doctor d, care c where d.id=c.Doctor_id And c.patient_ssn= " + pssn + " AND  d.name='" + name + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int Insertappointment(string st, string end, int clinicid, int ssn, string day)
        {
            string query = "INSERT INTO appointment(starttime,endtime,clinic_id,patient_ssn,day) values ('" + st + "','" + end + "','" + clinicid + "','" + ssn + "','" + day + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Selectclinicid(string name)
        {
            string query = "SELECT c.id FROM doctor d,clinic c where c.doctor_id=d.id and d.name='" + name + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable SelectDepname()
        {
            string query = "SELECT Dname FROM DeparTment ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectdoc(int ssn)
        {
            string query = "select d.name, d.id from Doctor d , care c where c.Doctor_id=d.id and c.patient_ssn=" + ssn + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable updaterate(int r, int did, int pssn)
        {
            string query = "update care set rate='" + r + "' where patient_ssn='" + pssn + "'and Doctor_id= '" + did + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selecttopratedoctor()
        {
            string query = "SELECT d.name as 'Doctor Name',e.Dname as 'specialization', AVG(rate) as 'rate'  FROM Department e,doctor d ,care c where e.Dnumber=d.DNO and c.Doctor_id=d.id  group by d.name,e.Dname order by avg(rate) desc ;";
            return dbMan.ExecuteReader(query);
        }
        /// <summary>
        /// /////////////////////
        /// </summary>
        /// 

        public DataTable viewDoctorSch(string user)
        {
            string query = "SELECT day , starttime , endtime FROM schedule s, Doctor d WHERE s.doctor_id = d.id AND d.username = '" +user +"' ;";
            return dbMan.ExecuteReader(query);  
        }
        public DataTable ViewDocQ(string user)
        {
            string query = "SELECT question, sender_ssn from Question q , Doctor d WHERE d.id = q.doctor_id AND d.username = '" + user + "';";
            return dbMan.ExecuteReader(query);  
        }
        public int insertAns(int SSN , int ID, string Q, string Ans)
        {
            string query = "UPDATE  Question SET response = ' " + Ans + "' WHERE sender_ssn =" + SSN + "AND doctor_id =" + ID + "AND question = '" + Q + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable gitAvalibleRoom()
        {
            string query = "SELECT * FROM rooms WHERE patient_ssn IS null";
            return dbMan.ExecuteReader(query);
        }
        public int EmergencyRoom(int id,int SSN )
        {
            string query = "INSERT INTO rooms (Id, patient_ssn) " +
                "Values ( " + id + ", " + SSN + ")";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getDocApDay(int id)
        {
            string query = "select DISTINCT day from appointment a,Doctor d, clinic c where clinic_id = c.id and doctor_id = d.id and d.id = " + id + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getDocApp(int id ,string day)
        {
            string query = "select starttime, endtime from appointment a, Doctor d, clinic c where clinic_id = c.id and doctor_id = d.id  and a.day = '" +day+ "' and d.id = " + id + ";";
            return dbMan.ExecuteReader(query) ;
        }
        public int deleteApointment(int id, string day, string t)
        {
            string query = "Select clinic_id from appointment a, Doctor d, clinic c where clinic_id = c.id and doctor_id = d.id  and a.day = '" + day + "' and d.id = " + id + " AND starttime=  "+ t + " ;";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return 0;
            }
            int cid= Convert.ToInt32(dbMan.ExecuteScalar(query));

            string q = "DELETE appointment WHERE clinic_id = " + cid + "AND  day = '" + day + "' AND starttime = " + t + ";";
            return dbMan.ExecuteNonQuery(q);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
