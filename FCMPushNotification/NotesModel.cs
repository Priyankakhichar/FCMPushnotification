using System;
using System.Collections.Generic;
using System.Text;

namespace FCMPushNotification
{
    /// <summary>
    /// notes model class
    /// </summary>
    public class NotesModel
    {

        /// <summary>
        /// id
        /// </summary> 
        public int Id
        {
            get;
            set;
        }

       
        public string UserId
        {
            get; set;
        }
        /// <summary>
        /// title
        /// </summary>
        public string Title
        {
            get; set;
        }


        /// <summary>
        /// description
        /// </summary>
        public string Description
        {
            get; set;
        }

        /// <summary>
        /// color
        /// </summary>
        public string Color
        {
            get; set;
        }


       

        public bool IsPin
        {
            get; set;
        }
        public DateTime? Reminder
        {
            get; set;
        }
        public string Image
        {
            get; set;
        }
        /// <summary>
        /// created date
        /// </summary>
        public DateTime? CreateDate
        {
            get; set;
        }

        /// <summary>
        /// modified date
        /// </summary>
        public DateTime? ModifiedDate
        {
            get; set;
        }
    }
}
