using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eLearningModels;

namespace EntityFrameworkDev
{
    public partial class DataBound : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<UserAlert> ListView_GetData()
        {
            var db = new eLearningEntities();

            var query = from ua in db.UserAlerts
                        where ua.userID == 254273
                        orderby ua.alertDate
                        select ua;

            return query;
        }
    }
}