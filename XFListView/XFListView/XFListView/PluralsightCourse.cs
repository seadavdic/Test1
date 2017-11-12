using System.Collections.Generic;

namespace XFListView
{
    public class PluralsightCourse
    {
        public string Author { get; set; }
        public string Title { get; set; }

        public static List<PluralsightCourse> GetCourseList()
        {
            var courseList = new List<PluralsightCourse>();
            courseList.Add(new PluralsightCourse
            {
                Title = "Building Cross Platform Apps with Xamarin Part 1",
                Author = "Jim Wilson"
            });
            courseList.Add(new PluralsightCourse
            {
                Title = "Building Cross Platform Apps with Xamarin Part 2",
                Author = "Jim Wilson"
            });
            courseList.Add(new PluralsightCourse
            {
                Title = "Building Google Glass Apps with c# and Xamarin",
                Author = "Jim Wilson"
            });
            courseList.Add(new PluralsightCourse
            {
                Title = "Android for .NET Developers",
                Author = "Jim Wilson"
            });

            return courseList;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}