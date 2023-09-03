using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.DAO
{
    public class RateDAO
    {
        public static List<Rate> GetRateByMovieId(int id)
        {
            List<Rate> rates;
            try
            {
                using (var context = new MovieDBContext())
                {
                    rates = context.Rates.Where(r => r.MovieId == id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return rates;
        }

        public static List<Rate> GetRates()
        {
            List<Rate> rates;
            try
            {
                using (var context = new MovieDBContext())
                {
                    rates = context.Rates.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return rates;
        }

        public static void addComment(int movieId, int memberId, double rate,string content)
        {
            try
            {
                Rate r = new Rate();
                r.MovieId = movieId;
                r.MemberId = memberId;
                r.Rating = rate;
                r.Time = DateTime.Now;
                r.Comment = content;
                using (MovieDBContext context = new MovieDBContext())
                {
                    context.Rates.Add(r);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.InnerException.Message);
            }
        }

        public static bool checkMemberComment(int id, int movId)
        {
            List<Rate> rates;
            try
            {
                using (var context = new MovieDBContext())
                {
                    rates = context.Rates.Where(r => r.MemberId == id && r.MovieId == movId).ToList();
                }
                if (rates.Count() == 0 )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteRate(int id, int movId)
        {
            List<Rate> rates;
            try
            {
                using (var context = new MovieDBContext())
                {
                    rates = context.Rates.Where(r => r.MemberId == id && r.MovieId == movId).ToList();
                }
                using (MovieDBContext context = new MovieDBContext())
                {
                    foreach (Rate r in rates)
                    {
                        context.Rates.Remove(r);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Rate findRate(string id, string movId)
        {
            Rate r;
            try
            {
                using (MovieDBContext context = new MovieDBContext())
                {
                    r = context.Rates.SingleOrDefault(r => r.MemberId == int.Parse(id) && r.MovieId == int.Parse(movId));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return r;
        }
    }
}
