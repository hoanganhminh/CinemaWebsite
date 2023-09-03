using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Cinema.Helpers;
using Cinema.Models;
using Cinema.Models.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.Pages
{
    public class singleModel : PageModel
    {
        public double averageRateCast;
        public string numberOfRate;
        public int editRatee;
        public string editComment;
        public Movie movie;
        public string categoryOfMovie;
        public List<Rate> rates;
        public string api1;
        public string api2;
        public void OnGet(int? id, string movieIdDelete, string memberIdDelete, string editCmt, string editRate, string edit)
        {
            //edit comment
            if(edit != null)
            {
                if (edit.Equals("edit"))
                {
                    editRatee = int.Parse(editRate);
                    editComment = editCmt;
                    RateDAO.DeleteRate(int.Parse(memberIdDelete), int.Parse(movieIdDelete));
                }
            }
            //xoa comment
            if (!String.IsNullOrEmpty(movieIdDelete) && !String.IsNullOrEmpty(memberIdDelete) && edit.Equals("no"))
            {
                RateDAO.DeleteRate(int.Parse(memberIdDelete), int.Parse(movieIdDelete));
            }
            if (id == null)
            {
                movie = MovieDAO.GetMovieById(int.Parse(movieIdDelete));
            }
            else
            {
                movie = MovieDAO.GetMovieById(int.Parse(id.ToString()));
                string name1 = System.Web.HttpUtility.UrlEncode(movie.Title+" Trailer", System.Text.Encoding.UTF8).ToUpper().Replace("+","%20");
                string name2 = System.Web.HttpUtility.UrlEncode(movie.Title, System.Text.Encoding.UTF8).ToUpper().Replace("+","%20");
                api1 = "https://youtube-search9.p.rapidapi.com/snc/" + name1;
                api2 = "https://online-movie-database.p.rapidapi.com/title/find?q=" + name2;
            }
            categoryOfMovie = GenreDAO.GetGenreById(int.Parse(movie.GenreId.ToString())).Description;
            rates = RateDAO.GetRateByMovieId(movie.MovieId);
            double? averageRate;
            if (rates != null)
            {
                averageRate = rates.Average(r => r.Rating);
            }
            else
            {
                averageRate = 0;
            }
            if (averageRate.HasValue)
            {
                averageRateCast = (double)averageRate;
                averageRateCast = Math.Round(averageRateCast, 1, MidpointRounding.ToEven);
            }
            numberOfRate =  " (" + averageRateCast + ") out of " + rates.Count +" rate";


        }

        public IActionResult OnPost()
        {
                if (!Request.Form["content"].Equals(""))
                {
                    Member a = SessionHelper.GetObjectFromJson<Member>(HttpContext.Session, "user");
                    int movieId = int.Parse(Request.Form["movieId"]);
                    double rate = double.Parse(Request.Form["rate"]);
                    string content = Request.Form["content"];
                    RateDAO.addComment(movieId, a.MemberId,rate,content);
                    OnGet(movieId,null,null,null,null,null);
                }
                return Page();
        }

        public string RelativeDate(DateTime theDate)
        {
            Dictionary<long, string> thresholds = new Dictionary<long, string>();
            int minute = 60;
            int hour = 60 * minute;
            int day = 24 * hour;
            thresholds.Add(60, "Few seconds ago");
            thresholds.Add(minute * 2, "A minute ago");
            thresholds.Add(45 * minute, "{0} minutes ago");
            thresholds.Add(120 * minute, "An hour ago");
            thresholds.Add(day, "{0} hours ago");
            thresholds.Add(day * 2, "Yesterday");
            thresholds.Add(day * 30, "{0} days ago");
            thresholds.Add(day * 365, "{0} months ago");
            thresholds.Add(long.MaxValue, "{0} years ago");
            long since = (DateTime.Now.Ticks - theDate.Ticks) / 10000000;
            foreach (long threshold in thresholds.Keys)
            {
                if (since < threshold)
                {
                    TimeSpan t = new TimeSpan((DateTime.Now.Ticks - theDate.Ticks));
                    return string.Format(thresholds[threshold], (t.Days > 365 ? t.Days / 365 : (t.Days > 0 ? t.Days : (t.Hours > 0 ? t.Hours : (t.Minutes > 0 ? t.Minutes : (t.Seconds > 0 ? t.Seconds : 0))))).ToString());
                }
            }
            return "";
        }

    }
}
