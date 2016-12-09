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
        static SqlCommand commandAuth = new SqlCommand();
        static List<Users> user = new List<Users>();

        static List<Products> product = new List<Products>();
        static List<Products> searchproduct = new List<Products>();

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
        public static int Login(string usern, string passw)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "LOGINSCRIPT";
                command.CommandType = CommandType.StoredProcedure;

                commandAuth.Connection = connection;
                commandAuth.CommandText = "PERMISSIONSCRIPT";
                commandAuth.CommandType = CommandType.StoredProcedure;

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
                commandAuth.Parameters.Add(loginName2);

                int result = (int)command.ExecuteScalar();
                LoggedUser.loggedUserId = (int)commandAuth.ExecuteScalar();

                return result;

                //if (result > 0)
                //{
                //    MainSearch mainwindow = new MainSearch();
                //    mainwindow.ShowDialog();
                //}
                //else
                //{
                //    command.Parameters.Clear();
                //    throw new Exception("Please check your username and password!");
                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region PRODUCT

        #region Select

        public static List<Products> SelectAllProduct()
        {
            try
            {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Products]";
                command.CommandType = CommandType.Text;

                for (int i = product.Count - 1; i >= 0; i--)
                {
                    product.RemoveAt(i);
                }

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

        public static List<Products> SearchProductByDetails(string searchDescription, int searchPartNumber, int searchBarCode)
        {
            if (searchDescription != string.Empty && searchPartNumber > 0 && searchBarCode > 0)
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM [Products] WHERE description = @DESCRIPTION AND part_number = @PARTNUMBER AND bar_code = @BARCODE";
                    command.CommandType = CommandType.Text;

                    SqlParameter queryDescription = new SqlParameter
                    {
                        ParameterName = "@DESCRIPTION",
                        SqlDbType = SqlDbType.VarChar,
                        Direction = ParameterDirection.Input,
                        Value = searchDescription
                    };

                    SqlParameter queryPartNumber = new SqlParameter
                    {
                        ParameterName = "@PARTNUMBER",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = searchPartNumber
                    };

                    SqlParameter queryBarCode = new SqlParameter
                    {
                        ParameterName = "@BARCODE",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = searchBarCode
                    };

                    command.Parameters.Add(queryDescription);
                    command.Parameters.Add(queryPartNumber);
                    command.Parameters.Add(queryBarCode);

                    for (int i = product.Count - 1; i >= 0; i--)
                    {
                        product.RemoveAt(i);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
                    }
                    reader.Close();
                    command.Parameters.Clear();
                    return product;
                }
                catch (Exception ex)
                {
                    throw new DatabaseException("Unable to retrieve all database information!", ex.Message);
                }
            }
            else if (searchDescription != string.Empty && searchPartNumber > 0)
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM [Products] WHERE part_number = @PARTNUMBER AND description = @DESCRIPTION";
                    command.CommandType = CommandType.Text;

                    SqlParameter queryDescription = new SqlParameter
                    {
                        ParameterName = "@DESCRIPTION",
                        SqlDbType = SqlDbType.VarChar,
                        Direction = ParameterDirection.Input,
                        Value = searchDescription
                    };

                    SqlParameter queryPartNumber = new SqlParameter
                    {
                        ParameterName = "@PARTNUMBER",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = searchPartNumber
                    };

                    command.Parameters.Add(queryDescription);
                    command.Parameters.Add(queryPartNumber);

                    for (int i = product.Count - 1; i >= 0; i--)
                    {
                        product.RemoveAt(i);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
                    }
                    reader.Close();
                    command.Parameters.Clear();
                    return product;
                }
                catch (Exception ex)
                {
                    throw new DatabaseException("Unable to retrieve all database information!", ex.Message);
                }
            }
            else if (searchDescription != string.Empty && searchBarCode > 0)
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM [Products] WHERE description = @DESCRIPTION AND bar_code = @BARCODE";
                    command.CommandType = CommandType.Text;

                    SqlParameter queryDescription = new SqlParameter
                    {
                        ParameterName = "@DESCRIPTION",
                        SqlDbType = SqlDbType.VarChar,
                        Direction = ParameterDirection.Input,
                        Value = searchDescription
                    };

                    SqlParameter queryBarCode = new SqlParameter
                    {
                        ParameterName = "@BARCODE",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = searchBarCode
                    };

                    command.Parameters.Add(queryDescription);
                    command.Parameters.Add(queryBarCode);

                    for (int i = product.Count - 1; i >= 0; i--)
                    {
                        product.RemoveAt(i);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
                    }
                    reader.Close();
                    command.Parameters.Clear();
                    return product;
                }
                catch (Exception ex)
                {
                    throw new DatabaseException("Unable to retrieve all database information!", ex.Message);
                }
            }
            else if (searchPartNumber > 0 && searchBarCode > 0)
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM [Products] WHERE part_number = @PARTNUMBER AND bar_code = @BARCODE";
                    command.CommandType = CommandType.Text;

                    SqlParameter queryPartNumber = new SqlParameter
                    {
                        ParameterName = "@PARTNUMBER",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = searchPartNumber
                    };

                    SqlParameter queryBarCode = new SqlParameter
                    {
                        ParameterName = "@BARCODE",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = searchBarCode
                    };

                    command.Parameters.Add(queryPartNumber);
                    command.Parameters.Add(queryBarCode);

                    for (int i = product.Count - 1; i >= 0; i--)
                    {
                        product.RemoveAt(i);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
                    }
                    reader.Close();
                    command.Parameters.Clear();
                    return product;
                }
                catch (Exception ex)
                {
                    throw new DatabaseException("Unable to retrieve all database information!", ex.Message);
                }
            }
            else if (searchDescription != string.Empty)
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM [Products] WHERE description = @DESCRIPTION";
                    command.CommandType = CommandType.Text;

                    SqlParameter queryDescription = new SqlParameter
                    {
                        ParameterName = "@DESCRIPTION",
                        SqlDbType = SqlDbType.VarChar,
                        Direction = ParameterDirection.Input,
                        Value = searchDescription
                    };

                    command.Parameters.Add(queryDescription);

                    for (int i = product.Count - 1; i >= 0; i--)
                    {
                        product.RemoveAt(i);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
                    }
                    reader.Close();
                    command.Parameters.Clear();
                    return product;
                }
                catch (Exception ex)
                {
                    throw new DatabaseException("Unable to retrieve all database information!", ex.Message);
                }
            }
            else if (searchPartNumber > 0)
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM [Products] WHERE part_number = @PARTNUMBER";
                    command.CommandType = CommandType.Text;

                    SqlParameter queryPartNumber = new SqlParameter
                    {
                        ParameterName = "@PARTNUMBER",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = searchPartNumber
                    };

                    command.Parameters.Add(queryPartNumber);

                    for (int i = product.Count - 1; i >= 0; i--)
                    {
                        product.RemoveAt(i);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
                    }
                    reader.Close();
                    command.Parameters.Clear();
                    return product;
                }
                catch (Exception ex)
                {
                    throw new DatabaseException("Unable to retrieve all database information!", ex.Message);
                }
            }
            else if (searchBarCode > 0)
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM [Products] WHERE bar_code = @BARCODE";
                    command.CommandType = CommandType.Text;

                    SqlParameter queryBarCode = new SqlParameter
                    {
                        ParameterName = "@BARCODE",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = searchBarCode
                    };

                    command.Parameters.Add(queryBarCode);

                    for (int i = product.Count - 1; i >= 0; i--)
                    {
                        product.RemoveAt(i);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
                    }
                    reader.Close();
                    command.Parameters.Clear();
                    return product;
                }
                catch (Exception ex)
                {
                    throw new DatabaseException("Unable to retrieve all database information!", ex.Message);
                }
            }
            else
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM [Products]";
                    command.CommandType = CommandType.Text;

                    for (int i = product.Count - 1; i >= 0; i--)
                    {
                        product.RemoveAt(i);
                    }

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
        }

        public static List<Products> SearchProductByList(List<int> searchFactory, List<int> searchType, List<int> searchMarket, List<int> searchBrand)
        {
            if (searchFactory.Count > 0 && searchType.Count > 0 && searchMarket.Count > 0 && searchBrand.Count > 0)
            {
                try
                {
                    command.Connection = connection;
                    string sqlFactory = "SELECT * FROM [Products] WHERE factory IN ({0})";
                    string sqlType = " AND type IN ({0})";
                    string sqlMarket = " AND market IN ({0})";
                    string sqlBrand = " AND brand IN ({0})";

                    List<string> idParameterListFactory = new List<string>();
                    var indexFactory = 0;
                    foreach (var id in searchFactory)
                    {
                        var parameterNameFactory = "@FACTORY" + indexFactory;
                        command.Parameters.AddWithValue(parameterNameFactory, id);
                        idParameterListFactory.Add(parameterNameFactory);
                        indexFactory++;
                    }
                    string sqlParameterFactory = String.Format(sqlFactory, string.Join(",", idParameterListFactory));

                    List<string> idParameterListType = new List<string>();
                    var indexType = 0;
                    foreach (var id in searchType)
                    {
                        var parameterNameType = "@TYPE" + indexType;
                        command.Parameters.AddWithValue(parameterNameType, id);
                        idParameterListType.Add(parameterNameType);
                        indexType++;
                    }
                    string sqlParameterType = String.Format(sqlType, string.Join(",", idParameterListType));

                    List<string> idParameterListMarket = new List<string>();
                    var indexMarket = 0;
                    foreach (var id in searchMarket)
                    {
                        var parameterNameMarket = "@MARKET" + indexMarket;
                        command.Parameters.AddWithValue(parameterNameMarket, id);
                        idParameterListMarket.Add(parameterNameMarket);
                        indexMarket++;
                    }
                    string sqlParameterMarket = String.Format(sqlMarket, string.Join(",", idParameterListMarket));

                    List<string> idParameterListBrand = new List<string>();
                    var indexBrand = 0;
                    foreach (var id in searchBrand)
                    {
                        var parameterNameBrand = "@BRAND" + indexBrand;
                        command.Parameters.AddWithValue(parameterNameBrand, id);
                        idParameterListBrand.Add(parameterNameBrand);
                        indexBrand++;
                    }
                    string sqlParameterBrand = String.Format(sqlBrand, string.Join(",", idParameterListBrand));

                    string sqlParameterAll = sqlParameterFactory + sqlParameterType + sqlParameterMarket + sqlParameterBrand;

                    command.CommandText = sqlParameterAll;
                    command.CommandType = CommandType.Text;

                    for (int i = product.Count - 1; i >= 0; i--)
                    {
                        product.RemoveAt(i);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        product.Add(new Products((int)reader["part_number"], reader["description"].ToString(), (Brands)(int)reader["brand"], (Markets)(int)reader["market"], (Factories)(int)reader["factory"], (Types)(int)reader["type"], (int)reader["bar_code"], (int)reader["width"], (int)reader["heigth"], (int)reader["length"], (int)reader["pieces"], (int)reader["temperature"]));
                    }
                    reader.Close();
                    command.Parameters.Clear();
                    sqlFactory = "SELECT * FROM [Products] WHERE factory IN ({0})";
                    sqlType = " AND type IN ({0})";
                    sqlMarket = " AND market IN ({0})";
                    sqlBrand = " AND brand IN ({0})";
                    return product;
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
                    command.CommandText = "SELECT * FROM [Products]";
                    command.CommandType = CommandType.Text;

                    for (int i = product.Count - 1; i >= 0; i--)
                    {
                        product.RemoveAt(i);
                    }

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
        }

        #endregion

        #region Modify
        public static void ProductNew(Products fresh)
        {
            try
            {
                command.CommandText = String.Format("INSERT INTO [Products] VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", fresh.PartNumber, fresh.Description, (int)(fresh.Brand), (int)(fresh.Market), (int)(fresh.Factory), (int)(fresh.Type), fresh.BarCode, fresh.Width, fresh.Height, fresh.Length, fresh.Pieces, fresh.Temperature);
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
                command.CommandText = String.Format("UPDATE [Products] SET [part_number] = '{0}', [description] = '{1}', [brand] = '{2}', [market] = '{3}', [factory] = '{4}', [type] = '{5}', [bar_code] = '{6}', [width] = '{7}', [heigth] = '{8}', [length] = '{9}', [pieces] = '{10}', [temperature] = '{11}' WHERE [part_number]  = '{0}'", modify.PartNumber, modify.Description, (int)modify.Brand, (int)modify.Market, (int)modify.Factory, (int)modify.Type, modify.BarCode, modify.Width, modify.Height, modify.Length, modify.Pieces, modify.Temperature);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Unable to modify data!", ex.Message);
            }
        }

        public static void ProductDelete(string deleteProduct)
        {
            try
            {
                command.CommandText = String.Format("DELETE FROM [Products] WHERE [part_number] = '{0}'", deleteProduct);
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

        public static List<Users> SearchUser(string searchUserName, List<int> searchPermission)
        {
            if (searchUserName != string.Empty && searchPermission.Count > 0) //username and permission
            {
                try
                {
                    command.Connection = connection;
                    string sqluser = "SELECT * FROM [Users] WHERE username = @USERNAME AND permission IN ({0})";
                    List<string> idParameterList = new List<string>();
                    var index = 0;
                    foreach (var id in searchPermission)
                    {
                        var paramName = "@PERMISSION" + index;
                        command.Parameters.AddWithValue(paramName, id);
                        idParameterList.Add(paramName);
                        index++;
                    }

                    SqlParameter queryUserName = new SqlParameter
                    {
                        ParameterName = "@USERNAME",
                        SqlDbType = SqlDbType.VarChar,
                        Direction = ParameterDirection.Input,
                        Value = searchUserName
                    };

                    command.Parameters.Add(queryUserName);

                    command.CommandText = String.Format(sqluser, string.Join(",", idParameterList));
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
                    sqluser = "SELECT * FROM [Users] WHERE username = @USERNAME AND permission IN ({0})";
                    return user;
                }
                catch (Exception ex)
                {
                    throw new DatabaseException("Unable to perform search!", ex.Message);
                }
            }
            else if (searchUserName != string.Empty) //username only
            {
                try
                {
                    command.CommandText = "SELECT * FROM [Users] WHERE username = @USERNAME";
                    command.CommandType = CommandType.Text;

                    SqlParameter queryUserName = new SqlParameter
                    {
                        ParameterName = "@USERNAME",
                        SqlDbType = SqlDbType.VarChar,
                        Direction = ParameterDirection.Input,
                        Value = searchUserName
                    };

                    command.Parameters.Add(queryUserName);

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
            else if (searchPermission.Count > 0) //permission only
            {
                try
                {
                    command.Connection = connection;
                    string sql = "SELECT * FROM [Users] WHERE permission IN ({0})";
                    List<string> idParameterList = new List<string>();
                    var index = 0;
                    foreach (var id in searchPermission)
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
            else //all users
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

        #endregion

        #region Modify
        public static void UserNew(Users fresh)
        {
            try
            {
                command.CommandText = String.Format("INSERT INTO [Users] VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", fresh.Username, fresh.Password, fresh.Name, (int)(fresh.Permission), fresh.Email);
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
                command.CommandText = String.Format("UPDATE [Users] SET [password] = '{0}', [name] = '{1}', [permission] = '{2}', [email] = '{3}' WHERE [username] = '{4}'", modify.Password, modify.Name, (int)modify.Permission, modify.Email, modify.Username);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Unable to modify data!", ex.Message);
            }
        }

        public static void UserDelete(string deleteuser)
        {
            try
            {
                command.CommandText = String.Format("DELETE FROM [Users] WHERE [username] = '{0}'", deleteuser);
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

