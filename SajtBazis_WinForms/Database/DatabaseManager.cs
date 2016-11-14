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

        #region CONNECTION
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

        
        public static void ConnectionClose()
        {
            try
            {
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Disconecting from database failed!", ex.Message);
            }
        }
        #endregion

        #region LOGIN
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
        #endregion

        #region PRODUCT

        #region Select
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
        #endregion

        #region Modify
        public static void ProductNew(Products fresh)
        {
            try
            {
                command.CommandText = String.Format("INSERT INTO [Products] VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')", fresh.PartNumber, fresh.Description, fresh.Brand, fresh.Category, fresh.Market, fresh.Factory, fresh.Type, fresh.BarCode, fresh.Width, fresh.Height, fresh.Length, fresh.Pieces, fresh.Temperature);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new DatabaseException("Insert new product failed!", ex.Message);
            }
        }

        public static void ProductModify(Products modify)
        {
            try
            {
                command.CommandText = String.Format("UPDATE [Products] SET [part_number] = '{0}', [description] = '{1}', [brand] = '{2}', [category] = '{3}', [market] = '{4}', [factory] = '{5}', [type] = '{6}', [bar_code] = '{7}', [width] = '{8}', [heigth] = '{9}', [length] = '{10}', [pieces] = '{11}', [temperature] = '{12}'", modify.PartNumber, modify.Description, modify.Brand, modify.Category, modify.Market, modify.Factory, modify.Type, modify.BarCode, modify.Width, modify.Height, modify.Length, modify.Pieces, modify.Temperature);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Unable to modify data!", ex.Message);
            }
        }

        public static void ProductDelete(Products delete)
        {
            try
            {
                command.CommandText = String.Format("DELETE FROM [Products] WHERE [part_number] = '{0}'", delete.PartNumber);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new DatabaseException("Deleting selected product failed!", ex.Message);
            }
        }
        #endregion
        #endregion

        #region USER
        #region Select
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
        #endregion

        #region Modify
        public static void UserNew(Users fresh)
        {
            try
            {
                command.CommandText = String.Format("INSERT INTO [Users] VALUES('{0}', '{1}', '{2}', '{3}')", fresh.Username, fresh.Password, fresh.Permission, fresh.Email);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new DatabaseException("Insert new user failed!", ex.Message);
            }
        }
        
        public static void UserModify(Users modify)
        {
            try
            {
                command.CommandText = String.Format("UPDATE [Users] SET [username] = '{0}', [password] = '{1}', [permission] = '{2}', [email] = '{3}'", modify.Username, modify.Password, modify.Permission, modify.Email);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Unable to modify data!", ex.Message);
            }
        }

        public static void UserDelete(Users delete)
        {
            try
            {
                command.CommandText = String.Format("DELETE FROM [Users] WHERE [username] = '{0}'", delete.Username);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new DatabaseException("Deleting selected user failed!", ex.Message);
            }
        }
        #endregion
        #endregion
    }
}

