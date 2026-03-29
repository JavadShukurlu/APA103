using _08_StatiClassExtensionMethodsExceptions.Models;
using _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions;

LoginSystem loginSystem = new LoginSystem();
//User user = new User("Cavad", "Cavad123");


while (true)
{
    Console.WriteLine("Username daxil edin:");
    string username = Console.ReadLine();
    Console.WriteLine("Sifreni  daxil edin:");
    string password = Console.ReadLine();
	try
	{
        bool result = loginSystem.Login(username, password);
        if (result == true)
            break;
    }
	catch (InvalidUsernameException ex)
	{

        Console.WriteLine("ERRRO: "+ex.Message);
	}
    catch(InvalidPasswordException ex)
    {
        Console.WriteLine("ERROR: "+ex.Message);
    } 
    catch(UserNotFoundException ex)
    {
        Console.WriteLine("ERROR: "+ex.Message);
        foreach(var item in loginSystem.Users)
        {
            Console.WriteLine($"Sistemde olan istifadeciler: {item.UserName}");
            
        }
    }
    catch(IncorrectPasswordException ex)
    {
        Console.WriteLine("WARNING: "+ex.Message);
    }
    catch(AccountLockedException ex)
    {
        Console.WriteLine("CRITICAL:"+ex.Message+" contact admin");
        break;
    }
    catch(Exception ex)
    {
        Console.WriteLine("UNEXPECTED ERROR: "+ex.Message);
    }



}