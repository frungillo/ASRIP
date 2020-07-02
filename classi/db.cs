﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Data;

namespace ASRIP.classi
{

    class db
    {
        public static String WebSite { get { return "Data Source=anm;Persist Security Info=True;User ID=websiteanm;Password=sito.web;Unicode=True"; } }

        private OracleConnection _conn;
        private OracleDataReader _r;

        public db()

        {
            _conn = new OracleConnection(db.WebSite);
            try
            {
                _conn.Open();

            }
            catch (Exception ex)
            {
                throw new Exception("Errore Ist DB:" + ex.Message);
            }
        }

        public void Dispose()
        {
            _conn.Close();
            GC.Collect();
        }

        /// <summary>
        /// Ritorna un SQLdataReader Aperto
        /// </summary>
        /// <param name="sql">frase sql</param>
        /// <returns>sqlDatareader</returns>
        public OracleDataReader getReader(string sql)
        {
            OracleCommand c = new OracleCommand(sql, _conn);

            _r = c.ExecuteReader();
            return _r;
        }

        /// <summary>
        /// Solo per update insert e delete 
        /// </summary>
        /// <param name="sql">frase sqsl</param>
        /// <returns>Numero di record interessati dalla query</returns>
        public int exe(string sql)
        {
            OracleCommand c = new OracleCommand(sql, _conn);
            int ar = c.ExecuteNonQuery();
            return ar;
        }

        public DataTable getDataTable(string sql)
        {
            OracleDataAdapter ta = new OracleDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            ta.Fill(dt);
            return dt;
        }

        public void CloseReader()
        {
            _r.Close();
        }

        /*
        public int Esegui(string sql, bool ret = false)
        {
            SqlCommand c = new SqlCommand(sql, _conn);
            return c.ExecuteNonQuery();
        }
        */

    }
}
