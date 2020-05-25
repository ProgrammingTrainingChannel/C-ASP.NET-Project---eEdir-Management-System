using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eEdir_Management_System.Forms
{
    public partial class frmMemberFamily : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                List<tblMember> members = entity.tblMembers.ToList();

                ddlMember.DataSource = members;
                ddlMember.DataValueField = "ID";
                ddlMember.DataTextField = "Fullname";
                ddlMember.DataBind();

                List<tblRelationType> relationTypes = entity.tblRelationTypes.ToList();
                ddlRelationType.DataSource = relationTypes;
                ddlRelationType.DataValueField = "ID";
                ddlRelationType.DataTextField = "Title";
                ddlRelationType.DataBind();

                List<tblRegion> regions = entity.tblRegions.ToList();
                ddlRegion.DataSource = regions;
                ddlRegion.DataValueField = "ID";
                ddlRegion.DataTextField = "Title";
                ddlRegion.DataBind();

                /////////////////////////////

                List<tblMemberFamily> memberFamilties = entity.tblMemberFamilies.ToList();
                grvwMemberFamily.DataSource = memberFamilties;
                grvwMemberFamily.DataBind();
            }
        }

        protected void ddlRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
            List<tblSubcity> subcities = entity.tblSubcities.ToList();

            ddlSubcity.DataSource = subcities;
            ddlSubcity.DataValueField = "ID";
            ddlSubcity.DataTextField = "Title";
            ddlSubcity.DataBind();
        }

        protected void ddlSubcity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWoreda();
        }

        private void LoadWoreda()
        {
            eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
            int subcityID = int.Parse(ddlSubcity.SelectedValue);

            List<tblWoreda> woredas = entity.tblWoredas.Where(x=>x.SubcityID == subcityID).ToList();

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
                tblMemberFamily memberFamily = new eEdir_Management_System.tblMemberFamily();
                memberFamily.MemberID = int.Parse(ddlMember.SelectedValue);
                memberFamily.Fullname = txtFullname.Text;
                memberFamily.RelationTypeID = int.Parse(ddlRelationType.SelectedValue);
                memberFamily.RegionID = int.Parse(ddlRegion.SelectedValue);
                memberFamily.SubcityID = int.Parse(ddlSubcity.SelectedValue);
                memberFamily.WoredaID = int.Parse(ddlWoreda.SelectedValue);
                memberFamily.HouseNumber = txtHouseNumber.Text;
                memberFamily.PhoneNumber = txtPhoneNumber.Text;

                entity.tblMemberFamilies.Add(memberFamily);
                entity.SaveChanges();

                lblMessage.Text = "Member Family Saved Successfully";
            }
            catch (Exception)
            {
                lblMessage.Text = "Member Family Save Failed";
            }
        }

        protected void grvwMemberFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
            int memberFamilyID = int.Parse(grvwMemberFamily.SelectedRow.Cells[0].Text);
            tblMemberFamily memberFamily = entity.tblMemberFamilies.Where(x => x.ID == memberFamilyID).FirstOrDefault();

            txtFullname.Text = memberFamily.Fullname;
            txtHouseNumber.Text = memberFamily.HouseNumber;
            txtPhoneNumber.Text = memberFamily.PhoneNumber;

            ddlMember.SelectedItem.Text = memberFamily.tblMember.Fullname;

            ddlRegion.SelectedItem.Value = memberFamily.RegionID.ToString();
            ddlRegion_SelectedIndexChanged(sender, e);

            ddlSubcity.SelectedItem.Value = memberFamily.SubcityID.ToString();
            LoadWoreda();

            ddlWoreda.SelectedItem.Value = memberFamily.WoredaID.ToString();
        }
    }
}