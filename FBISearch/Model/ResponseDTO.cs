using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBISearch.Model
{
    public class ResponseDTO
    {
        public int total {  get; set; }
        
        public List<Person> Items { get; set; }

       

    }

    public class Person
    {

        public string Title { get; set; }
        public List<PDF> Files { get; set; }
        public string Warning_message { get; set; }
        public List<PersonImage> Images {  get; set; }
        public string Race { get; set; }
        public string Sex { get; set; }
        public string Caution { get; set; }
        
        public string Description { get; set; }


        public string Reward_text { get; set; }
        public string Hair { get; set; }
        public string Eyes { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
   
        public string Publication { get; set; }
        public string Details { get; set; }
        public string Uid { get; set; }
    }

    public class PersonImage
    {
        public string Large { get; set; }
    }
    public class PDF
    {
        public string Url { get; set; }
        public string Name { get; set; }
    }
}
