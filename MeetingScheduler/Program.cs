using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace MeetingScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = @"{
                  ""users"": [
                    {
                      ""type"": ""CEO"",
                      ""name"": ""John Doe"",
                      ""meetings"": [
                        {""from"": ""2024-03-01T09:00:00"", ""to"": ""2024-03-01T10:00:00""},
                        {""from"": ""2024-03-05T11:30:00"", ""to"": ""2024-03-05T12:30:00""},
                        {""from"": ""2024-03-10T14:00:00"", ""to"": ""2024-03-10T15:00:00""},
                        {""from"": ""2024-03-15T16:30:00"", ""to"": ""2024-03-15T17:30:00""},
                        {""from"": ""2024-03-25T09:30:00"", ""to"": ""2024-03-25T10:30:00""},
                        {""from"": ""2024-03-26T09:30:00"", ""to"": ""2024-03-26T10:30:00""},
                        {""from"": ""2024-03-27T09:30:00"", ""to"": ""2024-03-27T10:30:00""},
                        {""from"": ""2024-03-28T09:30:00"", ""to"": ""2024-03-28T10:30:00""},
                        {""from"": ""2024-03-29T09:30:00"", ""to"": ""2024-03-29T10:30:00""},
                      ]
                    },
                    {
                      ""type"": ""Manager"",
                      ""name"": ""Alice Smith"",
                      ""meetings"": [
                        {""from"": ""2024-03-02T09:00:00"", ""to"": ""2024-03-02T10:00:00""},
                        {""from"": ""2024-03-07T11:30:00"", ""to"": ""2024-03-07T12:30:00""},
                        {""from"": ""2024-03-12T14:00:00"", ""to"": ""2024-03-12T15:00:00""},
                        {""from"": ""2024-03-17T16:30:00"", ""to"": ""2024-03-17T17:30:00""},
                        {""from"": ""2024-03-22T09:30:00"", ""to"": ""2024-03-22T10:30:00""}
                      ],
                      ""employees"": [
                        {
                          ""name"": ""Employee 1"",
                          ""meetings"": [
                            {""from"": ""2024-03-03T09:00:00"", ""to"": ""2024-03-03T10:00:00""},
                            {""from"": ""2024-03-08T11:30:00"", ""to"": ""2024-03-08T12:30:00""},
                            {""from"": ""2024-03-13T14:00:00"", ""to"": ""2024-03-13T15:00:00""},
                            {""from"": ""2024-03-18T16:30:00"", ""to"": ""2024-03-18T17:30:00""},
                            {""from"": ""2024-03-23T09:30:00"", ""to"": ""2024-03-23T10:30:00""}
                          ]
                        },
                        {
                          ""name"": ""Employee 2"",
                          ""meetings"": [
                            {""from"": ""2024-03-04T09:00:00"", ""to"": ""2024-03-04T10:00:00""},
                            {""from"": ""2024-03-09T11:30:00"", ""to"": ""2024-03-09T12:30:00""},
                            {""from"": ""2024-03-14T14:00:00"", ""to"": ""2024-03-14T15:00:00""},
                            {""from"": ""2024-03-19T16:30:00"", ""to"": ""2024-03-19T17:30:00""},
                            {""from"": ""2024-03-24T09:30:00"", ""to"": ""2024-03-24T10:30:00""}
                          ]
                        }
                      ]
                    },
                    {
                      ""type"": ""Manager"",
                      ""name"": ""Bob Johnson"",
                      ""meetings"": [
                        {""from"": ""2024-03-06T09:00:00"", ""to"": ""2024-03-06T10:00:00""},
                        {""from"": ""2024-03-11T11:30:00"", ""to"": ""2024-03-11T12:30:00""},
                        {""from"": ""2024-03-16T14:00:00"", ""to"": ""2024-03-16T15:00:00""},
                        {""from"": ""2024-03-21T16:30:00"", ""to"": ""2024-03-21T17:30:00""},
                        {""from"": ""2024-03-25T09:30:00"", ""to"": ""2024-03-25T10:30:00""},
                        {""from"": ""2024-03-26T14:30:00"", ""to"": ""2024-03-26T16:00:00""},
                        {""from"": ""2024-03-26T16:30:00"", ""to"": ""2024-03-26T18:00:00""}
                      ],
                      ""employees"": [
                        {
                          ""name"": ""Employee 3"",
                          ""meetings"": [
                            {""from"": ""2024-03-01T09:00:00"", ""to"": ""2024-03-01T10:00:00""},
                            {""from"": ""2024-03-07T11:30:00"", ""to"": ""2024-03-07T12:30:00""},
                            {""from"": ""2024-03-12T14:00:00"", ""to"": ""2024-03-12T15:00:00""},
                            {""from"": ""2024-03-17T16:30:00"", ""to"": ""2024-03-17T17:30:00""},
                            {""from"": ""2024-03-22T09:30:00"", ""to"": ""2024-03-22T10:30:00""}
                          ]
                        },
                        {
                          ""name"": ""Employee 4"",
                          ""meetings"": [
                            {""from"": ""2024-03-02T09:00:00"", ""to"": ""2024-03-02T10:00:00""},
                            {""from"": ""2024-03-08T11:30:00"", ""to"": ""2024-03-08T12:30:00""},
                            {""from"": ""2024-03-13T14:00:00"", ""to"": ""2024-03-13T15:00:00""},
                            {""from"": ""2024-03-18T16:30:00"", ""to"": ""2024-03-18T17:30:00""},
                            {""from"": ""2024-03-23T09:30:00"", ""to"": ""2024-03-23T10:30:00""}
                          ]
                        }
                      ]
                    }
                  ]
                }";

            // Deserialize JSON
            var data = JsonConvert.DeserializeObject<RootObject>(json);

            PrintDataBeforeMeetings(data);

            Console.WriteLine("\n\n-----------------------------------------\n\n");

            // Schedule meetings
            ScheduleMeetings(data);

            // Print scheduled meetings
            PrintDataAfterMeetings(data);

            //Console.ReadLine();
        }

        //Print data before the meetings
        public static void PrintDataBeforeMeetings(RootObject data)
        {
            // Print scheduled meetings
            Console.WriteLine("Scheduled Meetings:");
            foreach (var user in data.Users)
            {
                Console.WriteLine($"Name: {user.Name}, Type: {user.Type}");
                foreach (var meeting in user.Meetings)
                {
                    Console.WriteLine($"\tFrom: {meeting.From}, To: {meeting.To}");
                }

                // Print employees if the user is a Manager
                if (user.Type == "Manager" && user.Employees != null)
                {
                    Console.WriteLine("\tEmployees:");
                    foreach (var employee in user.Employees)
                    {
                        Console.WriteLine($"\t\tEmployee: {employee.Name}");
                        foreach (var meeting in employee.Meetings)
                        {
                            Console.WriteLine($"\t\t\tFrom: {meeting.From}, To: {meeting.To}");
                        }
                    }
                }
            }

            //Console.ReadLine();
        }

        public static void ScheduleMeetings(RootObject data)
        {
            // Iterate through each manager
            foreach (var manager in data.Users.Where(u => u.Type == "Manager"))
            {
                // Iterate through each employee of the manager
                foreach (var employee in manager.Employees)
                {
                    // Find the best time slot for the meeting
                    var bestTime = FindBestMeetingTime(data.Users.First(u => u.Type == "CEO"), manager, employee);

                    bestTime.Title = @$"Meeting between {data.Users.Where(u => u.Type == "CEO").FirstOrDefault().Name} , {manager.Name}, {employee.Name}";

                    // Add the meeting to manager's, employee's, and CEO's meetings
                    manager.Meetings.Add(bestTime);
                    employee.Meetings.Add(bestTime);
                    data.Users.First(u => u.Type == "CEO").Meetings.Add(bestTime);
                }
            }
        }

        // Find the best time slot for a meeting involving the CEO, manager, and employee
        public static Meeting FindBestMeetingTime(User ceo, User manager, Employee employee)
        {
            var ceoMeetings = ceo.Meetings ?? new List<Meeting>();
            var managerMeetings = manager.Meetings ?? new List<Meeting>();
            var employeeMeetings = employee != null ? employee.Meetings ?? new List<Meeting>() : new List<Meeting>();

            // Combine all meetings: CEO's, manager's, and employee's
            var allMeetings = ceoMeetings.Concat(managerMeetings).Concat(employeeMeetings).OrderBy(m => m.From).ToList();

            DateTime currentDate = DateTime.Now.Date.AddDays(1); // Get the day after today without time
            DateTime meetingStartTime = currentDate.Date.AddHours(9); // Start the meeting at 9 AM
            DateTime meetingEndTime = meetingStartTime.AddHours(1); // End the meeting after 1 hour

            // Find the first available time slot in the current month without overlapping with existing meetings
            while (meetingStartTime.Month == currentDate.Month && meetingStartTime.Hour < 18)
            {
                // Check if the meeting time does not overlap with existing meetings
                if (!allMeetings.Any(m => meetingStartTime < m.To && meetingEndTime > m.From))
                {
                    // Found a suitable time slot, break the loop
                    break;
                }

                // Move to the next hour
                meetingStartTime = meetingStartTime.AddHours(1);
                meetingEndTime = meetingStartTime.AddHours(1);

                // If the meeting starts after 18:00, move to the next day
                if (meetingStartTime.Hour >= 18)
                {
                    currentDate = currentDate.AddDays(1);
                    meetingStartTime = currentDate.Date.AddHours(9);
                    meetingEndTime = meetingStartTime.AddHours(1);
                }
            }

            return new Meeting { From = meetingStartTime, To = meetingEndTime };
        }

        // Print data after the meetings are scheduled
        public static void PrintDataAfterMeetings(RootObject data)
        {
            // Print scheduled meetings
            Console.WriteLine("Scheduled Meetings AFTER 1o1:");
            foreach (var user in data.Users)
            {
                Console.WriteLine($"Name: {user.Name}, Type: {user.Type}");
                foreach (var meeting in user.Meetings)
                {
                    Console.WriteLine($"\tFrom: {meeting.From}, To: {meeting.To} , {meeting.Title}");
                }

                // Print employees if the user is a Manager
                if (user.Type == "Manager" && user.Employees != null)
                {
                    Console.WriteLine("\tEmployees:");
                    foreach (var employee in user.Employees)
                    {
                        Console.WriteLine($"\t\tEmployee: {employee.Name}");
                        foreach (var meeting in employee.Meetings)
                        {
                            Console.WriteLine($"\t\t\tFrom: {meeting.From}, To: {meeting.To} , {meeting.Title}");
                        }
                    }
                }
            }
        }
    }
}

public class User
{
    public string Type { get; set; }
    public string Name { get; set; }
    public List<Meeting> Meetings { get; set; }
    public List<Employee> Employees { get; set; } // Add Employees property
}

public class Meeting
{
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public string? Title { get; set; }
}

public class Employee
{
    public string Name { get; set; }
    public List<Meeting> Meetings { get; set; }
}

public class RootObject
{
    public List<User> Users { get; set; }
}