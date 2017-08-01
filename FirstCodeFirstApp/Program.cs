using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new Initializer());

            using (var context=new Context())
            {

                context.Database.CreateIfNotExists();  //如果数据库不存在则创建

                #region 创建记录

                //var donators = new List<Donator>
                //{
                //    new Donator
                //    {
                //      Name   = "陈志康",
                //      Amount = 50,
                //      DonateDate = new DateTime(2016, 4, 7)
                //    },
                //    new Donator
                //    {
                //        Name = "海风",
                //        Amount = 5,
                //        DonateDate = new DateTime(2016, 4, 8)
                //    },
                //    new Donator
                //    {
                //        Name = "醉千秋",
                //        Amount = 18.8m,
                //        DonateDate = new DateTime(2016, 4, 15)
                //    }

                //};
                //context.Donator.AddRange(donators);
                //context.SaveChanges();
                #endregion


                #region 2.0 查询记录

                //var donators = context.Donator;
                //Console.WriteLine("Id\t\t姓名\t\t金额\t\t赞助日期");
                //foreach (var donator in donators)
                //{
                //    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", donator.DonatorId, donator.Name, donator.Amount, donator.DonateDate.ToShortDateString());
                //}
                #endregion


                #region 3.0 更新记录

                //var donators = context.Donator;
                //if (donators.Any())
                //{
                //    var toBeUpdatedDonator = donators.First(d => d.Name == "醉千秋");
                //    toBeUpdatedDonator.Name = "醉、千秋";
                //    context.SaveChanges();
                //}

                #endregion

                #region 4.0 删除记录
                //var toBeDeletedDonator = context.Donator.Single(d=>d.Name=="待打赏");
                //if (toBeDeletedDonator!=null)
                //{
                //    context.Donator.Remove(toBeDeletedDonator);
                //    context.SaveChanges();
                //}

                #endregion

                #region 5.0 遍历PayWays表
                var payways = context.PayWays;
                foreach (var payway in payways)
                {
                    Console.WriteLine("Id={0},Name={1}", payway.Id, payway.Name);
                }
                #endregion


            }



            //Console.WriteLine("数据库创建成功");
            Console.WriteLine("数据创建完成s");
            Console.Read();
        }
    }
}
