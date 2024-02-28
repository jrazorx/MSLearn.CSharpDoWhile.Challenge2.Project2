string[] validRoles = new string [] { "Administrator", "Manager", "User" };
string enterRoleNamePrompt = "Enter your role name (";

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
Console.WriteLine(enterRoleNamePrompt);