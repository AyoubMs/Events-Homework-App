using System;
using System.Collections.Generic;

namespace EventsHomework
{
    public class PersonModel
    {
        public event EventHandler<string> FullFriends;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MaxFriends { get; set; }
        private List<PersonModel> Friends = new List<PersonModel>();

        public PersonModel(string firstName, string lastName, int maxFriends = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            MaxFriends = maxFriends;
        }

        public string AddFriend(PersonModel friend)
        {
            string output = "";

            if (Friends.Count < MaxFriends)
            {
                Friends.Add(friend);
                output = $"{friend.FirstName} {friend.LastName} was added to the friends list.";
                if (Friends.Count == MaxFriends)
                {
                    FullFriends?.Invoke(this, $"{FirstName} doesn't need more friends.");
                }
            }
            else
            {
                output = $"no more friends.";
            }
            return output;
        }
    }
}
