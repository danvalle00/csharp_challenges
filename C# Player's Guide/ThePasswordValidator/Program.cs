Console.Title = "The Password Validator";
PasswordValidator validator = new PasswordValidator();
while (true)
{
    Console.Write("Tell me an password and ill check if its valid. ");
    string? myPassword = Console.ReadLine();
    if (myPassword == null)
        break;
    validator.Validate(myPassword);
}


class PasswordValidator
{
    public string? Password { get; }

    public void Validate(string givenPassword)
    {
        bool containUppercase = false, containLowercase = false, containNumber = false;
        // Can be refactored into functions, but im lazy rn
        int passwordLength = givenPassword.Length;
        if (passwordLength < 6 || passwordLength > 13)
        {
            Console.WriteLine("Invalid Password, LengthError");
            return;
        }
        foreach (char letter in givenPassword)
        {
            if (letter == 'T')
            {
                Console.WriteLine("Invalid Password, Contains Capital T 'T' ");
                return;
            }
            else if (letter == '&')
            {
                Console.WriteLine("Invalid Password, Contains Ampersand Char");
                return;
            }

            if (char.IsUpper(letter))
            {
                containUppercase = true;   
            }
            else if (char.IsLower(letter))
            {
                containLowercase = true;
            }
            else if (char.IsNumber(letter))
            {
                containNumber = true;
            }
        }
        if (containUppercase && containLowercase && containNumber)
        {
            Console.WriteLine("Password is Valid, Good Job!");       
        }
        else if (!containUppercase)
        {
            Console.WriteLine("Invalid Password, Doesn't contain Uppercases");
        }
        else if (!containLowercase)
        {
            Console.WriteLine("Invalid Password, Doesn't contain Lowercases");
        }
        else if (!containNumber)
        {
            Console.WriteLine("Invalid Password, Doesn't contain Numbers");
        }
    }

}