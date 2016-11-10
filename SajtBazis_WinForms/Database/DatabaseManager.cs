using SajtBazis_WinForms.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace SajtBazis_WinForms.Database
{
    static class DatabaseManager
    {
        static SqlConnection connection = new SqlConnection();
        static SqlCommand command = new SqlCommand();
        static SqlCommand command2 = new SqlCommand();
        static List<Users> user = new List<Users>();
        static List<Products> product = new List<Products>();
        static int userid = 0;

        //Connection Open
        public static void ConnectionOpen(string connStr)
        {
            try
            {
                connection.ConnectionString = connStr;
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Connecting to database failed!", ex.Message);
            }
        }

        //Connection Close
        public static void ConnectionClose()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Disconecting from database failed!", ex.Message);
            }
        }

        //Login
        public static void Login(string usern, string passw)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "LOGINSCRIPT";
                command.CommandType = CommandType.StoredProcedure;

                command2.Connection = connection;
                command2.CommandText = "PERMISSIONSCRIPT";
                command2.CommandType = CommandType.StoredProcedure;

                SqlParameter loginName = new SqlParameter
                {
                    ParameterName = "@USERNAME",
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input,
                    Value = usern
                };

                SqlParameter loginName2 = new SqlParameter
                {
                    ParameterName = "@USERNAME2",
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input,
                    Value = usern
                };

                SqlParameter loginPassword = new SqlParameter
                {
                    ParameterName = "@PASSWORD",
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input,
                    Value = passw
                };

                command.Parameters.Add(loginName);
                command.Parameters.Add(loginPassword);
                command2.Parameters.Add(loginName2);

                int result = (int)command.ExecuteScalar();
                userid = (int)command2.ExecuteScalar();
                if (result > 0)
                {
                    MainSearch mainwindow = new MainSearch();
                    mainwindow.Show();
                }
                else
                {
                    command.Parameters.Clear();
                    throw new Exception("Please check your username and password!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Product
        public static List<Products> SearchProduct(int searchpartnumber, string searchdescription, int searchbrand, int searchcategory, int searchmarket, int searchfactory, int searchtype, int searchbarcode)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Users] WHERE part_number = @PARTNUMBER OR description = @DESCRIPTION OR brand = @BRAND OR category = @CATEGORY OR market = @MARKET OR factory = @FACTORY OR type = @TYPE OR bar_code = @BARCODE";
                command.CommandType = CommandType.Text;

                SqlParameter querypartnumber = new SqlParameter
                {
                    ParameterName = "@PARTNUMBER",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = searchpartnumber
                };

                SqlParameter querydescription = new SqlParameter
                {
                    ParameterName = "@DESCRIPTION",
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input,
                    Value = searchdescription
                };

                SqlParameter querybrand = new SqlParameter
                {
                    ParameterName = "@BRAND",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = searchbrand
                };

                SqlParameter querycategory = new SqlParameter
                {
                    ParameterName = "@CATEGORY",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = searchcategory
                };

                SqlParameter querymarket = new SqlParameter
                {
                    ParameterName = "@MARKET",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = searchmarket
                };

                SqlParameter queryfactory = new SqlParameter
                {
                    ParameterName = "@FACTORY",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = searchfactory
                };

                SqlParameter querytype = new SqlParameter
                {
                    ParameterName = "@TYPE",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = searchtype
                };

                SqlParameter querybarcode = new SqlParameter
                {
                    ParameterName = "@BARCODE",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = searchbarcode
                };

                command.Parameters.Add(querypartnumber);
                command.Parameters.Add(querydescription);
                command.Parameters.Add(querybrand);
                command.Parameters.Add(querycategory);
                command.Parameters.Add(querymarket);
                command.Parameters.Add(queryfactory);
                command.Parameters.Add(querytype);
                command.Parameters.Add(querybarcode);

                //Empty list
                for (int i = product.Count - 1; i >= 0; i--)
                {
                    product.RemoveAt(i);
                }
                //Reading data
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Categories)(int)reader["category"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
                }
                reader.Close();
                command.Parameters.Clear();
                return product;
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Unable to perform search!", ex.Message);
            }

        }
        public static List<Products> SelectAllProduct()
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Products]";
                command.CommandType = CommandType.Text;

                //Empty list
                for (int i = product.Count - 1; i >= 0; i--)
                {
                    product.RemoveAt(i);
                }

                //Reading data
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Categories)(int)reader["category"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
                }
                reader.Close();
                return product;
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Unable to retrieve all database information!", ex.Message);
            }
        }

        //User
        public static List<Users> SearchUserByName(string searchuser)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Users] WHERE username =@USER";
                //command.CommandText = "SELECT * FROM [Users] WHERE username LIKE '%' + @USER + '%'";
                command.CommandType = CommandType.Text;

                SqlParameter queryname = new SqlParameter
                {
                    ParameterName = "@USER",
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input,
                    Value = searchuser
                };

                command.Parameters.Add(queryname);
                //command.Parameters.AddWithValue("@USER", "%" + queryname + "%");                

                //Empty list
                for (int i = user.Count - 1; i >= 0; i--)
                {
                    user.RemoveAt(i);
                }

                //Reading data
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.Add(new Users(reader["username"].ToString(), reader["password"].ToString(), (Permissions)(int)reader["permission"], reader["email"].ToString()));
                }
                reader.Close();
                command.Parameters.Clear();
                return user;
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Unable to perform search!", ex.Message);
            }
        }

        public static List<Users> SearchUserByPermission(int searchpermission)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Users] WHERE permission = @PERMISSION";
                command.CommandType = CommandType.Text;

                SqlParameter querypermission = new SqlParameter
                {
                    ParameterName = "@PERMISSION",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = searchpermission
                };

                command.Parameters.Add(querypermission);

                //Empty list
                for (int i = user.Count - 1; i >= 0; i--)
                {
                    user.RemoveAt(i);
                }

                //Reading data
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.Add(new Users(reader["username"].ToString(), reader["password"].ToString(), (Permissions)(int)reader["permission"], reader["email"].ToString()));
                }
                reader.Close();
                command.Parameters.Clear();
                return user;
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Unable to perform search!", ex.Message);
            }
        }

        
        public static List<Users> SelectAllUser()
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Users]";
                command.CommandType = CommandType.Text;

                //Empty list
                for (int i = user.Count - 1; i >= 0; i--)
                {
                    user.RemoveAt(i);
                }

                //Reading data into list
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.Add(new Users(reader["username"].ToString(), reader["password"].ToString(), (Permissions)(int)reader["permission"], reader["email"].ToString()));
                }
                reader.Close();
                return user;
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Unable to retrieve all database information!", ex.Message);
            }
        }

        public static void Modify(Users modify)
        {
            try
            {
                command.CommandText = string.Format("UPDATE [Users] SET [username] = '{0}', [password] = '{1}', [permission] = '{2}', [email] = '{3}'", modify.Username, modify.Password, modify.Permission, modify.Email);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Unable to modify data!", ex.Message);
            }
        }

    }
}

