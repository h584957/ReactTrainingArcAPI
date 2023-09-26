public class User{
public int UID{get;set;}
public string? Username{get;set;}
public string? Password{get;set;}
public User(){
Username = string.Empty;
Password = string.Empty;
}
public User(int uid, string username, string password){
    UID=uid;
    Username=username;
    Password=password;
}



}