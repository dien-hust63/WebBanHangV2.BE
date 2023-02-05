using Gather.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Interfaces.Base;
using WebBanHang.Common.Interfaces.BL;
using WebBanHang.Common.Interfaces.DL;
using WebBanHang.Common.Services;

namespace WebBanHang.BL.BL
{
    public class MailBL : BaseBL<MailRequest>, IMailBL
    {
        IMailDL _mailDL;

        public MailBL(IBaseDL<MailRequest> baseDL, IMailDL mailDL) : base(baseDL)
        {
            _mailDL = mailDL;
        }

        /// <summary>
        /// Gửi email
        /// </summary>
        /// <param name="mailContent"></param>
        /// <returns></returns>
        public ServiceResult sendEmail(MailRequest mailContent)
        {
            ServiceResult serviceResult = new ServiceResult();
            MailMessage mail = new MailMessage();
            mail.To.Add("macrohd34@gmail.com");
            mail.From = new MailAddress("nguyendien2804@gmail.com", "360 FOR MEN");
            mail.Subject = "360 For Men test";
            mail.Body = "<div>Hello mail</div>";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new NetworkCredential("nguyendien2804@gmail.com", "cstebbvezjruwbyz");
            smtp.Send(mail);

            return serviceResult;

        }
    }
}
