using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eEdir_Management_System.Forms
{
    public partial class frmMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                List<tblRegion> regions = entity.tblRegions.ToList();

                ddlRegion.DataSource = regions;
                ddlRegion.DataValueField = "ID";
                ddlRegion.DataTextField = "Title";

                ddlRegion.DataBind();
            }
        }

        protected void ddlRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
            int regionID = int.Parse(ddlRegion.SelectedValue);

            List<tblSubcity> subcities = entity.tblSubcities.Where(x=>x.RegionID == regionID).ToList();

            ddlSubcity.DataSource = subcities;
            ddlSubcity.DataValueField = "ID";
            ddlSubcity.DataTextField = "Title";
            ddlSubcity.DataBind();
        }

        protected void ddlSubcity_SelectedIndexChanged(object sender, EventArgs e)
        {
            eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
            int subcityID = int.Parse(ddlSubcity.SelectedValue);

            List<tblWoreda> woredas = entity.tblWoredas.Where(x => x.SubcityID == subcityID).ToList();

            ddlWoreda.DataSource = woredas;
            ddlWoreda.DataValueField = "ID";
            ddlWoreda.DataTextField = "Title";
            ddlWoreda.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                tblMember member = new eEdir_Management_System.tblMember();
                member.Fullname = txtFullname.Text;
                member.RegionID = int.Parse(ddlRegion.SelectedValue);
                member.SubcityID = int.Parse(ddlSubcity.SelectedValue);
                member.WoredaID = int.Parse(ddlWoreda.SelectedValue);
                member.HouseNumber = txtHouseNumber.Text;
                member.PhoneNumber = txtPhoneNumber.Text;
                member.EmailAddress = txtEmailAddress.Text;
                member.MembershipDate = DateTime.Parse(txtMembershipDate.Text);

                entity.tblMembers.Add(member);
                entity.SaveChanges();

                lblMessage.Text = "Member Saved Successfully";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Member Save Failed";
            }
        }
    }
}