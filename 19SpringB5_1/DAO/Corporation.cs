using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace _19SpringB5_1.DAO
{
    class Corporation
    {
        private int no;
        private string name;
        private string street;
        private DateTime dob;
        private string region;

        public Corporation(int no, string name, string street, DateTime dob, string region)
        {
            this.No = no;
            this.Name = name;
            this.Street = street;
            this.Dob = dob;
            this.Region = region;
        }

        public int No { get => no; set => no = value; }
        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Region { get => region; set => region = value; }

        public static List<Corporation> GetAllemployee()
        {
            List<Corporation> co = new List<Corporation>();
            DataTable dataTable = Database.GetDataBySQL("select corp_no, corp_name,corporation.street ,expr_dt, region_name from corporation, region " +
                "where corporation.region_no = region.region_no");
            foreach (DataRow dr in dataTable.Rows)
            {
                int no = Convert.ToInt32(dr["corp_no"]);
                string name = dr["corp_name"].ToString();
                string street = dr["street"].ToString();
                DateTime dob = Convert.ToDateTime(dr["expr_dt"]);
                string report = dr["region_name"].ToString();
                Corporation c = new Corporation(no, name,street ,dob, report);
                co.Add(c);
            }
            return co;
        }
    }
}
