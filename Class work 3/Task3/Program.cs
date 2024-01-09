var doctor = new Doctor("Dr. Johnson","Cardiologist",15);

System.Console.Write("Doctor's Name: ");
System.Console.WriteLine("Dr. Johnson");

System.Console.Write("Medical Specialty: ");
System.Console.WriteLine("Cardiologist");

System.Console.Write("Years of Experience: ");
System.Console.WriteLine(15);


System.Console.WriteLine(doctor.TreatPatient("Emily Parker"));
System.Console.WriteLine(doctor.PerformMedicalExamination("Emily Parker"));
System.Console.WriteLine(doctor.PrescribeMedication("James Brown","Antibiotics "));




public class Doctor
{
    string fullName;
    string specialty;
    int experience;

    public Doctor() 
    {

    }
    public Doctor(string name,string specialty)
    {
        fullName = name;

        this.specialty = specialty;
    }
    public Doctor(string name, string specialty, int experience)
    {
        fullName = name;

        this.specialty = specialty;

        this.experience = experience;
    }
    public string TreatPatient(string patientName)
    {
        return $"{fullName}, {specialty} бемореро бо номи {patientName} табобат мекунад.";
    }
    public string PerformMedicalExamination(string patientName)
    {
        return $"{fullName} назначает пациенту по имени {patientName}";
    }
    public string PrescribeMedication(string patientName, string medication)
    {
        return $"{fullName} {medication}-ро ба беморе бо номи {patientName} таъин мекунад.";
    }
    public void SetExperience(int years)
    {
        experience = years;
    }
    public int GetExperience() 
    {
        return experience;
    }
}