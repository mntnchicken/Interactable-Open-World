using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWorld
{
    class Being
    {

        //feelings or senses 
        //negative and postive or more???
        // Opinions are formed by other opinions
        // Percieved facts are stored as data
        // Beings -> Environments -> Objects -> Beings <- Environments <- Objects <- Beings
        //Luck/Butterfly Effect and choices leading to different timelines 

        //variables: ID of some sort, and then opinions and knowledge lists. As well as more object bodily needs and interactions between those and opinions/moods 
        //Complex feelings are how negativity and positivity are effected by opinions.  

        public List<Sense> Senses = new List<Sense>()
        {   
            new Sense { Name = "Crabcake" , Value = 50 , Care = 50}
        };

        public String getSenses()
        {
            String Output = "";
            foreach (Sense S in Senses)
            {
                Output += "\n";
                Output += S.Name;
            }
            return Output; 
        }

    }
}
