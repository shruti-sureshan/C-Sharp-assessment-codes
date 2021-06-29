using System;

//update the code below 
public class Account
{
	//CODE START
	 public int accountNo;
	 public double balance;
	 public String accountType;
	 public static int counter;
	 public Account(double b, String at){
	     this.balance=b;
	     this.accountType=at;
	     counter++;
	     this.accountNo=counter;
	 }
	 public int getAccountNo(){
	     return this.accountNo;
	 }
	 public void setAccountNo(int an){
	     this.accountNo=an;
	 }
	 public double getBalance(){
	     return this.balance;
	 }
	 public void setBalance(double b){
	     this.balance=b;
	 }
	 public String getAccountType(){
	     return this.accountType;
	 }
	 public void getAccountType(String at){
	     this.accountType=at;
	 }
	 public void depositAmount(double amount){
	     this.setBalance(this.getBalance()+amount);
	 }
	 public void printAccountDetails(){
	     String s1="[Acct No : "+this.getAccountNo()+", ";
	     String s2="Type : "+this.getAccountType()+", ";
	     String s3="Balance : "+this.getBalance()+"]";
	     Console.WriteLine(s1+s2+s3);
	 }
}



public	class AccountDetails
{
 
	public void GetData(){

	    //update the code below
	     double balance1 = Convert.ToDouble(Console.ReadLine());
		String type1 = Console.ReadLine();
	double amount1 = Convert.ToDouble(Console.ReadLine()) ;
		double balance2 = Convert.ToDouble(Console.ReadLine());
		String type2 = Console.ReadLine() ;
	double amount2 = Convert.ToDouble(Console.ReadLine());

		
		Account a1 = new Account(balance1, type1);
		a1.printAccountDetails();
		a1.depositAmount(amount1);
		Console.WriteLine("New Balance : {0:N}",a1.getBalance());
		
		Account a2 = new Account(balance2, type2);
		a2.printAccountDetails();
		a2.depositAmount(amount2);
		Console.WriteLine("New Balance : {0:N}",a2.getBalance());

	    
	}
	public static void Main(){
	    AccountDetails a=new AccountDetails();
	    a.GetData();
	}
		
		
	    
	  
}