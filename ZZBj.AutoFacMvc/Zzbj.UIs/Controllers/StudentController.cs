﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zzbj.IRepository;

namespace Zzbj.UIs.Controllers
{
    public class StudentController : Controller
    {
        readonly IStudentRepository repository;
        //构造器注入
        public StudentController(IStudentRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll();
            return View(data);
        }
    }
}