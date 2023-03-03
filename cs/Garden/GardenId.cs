namespace Garden;

/// <summary>
/// Garden Id should be made of exactly 7 characters,
/// all digits from 1 to 7
/// </summary>
public class GardenId
{
    /// <summary>
    /// Check that the value is a valid Garden ID
    /// </summary>
    public static bool Check(string value)
    {
        if (value.Length != 7)
        {
            return false;
        }

        foreach (var c in value)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }
}
