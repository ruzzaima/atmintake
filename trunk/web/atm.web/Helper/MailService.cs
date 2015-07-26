using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web
{
    public class MailService
    {
        private Stream ConvertByteArrayToStream(byte[] input)
        {
            return new MemoryStream(input);
        }

        private List<string> Spliter(string source)
        {
            if (source != null)
            {
                var result = new List<string>();
                var t = source.Split(new string[] { ",", " ", ";" }, StringSplitOptions.RemoveEmptyEntries);
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
            try
            {

                var mailDefinition = new MailDefinition();
                mailDefinition.Priority = MailPriority.High;
                mailDefinition.From = "noreply@atm.gov.my";
                mailDefinition.IsBodyHtml = true;
                mailDefinition.Subject = "[ATM]Notifikasi Pendaftaran";
                mailDefinition.BodyFileName = templatepath;

                var ldReplacement = new ListDictionary();
                if (dateTime.HasValue)
                    ldReplacement.Add("<%RegistrationDateTime%>", string.Format("{0:dd/MM/yyyy}", dateTime.Value));
                else
                    ldReplacement.Add("<%RegistrationDateTime%>", string.Format("{0:dd/MM/yyyy}", user.CreatedDt));

                ldReplacement.Add("<%FullName%>", user.FullName.Trim().ToUpper());
                ldReplacement.Add("<%UserName%>", user.UserName.Trim().ToUpper());
                ldReplacement.Add("<%Password%>", user.Password);
                ldReplacement.Add("<%LoginUrl%>", loginurl);
                var mail = new MailMessage();
                mail = mailDefinition.CreateMailMessage(user.Email, ldReplacement, new Control());
                mail.From = new MailAddress(from, "No Reply");
                if (null != tos)
                    foreach (var recipient in tos.ToList().SelectMany(Spliter))
                    {
                        mail.To.Add(new MailAddress(recipient));
                    }
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
                AlternateView htmlView = null;
                htmlView = AlternateView.CreateAlternateViewFromString(mail.Body, null, "text/html");
                mail.AlternateViews.Add(htmlView);

                //if (em.AttachmentList.Count > 0)
                //{
                //    foreach (var x in em.AttachmentList.Where(x => x.Attachment != null))
                //    {
                //        mail.Attachments.Add(new Attachment(ConvertByteArrayToStream(x.Attachment), x.FileName, x.ContentType));
                //    }
                //} 
                //client.SendCompleted += (s, e) => client.Dispose();
                //client.SendAsync(mail, null);
                client.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
    }
}