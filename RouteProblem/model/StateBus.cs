﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteProblem.model
{
    class StateBus
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int stdentUP;      
        private List<Student> students;
        internal List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        private int runningTime;
        public int RunningTime
        {
            get { return runningTime; }
            set { runningTime = value; }
        }
        private int distance;

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public int StdentUP
        {
            get
            {
                return stdentUP;
            }

            set
            {
                stdentUP = value;
            }
        }

        public int TimeToBack
        {
            get
            {
                return Timetoback;
            }

            set
            {
                Timetoback = value;
            }
        }

        private int Timetoback;
        public StateBus(int id) {
            this.id = id;
            this.students = new List<Student>();
            this.runningTime = 0;
            this.distance = 0;
            this.Timetoback = 0;

        }
    }
}
