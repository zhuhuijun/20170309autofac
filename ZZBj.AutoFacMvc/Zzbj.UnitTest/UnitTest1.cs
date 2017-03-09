using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autofac;
using Zzbj.Dal;
using Zzbj.IDal;

namespace Zzbj.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DBManager>();
            builder.RegisterType<SqlDAL>().As<IDAL>();
            using (var container=builder.Build())
            {
                var manager = container.Resolve<DBManager>();
                manager.Add("INSERT INTO PERSONS VALUES ();");
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DBManager>();
            builder.RegisterType<SqlDAL>().Named<IDAL>("SQL");
            builder.RegisterType<OracleDAL>().Named<IDAL>("ORACLE");
            using (var container = builder.Build())
            {
                SqlDAL sqlDAL = (SqlDAL)container.ResolveNamed<IDAL>("SQL");
                OracleDAL oracleDAL = (OracleDAL)container.ResolveNamed<IDAL>("ORACLE");
            }
        }




        [TestMethod]
        public void TestMethod3()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DBManager>();
            builder.RegisterType<SqlDAL>().Named<IDAL>("SQL");
            builder.RegisterType<OracleDAL>().Named<IDAL>("ORACLE");
            using (var container = builder.Build())
            {
                SqlDAL sqlDAL = (SqlDAL)container.ResolveNamed<IDAL>("SQL");
                OracleDAL oracleDAL = (OracleDAL)container.ResolveNamed<IDAL>("ORACLE");
            }
        }
    }
}
