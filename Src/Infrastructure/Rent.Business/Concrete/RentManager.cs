using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.DataAccess.Concrete;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Concrete
{
    public class RentManager : IRentService
    {
        private readonly IMailHeaderLineDal _mailHeaderLineDal;
        private readonly IMailSettingDal _mailSettingDal;

        public RentManager(IMailHeaderLineDal mailHeaderLineDal, IMailSettingDal mailSettingDal)
        {
            _mailHeaderLineDal = mailHeaderLineDal;
            _mailSettingDal = mailSettingDal;
        }

        public MailSetting GetMailSettings()
        {
            return _mailSettingDal.GetAll().FirstOrDefault();
        }

        public List<MailHeaderLine> GetsMailList(EnumModule module)
        {
            return _mailHeaderLineDal.GetsByModuleId(module);
        }

        public void SendMail()
        {
            MailSetting mailSetting = GetMailSettings();
            if(mailSetting != null)
            {
                Array arr = Enum.GetValues(typeof(EnumModule));
                foreach (EnumModule module in arr)
                {
                    List<MailHeaderLine> headerLines = GetsMailList(module);
                    foreach (var item in headerLines)
                    {
                        string html = "";
                        if (mailSetting != null)
                        {
                            html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";
                            html += "<tr>";
                            html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'> Satınalma Emir No </th>";
                            html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'> Tedarikçi </th>";
                            html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'> Satınalmacı </th>";
                            html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'> Ödeme Tutar </th>";
                            html += "</tr>";
                            html += "<tr>";

                            Encoding encode = Encoding.GetEncoding("windows-1254");
                            MailMessage email = new MailMessage();
                            MailAddress mailFromAccount = new MailAddress(mailSetting.MailAddress, mailSetting.DisplayName, encode);
                            
                            if (!string.IsNullOrEmpty(mailSetting.MailAddress))
                            {
                                MailAddress MailTO = new MailAddress(mailSetting.MailAddress, mailSetting.DisplayName, encode);
                                email.To.Add(MailTO);
                            }

                            html += "<td style='width:120px;border: 1px solid #ccc'>" + item.MailAddress+ "</td>";
                            html += "<td style='width:120px;border: 1px solid #ccc'>" + item.MailAddress  + "</td>";
                            html += "<td style='width:120px;border: 1px solid #ccc'>" + item.MailAddress  + "</td>";
                            html += "<td style='width:120px;border: 1px solid #ccc'>" + item.MailAddress + "</td>";
                            html += "</tr>";

                            email.From = mailFromAccount;
                            email.Subject = $"{item.MailAddress} : numaralı ödeme bilgisi";
                            email.IsBodyHtml = true;
                            email.Body = html;
                            SmtpClient SmtpMail = new SmtpClient(mailSetting.SmtpServer, Convert.ToInt32(mailSetting.ServerPortName));
                            SmtpMail.UseDefaultCredentials = false;
                            SmtpMail.Credentials = new System.Net.NetworkCredential(mailSetting.UserName, mailSetting.Password);
                            SmtpMail.EnableSsl = false;

                            if (email.To.Count > 0)
                                SmtpMail.Send(email);
                           
                        }
                    }
                }
            }
        }
    }
}
