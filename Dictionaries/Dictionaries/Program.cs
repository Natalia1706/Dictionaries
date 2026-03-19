using System.Xml.XPath;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
            DICTIONARIES --> Are collections of data, stored as Key-Value pairs --> Purpose:
             is to be able to track stuff, eg. Courses and Modules. We delete it to keep memory 
            
            --> provide fast data access based on a unique key

            Dictionary dict<Key>, Value> = new Dictionary<>();

            var dict = new Dictionary <Key, Value> 
           {

            {"Key, "Value"}
           }
           */

           /* Dictionary<string, string> valuePairs = new Dictionary<string, string>();

            // adding values
            valuePairs.Add("Computer Science", "Programming");
            valuePairs.Add("Law", "Criminology");
            valuePairs.Add("Education", "Teaching Practice");

            //add via index
            valuePairs["Engineering"] = "Mathematics";

            //set the value to empty to "delete it"
            valuePairs["Education"] = "";

            // Printing
            foreach (KeyValuePair<string, string> pair in valuePairs)
            {
                Console.WriteLine($"Course: {pair.Key} | Module: {pair.Value}");
            }

            //check if dict contains key
            bool containsKey = valuePairs.ContainsKey("Education");

            if (containsKey)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            // Remove -- to delete keys
            valuePairs.Remove("Education");

            //printing again
            foreach (KeyValuePair<string, string> pair in valuePairs)
            {
                Console.WriteLine($"Course: {pair.Key} | Module: {pair.Value}");
            }

            // returns the number of itemss in the dict
            int items = valuePairs.Count;

            Console.WriteLine(items);

            // clears everything
            valuePairs.Clear();
            items = valuePairs.Count;
            Console.WriteLine(items);*/

            // Creating dictionaries with user input - 18/03/26
            var courses = new Dictionary<string, List<string>>();

            while(true)
            {  // accepting user input
            Console.WriteLine("Enter Programme name or 'stop' to quit: ");
            string key = Console.ReadLine();

                if(key?.ToLower() == "stop")
                {
                    break;
                }

            Console.WriteLine($"Enter modules for {key}");
            string module = Console.ReadLine(); 

            // if dict does not contain key
            if (!courses.ContainsKey(key))
            {
                // the add key to dict as new key with an empty value
                courses[key] = new List<string>();
            }
            courses[key].Add(module);

            foreach (var entry in courses)
            {
                // items of a collection is presented by using string.join for a readable format to break it  in an indivaual string
                Console.WriteLine($"Course: {entry.Key} | Modules: {string.Join(",",entry.Value)}");
            }

          }
        }     
     }
  }
