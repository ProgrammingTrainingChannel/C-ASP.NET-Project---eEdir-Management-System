using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eEdir_Management_System.Forms
{
    public partial class frmSubcity : System.Web.UI.Page
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

                //List<tblSubcity> subcities = entity.tblSubcities.ToList();
                List<tblSubcity> subcities = entity.tblSubcities.ToList();
                grvwSubcity.DataSource = subcities;
                grvwSubcity.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                tblSubcity subcity = new tblSubcity();
                subcity.RegionID = int.Parse(ddlRegion.SelectedValue);
                subcity.Title = txtTitle.Text;

                entity.tblSubcities.Add(subcity);
                entity.SaveChanges();

                lblMessage.Text = "Saved Successfully";
            }
            catch (Exception)
            {
                lblMessage.Text = "Save Failed";
            }
        }

        protected void grvwSubcity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTitle.Text = grvwSubcity.SelectedRow.Cells[2].Text;
            ddlRegion.SelectedItem.Text = grvwSubcity.SelectedRow.Cells[1].Text;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int subcityID = int.Parse(grvwSubcity.SelectedRow.Cells[0].Text);

                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                tblSubcity newSubcity = new tblSubcity();
                newSubcity.ID = subcityID;
                newSubcity.RegionID = int.Parse(ddlRegion.SelectedValue);
                newSubcity.Title = txtTitle.Text;

                tblSubcity oldSubcity = entity.tblSubcities.Where(x => x.ID == subcityID).FirstOrDefault();

                entity.Entry(oldSubcity).CurrentValues.SetValues(newSubcity);
                entity.SaveChanges();

                lblMessage.Text = "Updated Successfully";
            }
            catch (Exception)
            {
                lblMessage.Text = "Update Failed";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int subcityID = int.Parse(grvwSubcity.SelectedRow.Cells[0].Text);

                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                tblSubcity oldSubcity = entity.tblSubcities.Where(x => x.ID == subcityID).FirstOrDefault();

                entity.tblSubcities.Remove(oldSubcity);
                entity.SaveChanges();

                lblMessage.Text = "Deleted Successfully";
            }
            catch (Exception)
            {
                lblMessage.Text = "Delete Failed";
            }
        }
    }
}