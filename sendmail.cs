using system.net.mail

public static void Sendmail(string emailbody){

MailMessage mailMessage = new MailMessage ("koudvenkat@gmail.com",
"kudvenkat@gamil.com");
//from and too 
mailMesssage.Subject = "something";
mailMessage.body = emailbody;
smtpClient smtpclient = new SmtpClient("smtp.gmail.com",587);
smtpClient.credentials = new system.ent.networkCredentia(){
UserName="kudvanekat@gmail.com",
Password = "test"
};
smtpclient.EnableSsl=true;
smtpClient.Send(mailMessage);



// in web config you should add

<confgurattion>
<appSettings>
<add key="SendEmail" value="true"/>
</appSettings>
</configuration>


}
