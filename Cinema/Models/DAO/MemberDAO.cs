using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Models.DAO
{
    public class MemberDAO
    {
        public static List<Member> GetMembers()
        {
            List<Member> rates;
            try
            {
                using (var context = new MovieDBContext())
                {
                    rates = context.Members.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return rates;
        }
        public static Member checkLogin(string username, string password)
        {
            Member a = null;
            try
            {
                using (MovieDBContext context = new MovieDBContext())
                {
                    a = context.Members.SingleOrDefault(acc => acc.Email.Equals(username) && acc.Password.Equals(EncodePasswordToBase64(password)));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return a;
        }

        public static Member checkExits(string username)
        {
            Member a = null;
            try
            {
                using (MovieDBContext context = new MovieDBContext())
                {
                    a = context.Members.SingleOrDefault(acc => acc.Email.Equals(username));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return a;
        }

        public static Member findMemberById(int id)
        {
            Member a = null;
            try
            {
                using (MovieDBContext context = new MovieDBContext())
                {
                    a = context.Members.SingleOrDefault(acc => acc.MemberId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return a;
        }
        public static void Register(string fullname, string gender, string email, string password)
        {
            try
            {
                Member c = new Member();
                c.Fullname = fullname;
                c.Password = EncodePasswordToBase64(password);
                c.Email = email;
                c.Gender = gender;
                c.Type = 0;
                using (MovieDBContext context = new MovieDBContext())
                {
                    context.Members.Add(c);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.InnerException.Message);
            }
        }

        public static void ChangePassword(int id, string pws)
        {
            try
            {
                Member c = findMemberById(id);
                c.Password = EncodePasswordToBase64(pws);
                using (MovieDBContext context = new MovieDBContext())
                {
                    context.Entry<Member>(c).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.InnerException.Message);
            }
        }

        public static void ChangeType(int id, int type)
        {
            try
            {
                Member c = findMemberById(id);
                c.Type = type;
                using (MovieDBContext context = new MovieDBContext())
                {
                    context.Entry<Member>(c).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.InnerException.Message);
            }
        }

        //this function Convert to Encord your Password 
        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
        //this function Convert to Decord your Password
        public string DecodeFrom64(string encodedData)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
    }
}
