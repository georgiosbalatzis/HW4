namespace HW4;

public class CarRental
{
    private string FirstName;
    private string LastName;
    private int NumberOfDays;

    public CarRental(string firstName, string lastName, int numberOfDays)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        NumberOfDays = numberOfDays;
    }

    public string FirstName1 => FirstName;

    public string LastName1 => LastName;

    public int NumberOfDays1 => NumberOfDays;

    public override string ToString()
    {
        return
            $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(NumberOfDays)}: {NumberOfDays}, {nameof(FirstName1)}: {FirstName1}, {nameof(LastName1)}: {LastName1}, {nameof(NumberOfDays1)}: {NumberOfDays1}";
    }
}