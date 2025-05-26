using System.Net.Mail;

namespace IM_P2.CleanCodeExamples;

public class X
{
    public void Y()
    {
        var l = new List<string>();
        l.Add("Apfel,1.2");
        l.Add("Banane,0.8");
        l.Add("Keks,1.5");

        foreach (var z in l)
        {
            var t = z.Split(',');
            var n = t[0];
            var p = double.Parse(t[1]);

            File.AppendAllText("products.csv", n + "," + p + Environment.NewLine);

            MailMessage m = new MailMessage("system@example.com", "admin@example.com");
            m.Subject = "New Product";
            m.Body = $"Product: {n}, Price: {p}";
            new SmtpClient("smtp.example.com").Send(m);
        }
    }
}