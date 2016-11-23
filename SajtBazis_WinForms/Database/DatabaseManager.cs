﻿using SajtBazis_WinForms.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace SajtBazis_WinForms.Database
{
    static class DatabaseManager
    {
        static SqlConnection connection = new SqlConnection();
        static SqlCommand command = new SqlCommand();
        static SqlCommand command2 = new SqlCommand();
        static List<Users> user = new List<Users>();
        static List<Products> product = new List<Products>();
        static List<Products> searchproduct = new List<Products>();
        //static int userid = 0;
        static string productsql = "SELECT * FROM [Products] WHERE";

        //még kell
        static string usersql = "SELECT * FROM [Users] WHERE";

        #region CONNECTION
        public static void ConnectionOpen(string connStr)
        {
            try
            {
                connection.ConnectionString = connStr;
                connection.Open();
                //command.Connection = connection;
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
                LoggedUser.loggedUserId = (int)command2.ExecuteScalar();

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

        //public static List<Products> SearchProducts(int searchpieces)
        //{
        //    for (int i = searchproduct.Count - 1; i >= 0; i--)
        //    {
        //        searchproduct.RemoveAt(i);
        //    }

        //    var query = from prod in product
        //                where prod.Pieces == 24
        //                select product;

        //    foreach (var item in query)
        //    {
        //        searchproduct.Add(item);
        //    }
        //    return searchproduct;
        //}

        //public static List<Products> SearchProducts(int searchpieces)
        //{
        //    //Empty list
        //    for (int i = searchproduct.Count - 1; i >= 0; i--)
        //    {
        //        searchproduct.RemoveAt(i);
        //    }

        //    var query = product.Where(x => x.Pieces == searchpieces);
        //    foreach (var item in query)
        //    {
        //        searchproduct.Add(item);
        //    }
        //    return searchproduct;
        //}

        public static string CreateProductSearchSql(int searchpartnumber, string searchdescription)
        {
            if (searchpartnumber > 0 && searchdescription != string.Empty)
            {
                productsql += " part_number = @PARTNUMBER AND description = @DESCRIPTION";
            }
            else if (searchpartnumber > 0)
            {
                productsql += " part_number = @PARTNUMBER";
            }
            else if (searchdescription != string.Empty)
            {
                productsql += " description = @DESCRIPTION";
            }
            else
            {
                productsql = null;
            }

            return productsql;
        }
        public static List<Products> SearchProduct(int searchpartnumber, string searchdescription)//, int searchbrand, int searchcategory, int searchmarket, int searchfactory, int searchtype, int searchbarcode)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = productsql;
                //command.CommandText = "SELECT * FROM [Users] WHERE part_number = @PARTNUMBER OR description = @DESCRIPTION OR brand = @BRAND OR category = @CATEGORY OR market = @MARKET OR factory = @FACTORY OR type = @TYPE OR bar_code = @BARCODE";
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

                //SqlParameter querybrand = new SqlParameter
                //{
                //    ParameterName = "@BRAND",
                //    SqlDbType = SqlDbType.Int,
                //    Direction = ParameterDirection.Input,
                //    Value = searchbrand
                //};

                //SqlParameter querycategory = new SqlParameter
                //{
                //    ParameterName = "@CATEGORY",
                //    SqlDbType = SqlDbType.Int,
                //    Direction = ParameterDirection.Input,
                //    Value = searchcategory
                //};

                //SqlParameter querymarket = new SqlParameter
                //{
                //    ParameterName = "@MARKET",
                //    SqlDbType = SqlDbType.Int,
                //    Direction = ParameterDirection.Input,
                //    Value = searchmarket
                //};

                //SqlParameter queryfactory = new SqlParameter
                //{
                //    ParameterName = "@FACTORY",
                //    SqlDbType = SqlDbType.Int,
                //    Direction = ParameterDirection.Input,
                //    Value = searchfactory
                //};

                //SqlParameter querytype = new SqlParameter
                //{
                //    ParameterName = "@TYPE",
                //    SqlDbType = SqlDbType.Int,
                //    Direction = ParameterDirection.Input,
                //    Value = searchtype
                //};

                //SqlParameter querybarcode = new SqlParameter
                //{
                //    ParameterName = "@BARCODE",
                //    SqlDbType = SqlDbType.Int,
                //    Direction = ParameterDirection.Input,
                //    Value = searchbarcode
                //};

                command.Parameters.Add(querypartnumber);
                command.Parameters.Add(querydescription);
                //command.Parameters.Add(querybrand);
                //command.Parameters.Add(querycategory);
                //command.Parameters.Add(querymarket);
                //command.Parameters.Add(queryfactory);
                //command.Parameters.Add(querytype);
                //command.Parameters.Add(querybarcode);

                //Empty list
                for (int i = product.Count - 1; i >= 0; i--)
                {
                    product.RemoveAt(i);
                }
                //Reading data
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
                }
                reader.Close();
                command.Parameters.Clear();
                productsql = "SELECT * FROM [Products] WHERE";
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
                    product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
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
                command.CommandText = String.Format("INSERT INTO [Products] VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", fresh.PartNumber, fresh.Description, fresh.Brand, fresh.Market, fresh.Factory, fresh.Type, fresh.BarCode, fresh.Width, fresh.Height, fresh.Length, fresh.Pieces, fresh.Temperature);
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
                command.CommandText = String.Format("UPDATE [Products] SET [part_number] = '{0}', [description] = '{1}', [brand] = '{2}', [market] = '{3}', [factory] = '{4}', [type] = '{5}', [bar_code] = '{6}', [width] = '{7}', [heigth] = '{8}', [length] = '{9}', [pieces] = '{10}', [temperature] = '{11}'", modify.PartNumber, modify.Description, modify.Brand, modify.Market, modify.Factory, modify.Type, modify.BarCode, modify.Width, modify.Height, modify.Length, modify.Pieces, modify.Temperature);
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
        //még kell
        public static string CreateUserSearchSql(string searchuser, int searchpermission)
        {
            if (searchuser != string.Empty && searchpermission > 0)
            {
                usersql += " username = @USER AND permission = @PERMISSION";
            }
            else if (searchuser != string.Empty)
            {
                usersql += " username = @USER";
            }
            else if (searchpermission > 0)
            {
                usersql += " permission = @PERMISSION";
            }
            else
            {
                usersql = null;
            }
            return usersql;
        }
        public static List<Users> SearchUser(string searchusername, List<int> searchpermission)
        {
            if (searchusername != string.Empty && searchpermission.Count > 0)
            {
                try
                {
                    command.Connection = connection;
                    string sql = "SELECT * FROM [Users] WHERE username = @USERNAME AND permission IN ({0})";
                    List<string> idParameterList = new List<string>();
                    var index = 0;
                    foreach (var id in searchpermission)
                    {
                        var paramName = "@PERMISSION" + index;
                        command.Parameters.AddWithValue(paramName, id);
                        idParameterList.Add(paramName);
                        index++;
                    }

                    SqlParameter queryusername = new SqlParameter
                    {
                        ParameterName = "@USERNAME",
                        SqlDbType = SqlDbType.VarChar,
                        Direction = ParameterDirection.Input,
                        Value = searchusername
                    };

                    command.Parameters.Add(queryusername);

                    command.CommandText = String.Format(sql, string.Join(",", idParameterList));
                    command.CommandType = CommandType.Text;

                    //Empty list
                    for (int i = user.Count - 1; i >= 0; i--)
                    {
                        user.RemoveAt(i);
                    }

                    //Reading data
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        user.Add(new Users(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), (Permissions)(int)reader["permission"], reader["email"].ToString()));
                    }
                    reader.Close();
                    command.Parameters.Clear();
                    sql = "SELECT * FROM [Users] WHERE username = @USERNAME AND permission IN ({0})";
                    return user;
                }
                catch (Exception ex)
                {
                    throw new DatabaseException("Unable to perform search!", ex.Message);
                }
            }
            else if (searchusername != string.Empty)
            {
                try
                {
                    command.CommandText = "SELECT * FROM [Users] WHERE username = @USERNAME";
                    command.CommandType = CommandType.Text;

                    SqlParameter queryusername = new SqlParameter
                    {
                        ParameterName = "@USERNAME",
                        SqlDbType = SqlDbType.VarChar,
                        Direction = ParameterDirection.Input,
                        Value = searchusername
                    };

                    command.Parameters.Add(queryusername);

                    //Empty list
                    for (int i = user.Count - 1; i >= 0; i--)
                    {
                        user.RemoveAt(i);
                    }

                    //Reading data
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        user.Add(new Users(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), (Permissions)(int)reader["permission"], reader["email"].ToString()));
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
            else if (searchpermission.Count > 0)
            {
                try
                {
                    command.Connection = connection;
                    string sql = "SELECT * FROM [Users] WHERE permission IN ({0})";
                    List<string> idParameterList = new List<string>();
                    var index = 0;
                    foreach (var id in searchpermission)
                    {
                        var paramName = "@PERMISSION" + index;
                        command.Parameters.AddWithValue(paramName, id);
                        idParameterList.Add(paramName);
                        index++;
                    }

                    command.CommandText = String.Format(sql, string.Join(",", idParameterList));
                    command.CommandType = CommandType.Text;

                    //Empty list
                    for (int i = user.Count - 1; i >= 0; i--)
                    {
                        user.RemoveAt(i);
                    }

                    //Reading data
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        user.Add(new Users(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), (Permissions)(int)reader["permission"], reader["email"].ToString()));
                    }
                    reader.Close();
                    command.Parameters.Clear();
                    sql = "SELECT * FROM [Users] WHERE permission IN ({0})";
                    return user;
                }
                catch (Exception ex)
                {
                    throw new DatabaseException("Unable to perform search!", ex.Message);
                }
            }
            else
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

                    //Reading data
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        user.Add(new Users(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), (Permissions)(int)reader["permission"], reader["email"].ToString()));
                    }
                    reader.Close();
                    return user;
                }
                catch (Exception ex)
                {
                    throw new DatabaseException("Unable to retrieve all database information!", ex.Message);
                }
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

                //Reading data
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.Add(new Users(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), (Permissions)(int)reader["permission"], reader["email"].ToString()));
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
                command.CommandText = String.Format("INSERT INTO [Users] ([username], [password], [name], [permission], [email]) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", fresh.Username, fresh.Password, fresh.Name, fresh.Permission, fresh.Email);
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
                command.CommandText = String.Format("UPDATE [Users] SET [username] = '{0}', [password] = '{1}', [password] = '{2}', [permission] = '{3}', [email] = '{4}'", modify.Username, modify.Password, modify.Name, modify.Permission, modify.Email);
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
                command.CommandText = String.Format("DELETE FROM [Users] WHERE [ID] = '{0}'", delete.Id);
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

