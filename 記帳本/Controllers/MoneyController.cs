using System;
using System.Collections.Generic;
using System.Web.Mvc;
using 記帳本.Models;

namespace 記帳本.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Money()
        {
            return View();
        }

        // 顯示記帳本輸入欄位
        public ActionResult CreateMoneyDetails()
        {
            return PartialView();
        }

        //顯示記帳結果
        public ActionResult ShowMoneyDetails()
        {
            DateTime dt = DateTime.Now;
            var money = new List<Money>() {
                new Money(){Category = "支出", Date = dt.AddDays(1),count = 300,Note = " ",SeqNum = 1},
                new Money(){Category = "支出", Date = dt.AddDays(1),count = 16000,Note = " ",SeqNum = 2},
                new Money(){Category = "支出", Date = dt.AddDays(1),count = 8000,Note = " ",SeqNum = 3}
            };
            return PartialView(money);
        }
    }
}