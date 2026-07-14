namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q01
            /*
             a) A University has Departments. If the university is closed, the departments no longer exist.
                Compostition ->Tigh coupling
             b) A Driver uses a Car. The driver does not own the car.
                 Association
             c) A Dog is an Animal.
                inheritance
             d) A Team has Players. If the team is deleted, the players still exist.
                Aggregation ->less coupling
             e) A method receives a Logger as a parameter and calls it inside the method only.
                Dependancy
             */
            #endregion
            #region Q02
            /*
             a) yes,child can access a protected field in a different assembly,
                but the object ant access it because protect member behave like private
             b) Private protected : inheret as protected private but use private with only the project with the same assembly
                internal protected : inheret as : internal protected but use as internal cannot access outside the assembly
             c) sealed keyword use to prevents the inheritance for the next class and the sealed class cann't be inherited
                A sealed method prevents overriding of that method
             d)yes,because using seald only to prevents inheritance
             */
            #endregion
            #endregion
        }
    }
}
