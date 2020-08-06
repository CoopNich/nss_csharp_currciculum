using System;
using System.Collections.Generic;

namespace dict_englishIdioms
{
    class Program
    {
        public static void Main(string[] args)
        {
        //     Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
        //         idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
        //         idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
        //         idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
        //         idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
        //         idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
        //         idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
        //         idioms.Add("Grain", new List<string> { "Take","what","someone","says","with","a","grain","of","salt" });
        //         idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
        //         idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
        //         idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

        //                foreach (KeyValuePair<string, List<string>> idiom in idioms) {
        //                     string phrase = "";
        //                     idiom.Value.ForEach(word => phrase += $" {word}");
        //                     Console.WriteLine($"{idiom.Key}: {phrase}");
        // }

                    List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>>();
            
            vehicles.Add(new Dictionary<string, Dictionary<string, string>>() {
                {"vehicle", new Dictionary<string, string> () {
                    {"year", "2008"},
                    {"model", "Damfresh"},
                    {"make", "Biotraxquote"},
                    {"color", "sky magenta"}
                }},
                {"salesAgent", new Dictionary<string, string> () {
                    {"mobile", "(896) 478-6975"},
                    {"lastName", "Botsford"},
                    {"firstName", "Shaina"}
                }},
                {"credit", new Dictionary<string, string> () {
                    {"creditProvider", "J.P.Morgan Chase & Co"},
                    {"account", "601109582720302"}
                }}
            });
            
            vehicles.Add(new Dictionary<string, Dictionary<string, string>>() {
                {"vehicle", new Dictionary<string, string> () {
                    {"year", "2010"},
                    {"model", "Hotquadtrax"},
                    {"make", "Transtintechno"},
                    {"color", "robin egg blue"}
                }},
                {"salesAgent", new Dictionary<string, string> () {
                    {"mobile", "562.300.2912"},
                    {"lastName", "Davis"},
                    {"firstName", "Gerardo"}
                }},
                {"credit", new Dictionary<string, string> () {
                    {"creditProvider", "PNC Financial Services"},
                    {"account", "34578280562836 "}
                }}
            });

            for (int i=0; i<vehicles.Count; i++) {
                int vehicleCount = i + 1;
                Console.WriteLine("-----");
                Console.WriteLine($"VEHICLE {vehicleCount}");
                Console.WriteLine("-----");
                foreach (KeyValuePair<string, Dictionary<string, string>> infoCategory in vehicles[i]) {
                    Console.WriteLine($"{infoCategory.Key.ToUpper()} INFO");
                    foreach (KeyValuePair<string, string> data in infoCategory.Value) {
                        Console.WriteLine($"{data.Key}: {data.Value}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    }
