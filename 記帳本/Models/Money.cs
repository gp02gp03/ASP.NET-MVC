using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace 記帳本.Models
{
    public class Money
    {

        public string Category { get; set; }        //類別

        public DateTime Date { get; set; }        //日期

        public int count { get; set; }                  //金額

        public string Note { get; set; }              //備註

        public int SeqNum { get; set; }             //流水號
    }
}