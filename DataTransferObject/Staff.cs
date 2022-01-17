using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataTransferObject
{
    public class Staff
    {
        private int id;
        private string name;
        private DateTime? birth;
        private string sex;
        private string address;
        private string user;
        private string avatarDir;
        private string email;
        private string phone;

        public Staff(DataRow dataRow)
        {
            id = int.Parse(dataRow["ID"].ToString());
            name = dataRow["Name"].ToString();
            birth = (DateTime)dataRow["BIRTH"];
            sex = dataRow["SEX"].ToString();
            address = dataRow["ADDRESS"].ToString();
            user = dataRow["USERNAME"].ToString();
            if (dataRow["AVATAR"].ToString()!="")
            {
                avatarDir = dataRow["AVATAR"].ToString();
            }
            if (dataRow["EMAIL"].ToString() != "")
            {
                avatarDir = dataRow["EMAIL"].ToString();
            }
            phone = dataRow["PHONE"].ToString();

        }

        public Staff(int id, string name, DateTime? birth, string sex, string address, string user, string avatarDir, string email, string phone)
        {
            this.id = id;
            this.name = name;
            this.birth = birth;
            this.sex = sex;
            this.address = address;
            this.user = user;
            this.avatarDir = avatarDir;
            this.email = email;
            this.phone = phone;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime? Birth { get => birth; set => birth = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
        public string User { get => user; set => user = value; }
        public string AvatarDir { get => avatarDir; set => avatarDir = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
