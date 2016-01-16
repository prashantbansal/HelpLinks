using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using HelpLinks.Entity;
using HelpLinks.Utility.EnumsUtility;

namespace HelpLinks.HLPages
{
    public partial class EnumerationList : System.Web.UI.Page
    {
        private IList<EnumClass> _enumClassList; 
        protected void Page_Load(object sender, EventArgs e)
        {
            BindEnumDropdown();
        }

        private void BindEnumDropdown()
        {
            var allEnums = EnumReader.GetAllEnumNames();

            ddlEnums.DataSource = allEnums;
            ddlEnums.DataTextField = "EnumName";
            ddlEnums.DataValueField = "EnumName";
            ddlEnums.DataBind();
        }

        protected void btnGetData_OnClick(object sender, EventArgs e)
        {
            _enumClassList = EnumReader.GetEnumDetails(ddlEnums.SelectedValue);
            if (_enumClassList != null && _enumClassList.Any())
            {
                gvEnumList.DataSource = _enumClassList;
                gvEnumList.DataBind();
            }
        }

        protected void btnGetAllData_OnClick(object sender, EventArgs e)
        {
            _enumClassList = EnumReader.GetAllEnumDetailsList();
            if (_enumClassList != null && _enumClassList.Any())
            {
                gvEnumList.DataSource = _enumClassList;
                gvEnumList.DataBind();
            }
        }

        protected void gvEnumList_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var enumName = e.Row.Cells[0].Text;
                GridView gvEnumDetails = e.Row.FindControl("gvEnumDetails") as GridView;
                var firstOrDefault = _enumClassList.FirstOrDefault(x => x.EnumName.Equals(enumName));
                if (firstOrDefault != null)
                {
                    var enumFields = firstOrDefault.EnumFields;
                    if (enumFields != null)
                    {
                        if (gvEnumDetails != null)
                        {
                            gvEnumDetails.DataSource = enumFields;
                            gvEnumDetails.DataBind();
                        }
                    }
                }
            }
        }
    }
}