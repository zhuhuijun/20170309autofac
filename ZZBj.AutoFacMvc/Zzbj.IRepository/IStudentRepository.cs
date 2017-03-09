﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zzbj.Models;

namespace Zzbj.IRepository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student Get(int id);
        Student Add(Student item);
        bool Update(Student item);
        bool Delete(int id);
    }
}
