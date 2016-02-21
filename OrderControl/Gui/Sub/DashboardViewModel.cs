using MySql.Data.MySqlClient;
using OrderControl.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderControl.Gui.Sub
{
    public class DashboardViewModel
    {
        private Form dashboard;
        private Global global;

        public DashboardViewModel(Global global)
        {
            this.global = global;
        }

        protected void getNewOrder()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT COUNT(*)");
            sql.Append(" FROM tBestellung");
            sql.Append(" INNER JOIN tStatus ON tStatus.ID = tBestellung.tStatus_ID");
            sql.Append(" WHERE tStatus.cName = @cName");
            NewOrderCount = Convert.ToInt32(global.DataBase.Skalar(sql.ToString(), "Neu")).ToString();
        }


        protected void getOrder()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT COUNT(*)");
            sql.Append(" FROM tBestellung");
            sql.Append(" WHERE DATEDIFF(dETD, NOW()) < 0");
            Order = Convert.ToInt32(global.DataBase.Skalar(sql.ToString())).ToString();
        }

        protected void getArticle()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT COUNT(*)");
            sql.Append(" FROM tBestellPos");
            sql.Append(" INNER JOIN tBestellung ON tBestellPos.tBestellung_ID=tBestellung.ID");
            sql.Append(" WHERE DATEDIFF(dETD, NOW()) < 0 AND fGelieferteMenge < fMenge");
            Article = Convert.ToInt32(global.DataBase.Skalar(sql.ToString())).ToString();
        }

        protected void getWorngArticle()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT SUM(fAnzahl)");
            sql.Append(" FROM tFalschlieferung");
            sql.Append(" INNER JOIN tBestellung ON tFalschlieferung.tBestellung_ID = tBestellung.ID");
            sql.Append(" INNER JOIN tBestellPos ON tBestellPos.tBestellung_ID = tBestellung.ID");
            sql.Append(" WHERE fGelieferteMenge < fMenge");
            WorngArticle = Convert.ToInt32(global.DataBase.Skalar(sql.ToString())).ToString();
        }

        public void LoadData()
        {
            getNewOrder();
            getOrder();
            getArticle();
            getWorngArticle();
            getWorngArticle();
        }

        public string NewOrderCount
        {
            get;
            set;
        }

        public string Order
        {
            get;
            set;
        }

        public string Article
        {
            get;
            set;
        }

        public string WorngArticle
        {
            get;
            set;
        }
    }
}
