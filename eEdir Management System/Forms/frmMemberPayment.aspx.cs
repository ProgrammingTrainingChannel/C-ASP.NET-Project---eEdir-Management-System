using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eEdir_Management_System.Forms
{
    public partial class frmMemberPayment : System.Web.UI.Page
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

                List<tblPaymentPeriod> paymentPeriods = entity.tblPaymentPeriods.ToList();

                ddlPaymentPeriod.DataSource = paymentPeriods;
                ddlPaymentPeriod.DataValueField = "ID";
                ddlPaymentPeriod.DataTextField = "Title";
                ddlPaymentPeriod.DataBind();

                List<tblMemberPayment> memberPayments = entity.tblMemberPayments.ToList();
                grvwMemberPayment.DataSource = memberPayments;
                grvwMemberPayment.DataBind();

                txtPaymentDate.Text = DateTime.Today.ToShortDateString();
                txtPaymentYear.Text = DateTime.Today.Year.ToString();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                tblMemberPayment memberPayment = new eEdir_Management_System.tblMemberPayment();
                memberPayment.MemberID = int.Parse(ddlMember.SelectedValue);
                memberPayment.PaymentPeriodID = int.Parse(ddlPaymentPeriod.SelectedValue);
                memberPayment.PaymentYear = int.Parse(txtPaymentYear.Text);
                memberPayment.PaymentDate = DateTime.Parse(txtPaymentDate.Text);
                memberPayment.PaymentAmount = decimal.Parse(txtPaymentAmount.Text);
                memberPayment.PaymentTransactionCode = txtPaymentTransactionCode.Text;

                entity.tblMemberPayments.Add(memberPayment);
                entity.SaveChanges();

                lblMessage.Text = "Member payment saved successfully";
            }
            catch (Exception)
            {
                lblMessage.Text = "Member payment save failed";
            }
        }

        protected void grvwMemberPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlMember.SelectedItem.Text = grvwMemberPayment.SelectedRow.Cells[1].Text;
            ddlPaymentPeriod.SelectedItem.Text = grvwMemberPayment.SelectedRow.Cells[2].Text;
            txtPaymentYear.Text = grvwMemberPayment.SelectedRow.Cells[3].Text;
            txtPaymentDate.Text = grvwMemberPayment.SelectedRow.Cells[4].Text;
            txtPaymentAmount.Text = grvwMemberPayment.SelectedRow.Cells[5].Text;
            txtPaymentTransactionCode.Text = grvwMemberPayment.SelectedRow.Cells[6].Text;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int memberPaymentID = int.Parse(grvwMemberPayment.SelectedRow.Cells[0].Text);

                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                tblMemberPayment newMemberPayment = new eEdir_Management_System.tblMemberPayment();
                newMemberPayment.ID = memberPaymentID;
                newMemberPayment.MemberID = int.Parse(ddlMember.SelectedValue);
                newMemberPayment.PaymentPeriodID = int.Parse(ddlPaymentPeriod.SelectedValue);
                newMemberPayment.PaymentYear = int.Parse(txtPaymentYear.Text);
                newMemberPayment.PaymentDate = DateTime.Parse(txtPaymentDate.Text);
                newMemberPayment.PaymentAmount = decimal.Parse(txtPaymentAmount.Text);
                newMemberPayment.PaymentTransactionCode = txtPaymentTransactionCode.Text;

                tblMemberPayment oldMemberPayment = entity.tblMemberPayments.Where(x => x.ID == memberPaymentID).FirstOrDefault();
                entity.Entry(oldMemberPayment).CurrentValues.SetValues(newMemberPayment);

                entity.SaveChanges();

                lblMessage.Text = "Member payment updated successfully";
            }
            catch (Exception)
            {
                lblMessage.Text = "Member payment update failed";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int memberPaymentID = int.Parse(grvwMemberPayment.SelectedRow.Cells[0].Text);

                eEdirManagementSystemDBEntities entity = new eEdir_Management_System.eEdirManagementSystemDBEntities();
                tblMemberPayment oldMemberPayment = entity.tblMemberPayments.Where(x => x.ID == memberPaymentID).FirstOrDefault();

                entity.tblMemberPayments.Remove(oldMemberPayment);

                entity.SaveChanges();

                lblMessage.Text = "Member payment deleted successfully";
            }
            catch (Exception)
            {
                lblMessage.Text = "Member payment delete failed";
            }
        }
    }
}