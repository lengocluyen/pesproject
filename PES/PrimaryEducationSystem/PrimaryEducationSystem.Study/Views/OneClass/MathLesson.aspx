﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="PrimaryEducationSystem.Study.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	MathLesson
</asp:Content>

<asp:Content ID="Scriptcontent" ContentPlaceHolderID="ScriptContent" runat="server">
    <style type="text/css">
        html, body
        {
            height: 100%;
            overflow: auto;
        }
        body
        {
            padding: 0;
            margin: 0;
        }
        #silverlightControlHost
        {
            height: 100%;
            text-align: center;
        }
    </style>

    <script type="text/javascript" src="<%= Html.ResolveUrl("~/Scripts/Silverlight.js") %>"></script>

    <script type="text/javascript">
        function onSilverlightError(sender, args) {
            var appSource = "";
            if (sender != null && sender != 0) {
                appSource = sender.getHost().Source;
            }

            var errorType = args.ErrorType;
            var iErrorCode = args.ErrorCode;

            if (errorType == "ImageError" || errorType == "MediaError") {
                return;
            }

            var errMsg = "Unhandled Error in Silverlight Application " + appSource + "\n";

            errMsg += "Code: " + iErrorCode + "    \n";
            errMsg += "Category: " + errorType + "       \n";
            errMsg += "Message: " + args.ErrorMessage + "     \n";

            if (errorType == "ParserError") {
                errMsg += "File: " + args.xamlFile + "     \n";
                errMsg += "Line: " + args.lineNumber + "     \n";
                errMsg += "Position: " + args.charPosition + "     \n";
            }
            else if (errorType == "RuntimeError") {
                if (args.lineNumber != 0) {
                    errMsg += "Line: " + args.lineNumber + "     \n";
                    errMsg += "Position: " + args.charPosition + "     \n";
                }
                errMsg += "MethodName: " + args.methodName + "     \n";
            }

            throw new Error(errMsg);
        }
    </script>

</asp:Content>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server" style="height: 100%">
    <div id="silverlightControlHost">
        <object data="data:application/x-silverlight-2," type="application/x-silverlight-2"
            width="100%" height="100%">
            <param name="source" value="<%= Html.ResolveUrl("~/ClientBin/OneClass/PESLessonHome.xap") %>" />
            <param name="enableHtmlAccess" value="true" />
            <param name="onError" value="onSilverlightError" />
            <param name="background" value="white" />
            <param name="minRuntimeVersion" value="3.0.40624.0" />
            <param name="autoUpgrade" value="true" />
            <a href="http://go.microsoft.com/fwlink/?LinkID=149156&v=3.0.40624.0" style="text-decoration: none">
                <img src="http://go.microsoft.com/fwlink/?LinkId=108181" alt="Get Microsoft Silverlight"
                    style="border-style: none" />
            </a>
        </object>
        <iframe id="_sl_historyFrame" style="visibility: hidden; height: 0px; width: 0px;">
        </iframe>
    </div>
    </form>
</asp:Content>