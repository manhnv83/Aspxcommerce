﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AttributesManage.ascx.cs"
    Inherits="Modules_AspxAttributesManagement_AttributesManage" %>

<script type="text/javascript">
    //<![CDATA[
    var lblAttrFormHeading = "<%= lblAttrFormHeading.ClientID %>";
    var lblLength = "<%= lblLength.ClientID %>";
    var lblDefaultValue = "<%= lblDefaultValue.ClientID %>";
    //]]>
</script>

<!-- Grid -->
<div id="divAttribGrid">
    <div class="cssClassCommonBox Curve">
        <div class="cssClassHeader">
            <h2>
                <asp:Label ID="lblAttrGridHeading" runat="server" Text="Manage Attributes"></asp:Label>
            </h2>
            <div class="cssClassHeaderRight">
                <div class="cssClassButtonWrapper">
                    <p>
                        <button type="button" id="btnDeleteSelected">
                            <span><span>Delete All Selected</span> </span>
                        </button>
                    </p>
                    <p>
                        <button type="button" id="btnAddNew">
                            <span><span>Add New Attribute</span> </span>
                        </button>
                    </p>
                    <div class="cssClassClear">
                    </div>
                </div>
                <div class="cssClassClear">
                </div>
            </div>
            <div class="cssClassClear">
            </div>
        </div>
        <div class="cssClassGridWrapper">
            <div class="cssClassGridWrapperContent">
                <div class="cssClassSearchPanel cssClassFormWrapper">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <label class="cssClassLabel">
                                    Attribute Name:</label>
                                <input type="text" id="txtSearchAttributeName" class="cssClassTextBoxSmall" />
                            </td>
                            <td>
                                <label class="cssClassLabel">
                                    Required:</label>
                                <select id="ddlIsRequired" class="cssClassDropDown">
                                    <option value="">-- All --</option>
                                    <option value="True">Yes</option>
                                    <option value="False">No</option>
                                </select>
                            </td>
                            <td>
                                <label class="cssClassLabel">
                                    Comparable:</label><select id="ddlComparable" class="cssClassDropDown">
                                        <option value="">-- All --</option>
                                        <option value="True">Yes</option>
                                        <option value="False">No</option>
                                    </select>
                            </td>
                            <td>
                                <label class="cssClassLabel">
                                    Is System:</label>
                                <select id="ddlIsSystem" class="cssClassDropDown">
                                    <option value="">-- All --</option>
                                    <option value="True">Yes</option>
                                    <option value="False">No</option>
                                </select>
                            </td>
                            <td>
                                <div class="cssClassButtonWrapper cssClassPaddingNone">
                                    <p>
                                        <button type="button" id="btnSearchAttribute">
                                            <span><span>Search</span></span></button>
                                    </p>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="loading">
                    <img id="ajaxAttributeImageLoader" src="" alt="loading...." title="loading...." />
                </div>
                <div class="log">
                </div>
                <table id="gdvAttributes" cellspacing="0" cellpadding="0" border="0" width="100%">
                </table>
            </div>
        </div>
    </div>
