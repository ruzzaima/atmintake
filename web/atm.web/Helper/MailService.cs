using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web
{
    public class MailService
    {
        private List<string> Spliter(string source)
        {
            if (source != null)
            {
                var result = new List<string>();
                var t = source.Split(new[] { ",", " ", ";" }, StringSplitOptions.RemoveEmptyEntries);
                if (t.Any())
                {
                    result.AddRange(t);
                }
                else
                {
                    result.Add(source);
                }
                return result;
            }
            return new List<string>();
        }

        public void Send(string from, IEnumerable<string> tos, IEnumerable<string> ccs, IEnumerable<string> bccs, LoginUser user, string loginurl, string templatepath, DateTime? dateTime)
        {
            var client = new SmtpClient();

            var mailDefinition = new MailDefinition
            {
                Priority = MailPriority.High,
                From = "noreply@atm.gov.my",
                IsBodyHtml = true,
                Subject = "[ATM]Notifikasi Pendaftaran",
                BodyFileName = templatepath
            };

            var ldReplacement = new ListDictionary
            {
                {
                    "<%RegistrationDateTime%>", dateTime.HasValue
                        ? $"{dateTime.Value:dd/MM/yyyy}"
                        : $"{user.CreatedDt:dd/MM/yyyy}"
                },
                {"<%FullName%>", user.FullName.Trim().ToUpper()},
                {"<%UserName%>", user.UserName.Trim().ToUpper()},
                {"<%Password%>", user.Password},
                {"<%LoginUrl%>", loginurl}
            };

            var mail = mailDefinition.CreateMailMessage(user.Email, ldReplacement, new Control());
            mail.From = new MailAddress(from, "No Reply");

            if (null != ccs)
                foreach (var cc in ccs.ToList().SelectMany(Spliter))
                {
                    mail.CC.Add(new MailAddress(cc, ""));
                }

            if (null != bccs)
                foreach (var bcc in bccs.ToList().SelectMany(Spliter))
                {
                    mail.Bcc.Add(new MailAddress(bcc, ""));
                }

            mail.Subject = "[ATM]Notifikasi Pendaftaran";
            mail.IsBodyHtml = true;
            AlternateView htmlView;
            htmlView = AlternateView.CreateAlternateViewFromString(mail.Body, null, "text/html");
            mail.AlternateViews.Add(htmlView);

            if (null != tos)
                foreach (var recipient in tos.ToList().SelectMany(Spliter))
                {
                    mail.To.Add(new MailAddress(recipient));
                    try
                    {
                        client.Send(mail);
                    }
                    catch (Exception)
                    {
                        //ignore
                    }
                }
        }

        public void SendMail(string subject, string from, IEnumerable<string> tos, IEnumerable<string> ccs, IEnumerable<string> bccs, LoginUser user, string loginurl, string templatepath, DateTime? dateTime)
        {
            var client = new SmtpClient();
            var mailDefinition = new MailDefinition
            {
                Priority = MailPriority.High,
                From = @from,
                IsBodyHtml = true,
                Subject = subject,
                BodyFileName = templatepath
            };

            var ldReplacement = new ListDictionary
            {
                {
                    "<%RegistrationDateTime%>", dateTime.HasValue
                        ? $"{dateTime.Value:dd/MM/yyyy}"
                        : $"{user.CreatedDt:dd/MM/yyyy}"
                },
                {"<%FullName%>", user.FullName.Trim().ToUpper()},
                {"<%UserName%>", user.UserName.Trim().ToUpper()}
            };

            if (!string.IsNullOrWhiteSpace(user.Password))
                ldReplacement.Add("<%Password%>", user.Password);
            ldReplacement.Add("<%LoginUrl%>", loginurl);
            var mail = mailDefinition.CreateMailMessage(user.Email, ldReplacement, new Control());
            mail.From = new MailAddress(from, "No Reply");

            if (null != ccs)
                foreach (var cc in ccs.ToList().SelectMany(Spliter))
                {
                    mail.CC.Add(new MailAddress(cc, ""));
                }

            if (null != bccs)
                foreach (var bcc in bccs.ToList().SelectMany(Spliter))
                {
                    mail.Bcc.Add(new MailAddress(bcc, ""));
                }
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            var htmlView = AlternateView.CreateAlternateViewFromString(mail.Body, null, "text/html");
            mail.AlternateViews.Add(htmlView);

            if (null != tos)
                foreach (var recipient in tos.ToList().SelectMany(Spliter))
                {
                    mail.To.Add(new MailAddress(recipient));
                    try
                    {
                        client.Send(mail);
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
        }
        public void SendWithMessage(string from, IEnumerable<string> tos, IEnumerable<string> ccs, IEnumerable<string> bccs, LoginUser user, string subject, string body, DateTime? dateTime)
        {
            var client = new SmtpClient();

            var mail = new MailMessage { From = new MailAddress(@from, "No Reply") };

            if (null != ccs)
                foreach (var cc in ccs.ToList().SelectMany(Spliter))
                {
                    mail.CC.Add(new MailAddress(cc, ""));
                }

            if (null != bccs)
                foreach (var bcc in bccs.ToList().SelectMany(Spliter))
                {
                    mail.Bcc.Add(new MailAddress(bcc, ""));
                }

            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = body;
            AlternateView htmlView = null;
            if (mail.Body != null) htmlView = AlternateView.CreateAlternateViewFromString(mail.Body, null, "text/html");
            mail.AlternateViews.Add(htmlView);

            if (null != tos)
                foreach (var recipient in tos.ToList().SelectMany(Spliter))
                {
                    mail.To.Add(new MailAddress(recipient));
                    try
                    {
                        client.Send(mail);
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
        }

    }
}