﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zzbj.IDal;

namespace Zzbj.Dal
{
    public class DBManager
    {
        IDAL _dal;
        public DBManager(IDAL dal)
        {
            _dal = dal;
        }
        public void Add(string commandText)
        {
            _dal.Insert(commandText);
        }
    }
}
