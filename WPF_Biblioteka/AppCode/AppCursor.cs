using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Biblioteka.AppCode
{
    class AppCursor
    {

        static List<Cursor> CCursors;
        private AppCursor()
        {
            string cursorDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Cursor";
            CCursors = new List<Cursor>()
            {
                Cursors.Arrow,
                new Cursor($"{cursorDirectory}\\cursor-fire.cur"),
                new Cursor($"{cursorDirectory}\\cursor.cur"),
                new Cursor($"{cursorDirectory}\\cursor_2.cur"),
                //new Cursor($"{cursorDirectory}\\cursor.cur"),
            };
        }

        private static AppCursor _instance;
        public static AppCursor GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppCursor();
            }
            
            return _instance;
        }

        public static int CCursor;


        public static Cursor GetCursor()
        {
            Cursor cursor = CCursors[CCursor];
            return cursor;
        }
    }
}
