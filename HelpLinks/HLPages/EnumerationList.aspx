<%@ Page Language="C#" MasterPageFile="~/HelpLinks.Master" AutoEventWireup="true" CodeBehind="EnumerationList.aspx.cs" Inherits="HelpLinks.HLPages.EnumerationList" %>

<asp:Content runat="server" ID="HeadContent" ContentPlaceHolderID="HLHeadContent">
    <style type="text/css">
        .Grid td {
            background-color: white;
            color: black;
            font-size: 10pt;
            line-height: 200%;
            border-width: 1px;
            border-color: black;
            border-style: solid;
            text-align: center;
        }

        .Grid th {
            background-color: lightgray;
            color: black;
            font-size: 10pt;
            line-height: 200%;
            border: 1px;
            border-color: black;
            border-width: 1px;
            border-style: solid;
            text-align: center;
        }

        .Grid2 td {
            background-color: white;
            color: black;
            font-size: 10pt;
            line-height: 200%;
            border-width: 1px;
            border-color: black;
            border-style: solid;
            padding-left: 5px;
        }

        .Grid2 th {
            background-color: lightgray;
            color: black;
            font-size: 10pt;
            line-height: 200%;
            padding-left: 5px;
            border: 1px;
            border-color: black;
            border-width: 1px;
            border-style: solid;
        }

        .ChildGrid td {
            background-color: #eee !important;
            color: black;
            font-size: 10pt;
            line-height: 200%;
            padding-left: 5px;
            border-width: 1px;
            border-color: black;
        }

        .ChildGrid th {
            background-color: #6C6C6C !important;
            color: White;
            font-size: 10pt;
            line-height: 200%;
            padding-left: 5px;
            border-width: 1px;
            border-color: black;
        }
    </style>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="HLMainContent">
    <div style="width: 100%; float: left;">
        <div style="float: left; width: 100%; font-weight: bold; color: darkblue; font-size: 18px; text-align: center"><span style="text-align: center">Enumerations List</span></div>
        <div style="float: left; width: 100%; padding-top: 20px; padding-left: 50px;">
            <div style="width: 11%; float: left; font-weight: bold">Enum Type</div>
            <div style="float: left; width: 30%">
                <asp:DropDownList runat="server" ID="ddlEnums" />
            </div>
            <div style="width: 10%; float: left">
                <asp:Button runat="server" ID="btnGetData" Text="Get Data" OnClick="btnGetData_OnClick" />
            </div>
            <div style="width: 10%; float: left">
                <asp:Button runat="server" ID="btnGetAllData" Text="GetAll Data" OnClick="btnGetAllData_OnClick" />
            </div>
        </div>
        <div style="float: left; width: 100%; padding-top: 20px;" id="divEnumAll" runat="server">
            <div style="width: 100%; float: left; padding-left: 50px;" id="divEnumRow" runat="server">
                <div style="width: 60%; float: left">
                    <asp:GridView ID="gvEnumList" runat="server" Visible="True" AutoGenerateColumns="False" CssClass="Grid" OnRowDataBound="gvEnumList_OnRowDataBound">
                        <Columns>
                            <asp:BoundField ItemStyle-Width="150px" DataField="EnumName" HeaderText="Enum Name" Visible="True" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:GridView runat="server" ID="gvEnumDetails" AutoGenerateColumns="False" CssClass="ChildGrid">
                                        <Columns>
                                            <asp:BoundField DataField="EnumValue" ItemStyle-Width="200px" HeaderText="Value" SortExpression="EnumValue" />
                                            <asp:BoundField DataField="EnumText" ItemStyle-Width="500px" HeaderText="Text" SortExpression="EnumText" />
                                        </Columns>
                                    </asp:GridView>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
