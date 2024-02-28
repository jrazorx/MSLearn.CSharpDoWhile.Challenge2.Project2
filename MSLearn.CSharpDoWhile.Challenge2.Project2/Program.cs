string[] validRoles = new string [] { "Administrator", "Manager", "User" };
string enterRoleNamePrompt = "Enter your role name (";

string? roleInput;
string transformedRoleInput;
string validRoleSelected = "";
bool isValidRoleInput = false;

/*
 * Creates the prompt "Enter your role name"
 * with the list of available valid roles
*/ 
for (int i = 0; i < validRoles.Length; i++)
{
    enterRoleNamePrompt += validRoles[i];

    if      (i <  validRoles.Length - 2)
        enterRoleNamePrompt += ", ";
    else if (i == validRoles.Length - 2)
        enterRoleNamePrompt += ", or ";
    else
        enterRoleNamePrompt += ")";
}

/*
 * Prompts the user to enter his role name
 * Loops until the role is valid
 * Displays an error if the input is not valid
*/
do
{
    Console.WriteLine(enterRoleNamePrompt);
    roleInput = Console.ReadLine();

    if (roleInput == null)
        continue;

    transformedRoleInput = roleInput.Trim().ToLower();
    foreach (string role in validRoles)
    {
        if (transformedRoleInput == role.Trim().ToLower())
        {
            validRoleSelected = role;
            isValidRoleInput = true;
        }
    }

    if (!isValidRoleInput)
        Console.Write($"The role name that you entered, \"{transformedRoleInput}\" is not valid. ");

} while (!isValidRoleInput);

Console.WriteLine($"Your input value ({validRoleSelected}) has been accepted.");