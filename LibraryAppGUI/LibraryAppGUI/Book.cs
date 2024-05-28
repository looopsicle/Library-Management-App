using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppGUI
{
    public class Book : ICloneable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Book DeepClone()
        {
            string json = JsonConvert.SerializeObject(this);
            Book book = JsonConvert.DeserializeObject<Book>(json);
            return book;
        }
    }
}
