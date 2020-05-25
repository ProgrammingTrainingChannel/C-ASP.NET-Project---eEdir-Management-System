using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eEdir_Management_System.Forms
{
    public partial class frmRegion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
            List<tblRegion> regions = entity.tblRegions.ToList();

            grvwRegion.DataSource = regions;
            grvwRegion.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                tblRegion region = new eEdir_Management_System.tblRegion();
                region.Title = txtTitle.Text;

                entity.tblRegions.Add(region);
                entity.SaveChanges();

                lblMessage.Text = "Region saved successfully";
            }
            catch (Exception)
            {
                lblMessage.Text = "Region save failed";
            }
        }

        protected void grvwRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTitle.Text = grvwRegion.SelectedRow.Cells[2].Text;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int regionID = int.Parse(grvwRegion.SelectedRow.Cells[1].Text);
                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                tblRegion newRegion = new eEdir_Management_System.tblRegion();
                newRegion.ID = regionID;
                newRegion.Title = txtTitle.Text;

                tblRegion oldRegion = entity.tblRegions.Where(x => x.ID == regionID).FirstOrDefault();

                entity.Entry(oldRegion).CurrentValues.SetValues(newRegion);
                entity.SaveChanges();

                lblMessage.Text = "Region updated successfully";
            }
            catch (Exception)
            {
                lblMessage.Text = "Region update failed";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int regionID = int.Parse(grvwRegion.SelectedRow.Cells[1].Text);
                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                tblRegion oldRegion = entity.tblRegions.Where(x => x.ID == regionID).FirstOrDefault();

                entity.tblRegions.Remove(oldRegion);
                entity.SaveChanges();

                lblMessage.Text = "Region deleted successfully";
            }
            catch (Exception)
            {
                lblMessage.Text = "Region delete failed";
            }
        }
    }
}