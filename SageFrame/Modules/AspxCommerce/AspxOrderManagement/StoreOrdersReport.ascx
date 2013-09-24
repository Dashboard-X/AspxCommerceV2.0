﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="StoreOrdersReport.ascx.cs"
    Inherits="Modules_AspxCommerce_AspxOrderManagement_StoreOrdersReport" %>

<script type="text/javascript">
    $(function() {
        $(".sfLocale").localize({
            moduleKey: AspxOrderManagement
        });
    });
    //<![CDATA[
    var lblOrderForm = "<%= lblOrderForm.ClientID %>"; 
    var storeName="<%=StoreName %>";   
    //]]>
</script>

<div id="divOrderDetails">
    <div class="cssClassCommonBox Curve">
        <div class="cssClassHeader">
            <h1>
                <asp:Label ID="lblOrderHeading" runat="server" Text="Order Reports" 
                    meta:resourcekey="lblOrderHeadingResource1"></asp:Label>
            </h1>
            <div class="cssClassHeaderRight">
                <div class="sfButtonwrapper">
                    <p>
                        <asp:Button ID="btnExportToExcel" class="cssClassButtonSubmit" runat="server" OnClick="Button1_Click"
                            Text="Export to Excel" 
                            OnClientClick="storeOrdersReport.ExportDivDataToExcel()" 
                            meta:resourcekey="btnExportToExcelResource1" />
                    </p>
                    <p>
                        <asp:Button ID="Button1" runat="server" class="cssClassButtonSubmit" OnClick="Button2_Click"
                            Text="Export to CSV" OnClientClick="storeOrdersReport.ExportToCsvData()" 
                            meta:resourcekey="Button1Resource1" />
                    </p>
                    <div class="cssClassClear">
                    </div>
                </div>
            </div>
        </div>
        <div class="sfGridwrapper">
            <div class="sfGridWrapperContent">
                <div class="cssClassSearchPanel sfFormwrapper">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="150">
                                <label class="cssClassLabel sfLocale">
                                    Customer Name:</label>
                                <input type="text" id="txtCustomerName" class="sfTextBoxSmall" />
                            </td>
                           <td width="150">
                                <label class="cssClassLabel sfLocale"">
                                    Order Status:</label>
                                <select id="ddlOrderStatus" class="sfListmenu">
                                    <option value="0" class="sfLocale">--All--</option>
                                </select>
                            </td>
                            <td>
                                <div class="sfButtonwrapper cssClassPaddingNone">
                                    <p>
                                        <button type="button" id="btnSearchOrderReport">
                                            <span><span class="sfLocale">Search</span></span></button>
                                    </p>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="loading">
                    <img id="ajaxStoreOrderReportImage" src="" class="sfLocale" alt="loading...." />
                </div>
                <div class="log">
                </div>
                <table id="gdvOrderDetails" cellspacing="0" cellpadding="0" border="0" width="100%">
                </table>
               <table id="orderReportExportData" cellspacing="0" cellpadding="0" border="0" width="100%" style="display:none">
                </table>
                <div class="cssClassClear">
                </div>
            </div>
        </div>
    </div>
</div>
<asp:HiddenField ID="HdnValue" runat="server" />
<div class="sfFormwrapper">
<div class="cssClassCommonBox Curve" id="divOrderDetailForm" style="display:none">
    <div class="cssClassHeader">
        <h2>
            <asp:Label ID="lblOrderForm" runat="server" 
                meta:resourcekey="lblOrderFormResource1"></asp:Label>
        </h2>
    </div>
    <div id="divOrderDetailHead">
        <div class="cssClassStoreDetail">
            <b><span class="cssClassLabel sfLocale">Ordered Date : </span></b><span id="OrderDate">
            </span>
            <br />
            <b><span class="cssClassLabel sfLocale">Invoice Number : </span></b><span id="invoiceNo">
            </span>
            <br />
            <b><span class="cssClassLabel sfLocale">Store Name : </span></b><span id="storeName">
            </span>
            <br />
            <b><span class="cssClassLabel sfLocale">Store Description : </span></b><span id="storeDescription">
            </span>
            <br />
            <div class="cssPaymentDetail">
                <b><span class="cssClassLabel sfLocale">Payment Method : </span></b><span id="PaymentMethod">
                </span>
            </div>
        </div>
        <div class="cssClassBillingAddress cssClassStorePayment">
            <ul class="cssBillingAddressUl">
            </ul>
        </div>
        <br />
    </div>
    <div class="cssClassCommonBox Curve">
        <div class="cssClassHeader">
            <h2 class="sfLocale">
                Ordered Items:</h2>
        </div>
        <div class="sfGridwrapper">
            <div class="sfGridWrapperContent">
                <table cellspacing="0" cellpadding="0" border="0" width="100%">
                    <thead>
                        <tr class="cssClassHeading">
                           <td class="sfLocale">
                                SKU
                            </td>
                            <td class="sfLocale">
                                Item Name
                            </td>
                             <td class="sfLocale" >
                                Shipping Method
                            </td>
                            <td class="sfLocale">
                                Shipping Address
                            </td>
                            <td class="sfLocale">
                                Shipping Rate
                            </td>
                            <td class="sfLocale">
                                Price
                            </td>
                            <td class="sfLocale">
                                Quantity
                            </td>
                            <td  class="sfLocale">
                                Line Total
                            </td>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class="sfButtonwrapper">
        <p>
            <button type="button" id="btnBack">
                <span><span class="sfLocale">Back</span></span></button>
        </p>
    </div>
</div>
</div>
<asp:HiddenField ID="_csvHiddenValue" runat="server" />