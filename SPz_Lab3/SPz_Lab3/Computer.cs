﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPz_Lab3
{
    class Computer: IComparable<Computer>
    {
        //Computer fields

        private string CName { get; set; }

        public List<Task> CAssignedTasks { get; set; }
        private int CAmountOfAssgndTsks { get; set; }
        private bool CStatus { get; set; }

        public Task AssignedTasks 
        {
            set { CAssignedTasks.Add(value); }
        }



        //Override Equals for comparison in Comuter Class
        public override bool Equals(object c)
        {
            if (c == null || !(c is Computer))
                return false;

            return (((Computer) c).CStatus == this.CStatus &&
                ((Computer)c).CAmountOfAssgndTsks == this.CAmountOfAssgndTsks &&
                ((Computer)c).CAssignedTasks.SequenceEqual(this.CAssignedTasks));
        }

        public override int GetHashCode() => (CName).GetHashCode();
        public static bool operator ==(Computer c1, Computer c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Computer c1, Computer c2)
        {
            return !c1.Equals(c2);
        }

        int IComparable<Computer>.CompareTo(Computer obj)
        {
            if (this.CAmountOfAssgndTsks > obj.CAmountOfAssgndTsks)
                return 1;
            if (this.CAmountOfAssgndTsks < obj.CAmountOfAssgndTsks)
                return -1;
            else
                return 0;
        }

    }
}
