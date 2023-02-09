// Simple Number formatter

long number = 0;
string input;

System.Console.WriteLine("Hello and welcome to the Number Formatter!");

do
{
    System.Console.Write("Enter a number: ");
    input = Console.ReadLine()!.ToLower();
    if (input != "q")
    {
        number = long.Parse(input);
        if (number == 88) { System.Console.WriteLine("Heil!"); return; }
        System.Console.Write("Your number into text: ");
        if (number < 0)
        {
            System.Console.Write("minus");
            number *= -1;
        }
        System.Console.Write(TenAndElevenAndTwelveDigitNumberIntoLongText(number));
        System.Console.WriteLine();
    }
}
while (input != "q");

string OneDigitNumbersIntoLongText(long number)
{
    switch (number)
    {
        case 0: return "zero";
        case 1: return "one";
        case 2: return "two";
        case 3: return "three";
        case 4: return "four";
        case 5: return "five";
        case 6: return "six";
        case 7: return "seven";
        case 8: return "eight";
        case 9: return "nine";
        default: return "Not a digit";
    }
}

string TwoDigitNumberIntoLongText(long number)
{
    if (number >= 100) { return "Too high!"; }
    string countTens;
    if (number < 10)
    {
        return OneDigitNumbersIntoLongText(number);
    }
    else if (number < 20)
    {
        switch (number)
        {
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "thirteen";
            case 15: return "fifteen";
            case 18: return "eighteen";
            default: return $"{OneDigitNumbersIntoLongText(number % 10)}teen";
        }
    }

    if (number / 10 == 2) { countTens = "twenty"; }
    else if (number / 10 == 3) { countTens = "thirty"; }
    else if (number / 10 == 4) { countTens = "fourty"; }
    else if (number / 10 == 5) { countTens = "fifty"; }
    else if (number / 10 == 6) { countTens = "sixty"; }
    else if (number / 10 == 7) { countTens = "seventy"; }
    else if (number / 10 == 8) { countTens = "eighty"; }
    else { countTens = "ninety"; }

    switch (number)
    {
        case 20:
        case 30:
        case 40:
        case 50:
        case 60:
        case 70:
        case 80:
        case 90: return $"{countTens}";
        default: return $"{countTens}{OneDigitNumbersIntoLongText(number % 10)}";
    }
}

string ThreeDigitNumberIntoLongText(long number)
{
    if (number >= 1000) { return "Too high"; }
    else if (number < 100)
    {
        return TwoDigitNumberIntoLongText(number);
    }
    string countHundreds = $"{OneDigitNumbersIntoLongText(number / 100)}";
    switch (number)
    {
        case 100:
        case 200:
        case 300:
        case 400:
        case 500:
        case 600:
        case 700:
        case 800:
        case 900: return $"{countHundreds}hundred";
        default: return $"{countHundreds}hundred{TwoDigitNumberIntoLongText(number % 100)}";
    }
}

string FourAndFiveAndSixDigitNumberIntoLongText(long number)
{
    if (number >= 1_000_000) { return "Too high"; }
    else if (number < 1000)
    {
        return ThreeDigitNumberIntoLongText(number);
    }
    string countTenAndHundredThousands = ThreeDigitNumberIntoLongText(number / 1000);
    if (number % 1000 == 0 && number % 100 == 0 && number % 10 == 0)
    {
        return $"{countTenAndHundredThousands}thousand";
    }
    else
    {
        return $"{countTenAndHundredThousands}thousand{ThreeDigitNumberIntoLongText(number % 1000)}";
    }
}

string SevenAndEightAndNineDigitNumberIntoLongText(long number)
{
    if (number >= 1_000_000_000) { return "Too high"; }
    else if (number < 1_000_000)
    {
        return FourAndFiveAndSixDigitNumberIntoLongText(number);
    }
    string countMillions = ThreeDigitNumberIntoLongText(number / 1_000_000);
    if (number % 1_000_000 == 0 && number % 100_000 == 0 && number % 10_000 == 0 && number % 1_000 == 0 && number % 100 == 0 && number % 10 == 0)
    {
        return $"{countMillions}million";
    }
     else
    {
        return $"{countMillions}million{FourAndFiveAndSixDigitNumberIntoLongText(number % 1_000_000)}";
    }
}

string TenAndElevenAndTwelveDigitNumberIntoLongText(long number)
{
    if (number >= 1_000_000_000_000) { return "Too high"; }
    else if (number < 1_000_000_000)
    {
        return FourAndFiveAndSixDigitNumberIntoLongText(number);
    }
    string countBillions = ThreeDigitNumberIntoLongText(number / 1_000_000_000);
    if (number % 1_000_000_000 == 0 && number % 100_000_000 == 0 && number % 10_000_000 == 0 && number % 1_000_000 == 0 && number % 100_000 == 0 && number % 10_000 == 0&& number % 1_000 == 0&& number % 100 == 0&& number % 10 == 0)
    {
        return $"{countBillions}billion";
    }
     else
    {
        return $"{countBillions}billion{SevenAndEightAndNineDigitNumberIntoLongText(number % 1_000_000_000)}";
    }
}

