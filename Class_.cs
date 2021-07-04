using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace project001
{
    class DBconnect
    {
        MySqlConnection conn = new MySqlConnection("datasource = 127.0.0.1; port=3306;username=root;password=;database=project01;");

        public MySqlConnection getconnection
        {
            get
            {
                return conn;
            }
        }
        public void openConnect()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConnect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
    class Class_order
    {
        DBconnect conn = new DBconnect();

        ///ลบรายการสินค้าในตะกร้า
        public bool deleterorder(int id)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `order` WHERE `id` =@roomID", conn.getconnection);

            cmd.Parameters.Add("@roomID", MySqlDbType.Int32).Value = id;
            


            conn.openConnect();
            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.CloseConnect();
                return true;
            }
            else
            {
                conn.CloseConnect();
                return false;
            }
        }
        
        public DataTable getorder()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `order`", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
    class Class_stockproduct
    {
        DBconnect conn = new DBconnect();

        ///เพิ่มข้อมูลในคลัง
        public bool insertstockproduct(string type, string name, string characteristics, string amount, string price, byte[] img)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `stockproduct`(`type`, `name`, `characteristic`, `amount`, `price`, `photo`) VALUES (@ty,@na,@ch,@am,@pr,@img)", conn.getconnection);

            //@ty,@na,@ch,@am,@pr,@img
            cmd.Parameters.Add("@ty", MySqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@na", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@ch", MySqlDbType.VarChar).Value = characteristics;
            cmd.Parameters.Add("@am", MySqlDbType.VarChar).Value = amount;
            cmd.Parameters.Add("@pr", MySqlDbType.VarChar).Value = price;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            conn.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.CloseConnect();
                return true;
            }
            else
            {
                conn.CloseConnect();
                return false;
            }
        }
        public DataTable getstockproduct()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `stockproduct`", conn.getconnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public bool updatestockproduct(string id, string type, string name, string characteristics, string amount, string price, byte[] img)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `stockproduct` SET `type`=@ty,`name`=@na,`characteristic`=@ch,`amount`=@am,`price`=@pr,`photo`=@img WHERE `id`=@stockproductID", conn.getconnection);

            cmd.Parameters.Add("@stockproductID", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@ty", MySqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@na", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@ch", MySqlDbType.VarChar).Value = characteristics;
            cmd.Parameters.Add("@am", MySqlDbType.VarChar).Value = amount;
            cmd.Parameters.Add("@pr", MySqlDbType.VarChar).Value = price;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;


            conn.openConnect();
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.CloseConnect();
                return true;
            }
            else
            {
                conn.CloseConnect();
                return false;
            }

        }

        public bool deletestockproduct(int id)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `stockproduct` WHERE `id` =@stockproductID", conn.getconnection);

            cmd.Parameters.Add("@stockproductID", MySqlDbType.Int32).Value = id;

            conn.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.CloseConnect();
                return true;
            }
            else
            {
                conn.CloseConnect();
                return false;
            }
        }
    }

    
    class Class_roomToOrder
    {
        DBconnect conn = new DBconnect();
        public bool roomToOrder(string id, string type, string name, string characteristics, string amount, string price, string sum, byte[] img)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `order`(`id`,`type`, `name`, `characteristic`, `amount`, `price`, `sum`, `photo`) VALUES (@ID,@ty,@na,@ch,@am,@pr,@sm,@img)", conn.getconnection);

            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ty", MySqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@na", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@ch", MySqlDbType.VarChar).Value = characteristics;
            cmd.Parameters.Add("@am", MySqlDbType.VarChar).Value = amount;
            cmd.Parameters.Add("@pr", MySqlDbType.VarChar).Value = price;

            cmd.Parameters.AddWithValue("@sm", Convert.ToInt32(amount) * Convert.ToInt32(price));

            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            conn.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.CloseConnect();
                return true;
            }
            else
            {
                conn.CloseConnect();
                return false;
            }

        }
        public DataTable getroomToOrder()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `stockproduct`", conn.getconnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

    }

    class Class_login
    {
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project01;");

        public MySqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        
    }

    

    class USER
    {
        Class_login login = new Class_login();

        public bool usernameExists(string username)
        {
            string quper = "SELECT * FROM `user` WHERE `username` =@un";

            MySqlCommand cmd = new MySqlCommand(quper, login.getConnection);

            cmd.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool inseruser(string fname, string lname, string username, string password, string address, string phone)
        {
            DBconnect conn = new DBconnect();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `user`(`fname`, `lname`, `username`, `pass`, `address`, `phone`) VALUES (@fn,@ln,@un,@pass,@ad,@ph)", login.getConnection);

            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;

            login.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                login.CloseConnection();
                return true;
            }
            else
            {
                login.CloseConnection();
                return false;
            }
            
        }
    }
    class Class_pay
    { 
        DBconnect conn = new DBconnect();
        
        public bool insertpay(string username, string fname, string lname, string address, string phone, string day, string  sum, byte[] img, string time)
        {
           
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `pay` (`username`, `fname`, `lname`, `address`, `phone`, `day`, `sum`, `photo`, `time`) VALUES (@un,@fn,@ln,@ad,@ph,@dy,@su,@img,@tm)", conn.getconnection);

            //@un,@fn,@ln,@ad,@ph,@dy,@su,@img
            cmd.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@dy", MySqlDbType.VarChar).Value = day;
            cmd.Parameters.Add("@su", MySqlDbType.VarChar).Value = sum;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
            cmd.Parameters.Add("@tm", MySqlDbType.VarChar).Value = time;

            conn.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.CloseConnect();
                return true;
            }
            else
            {
                conn.CloseConnect();
                return false;
            }

        }
        public DataTable getpay()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `pay`", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }

    class Class_history
    {
        DBconnect conn = new DBconnect();
        public bool inserthistoryr(string id ,string username, string type,string name, string price, string amount, string sum,byte[] img, string day)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `history` (`id`,`username`,`type`,`name`, `price`,`amount`,`sum`, `photo`, `day`) VALUES(@ID,@un,@ty, @pn, @pr,@am,@sm, @img, @dy)", conn.getconnection);
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@ty", MySqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@pr", MySqlDbType.VarChar).Value = price;
            cmd.Parameters.Add("@am", MySqlDbType.VarChar).Value = amount;
            cmd.Parameters.AddWithValue("@sm", Convert.ToInt32(amount) * Convert.ToInt32(price));
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
            cmd.Parameters.Add("@dy", MySqlDbType.VarChar).Value = day;

            conn.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.CloseConnect();
                return true;
            }
            else
            {
                conn.CloseConnect();
                return false;
            }
        }
        public bool deletehistory(int id)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `history` WHERE `id` =@roomID", conn.getconnection);

            cmd.Parameters.Add("@roomID", MySqlDbType.Int32).Value = id;


            conn.openConnect();
            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.CloseConnect();
                return true;
            }
            else
            {
                conn.CloseConnect();
                return false;
            }
        }
        public DataTable gethistory()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `history`", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }


}
