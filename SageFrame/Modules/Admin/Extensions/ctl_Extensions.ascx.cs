﻿/*
SageFrame® - http://www.sageframe.com
Copyright (c) 2009-2010 by SageFrame
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SageFrame.Packages;
using SageFrame.Web;
using System.Data;
using SageFrame.Framework;
using System.Web.UI.HtmlControls;

namespace SageFrame.Modules.Admin.Extensions
{
    /// <remark>
    /// This is modulepackage user control
    /// </remark>
    public partial class ctl_Extensions : BaseAdministrationUserControl
    {
        PackagesDataContext dbPackages = new PackagesDataContext(SystemSetting.SageFrameConnectionString);
        CommonFunction LToDCon = new CommonFunction();

        protected void Page_Init(object sender, EventArgs e)
        {
            if (Request.QueryString["extension"] != null)
            {
                string ControlSrc = Request.QueryString["extension"].ToString();
                LoadControl(new Random().Next().ToString(), false, ExtensionPlaceHolder, ControlSrc);
            }
        }

        public void LoadControl(string UpdatePanelIDPrefix, bool IsPartialRendring, PlaceHolder ContainerControl, string ControlSrc)
        {
            SageUserControl ctl;
            if (ControlSrc.ToLower().EndsWith(".ascx"))
            {
                if (IsPartialRendring)
                {
                    UpdatePanel udp = CreateUpdatePanel(UpdatePanelIDPrefix, UpdatePanelUpdateMode.Always, ContainerControl.Controls.Count);
                    ctl = this.Page.LoadControl("~" + ControlSrc) as SageUserControl;
                    //ctl.EnableViewState = true;
                    udp.ContentTemplateContainer.Controls.Add(ctl);
                    //ContainerControl.Controls.Clear();
                    ContainerControl.Controls.Add(udp);
                }
                else
                {
                    ctl = this.Page.LoadControl("~" + ControlSrc) as SageUserControl;
                    ContainerControl.Controls.Clear();
                    ContainerControl.Controls.Add(ctl);
                }
            }
            else
            {
            }

        }

        public UpdatePanel CreateUpdatePanel(string Prefix, UpdatePanelUpdateMode Upm, int PaneUpdatePanelCount)
        {
            UpdatePanel udp = new UpdatePanel();
            udp.UpdateMode = Upm;
            PaneUpdatePanelCount++;
            udp.ID = "_udp_" + "_" + PaneUpdatePanelCount + Prefix;
            //udp.EnableViewState = true;
            return udp;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (HttpContext.Current.Request.QueryString["ExtensionMessage"] != null && HttpContext.Current.Request.QueryString["ExtensionMessage"].ToString() != "")
                {
                    ShowMessage(SageMessageTitle.Information.ToString(), HttpContext.Current.Request.QueryString["ExtensionMessage"].ToString(), "", SageMessageType.Success);
                }
                if (!IsPostBack && Request.QueryString["extension"] == null)
                {
                    AddImageUrls();
                    BindGrid(string.Empty);
                    imbBtnSaveChanges.Attributes.Add("onclick", "javascript:return confirm('" + GetSageMessage("Extensions_Editors", "AreYouSureToSaveChanges") + "')");
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }

        private void AddImageUrls()
        {
            imbBtnSaveChanges.ImageUrl = GetTemplateImageUrl("imgsave.png", true);
            imbInstallModule.ImageUrl = GetTemplateImageUrl("imginstall-module.png", true);
            imbCreateNewModule.ImageUrl = GetTemplateImageUrl("imgadd.png", true);
            imgSearch.ImageUrl = GetTemplateImageUrl("imgpreview.png", true);
        }

        /// <summary>
        /// This is used to buind the gridview with package info
        /// </summary>
        private void BindGrid(string searchText)
        {
            try
            {
                var packageInfo = dbPackages.sp_PackagesGetByPortalID(GetPortalID, searchText);
                gdvExtensions.PageSize = int.Parse(ddlRecordsPerPage.Text);
                gdvExtensions.DataSource = packageInfo;
                gdvExtensions.DataBind();
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }

        protected void imbInstallModule_Click(object sender, ImageClickEventArgs e)
        {
            string ControlPath = "/Modules/Admin/Extensions/ctl_ModuleInstaller.ascx";
            ProcessSourceControlUrl(Request.RawUrl, ControlPath, "extension");
        }

        protected void imbCreateNewModule_Click(object sender, ImageClickEventArgs e)
        {
            string ControlPath = "/Modules/Admin/Extensions/Editors/EditModuleDefinition.ascx";
            ProcessSourceControlUrl(Request.RawUrl, ControlPath, "extension");
        }

        public string ConvertToYesNo(string i)
        {
            string flag = "No";
            if (i == "1")
            {
                flag = "Yes";
            }
            return flag;
        }

        protected void gdvExtensions_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            HttpContext.Current.Session["moduleid"] = int.Parse(e.CommandArgument.ToString());
            switch (e.CommandName)
            {
                case "Edit":
                    string strURL = string.Empty;
                    string redmain = Request.RawUrl;
                    if (redmain.Contains("ExtensionMessage"))
                        redmain = redmain.Remove(redmain.IndexOf("ExtensionMessage") - 1);

                    //To direct to new page with query string
                    string ControlPath = "/Modules/Admin/Extensions/Editors/ModuleEditor.ascx";
                    SageFrameConfig pagebase = new SageFrameConfig();
                    bool IsUseFriendlyUrls = pagebase.GetSettingBollByKey(SageFrameSettingKeys.UseFriendlyUrls);
                    if (!IsUseFriendlyUrls)
                    {
                        string[] arrUrl;
                        arrUrl = redmain.Split('&');
                        if (arrUrl.Length > 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                strURL += arrUrl[i] + "&";
                            }
                            //strURL = strURL.Remove(strURL.LastIndexOf('&'));
                            strURL = strURL + "extension=" + ControlPath + "&modulecode=" + HttpContext.Current.Session["moduleid"];
                        }
                    }
                    else
                    {
                        if (redmain.Contains("?"))
                        {
                            // Location of the letter ?.
                            int i = redmain.IndexOf('?');
                            // Remainder of string starting at '?'.
                            string d = redmain.Substring(i);
                            strURL = redmain + "?extension=" + ControlPath + "&modulecode=" + HttpContext.Current.Session["moduleid"];

                        }
                        else
                        {
                            strURL = redmain + "?extension=" + ControlPath + "&modulecode=" + HttpContext.Current.Session["moduleid"];
                        }
                    }
                    Response.Redirect(strURL);
                    break;
                case "Delete":
                    int moduleID = int.Parse(e.CommandArgument.ToString());
                    try
                    {
                        var Delete = dbPackages.sp_PackagesDeleteByModuleID(GetPortalID, moduleID, GetUsername);
                        BindGrid(string.Empty);
                        ShowMessage(SageMessageTitle.Information.ToString(), GetSageMessage("Extensions_Editors", "ModuleIsDeletedSuccessfully"), "", SageMessageType.Success);
                    }
                    catch (Exception ex)
                    {
                        ProcessException(ex);
                    }
                    break;
            }
        }

        protected void gdvExtensions_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gdvExtensions_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gdvExtensions_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gdvExtensions_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdvExtensions.PageIndex = e.NewPageIndex;
            BindGrid(txtSearchText.Text);
        }

        protected void gdvExtensions_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ImageButton btnDelete = (ImageButton)e.Row.FindControl("imbDelete");
                btnDelete.Attributes.Add("onclick", "javascript:return confirm('" + GetSageMessage("Extensions_Editors", "AreYouSureToDelete") + "')");

                HiddenField hdnIsActive = (HiddenField)e.Row.FindControl("hdnIsActive");

                HtmlInputCheckBox chkIsActiveItem = (HtmlInputCheckBox)e.Row.FindControl("chkBoxIsActiveItem");
                chkIsActiveItem.Attributes.Add("onclick", "javascript:Check(this,'cssCheckBoxIsActiveHeader','" + gdvExtensions.ClientID + "','cssCheckBoxIsActiveItem');");
                chkIsActiveItem.Checked = bool.Parse(hdnIsActive.Value);

                HiddenField hdnIsAdmin = (HiddenField)e.Row.FindControl("hdnIsAdmin");
                chkIsActiveItem.Disabled = bool.Parse(hdnIsAdmin.Value);
                if (chkIsActiveItem.Disabled == true)
                {
                    chkIsActiveItem.Attributes.Add("class", "disabledClass");
                    ImageButton imbDelete = (ImageButton)e.Row.FindControl("imbDelete");
                    imbDelete.Visible = false;
                }
            }
            else if (e.Row.RowType == DataControlRowType.Header)
            {
                HtmlInputCheckBox chkIsActiveHeader = (HtmlInputCheckBox)e.Row.FindControl("chkBoxIsActiveHeader");
                chkIsActiveHeader.Attributes.Add("onclick", "javascript:SelectAllCheckboxesSpecific(this,'" + gdvExtensions.ClientID + "','cssCheckBoxIsActiveItem');");
            }
        }

        protected void imbBtnSaveChanges_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                string seletedModulesID = string.Empty;
                string IsActive = string.Empty;

                for (int i = 0; i < gdvExtensions.Rows.Count; i++)
                {
                    HtmlInputCheckBox chkBoxItem = (HtmlInputCheckBox)gdvExtensions.Rows[i].FindControl("chkBoxIsActiveItem");
                    HiddenField hdnModuleID = (HiddenField)gdvExtensions.Rows[i].FindControl("hdnModuleID");
                    seletedModulesID = seletedModulesID + hdnModuleID.Value.Trim() + ",";
                    IsActive = IsActive + (chkBoxItem.Checked ? "1" : "0") + ",";
                }
                if (seletedModulesID.Length > 1 && IsActive.Length > 0)
                {
                    seletedModulesID = seletedModulesID.Substring(0, seletedModulesID.Length - 1);
                    IsActive = IsActive.Substring(0, IsActive.Length - 1);
                    dbPackages.sp_PackagesUpdateChanges(seletedModulesID, IsActive, GetUsername);
                    ShowMessage(SageMessageTitle.Information.ToString(), GetSageMessage("Extensions_Editors", "SelectedChangesAreSavedSuccessfully"), "", SageMessageType.Success);
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }


        protected void imgSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BindGrid(txtSearchText.Text);
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }

        protected void ddlRecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            gdvExtensions.PageSize = int.Parse(ddlRecordsPerPage.SelectedValue.ToString());
            BindGrid(txtSearchText.Text);
        }
    }
}