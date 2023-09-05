using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer.Class
{
    public class MysqlController
    {
        MySqlConnection mysql;
        public MysqlController()
        {
            mysql = new MySqlConnection();
        }
        public bool DatabaseConnection(string SERVER, string UID, string PWD, int PORT)
        {
            mysql = new MySqlConnection();
            string v = $"SERVER = '{SERVER}'; UID = '{UID}'; PWD = '{PWD}'; PORT = {PORT};allow user variables = true";
            try
            {
                mysql.ConnectionString = v;
                mysql.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable My_SELECT(string SQuery, string DBNm)
        {
            var da = new MySqlDataAdapter();
            var cmd = new MySqlCommand() { CommandTimeout = 300 };
            var dT = new DataTable();
            if (mysql.Ping() == false)
            {
                if (mysql is null || mysql.State == ConnectionState.Closed)
                {
                    Interaction.MsgBox("서버가 불안정합니다.");
                    return default;
                }
            }
            cmd.Connection = mysql;
            if (Strings.UCase(mysql.Database) != Strings.UCase(DBNm))
            {
                mysql.ChangeDatabase(DBNm);
            }
            cmd.CommandText = SQuery;
            da.SelectCommand = cmd;
            da.Fill(dT);
            da.Dispose();
            da = default;
            cmd.Dispose();
            cmd = default;
            return dT;
        }
        public DataTable MysqlSelect(string Sql)
        {
            var dT = new DataTable();
            var dS = new DataSet();
            using (var cmd = new MySqlCommand() { Connection = mysql, CommandText = Sql })
            {
                using (var da = new MySqlDataAdapter() { SelectCommand = cmd })
                {
                    da.Fill(dT);
                }
            }
            return dT;
        }
        public MySqlDataReader MysqlRead(string Sql)
        {
            MySqlDataReader Read;
            using (var cmd = new MySqlCommand() { Connection = mysql, CommandText = Sql })
            {
                Read = cmd.ExecuteReader();
            }
            return Read;
        }
        public object DataSelect(string Sql)
        {
            try
            {
                using (var cmd = new MySqlCommand(Sql, mysql))
                {
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int DataExeCute(string Sql, string pdfFileCol, byte[] bytes)
        {
            int auto = 0;
            mysql.ChangeDatabase("mysql");
            using (var cmd = new MySqlCommand(Sql, mysql))
            {
                try
                {
                    if (bytes != null)
                        cmd.Parameters.AddWithValue(pdfFileCol, bytes);
                    cmd.ExecuteNonQuery();
                    auto = Conversions.ToInteger(cmd.LastInsertedId);
                }
                catch (Exception ex)
                {
                }
            }
            return auto;
        }
        public void My_EXECUTE(string SQuery, string DBNm = "")
        {
            var Cmd = new MySqlCommand() { CommandTimeout = 300 };

            if (mysql.Ping() == false)
            {
                if (mysql is null || mysql.State == ConnectionState.Closed)
                {
                    Interaction.MsgBox("서버가 불안정합니다.");
                    return;
                }
            }
            Cmd.Connection = mysql;

            if (Strings.UCase(mysql.Database) != Strings.UCase(DBNm))
            {
                mysql.ChangeDatabase(DBNm);
            }
            Cmd.CommandText = SQuery;
            Cmd.ExecuteNonQuery();
            Cmd.Dispose();
        }
        public void My_EXECUTE(string SQuery, string DBnm, ref int LastInsertedId)
        {
            var Cmd = new MySqlCommand() { CommandTimeout = 300 };
            if (mysql.Ping() == false)
            {
                if (mysql is null || mysql.State == ConnectionState.Closed)
                {
                    Interaction.MsgBox("서버가 불안정합니다.");
                    return;
                }
            }
            Cmd.Connection = mysql;
            if (Strings.UCase(mysql.Database) != Strings.UCase(DBnm))
            {
                mysql.ChangeDatabase(DBnm);
            }
            Cmd.CommandText = SQuery;
            Cmd.ExecuteNonQuery();
            LastInsertedId = Conversions.ToInteger(Cmd.LastInsertedId);
            Cmd.Dispose();
        }
        public long BlobExecute(string Sql, string DBName, params byte[][] Buffer)
        {
            var Cmd = new MySqlCommand();
            var Pm = new MySqlParameter();
            for (int i = 0, loopTo = Information.UBound(Buffer); i <= loopTo; i++)
                Cmd.Parameters.Add("?" + (i + 1), MySqlDbType.Binary).Value = Buffer[i];
            if (mysql.Database != DBName)
                mysql.ChangeDatabase(DBName);
            Cmd.Connection = mysql;
            Cmd.CommandText = Sql;
            Cmd.CommandType = CommandType.Text;
            Cmd.ExecuteNonQuery();
            return Cmd.LastInsertedId;
        }
        public byte[] CompressByte(string FileName)
        {
            if (File.Exists(FileName) == false)
                return null;
            byte[] buffer = null;
            FileStream sourceStream = null;
            FileStream destinationStream = null;
            System.IO.Compression.GZipStream compressedStream = null;
            try
            {
                sourceStream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                buffer = new byte[(int)(sourceStream.Length + 1)];
                int checkCounter = sourceStream.Read(buffer, 0, buffer.Length);
                var ms = new MemoryStream();
                using (var zipStream = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Compress, true))
                {
                    zipStream.Write(buffer, 0, buffer.Length);
                }
                buffer = ms.ToArray();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "An Error occured during compression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sourceStream != null)
                    sourceStream.Close();
                if (compressedStream != null)
                    compressedStream.Close();
                if (destinationStream != null)
                    destinationStream.Close();
            }
            return buffer;
        }
        public byte[] DecompressByte_FromByte(byte[] Buf)
        {
            byte[] DecompressByte_FromByteRet = default;
            System.IO.Compression.GZipStream decompressedStream = null;
            byte[] quartetBuffer = null;
            var ms = new MemoryStream(Buf);

            try
            {
                decompressedStream = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Decompress, true);

                quartetBuffer = new byte[5];
                int position = ms.ToArray().Length - 4;
                ms.Position = position;
                ms.Read(quartetBuffer, 0, 4);
                ms.Position = 0L;

                int checkLength = BitConverter.ToInt32(quartetBuffer, 0);
                var buffer = new byte[checkLength + 100 + 1];
                int offset = 0;
                int total = 0;

                while (true)
                {
                    int bytesRead = decompressedStream.Read(buffer, offset, 100);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    offset += bytesRead;
                    total += bytesRead;
                }
                DecompressByte_FromByteRet = buffer;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "An Error occured during compression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DecompressByte_FromByteRet = new byte[] { };
            }
            finally
            {
                if (ms != null)
                {
                    ms.Close();
                }
                if (decompressedStream != null)
                {
                    decompressedStream.Close();
                }
            }

            return DecompressByte_FromByteRet;
        }



    }
}
