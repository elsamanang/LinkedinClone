using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinClone.Models
{
#nullable disable
    public class Post
    {
        public string Id { get; set; }  
        public string UserName { get; set; }
        public string UserFunction { get; set; }
        public string UserProfil { get; set; }
        public int PostLike {  get; set; }
        public int PostLove {  get; set; }
        public int PostClap {  get; set; }
        public int PostSmile {  get; set; }
        public int PostSupport {  get; set; }
        public int PostIdea {  get; set; }
        public string Details { get; set; }
        public string PostPicture { get; set; }
        public DateTime DateCreation { get; set; }
    }
}
