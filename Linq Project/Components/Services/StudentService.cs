
 public class AddDataService
{
    List<string> studentNameList = new List<string>
        {
            "Abdullah", "Aisha", "Ahmed", "Ali", "Amira", "Anwar", "Ayesha", "Bilal", "Dalia", "Ehsan",
            "Farid", "Fatima", "Faisal", "Ghazi", "Hana", "Hassan", "Huda", "Idris", "Iman", "Ismael",
            "Jamal", "Jamila", "Jibril", "Kamil", "Karima", "Khalid", "Khadija", "Layla", "Luqman", "Mahira",
            "Malik", "Mariam", "Mustafa", "Nadia", "Nour", "Omar", "Qasim", "Qamar", "Rafiq", "Rania",
            "Rayyan", "Ruqayyah", "Saad", "Safa", "Salah", "Samir", "Samira", "Tariq", "Yasir", "Yasmine",
            "Youssef", "Zahra", "Zain", "Zara", "Zayd", "Zainab", "Amin", "Yasmin", "Yasin", "Yara",
            "Ibtisam", "Ihsan", "Ibrahim", "Ayman", "Asma", "Asim", "Aziza", "Ayah", "Anas", "Asiya",
            "Amirah", "Azhar", "Adil", "Amina", "Atif", "Aaliyah", "Ayman", "Amal", "Bassam", "Bahira",
            "Barakah", "Dawud", "Dina", "Fadil", "Farida", "Fawzi", "Hadi", "Halimah", "Hamza", "Hanan",
            "Haytham", "Iqbal", "Isra", "Jalil", "Jumana", "Kamal", "Karim", "Khulood", "Laila", "Latif",
            "Lubna", "Maheen", "Malik", "Mona", "Nadir", "Naima", "Nidal", "Noor", "Rafi", "Rasha",
            "Riyad", "Sabir", "Sadiq", "Sana", "Shireen", "Tahir", "Tala", "Tawfiq", "Umar", "Wafa",
            "Waleed", "Yasmina", "Yusef", "Zafir", "Zainah", "Zaki", "Zeina", "Zuhair", "Arif", "Arwa",
            "Bahiyah", "Basim", "Bushra", "Danya", "Daud", "Dilara", "Emad", "Enas", "Farouk", "Firdaus",
            "Faisal", "Ghalib", "Gulzar", "Habib", "Hala", "Hamid", "Haniya", "Iman", "Jabir", "Jahan",
            "Javed", "Kamilah", "Karima", "Khadijah", "Khalil", "Khayyam", "Layla", "Leila", "Lutfi",
            "Mahir", "Maimun", "Majid", "Malika", "Mamdouh", "Marwan", "Nadia", "Naeem", "Nahla", "Nizar",
            "Nuha", "Omaima", "Othman", "Qamar", "Qasim", "Rabia", "Radwan", "Rami", "Rukhsar", "Sadiq",
            "Salim", "Samia", "Sayyid", "Shakir", "Shireen", "Tariq", "Uthman", "Varda", "Wajih", "Yusra",
            "Yusuf", "Zayn", "Zayna", "Zaynab", "Zia", "Zuhra", "Zainab", "Zaheer", "Zain", "Zubair", "Zulaikha"
        };
    List<string> facultyNames = new List<string>
    {
     "Dr. Omar Malik",
    "Prof. Lubna Ahmed",
    "Dr. Salman Rizvi",
    "Prof. Nazia Mahmood",
    "Dr. Sumaira Akram",
    "Prof. Adnan Ahmed",
    "Dr. Shazia Iqbal",
    "Prof. Imran Khan",
    "Dr. Fatima Ali",
    "Prof. Shahid Iqbal",
    "Dr. Mariam Khan",
    "Prof. Ali Abbas",
    "Dr. Sara Qamar",
    "Prof. Tariq Mehmood",
    "Dr. Hira Aziz",
    "Prof. Kashif Ahmed",
    "Dr. Sadia Malik",
    "Prof. Amir Khan",
    "Dr. Aisha Rafique",
    "Prof. Waqar Akram",
    "Dr. Natasha Irfan",
    "Prof. Arslan Ahmed",
    "Dr. Mahira Shahid",
    "Prof. Asif Riaz",
    "Dr. Amina Shah",
    "Prof. Saad Hassan",
    "Dr. Imtiaz Ahmed",
    "Prof. Nida Ali",
    "Dr. Bilal Riaz",
    "Prof. Sofia Akhtar",
    "Dr. Talha Siddiqui",
    "Prof. Saba Malik",
    "Dr. Rashid Khan",
    "Prof. Nadia Shah",
    "Dr. Danish Ali",
    "Prof. Aiza Khan",
    "Dr. Taimoor Haider",
    "Prof. Aneela Qureshi",
    "Dr. Sajjad Ahmed",
    "Prof. Rabia Jamil",
    "Dr. Hassan Mahmood",
    "Prof. Fiza Anwar",
    "Dr. Sara Aslam",
    "Prof. Bilal Akram",
    "Dr. Amna Ashraf",
    "Prof. Ahmed Malik",
    "Dr. Huma Farooq",
    "Prof. Tahir Iqbal",
    "Dr. Sidra Asif",
    "Prof. Salman Ahmed",
    "Dr. Sobia Khan",
    "Prof. Naeem Abbas",
    "Dr. Khadija Ahmed",
    "Prof. Aftab Riaz",
    "Dr. Maria Ilyas",
    "Prof. Akbar Khan",
    "Dr. Rabia Siddiqui",
    "Prof. Zaid Ahmed",
    "Dr. Fatima Ali",
    "Prof. Amir Hussain",
    "Dr. Usama Khan",
    "Prof. Rukhsar Malik",
    "Dr. Ayesha Tariq",
    "Prof. Imran Riaz",
    "Dr. Sadaf Iqbal",
    "Prof. Ahmed Shah",
    "Dr. Amina Baig",
    "Prof. Tariq Mehmood",
    "Dr. Sana Akram",
    "Prof. Imran Ali",
    "Dr. Noor Ahmed",
    "Prof. Naima Khan",
    "Dr. Adeel Malik",
    "Prof. Fariha Tahir"
    };


    private readonly LinqDbContext _db;
    public AddDataService(LinqDbContext db)
    {
        _db = db;
    }

    public bool addFaculty()
    {
        try
        {
            for (int i = 1; i < facultyNames.Count; i++)
            {
                _db.Faculties.Add(new Faculty
                {
                    FName = facultyNames[i],
                    DeptId = i,
                    Standing = i % 2 == 0 ? "Full-Time" : "Part-Time"
                });
            }
            var lastEntry = _db.SaveChanges();
            if (lastEntry > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }catch(Exception ex)
        {
            return false;
        }
    }
    public bool AddStudent()
    {
        try
        {
            List<Student> students = new List<Student>();

            for (int i = 1; i < studentNameList.Count; i++)
            {
                Student student = new Student
                {
                    SName = studentNameList[i],
                    Major = GetRandomMajor(),
                    Standing = GetRandomStanding()
                };

                students.Add(student);
            }
            _db.Students.AddRange(students);
            var lastEntry = _db.SaveChanges();
            if (lastEntry > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    private string GetRandomMajor()
    {
        string[] majors = { "Computer Science", "Biology", "Physics", "Mathematics", "History", "English", "Psychology", "Economics", "Chemistry", "Sociology" };
        return majors[new Random().Next(majors.Length)];
    }

    private string GetRandomStanding()
    {
        string[] standings = { "Freshman", "Sophomore", "Junior", "Senior" };
        return standings[new Random().Next(standings.Length)];
    }
}

