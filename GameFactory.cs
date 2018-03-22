using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace GameLibrary
{
    public class GameFactory
    {
        //Define objects for game list, stream writer, xml serializer, and a string containing filepath
        List<Game> gameList; //list object for games
        StreamWriter sw; //stream writer to enable writing to a file
        XmlSerializer serial; //xmlserializer to enable serialization and deserialization of XML type files
        const string FilePath = @"..\..\games.xml"; //string to hold the filepath of XML file
        
        //Method to create and populate a list of games
        public void CreateGameList()
        {
            gameList = new List<Game>(); //instantiate new list object gameList
            Game G = new Game("Heat", "Bulls", 98, 104);
            gameList.Add(G);
            G = new Game("Lakers", "Knicks", 82, 90);
            gameList.Add(G);
            G = new Game("Rockets", "Celtics", 102, 100);
            gameList.Add(G);
            G = new Game("Raptors", "Clippers", 88, 65);
            gameList.Add(G);
            G = new Game("Wizards", "Pistons", 99, 102);
            gameList.Add(G);
            G = new Game("Jazz", "Nuggets", 76, 70);
            gameList.Add(G);
        }

        //Method to serialize gameList to an XML file
        public void SerializeGameList()
        {
            serial = new XmlSerializer(gameList.GetType());
            sw = new StreamWriter(FilePath);
            serial.Serialize(sw, gameList);
            sw.Close();
        }

        //Method to deserialize gameList from an XML file and returns a List<Game> object
        public List<Game> DeserializeGameList(out string resultMessage)
        {
            try
            {
                gameList = new List<Game>();
                StreamReader sr = new StreamReader(FilePath);
                serial = new XmlSerializer(gameList.GetType());
                gameList = (List<Game>)serial.Deserialize(sr);
                sr.Close();
                resultMessage = "Success.";
                return gameList;
            }
            catch( Exception ex )
            {
                resultMessage = "Exception thrown: " + ex.Message;
                return null;
            }
        }
    }
}
