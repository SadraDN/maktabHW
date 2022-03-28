var dest = @"C:\\Users\\Sadra\\Desktop\\maktab\\codes\\HW5\\Archive\\CopyDest.txt";
var source = @"C:\\Users\\Sadra\\Desktop\\maktab\\codes\\HW5\\CopySource.txt";

try
{
    File.Copy(source, dest , true);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("File doesn't exist");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine("You Do not have access to this file");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine("Can't find your destination folder");
}
catch (Exception ex)
{
    Console.WriteLine("Something went wrong , try again");
}











//catch (IOException iox)
//{
//    Console.WriteLine(iox.Message);
//    throw iox;
//}
//catch (UnauthorizedAccessException iox)
//{
//    Console.WriteLine("Do not have access to File");
//    throw iox;
//}
