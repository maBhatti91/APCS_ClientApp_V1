using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APMS_ClientApp.DataSource
{
    public class DummyData
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public string VehicleNumber { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public BindingList<DetailData> DetailData { get; set; }
        public DummyData() { }
        public DummyData(int index, int count)
        {
            Id = index;
            TransactionId = index + 100;
            VehicleNumber = "ISB ";// + index.ToString() + "756";
            CheckInTime = DateTime.Now;
            CheckOutTime = DateTime.Now.AddDays(index - count / 2);
        }

        public static BindingList<DummyData> GetData(int count = 100)
        {
            var data = new BindingList<DummyData>();
            for (int i = 1; i <= count; i++)
                data.Add(new DummyData(i, count));

            return data;
        }
    }
    public class DetailData
    {
        public int FirstLevelChildId { get; set; }
        public int ParentRowId { get; set; }
        public string FirstLevelDetailStringProperties { get; set; }
        public bool Boolean { get; set; }
        public DetailData(int id, int parentId)
        {
            FirstLevelChildId = id;
            ParentRowId = parentId;
            Boolean = id % 2 == 0 ? true : false;
            FirstLevelDetailStringProperties = "Detail row " + id.ToString();
        }
    }
}
