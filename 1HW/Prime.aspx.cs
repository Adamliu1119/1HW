using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int N = 17;
            int count = 0;
            for (int i= 1; i <= N;i++)
            {
                if (N % i == 0)
                {
                    count += 1;
                }
            }
            if (count == 2)
            {
                Response.Write("YES");
            }
            else
            {
                Response.Write("NO");
            }
        }
    }
}