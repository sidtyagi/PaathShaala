using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Post
    {
        private string _title;
        private string _description;
        private DateTime _dateTime;
        private int _vote = 0;

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return _dateTime;
            }

            set
            {
                _dateTime = value;
            }
        }

        public void upvote()
        {
            _vote += 1;
        }

        public void downvote()
        {
            _vote -= 1;
        }

        public int display()
        {
            return _vote;
        }
    }
}