</div>
<!-- End of Grid -->
<!-- form -->
<div id="divAttribForm" style="display:none">
    <div class="cssClassCommonBox Curve">
        <div class="cssClassHeader">
            <h2>
                <asp:Label ID="lblAttrFormHeading" runat="server" Text="General Information"></asp:Label>
            </h2>
        </div>
        <div class="cssClassTabPanelTable">
            <div id="container-7">
                <ul>
                    <li><a href="#fragment-1">
                        <asp:Label ID="lblTabTitle1" runat="server" Text="Attribute Properties"></asp:Label>
                    </a></li>
                    <li><a href="#fragment-2">
                        <asp:Label ID="lblTabTitle2" runat="server" Text="Frontend Properties"></asp:Label>
                    </a></li>
                </ul>
                <div id="fragment-1">
                    <div class="cssClassFormWrapper">
                        <h3>
                            <asp:Label ID="lblTab1Info" runat="server" Text="General Information"></asp:Label>
                        </h3>
                        <table cellspacing="0" cellpadding="0" border="0" width="100%">
                            <tr>
                                <td>
                                    <asp:Label ID="lblAttributeName" runat="server" Text="Attribute Name:" CssClass="cssClassLabel"></asp:Label>
                                    <span class="cssClassRequired">*</span>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="text" id="txtAttributeName" class="cssClassNormalTextBox required" />
                                    <span class="cssClassRight">
                                        <img class="cssClassSuccessImg" height="13" width="18" title="Right" src="" alt="Right" /></span>
                                    <b class="cssClassError">Ops! found something error, must be unique with no spaces</b>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblType" runat="server" Text="Type:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <select id="ddlAttributeType" class="cssClassDropDown" title="Attribute Input Type">
                                    </select>
                                </td>
                            </tr>
                            <tr id="trdefaultValue">
                                <td>
                                    <asp:Label ID="lblDefaultValue" runat="server" Text="Default Value:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="text" class="cssClassNormalTextBox" title="Default Value" value="" name="default_value_text"
                                        id="default_value_text" />
                                    <div id="fileDefaultTooltip" style="display: none;" class="cssClassRed">
                                    </div>
                                    <textarea class="cssClassTextArea" cols="15" rows="2" title="Default Value" name="default_value_textarea"
                                        id="default_value_textarea"></textarea>
                                    <div id="div_default_value_date">
                                        <input type="text" class="cssClassNormalTextBox" title="Default Value" value="" id="default_value_date"
                                            name="default_value_date" />
                                    </div>
                                    <select class="cssClassDropDown" title="Default Value" name="default_value_yesno"
                                        id="default_value_yesno">
                                        <option value="1">Yes</option>
                                        <option selected="selected" value="0">No</option>
                                    </select>
                                </td>
                            </tr>
                            <tr id="trOptionsAdd">
                                <td>
                                    <asp:Label ID="lblAddOptions" runat="server" Text="Manage Options (values of your attribute):"
                                        CssClass="cssClassLabel"></asp:Label>
                                    <span class="cssClassRequired">*</span>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <table id="dataTable" cellspacing="0" cellpadding="0" border="0" width="100%">
                                        <thead>
                                            <tr>
                                                <th>
                                                    <asp:Label ID="lblValue" runat="server" Text="Value" CssClass="cssClassLabel"></asp:Label>
                                                </th>
                                                <th>
                                                    <asp:Label ID="lblPosition" runat="server" Text="Display Order" CssClass="cssClassLabel"></asp:Label>
                                                </th>
                                                <th>
                                                    <asp:Label ID="lblAlias" runat="server" Text="Alias" CssClass="cssClassLabel"></asp:Label>
                                                </th>
                                                <th>
                                                    <asp:Label ID="lblIsDefault" runat="server" Text="Is Default" CssClass="cssClassLabel"></asp:Label>
                                                </th>
                                            </tr>
                                        </thead>
                                        <tr>
                                            <td>
                                                <input type="text" class="class-text" value="" name="value" />
                                            </td>
                                            <td>
                                                <input type="text" class="class-text" value="" name="position" />
                                            </td>
                                            <td>
                                                <input type="text" class="class-text" value="" name="Alias" />
                                            </td>
                                            <td id="tddefault">
                                            </td>
                                            <td>
                                                <input type="Button" value="Add More" name="AddMore" class="AddOption cssClassButtonSubmit" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblUniqueValue" runat="server" Text="Unique Value:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkUniqueValue" value="" class="cssClassCheckBox" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblTypeValidation" runat="server" Text="Type Validation:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <select id="ddlTypeValidation" class="cssClassDropDown" name="" title="Attribute Input Validation Type">
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblValuesRequired" runat="server" Text="Values Required:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkValuesRequired" class="cssClassCheckBox" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblApplyTo" runat="server" Text="Apply To:" CssClass="cssClassLabel"></asp:Label>
                                    <span class="cssClassRequired">*</span>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <select id="ddlApplyTo" class="cssClassDropDown" name="">
                                        <option selected="selected" value="0">All Item Types</option>
                                        <option value="1">Selected Item Types</option>
                                    </select>
                                </td>
                            </tr>
                            <tr class="itemTypes">
                                <td>
                                    &nbsp;
                                </td>
                                <td class="cssClassTableRightCol">
                                    <select id="lstItemType" class="cssClassMultiSelect">
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblLength" runat="server" Text="Length:" CssClass="cssClassLabel"></asp:Label>
                                    <span class="cssClassRequired">*</span>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input class="cssClassNormalTextBox required" id="txtLength" type="text" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblAliasName" runat="server" Text="Alias Name:" CssClass="cssClassLabel"></asp:Label>
                                    <span class="cssClassRequired">*</span>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input class="cssClassNormalTextBox required" id="txtAliasName" type="text" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblAliasToolTip" runat="server" Text="Alias ToolTip:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input class="cssClassNormalTextBox" id="txtAliasToolTip" type="text" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblAliasHelp" runat="server" Text="Alias Help:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input class="cssClassNormalTextBox" id="txtAliasHelp" type="text" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblDisplayOrder" runat="server" Text="Display Order:" CssClass="cssClassLabel"></asp:Label>
                                    <span class="cssClassRequired">*</span>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input class="cssClassNormalTextBox required" id="txtDisplayOrder" type="text" />
                                </td>
                            </tr>
                            <tr id="activeTR">
                                <td>
                                    <asp:Label ID="lblActive" runat="server" Text="Is Active:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkActive" class="cssClassCheckBox" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div id="fragment-2">
                    <div class="cssClassFormWrapper">
                        <h3>
                            <asp:Label ID="lblTab2Info" runat="server" Text="Frontend Display Settings"></asp:Label>
                        </h3>
                        <table cellspacing="0" cellpadding="0" border="0" width="100%">
                            <tr>
                                <td>
                                    <asp:Label ID="lblIsEnableEditor" runat="server" Text="Is Enable Editor:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkIsEnableEditor" class="cssClassCheckBox" />
                                </td>
                            </tr>
                            <%--<tr>
                                <td>
                                    <asp:Label ID="lblShowInGrid" runat="server" Text="Show in Grid:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkShowInGrid" class="cssClassCheckBox" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblIsEnableSorting" runat="server" Text="Is Enable Sorting:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkIsEnableSorting" class="cssClassCheckBox" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblIsUseInFilter" runat="server" Text="Is Use in Filter:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkIsUseInFilter" class="cssClassCheckBox" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblShowInSearch" runat="server" Text="Use in Search:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkShowInSearch" class="cssClassCheckBox" />
                                </td>
                            </tr>--%>
                            <tr>
                                <td>
                                    <asp:Label ID="lblUseInAdvancedSearch" runat="server" Text="Use in Advanced Search:"
                                        CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkUseInAdvancedSearch" class="cssClassCheckBox" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblComparable" runat="server" Text="Comparable on Front-end:" CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkComparable" class="cssClassCheckBox" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblUseForPriceRule" runat="server" Text="Use for Price Rule Conditions:"
                                        CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkUseForPriceRule" class="cssClassCheckBox" />
                                </td>
                            </tr>
                            <%--<tr>
                                <td>
                                    <asp:Label ID="lblUseForPromoRule" runat="server" Text="Use for Promo Rule Conditions:"
                                        CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkUseForPromoRule" class="cssClassCheckBox" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblUseForRating" runat="server" Text="Use for Rating Conditions:"
                                        CssClass="cssClassLabel"></asp:Label>
                                </td>
                                <td class="cssClassTableRightCol">
                                    <input type="checkbox" name="chkUseForRating" class="cssClassCheckBox" />
                                </td>
                            </tr>--%>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <div class="cssClassButtonWrapper">
            <p>
                <button type="button" id="btnBack">
                    <span><span>Back</span></span></button>
            </p>
            <p>
                <button type="button" id="btnReset">
                    <span><span>Reset</span></span></button>
            </p>
            <p>
                <button type="button" class="delbutton">
                    <span><span>Delete</span></span></button>
            </p>
            <p>
                <button type="button" id="btnSaveAttribute">
                    <span><span>Save</span></span></button>
            </p>
        </div>
    </div>
</div>
<!-- End form -->
