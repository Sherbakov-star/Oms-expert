using System;
using System.ComponentModel;
using Npoi.Mapper.Attributes;


namespace Mee
{
    public class F014
    {
      
        [Browsable(false)]
        public Guid Id { get; set; }

        [Browsable(false)]
        public int Code { get; set; }

        public string Caption { get; set; }

        public string Osn { get; set; }

        [Browsable(false)]
        public string Komment { get; set; }

        public DateTime DateBeg { get; set; }

        public DateTime DateEnd { get; set; }

        [Browsable(false)]
        public int? KodPG { get; set; }

        [Browsable(false)]
        public int? IDVID { get; set; }
    }
}
