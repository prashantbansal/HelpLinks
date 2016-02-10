<%@ Page Title="Links" Language="C#" MasterPageFile="~/HelpLinks.Master" AutoEventWireup="true" CodeBehind="Links.aspx.cs" Inherits="HelpLinks.HLPages.Links" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="HLHeadContent">
    <style type="text/css">
        .headerRow {
            float: left;
            height: 25px;
            width: 100%;
            background-color: lightgray;
            padding-left: 5px;
            padding-top: 5px;
            font-weight: bold;
            font-family: Arial;
            font-size: 13px;
            vertical-align: middle;
        }

        .buttonRow {
            float: left;
            padding-top: 5px;
            width: 100%;
            padding-bottom: 30px;
        }

        .cellOne {
            float: left;
            width: 30%;
        }

        .cellTwo {
            float: left;
            width: 40%;
        }

        .cellThree {
            float: right;
            width: 30%;
        }

        .cellOneButton {
            width: 110px;
            height: 40px;
            color: Blue;
            font-weight: bold;
        }

        .cellTwoButton {
            width: 160px;
            height: 40px;
            color: green;
            font-weight: bold;
        }

        .cellThreeButton {
            width: 158px;
            height: 40px;
            color: red;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="HLMainContent">
    <div style="text-align: center; color: red; font-size: 15px; font-family: Arial; font-weight: bold; padding-bottom: 40px">
        Help Links
    </div>
    <div class="headerRow">
        OAM Links   
    </div>
    <div class="buttonRow">
        <div class="cellOne" style="display: none;">
            <form name="loginCSRQA" action="http://store.qa01.kaptest.net:8840/csr/en/login.jsp" method="post">
                <input type="hidden" name="login" value="imasud">
                <input type="hidden" name="password" value="kaplan">
                
                <input type="submit" class="cellOneButton" value="OAM-QA">
            </form>
        </div>
        <div class="cellOne">
            <form name="loginCSRQA" action="http://store.qa01.kaptest.net:8840/csr/en/login.jsp" method="post">
                <input type="hidden" name="login" value="imasud">
                <input type="hidden" name="password" value="kaplan">
                <input type="submit" class="cellOneButton" value="OAM-QA">
            </form>
        </div>
        <div class="cellTwo">
            <form name="OAM_STG" action="http://store.stg.kaptest.net:8940/csr/en/login.jsp;jsessionid=0I1AXEQF3WSWZLASAOQSF3VMCIB0CI2C" method="post">
                <input type="hidden" name="login" value="ans">
                <input type="hidden" name="password" value="kaplan">
                <input type="submit" class="cellTwoButton" value="OAM-STG">
            </form>
        </div>
        <div class="cellThree">
            <form name="OAM_PROD" action="http://services.kaptest.com:8740/csr/en/login.jsp" method="post">
                <input type="hidden" name="login" value="kaswani">
                <input type="hidden" name="password" value="qf7Fx%Z#">
                <input type="submit" class="cellThreeButton" value="OAM Production">
            </form>
        </div>
    </div>
    <div class="headerRow">
        Kaptest Links
    </div>
    <div class="buttonRow">
        <div class="cellOne">
            <input type="button" class="cellOneButton" onclick="javascript: window.location.href = 'http://www.qa01.kaptest.net';" value="Kaptest QA">
        </div>
        <div class="cellTwo">
            <input type="button" class="cellTwoButton" onclick="javascript: window.location.href = 'http://www.stg.kaptest.net';" value="Kaptest STG">
        </div>
        <div class="cellThree">
            <input type="button" class="cellThreeButton" onclick="javascript: window.location.href = 'http://www.kaptest.com';" value="Kaptest Production">
        </div>
    </div>
    <div class="headerRow">
        Slingshot Dev Links
    </div>
    <div class="buttonRow">
        <div class="cellOne" style="font-weight: bold" id="dev101">
            &nbsp;
        </div>
        <div class="cellTwo" style="font-weight: bold; background-color: lightgoldenrodyellow" id="dev80">
            Previous Release Branch
        </div>
        <div class="cellThree" style="font-weight: bold; background-color: lightskyblue" id="dev100">
            Current Development Branch
        </div>
    </div>
    <div class="buttonRow">
        <div class="cellOne">
            <input type="button" class="cellOneButton" onclick="javascript: window.location.href = 'http://kbr.dev101.kaplan.com';" value="Dev 101">
            <input type="button" class="cellOneButton" onclick="javascript: window.location.href = 'http://kbrcms.dev101.kaplan.com';" value="Dev 101 CMS">
        </div>
        <div class="cellTwo">
            <input type="button" class="cellTwoButton" onclick="javascript: window.location.href = 'http://kbr.dev80.kaplan.com';" value="Dev Feedback">
            <input type="button" class="cellTwoButton" onclick="javascript: window.location.href = 'http://kbrcms.dev80.kaplan.com';" value="Dev Feedback CMS">
        </div>
        <div class="cellThree">
            <input type="button" class="cellThreeButton" onclick="javascript: window.location.href = 'https://kbrdev100.kaplan.com';" value="Dev Flashcards">
            <input type="button" class="cellThreeButton" onclick="javascript: window.location.href = 'https://kbrcmsdev100.kaplan.com';" value="Dev Flashcards CMS">
        </div>
    </div>
    <div class="headerRow">
        Slingshot Other Environments
    </div>
    <div class="buttonRow">
        <div class="cellOne">
            <input type="button" class="cellOneButton" onclick="javascript: window.location.href = 'http://kbr.qa.kaplan.com';" value="QA">
            <input type="button" class="cellOneButton" onclick="javascript: window.location.href = 'http://kbrcms.qa.kaplan.com';" value="QA CMS">
        </div>
        <div class="cellTwo">
            <input type="button" class="cellTwoButton" onclick="javascript: window.location.href = 'http://kbr.stg.kaplan.com';" value="STG">
            <input type="button" class="cellTwoButton" onclick="javascript: window.location.href = 'http://kbrcms.stg.kaplan.com';" value="STG CMS">
        </div>
        <div class="cellThree">
            <input type="button" class="cellThreeButton" onclick="javascript: window.location.href = 'http://kbr.kaplan.com';" value="Production">
            <input type="button" class="cellThreeButton" onclick="javascript: window.location.href = 'http://kbrcms.kaplan.com';" value="Production CMS">
        </div>
    </div>
    <div class="headerRow">
        PMBR
    </div>
    <div class="buttonRow">
        <div class="cellOne">
            <input type="button" class="cellOneButton" onclick="javascript: window.location.href = 'http://pmbronline.com';" value="PMBR Login">
        </div>
        <div class="cellTwo">
            <input type="button" class="cellTwoButton" onclick="javascript: window.location.href = 'http://pmbr.com';" value="PMBR Marketing">
        </div>
    </div>
</asp:Content>
