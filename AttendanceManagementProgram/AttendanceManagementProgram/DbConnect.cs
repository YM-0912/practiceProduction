﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace AttendanceManagementProgram
{
    /// <summary>
    /// クラス：データベースに接続し値を取得する
    /// </summary>
    class DbConnect
    {
        //プロパティ
        public string Id { get; set; }      //ID
        public string Pw { get; set; }      //PW
        public string Name { get; set; }    //姓名

        /// <summary>
        /// IDとPWをデータベースから取得する
        /// </summary>
        /// <returns></returns>
        public void IdPwGet()
        {

            var dbIdPw = new Db();

            dbIdPw.DataTable();
            {
                
            };

            MessageBox.Show(dbIdPw.Id);

            //var idList = new string[] { dbIdPw.Id };
            //foreach (var n in idList)
            //{
            //    this.Id = n;
            //}

            //var pwList = new string[] { dbIdPw.Pass };
            //foreach (var n in pwList)
            //{
            //    this.Pw = n;
            //}

        }
    }
}
