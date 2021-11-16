using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using LearningMaterials.Model;

namespace LearningMaterials.Utils
{
    class Transition
    {
        public static Frame MainFrame { get; set; }

        private static LearnEntities _context;
        public static LearnEntities Context
        { 
            get
            {
                if (_context == null)
                    _context = new LearnEntities();

                return _context;
            }
        }
    }
}
